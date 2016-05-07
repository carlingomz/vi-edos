using System;
using WW.Cad.Drawing;
using WW.Cad.Drawing.OpenGL;
using WW.Cad.Drawing.Surface;
using WW.Cad.Model;
using WW.Math;
using WW.OpenGL;

namespace viñedos.Autocad
{
    public static class GlUtil
    {
        public static void InitGlGraphics(
            GLGraphics3D glGraphics,
            DxfModel model,
            Bounds3D bounds,
            Size2D targetSize
        )
        {
            //Set up OpenGL related characteristics
            GL.ClearColor(0f, 0f, 0f, 0f);
            GL.ClearAccum(0f, 0f, 0f, 0f);
            GL.Enable(Capability.DepthTest);
            GL.DepthFunc(ComparisonFunction.LessEqual);
            GL.Disable(Capability.CullFace);
            GL.Enable(Capability.ColorMaterial);
            GL.ColorMaterial(ColorMaterialFace.FrontAndBack, ColorMaterialParameter.AmbientAndDiffuse);
            GL.LightModeli(LightModelParameter.Ambient, true);
            GL.Hint(HintTarget.PerspectiveCorrection, HintMode.Fastest);
            // Use either modulate or replace to make texture lighting working.
            GL.TexEnvi(
                TextureEnvironmentTarget.TextureEnvironment,
                TextureEnvironmentParameterName.Mode,
                TextureEnvironmentMode.Modulate
            );

            GL.ShadeModel(ShadingModel.Smooth);

            // Add some global illumination.
            GL.LightModelfv(LightModelParameter.LocalViewer, new float[] { 0.5f, 0.5f, 0.5f, 1f });
            GL.LightModeli(LightModelParameter.TwoSide, true);

            GL.Lightfv(LightName.Light0, LightParameter.Diffuse, new float[] { 0.5f, 0.5f, 0.5f, 1f });

            //GL.Lightfv(LightName.Light0, LightParameter.Specular, 0f, 0f, 0f, 0f);
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadIdentity();
            Point3D lightPosition = Point3D.Zero;
            GL.Lightfv(LightName.Light0,LightParameter.Position,new float[] {(float)lightPosition.X,(float)lightPosition.Y,(float)lightPosition.Z,1f});
            GL.Enable(LightName.Light0);
            GL.Hint(HintTarget.PerspectiveCorrection, HintMode.Fastest);
            // Create the drawables.
            DrawContext.Surface drawContext =
                new DrawContext.Surface.ModelSpace(
                    model,
                    glGraphics.GraphicsConfig,
                    Matrix4D.Identity,
                    glGraphics.CharTriangulationCache);

            Graphics graphics = new Graphics();
            model.Draw(drawContext, graphics, graphics);

            ProcessedGraphics processedGraphics = new ProcessedGraphics();
            processedGraphics.Process(GraphicsConfig.AcadLikeWithBlackBackground, graphics);

            glGraphics.CreateDrawables(processedGraphics);

            glGraphics.Resize((int)Math.Ceiling(targetSize.X), (int)Math.Ceiling(targetSize.Y));
        }
    }
}