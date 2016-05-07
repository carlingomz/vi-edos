namespace viñedos
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.MenuGeneral = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnMonitoreo = new System.Windows.Forms.Button();
            this.btnPlanesFinanciamiento = new System.Windows.Forms.Button();
            this.btnAreaAdministrativa = new System.Windows.Forms.Button();
            this.btnProcesosEspeciales = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MenuGeneral.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuGeneral
            // 
            this.MenuGeneral.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.MenuGeneral.Location = new System.Drawing.Point(0, 0);
            this.MenuGeneral.Name = "MenuGeneral";
            this.MenuGeneral.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.MenuGeneral.Size = new System.Drawing.Size(1114, 25);
            this.MenuGeneral.TabIndex = 0;
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarSesionToolStripMenuItem,
            this.cerrarToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 19);
            this.menuToolStripMenuItem.Text = "Menu";
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
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnMonitoreo);
            this.flowLayoutPanel1.Controls.Add(this.btnPlanesFinanciamiento);
            this.flowLayoutPanel1.Controls.Add(this.btnAreaAdministrativa);
            this.flowLayoutPanel1.Controls.Add(this.btnProcesosEspeciales);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(18, 75);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(489, 305);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // btnMonitoreo
            // 
            this.btnMonitoreo.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnMonitoreo.FlatAppearance.CheckedBackColor = System.Drawing.Color.Maroon;
            this.btnMonitoreo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMonitoreo.Location = new System.Drawing.Point(4, 5);
            this.btnMonitoreo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMonitoreo.Name = "btnMonitoreo";
            this.btnMonitoreo.Size = new System.Drawing.Size(165, 134);
            this.btnMonitoreo.TabIndex = 0;
            this.btnMonitoreo.Text = "Monitoreo\r\n\r\nMonitoreo total\r\nMonitoreo por viña\r\nComo llegar";
            this.btnMonitoreo.UseVisualStyleBackColor = false;
            this.btnMonitoreo.Click += new System.EventHandler(this.btnMonitoreo_Click);
            // 
            // btnPlanesFinanciamiento
            // 
            this.btnPlanesFinanciamiento.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnPlanesFinanciamiento.FlatAppearance.CheckedBackColor = System.Drawing.Color.Maroon;
            this.btnPlanesFinanciamiento.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPlanesFinanciamiento.Location = new System.Drawing.Point(177, 5);
            this.btnPlanesFinanciamiento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPlanesFinanciamiento.Name = "btnPlanesFinanciamiento";
            this.btnPlanesFinanciamiento.Size = new System.Drawing.Size(295, 134);
            this.btnPlanesFinanciamiento.TabIndex = 1;
            this.btnPlanesFinanciamiento.Text = "Planes de financiamiento\r\n\r\nAnexo de contrato\r\nCotizacion de lotes\r\nImpresion de " +
    "cotizacion";
            this.btnPlanesFinanciamiento.UseVisualStyleBackColor = false;
            this.btnPlanesFinanciamiento.Click += new System.EventHandler(this.btnPlanesFinanciamiento_Click);
            // 
            // btnAreaAdministrativa
            // 
            this.btnAreaAdministrativa.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnAreaAdministrativa.FlatAppearance.CheckedBackColor = System.Drawing.Color.Maroon;
            this.btnAreaAdministrativa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAreaAdministrativa.Location = new System.Drawing.Point(4, 149);
            this.btnAreaAdministrativa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAreaAdministrativa.Name = "btnAreaAdministrativa";
            this.btnAreaAdministrativa.Size = new System.Drawing.Size(230, 134);
            this.btnAreaAdministrativa.TabIndex = 2;
            this.btnAreaAdministrativa.Text = "Area administrativa\r\n\r\nAlta estructura de lotes\r\nAlta lotes\r\nInformacion de los l" +
    "otes\r\nReporte estatus de los lotes";
            this.btnAreaAdministrativa.UseVisualStyleBackColor = false;
            this.btnAreaAdministrativa.Click += new System.EventHandler(this.btnAreaAdministrativa_Click);
            // 
            // btnProcesosEspeciales
            // 
            this.btnProcesosEspeciales.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnProcesosEspeciales.FlatAppearance.CheckedBackColor = System.Drawing.Color.Maroon;
            this.btnProcesosEspeciales.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnProcesosEspeciales.Location = new System.Drawing.Point(242, 149);
            this.btnProcesosEspeciales.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnProcesosEspeciales.Name = "btnProcesosEspeciales";
            this.btnProcesosEspeciales.Size = new System.Drawing.Size(230, 134);
            this.btnProcesosEspeciales.TabIndex = 3;
            this.btnProcesosEspeciales.Text = "Procesos especiales\r\n\r\nMantenimiento de usuarios\r\nRespaldo de datos\r\nConfiguracio" +
    "n del sistema";
            this.btnProcesosEspeciales.UseVisualStyleBackColor = false;
            this.btnProcesosEspeciales.Click += new System.EventHandler(this.btnProcesosEspeciales_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(574, 75);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(506, 211);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1114, 446);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.MenuGeneral);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.MenuGeneral;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Menu";
            this.ShowIcon = false;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Menu_Load);
            this.MenuGeneral.ResumeLayout(false);
            this.MenuGeneral.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuGeneral;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnMonitoreo;
        private System.Windows.Forms.Button btnPlanesFinanciamiento;
        private System.Windows.Forms.Button btnAreaAdministrativa;
        private System.Windows.Forms.Button btnProcesosEspeciales;
    }
}