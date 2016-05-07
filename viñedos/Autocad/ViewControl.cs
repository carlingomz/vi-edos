using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using WW.Actions;
using WW.Cad.Drawing;
using WW.Cad.Drawing.GDI;
using WW.Cad.Drawing.OpenGL;
using WW.Cad.Model;
using WW.ComponentModel;
using WW.Drawing;
using WW.Math;
using WW.Math.Geometry;
using WW.OpenGL;
using WW.OpenGL.Actions;
using WW.OpenGL.Win;

namespace viñedos.Autocad
{
    public partial class ViewControl : UserControl
    {
        #region Variables
        private Matrix4D _canonicalProjectionTransform;
        private Matrix4D _from2DTransform;
        private readonly GDIGraphics3D _gdiGraphics3D;
        private GLGraphics3D _glGraphics;
        private readonly WireframeGraphicsCache _graphicsCache;
        private readonly ArgbColor _highlightColor = ArgbColors.Magenta;
        private RenderedEntityInfo _highlightedEntity;
        private DxfModel _model;
        private Matrix4D _modelViewTransform;
        private Point _mouseClickLocation;
        private bool _mouseDown;
        private readonly ArgbColor _secondaryHighlightColor = ArgbColors.Cyan;
        private bool _shiftPressed;
        private bool _updatingTransforms;
        #endregion
        public ViewControl()
        {
            InitializeComponent();
            _glGraphics = new GLGraphics3D();
            ModelBounds = new Bounds3D();
            _glGraphics.GraphicsConfig.ShapeFlattenEpsilon = -0.1d;
            _glGraphics.AfterDrawScene += GlGraphicsOnAfterDrawScene;

            var graphicsConfig = new GraphicsConfig
            {
                BackColor = BackColor,
                CorrectColorForBackgroundColor = true
            };

            _gdiGraphics3D = new GDIGraphics3D(graphicsConfig);
            _gdiGraphics3D.EnableDrawablesUpdate();
            _gdiGraphics3D.Config.ShowDisabledLayers = false;
            _graphicsCache = new WireframeGraphicsCache(false, true);

            _transformationProvider = new SimpleTransformationProvider3D();
            _transformationProvider.TransformsChanged += transformationProvider_TransformsChanged;
            _panInteractor = new SimplePanInteractor(_transformationProvider);
            //rotateInteractor = new SimpleRotateInteractor(transformationProvider);
            _rectZoomInteractor = new SimpleRectZoomInteractor(_transformationProvider);
            _zoomWheelInteractor = new SimpleZoomWheelInteractor(_transformationProvider);
            _rectZoomInteractorDrawable = new SimpleRectZoomInteractorGLDrawable(_rectZoomInteractor);

            if (components == null)
            {
                components = new Container();
            }
            // Add to components so the OpenGL graphics object is properly disposed.
            components.Add(new DisposableComponentContainer(_glGraphics));
        }
        public DxfModel Model
        {
            get { return _model; }
            set
            {
                _model = value;
                if (_model != null)
                {
                    var boundsCalculator = new BoundsCalculator(ModelBounds);
                    ModelBounds.Reset();
                    boundsCalculator.GetBounds(_model, Matrix4D.Identity);

                    // For drawings where the offset is large compared to its size it might cause precision problems.
                    // Transforming the whole drawing to the center prevents these problems.
                    /*
                    Matrix4D transform = Transformation4D.Translation(Point3D.Zero - ModelBounds.Center);
                    TransformConfig transformConfig = new TransformConfig();
                    foreach (DxfEntity entity in _model.Entities) {
                        entity.TransformMe(transformConfig, transform);
                    }
                    ModelBounds.Transform(transform);
                    */
                    _transformationProvider.ResetTransforms(ModelBounds);
                    CalculateTo2DTransform();
                    Invalidate();
                }
            }
        }
        private Bounds3D ModelBounds { get; }
        /*
        public SimpleRotateInteractor RotateInteractor {get; set;}
        */
        public event EventHandler<EntityEventArgs> EntitySelected;
        private void GlGraphicsOnAfterDrawScene(object sender, EventArgs eventArgs)
        {
            // Let the current interactor draw itself if active.
            if (_currentInteractorDrawable != null)
            {
                var i = Matrix4D.Identity;
                var s = Transformation4D.GetScaleAndTranslateTransform(new Point2D(ClientRectangle.Left, ClientRectangle.Bottom),new Point2D(ClientRectangle.Right, ClientRectangle.Top),new Point2D(-1, -1),new Point2D(1, 1));

                _glGraphics.RenderingContext.MakeCurrent();
                GL.MatrixMode(MatrixMode.Projection);
                GL.LoadMatrixd(ref s);
                GL.MatrixMode(MatrixMode.ModelView);
                GL.LoadMatrixd(ref i);

                _currentInteractorDrawable.Draw(new GraphicsHelper(), GetInteractionContext());

                GL.MatrixMode(MatrixMode.Projection);
                GL.LoadMatrixd(ref _canonicalProjectionTransform);
                GL.MatrixMode(MatrixMode.ModelView);
                GL.LoadMatrixd(ref _modelViewTransform);
            }
        }
        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            var pfd = PixelFormatDescriptor.RGBA;
            pfd.Flags |= PFD.Flags.DrawToWindow | PFD.Flags.DoubleBuffer;
            pfd.AccumBits = 128; // Set this if antialiasing is required.
            _glGraphics.Initialize(RenderingContext.FromWindowHandle(Handle, pfd));

            if (_model != null)
            {
                var start = DateTime.UtcNow;
                GlUtil.InitGlGraphics(_glGraphics,_model,ModelBounds,new Size2D(ClientSize.Width, ClientSize.Height));
                var end = DateTime.UtcNow;
                Debug.WriteLine((end - start).TotalSeconds);
                CalculateModelViewAndProjectionTransform();

                Invalidate();
            }
        }      
        protected override void OnHandleDestroyed(EventArgs e)
        {
            try
            {
                if (_glGraphics != null)
                {
                    _glGraphics.Dispose();
                    _glGraphics = null;
                }
                base.OnHandleDestroyed(e);
            }
            catch
            {
                // ignored
            }
        }
        protected override void OnResize(EventArgs e)
        {
            try
            {
                base.OnResize(e);
                CalculateModelViewAndProjectionTransform();
                _glGraphics.Resize(ClientSize.Width, ClientSize.Height);
                CalculateTo2DTransform();
                Invalidate();
            }
            catch
            {
                // ignored
            }
        }
        // Don't paint the background.
        protected override void OnPaintBackground(PaintEventArgs e)
        {
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            try
            {
                _glGraphics.Paint(ClientSize.Width, ClientSize.Height);
            }
            catch
            {
                //
            }
        }
        protected override void OnMouseDown(MouseEventArgs e)
        {
            try
            {
                base.OnMouseDown(e);
                _mouseClickLocation = e.Location;
                _mouseDown = true;
                _panInteractor.Activate();
                _panInteractor.ProcessMouseButtonDown(new CanonicalMouseEventArgs(e), GetInteractionContext());
            }
            catch
            {
                //
            }
        }
        protected override void OnMouseMove(MouseEventArgs e)
        {
            try
            {
                base.OnMouseMove(e);
                if (_mouseDown)
                {
                    if (_shiftPressed)
                    {
                        _rectZoomInteractor.ProcessMouseMove(new CanonicalMouseEventArgs(e), GetInteractionContext());
                    }
                    else
                    {
                        _panInteractor.ProcessMouseMove(new CanonicalMouseEventArgs(e), GetInteractionContext());
                    }
                    Invalidate();
                }
            }
            catch
            {
                // ignored
            }
        }
        protected override void OnMouseUp(MouseEventArgs e)
        {
            try
            {
                base.OnMouseUp(e);
                _mouseDown = false;

                // Use shift key for rectangle zoom.
                if (_shiftPressed)
                {
                    _rectZoomInteractor.ProcessMouseButtonUp(new CanonicalMouseEventArgs(e), GetInteractionContext());
                    _rectZoomInteractor.Deactivate();
                    Invalidate();
                }
                else
                {
                    _panInteractor.Deactivate();
                }
                _currentInteractorDrawable = null;
            }
            catch
            {
                // ignored
            }
        }
        protected override void OnMouseWheel(MouseEventArgs e)
        {
            try
            {
                base.OnMouseWheel(e);

                _zoomWheelInteractor.Activate();
                _zoomWheelInteractor.ProcessMouseWheel(new CanonicalMouseEventArgs(e), GetInteractionContext());
                _zoomWheelInteractor.Deactivate();

                Invalidate();
            }
            catch
            {
                // ignored
            }
        }
        /*private void OnEntitySelected(EntityEventArgs e)
        {
            if (EntitySelected != null)
            {
                EntitySelected(this, e);
            }
        }*/
        /// <summary>
        ///     Sets the OpenGL transformations for specified rendering context.
        /// </summary>
        private void SetTransformations(Size2D window, RenderingContext rc)
        {
            var t = (SimpleTransformationProvider3D)_transformationProvider.Clone();
            var rect = new Rectangle2D(1d, 1d, window.X, window.Y);
            SetTransformations(rc, t, rect);
        }
        private void SetTransformations(RenderingContext rc, SimpleTransformationProvider3D t, Rectangle2D rect)
        {
            t.ViewWindow = rect;
            _modelViewTransform = Matrix4D.Identity;
            _canonicalProjectionTransform = Matrix4D.Identity;
            if (_model != null && ModelBounds != null)
            {
                _canonicalProjectionTransform = t.CanonicalProjectionTransform;
                _modelViewTransform = t.WorldTransform;
            }
            if (rc != null)
            {
                rc.MakeCurrent();
            }
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadMatrixd(ref _canonicalProjectionTransform);
            GL.MatrixMode(MatrixMode.ModelView);
            GL.LoadMatrixd(ref _modelViewTransform);
        }
        private void CalculateModelViewAndProjectionTransform()
        {
            if (!_updatingTransforms)
            {
                _updatingTransforms = true;
                SetTransformations(_glGraphics.RenderingContext, _transformationProvider, GetClientRectangle2D());
                _updatingTransforms = false;
            }
        }
        private Rectangle2D GetClientRectangle2D()
        {
            return new Rectangle2D(
                ClientRectangle.Left,
                ClientRectangle.Top,
                ClientRectangle.Right,
                ClientRectangle.Bottom
                );
        }
        private void transformationProvider_TransformsChanged(object sender, EventArgs e)
        {
            if (!_updatingTransforms)
            {
                CalculateModelViewAndProjectionTransform();
                CalculateTo2DTransform();
                Invalidate();
            }
        }
        private InteractionContext GetInteractionContext()
        {
            return new InteractionContext(
                new Rectangle2D(ClientRectangle.Left, ClientRectangle.Top, ClientRectangle.Right, ClientRectangle.Bottom),
                _transformationProvider.CompleteTransform,
                true,
                BackColor
                );
        }
        /*private ArgbColor ColorChanger(ArgbColor argbColor)
        {
            var result = _highlightColor;
            if (argbColor == result)
            {
                result = _secondaryHighlightColor;
            }
            return result;
        }*/
        public Point2D GetModelSpaceCoordinates(Point2D screenSpaceCoordinates)
        {
            return _from2DTransform.TransformTo2D(screenSpaceCoordinates);
        }
        private void CalculateTo2DTransform()
        {
            _transformationProvider.ViewWindow = GetClientRectangle2D();
            var to2DTransform = Matrix4D.Identity;
            if (_model != null && ModelBounds != null)
            {
                to2DTransform = _transformationProvider.CompleteTransform;
            }
            _gdiGraphics3D.To2DTransform = to2DTransform;
            _from2DTransform = _gdiGraphics3D.To2DTransform.GetInverse();
        }
        public string GuardarImagen()
        {
            IntPtr bitmapHandle;

            BitmapInfo bitmapInfo = new BitmapInfo
            {
                Size = 40,
                BitCount = 24,
                Planes = 1,
                Width = 500,
                Height = 500
            };

            PixelFormatDescriptor pfd = PixelFormatDescriptor.RGBA;
            pfd.Flags |= PFD.Flags.DrawToBitmap;
            pfd.ColorBits = 24;
            pfd.AlphaBits = 0;

            // This rendering context is passed to GLGraphics3D below, which will dispose it
            // at the end of the using block.
            RenderingContext bitmapRenderingContext =
                RenderingContext.FromBitmapInfo(
                    bitmapInfo,
                    pfd,
                    out bitmapHandle
                );
            using (GLGraphics3D glGraphics = new GLGraphics3D(bitmapRenderingContext))
            {
                GlUtil.InitGlGraphics(
                    glGraphics,
                    Model,
                    ModelBounds,
                    new Size2D(bitmapInfo.Width, bitmapInfo.Height)
                );
                SetTransformations(new Size2D(bitmapInfo.Width, bitmapInfo.Height), bitmapRenderingContext);
                glGraphics.Paint(bitmapRenderingContext, bitmapInfo.Width, bitmapInfo.Height);
            }
            Bitmap bitmap = Bitmap.FromHbitmap(bitmapHandle);
            //PngImage val = new PngImage();
            string archivo = Auxiliares.Auxiliares.GetTempFilePathWithExtension();
            bitmap.Save(archivo + "lote.png");
            return archivo + "lote.png";
        }
        #region zooming, rotating and panning
        private readonly SimpleTransformationProvider3D _transformationProvider;
        private readonly SimplePanInteractor _panInteractor;
        private readonly SimpleRectZoomInteractor _rectZoomInteractor;
        private readonly SimpleZoomWheelInteractor _zoomWheelInteractor;
        private readonly IInteractorGLDrawable _rectZoomInteractorDrawable;
        private IInteractorGLDrawable _currentInteractorDrawable;
        #endregion
    }
}