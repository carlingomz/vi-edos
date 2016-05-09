namespace viñedos.Monitoreo
{
    internal partial class Monitoreo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelInfo = new System.Windows.Forms.Panel();
            this.btnBuscarlote = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNlote = new System.Windows.Forms.TextBox();
            this.txtLote = new System.Windows.Forms.TextBox();
            this.MenuGeneral = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelMapa = new System.Windows.Forms.Panel();
            this.generarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewControl = new viñedos.Autocad.ViewControl();
            this.panelInfo.SuspendLayout();
            this.MenuGeneral.SuspendLayout();
            this.panelMapa.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelInfo
            // 
            this.panelInfo.BackColor = System.Drawing.Color.LavenderBlush;
            this.panelInfo.Controls.Add(this.btnBuscarlote);
            this.panelInfo.Controls.Add(this.label1);
            this.panelInfo.Controls.Add(this.txtNlote);
            this.panelInfo.Controls.Add(this.txtLote);
            this.panelInfo.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelInfo.Location = new System.Drawing.Point(0, 25);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(360, 457);
            this.panelInfo.TabIndex = 0;
            // 
            // btnBuscarlote
            // 
            this.btnBuscarlote.Location = new System.Drawing.Point(96, 424);
            this.btnBuscarlote.Name = "btnBuscarlote";
            this.btnBuscarlote.Size = new System.Drawing.Size(157, 23);
            this.btnBuscarlote.TabIndex = 3;
            this.btnBuscarlote.Text = "Buscar";
            this.btnBuscarlote.UseVisualStyleBackColor = true;
            this.btnBuscarlote.Click += new System.EventHandler(this.btnBuscarlote_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 378);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Numero de lote";
            // 
            // txtNlote
            // 
            this.txtNlote.Location = new System.Drawing.Point(96, 375);
            this.txtNlote.Name = "txtNlote";
            this.txtNlote.Size = new System.Drawing.Size(157, 20);
            this.txtNlote.TabIndex = 1;
            // 
            // txtLote
            // 
            this.txtLote.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtLote.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLote.Location = new System.Drawing.Point(0, 0);
            this.txtLote.Multiline = true;
            this.txtLote.Name = "txtLote";
            this.txtLote.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLote.Size = new System.Drawing.Size(360, 358);
            this.txtLote.TabIndex = 0;
            // 
            // MenuGeneral
            // 
            this.MenuGeneral.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.MenuGeneral.Location = new System.Drawing.Point(0, 0);
            this.MenuGeneral.Name = "MenuGeneral";
            this.MenuGeneral.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.MenuGeneral.Size = new System.Drawing.Size(817, 25);
            this.MenuGeneral.TabIndex = 1;
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem1,
            this.cerrarSesionToolStripMenuItem,
            this.cerrarToolStripMenuItem,
            this.generarToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 19);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // menuToolStripMenuItem1
            // 
            this.menuToolStripMenuItem1.Name = "menuToolStripMenuItem1";
            this.menuToolStripMenuItem1.Size = new System.Drawing.Size(142, 22);
            this.menuToolStripMenuItem1.Text = "Menu";
            this.menuToolStripMenuItem1.Click += new System.EventHandler(this.menuToolStripMenuItem1_Click);
            // 
            // cerrarSesionToolStripMenuItem
            // 
            this.cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            this.cerrarSesionToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.cerrarSesionToolStripMenuItem.Text = "Cerrar sesion";
            this.cerrarSesionToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesionToolStripMenuItem_Click);
            // 
            // cerrarToolStripMenuItem
            // 
            this.cerrarToolStripMenuItem.Name = "cerrarToolStripMenuItem";
            this.cerrarToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.cerrarToolStripMenuItem.Text = "cerrar";
            this.cerrarToolStripMenuItem.Click += new System.EventHandler(this.cerrarToolStripMenuItem_Click);
            // 
            // panelMapa
            // 
            this.panelMapa.Controls.Add(this.viewControl);
            this.panelMapa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMapa.Location = new System.Drawing.Point(360, 25);
            this.panelMapa.Name = "panelMapa";
            this.panelMapa.Size = new System.Drawing.Size(457, 457);
            this.panelMapa.TabIndex = 2;
            // 
            // generarToolStripMenuItem
            // 
            this.generarToolStripMenuItem.Name = "generarToolStripMenuItem";
            this.generarToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.generarToolStripMenuItem.Text = "Generar PDF";
            this.generarToolStripMenuItem.Click += new System.EventHandler(this.generarToolStripMenuItem_Click);
            // 
            // viewControl
            // 
            this.viewControl.BackColor = System.Drawing.Color.Transparent;
            this.viewControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewControl.Location = new System.Drawing.Point(0, 0);
            this.viewControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.viewControl.Model = null;
            this.viewControl.Name = "viewControl";
            this.viewControl.Size = new System.Drawing.Size(457, 457);
            this.viewControl.TabIndex = 1;
            this.viewControl.MouseClick += new System.Windows.Forms.MouseEventHandler(this.viewControl_MouseClick);
            this.viewControl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.viewControl_MouseMove);
            // 
            // monitoreo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 482);
            this.Controls.Add(this.panelMapa);
            this.Controls.Add(this.panelInfo);
            this.Controls.Add(this.MenuGeneral);
            this.Name = "monitoreo";
            this.ShowIcon = false;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.monitoreo_FormClosing);
            this.Load += new System.EventHandler(this.monitoreo_Load);
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            this.MenuGeneral.ResumeLayout(false);
            this.MenuGeneral.PerformLayout();
            this.panelMapa.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.MenuStrip MenuGeneral;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarToolStripMenuItem;
        private System.Windows.Forms.Panel panelMapa;
        public Autocad.ViewControl viewControl;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem1;
        private System.Windows.Forms.TextBox txtLote;
        private System.Windows.Forms.Button btnBuscarlote;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNlote;
        private System.Windows.Forms.ToolStripMenuItem generarToolStripMenuItem;
    }
}