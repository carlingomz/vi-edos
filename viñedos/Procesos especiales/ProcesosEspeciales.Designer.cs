namespace viñedos.Procesos_especiales
{
    partial class ProcesosEspeciales
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
            this.MenuGeneral = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvBajaUsuario = new System.Windows.Forms.DataGridView();
            this.btnBuscarBaja = new System.Windows.Forms.Button();
            this.txtUsuarioBaja = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.chbAdministrador = new System.Windows.Forms.CheckBox();
            this.chbProcesosEsp = new System.Windows.Forms.CheckBox();
            this.chbfinanciamiento = new System.Windows.Forms.CheckBox();
            this.chbMonitoreo = new System.Windows.Forms.CheckBox();
            this.chbAministracion = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGuardarUsuario = new System.Windows.Forms.Button();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.comboEstructuraBaja = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtnombreBaja = new System.Windows.Forms.TextBox();
            this.dgvBaja = new System.Windows.Forms.DataGridView();
            this.buscarBajaEstructura = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvPrecio = new System.Windows.Forms.DataGridView();
            this.tipoprecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbprecio = new System.Windows.Forms.Label();
            this.lbtipoprecio = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.comboEstructuraAlta = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnGuardarEstructura = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtEstructuraAlta = new System.Windows.Forms.TextBox();
            this.MenuGeneral.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBajaUsuario)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaja)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrecio)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuGeneral
            // 
            this.MenuGeneral.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.MenuGeneral.Location = new System.Drawing.Point(0, 0);
            this.MenuGeneral.Name = "MenuGeneral";
            this.MenuGeneral.Padding = new System.Windows.Forms.Padding(12, 4, 0, 4);
            this.MenuGeneral.Size = new System.Drawing.Size(817, 27);
            this.MenuGeneral.TabIndex = 1;
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem1,
            this.cerrarSesionToolStripMenuItem,
            this.cerrarToolStripMenuItem});
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
            this.cerrarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cerrarToolStripMenuItem.Text = "cerrar";
            this.cerrarToolStripMenuItem.Click += new System.EventHandler(this.cerrarToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 27);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(817, 516);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LavenderBlush;
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(809, 487);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Usuarios";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.dgvBajaUsuario);
            this.panel2.Controls.Add(this.btnBuscarBaja);
            this.panel2.Controls.Add(this.txtUsuarioBaja);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(12, 266);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(550, 198);
            this.panel2.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(215, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 16);
            this.label5.TabIndex = 30;
            this.label5.Text = "Baja de usuarios";
            // 
            // dgvBajaUsuario
            // 
            this.dgvBajaUsuario.AllowUserToAddRows = false;
            this.dgvBajaUsuario.AllowUserToDeleteRows = false;
            this.dgvBajaUsuario.AllowUserToResizeColumns = false;
            this.dgvBajaUsuario.AllowUserToResizeRows = false;
            this.dgvBajaUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBajaUsuario.Location = new System.Drawing.Point(35, 98);
            this.dgvBajaUsuario.Name = "dgvBajaUsuario";
            this.dgvBajaUsuario.Size = new System.Drawing.Size(372, 82);
            this.dgvBajaUsuario.TabIndex = 29;
            this.dgvBajaUsuario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBajaUsuario_CellContentClick);
            // 
            // btnBuscarBaja
            // 
            this.btnBuscarBaja.ForeColor = System.Drawing.Color.Black;
            this.btnBuscarBaja.Location = new System.Drawing.Point(287, 39);
            this.btnBuscarBaja.Name = "btnBuscarBaja";
            this.btnBuscarBaja.Size = new System.Drawing.Size(120, 53);
            this.btnBuscarBaja.TabIndex = 28;
            this.btnBuscarBaja.Text = "Buscar";
            this.btnBuscarBaja.UseVisualStyleBackColor = true;
            this.btnBuscarBaja.Click += new System.EventHandler(this.btnBuscarBaja_Click);
            // 
            // txtUsuarioBaja
            // 
            this.txtUsuarioBaja.Location = new System.Drawing.Point(132, 57);
            this.txtUsuarioBaja.Name = "txtUsuarioBaja";
            this.txtUsuarioBaja.Size = new System.Drawing.Size(132, 22);
            this.txtUsuarioBaja.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 27;
            this.label4.Text = "Usuario";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.chbAdministrador);
            this.panel1.Controls.Add(this.chbProcesosEsp);
            this.panel1.Controls.Add(this.chbfinanciamiento);
            this.panel1.Controls.Add(this.chbMonitoreo);
            this.panel1.Controls.Add(this.chbAministracion);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnGuardarUsuario);
            this.panel1.Controls.Add(this.txtUsuario);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtContraseña);
            this.panel1.Location = new System.Drawing.Point(11, 28);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(551, 219);
            this.panel1.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(216, 26);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 16);
            this.label3.TabIndex = 31;
            this.label3.Text = "Alta de usuarios";
            // 
            // chbAdministrador
            // 
            this.chbAdministrador.AutoSize = true;
            this.chbAdministrador.Location = new System.Drawing.Point(32, 179);
            this.chbAdministrador.Margin = new System.Windows.Forms.Padding(4);
            this.chbAdministrador.Name = "chbAdministrador";
            this.chbAdministrador.Size = new System.Drawing.Size(181, 20);
            this.chbAdministrador.TabIndex = 30;
            this.chbAdministrador.Text = "Permiso de administrador";
            this.chbAdministrador.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chbAdministrador.UseVisualStyleBackColor = true;
            // 
            // chbProcesosEsp
            // 
            this.chbProcesosEsp.AutoSize = true;
            this.chbProcesosEsp.Location = new System.Drawing.Point(207, 151);
            this.chbProcesosEsp.Margin = new System.Windows.Forms.Padding(4);
            this.chbProcesosEsp.Name = "chbProcesosEsp";
            this.chbProcesosEsp.Size = new System.Drawing.Size(155, 20);
            this.chbProcesosEsp.TabIndex = 29;
            this.chbProcesosEsp.Text = "Procesos especiales";
            this.chbProcesosEsp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chbProcesosEsp.UseVisualStyleBackColor = true;
            // 
            // chbfinanciamiento
            // 
            this.chbfinanciamiento.AutoSize = true;
            this.chbfinanciamiento.Location = new System.Drawing.Point(207, 123);
            this.chbfinanciamiento.Margin = new System.Windows.Forms.Padding(4);
            this.chbfinanciamiento.Name = "chbfinanciamiento";
            this.chbfinanciamiento.Size = new System.Drawing.Size(177, 20);
            this.chbfinanciamiento.TabIndex = 28;
            this.chbfinanciamiento.Text = "Planes de financiamiento";
            this.chbfinanciamiento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chbfinanciamiento.UseVisualStyleBackColor = true;
            // 
            // chbMonitoreo
            // 
            this.chbMonitoreo.AutoSize = true;
            this.chbMonitoreo.Location = new System.Drawing.Point(32, 151);
            this.chbMonitoreo.Margin = new System.Windows.Forms.Padding(4);
            this.chbMonitoreo.Name = "chbMonitoreo";
            this.chbMonitoreo.Size = new System.Drawing.Size(87, 20);
            this.chbMonitoreo.TabIndex = 27;
            this.chbMonitoreo.Text = "Monitoreo";
            this.chbMonitoreo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chbMonitoreo.UseVisualStyleBackColor = true;
            // 
            // chbAministracion
            // 
            this.chbAministracion.AutoSize = true;
            this.chbAministracion.Location = new System.Drawing.Point(32, 123);
            this.chbAministracion.Margin = new System.Windows.Forms.Padding(4);
            this.chbAministracion.Name = "chbAministracion";
            this.chbAministracion.Size = new System.Drawing.Size(142, 20);
            this.chbAministracion.TabIndex = 26;
            this.chbAministracion.Text = "Area administrativa";
            this.chbAministracion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chbAministracion.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 91);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Contraseña";
            // 
            // btnGuardarUsuario
            // 
            this.btnGuardarUsuario.ForeColor = System.Drawing.Color.Black;
            this.btnGuardarUsuario.Location = new System.Drawing.Point(288, 55);
            this.btnGuardarUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardarUsuario.Name = "btnGuardarUsuario";
            this.btnGuardarUsuario.Size = new System.Drawing.Size(120, 54);
            this.btnGuardarUsuario.TabIndex = 25;
            this.btnGuardarUsuario.Text = "Guardar";
            this.btnGuardarUsuario.UseVisualStyleBackColor = true;
            this.btnGuardarUsuario.Click += new System.EventHandler(this.btnGuardarUsuario_Click);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(133, 55);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(132, 22);
            this.txtUsuario.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuario";
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(133, 87);
            this.txtContraseña.Margin = new System.Windows.Forms.Padding(4);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(132, 22);
            this.txtContraseña.TabIndex = 2;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.LavenderBlush;
            this.tabPage2.Controls.Add(this.panel4);
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(809, 487);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Estructura";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.comboEstructuraBaja);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.txtnombreBaja);
            this.panel4.Controls.Add(this.dgvBaja);
            this.panel4.Controls.Add(this.buscarBajaEstructura);
            this.panel4.Location = new System.Drawing.Point(8, 356);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(462, 198);
            this.panel4.TabIndex = 30;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 16);
            this.label8.TabIndex = 70;
            this.label8.Text = "Borrar";
            // 
            // comboEstructuraBaja
            // 
            this.comboEstructuraBaja.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboEstructuraBaja.FormattingEnabled = true;
            this.comboEstructuraBaja.Items.AddRange(new object[] {
            "Fraccionamiento",
            "Sector",
            "Viña"});
            this.comboEstructuraBaja.Location = new System.Drawing.Point(106, 28);
            this.comboEstructuraBaja.Name = "comboEstructuraBaja";
            this.comboEstructuraBaja.Size = new System.Drawing.Size(179, 24);
            this.comboEstructuraBaja.TabIndex = 69;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 16);
            this.label6.TabIndex = 68;
            this.label6.Text = "Nombre";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 16);
            this.label7.TabIndex = 66;
            this.label7.Text = "Estructura";
            // 
            // txtnombreBaja
            // 
            this.txtnombreBaja.Location = new System.Drawing.Point(106, 57);
            this.txtnombreBaja.Name = "txtnombreBaja";
            this.txtnombreBaja.Size = new System.Drawing.Size(179, 22);
            this.txtnombreBaja.TabIndex = 67;
            // 
            // dgvBaja
            // 
            this.dgvBaja.AllowUserToAddRows = false;
            this.dgvBaja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBaja.Location = new System.Drawing.Point(31, 92);
            this.dgvBaja.Name = "dgvBaja";
            this.dgvBaja.Size = new System.Drawing.Size(297, 82);
            this.dgvBaja.TabIndex = 29;
            this.dgvBaja.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBaja_CellContentClick);
            // 
            // buscarBajaEstructura
            // 
            this.buscarBajaEstructura.ForeColor = System.Drawing.Color.Black;
            this.buscarBajaEstructura.Location = new System.Drawing.Point(334, 26);
            this.buscarBajaEstructura.Name = "buscarBajaEstructura";
            this.buscarBajaEstructura.Size = new System.Drawing.Size(90, 53);
            this.buscarBajaEstructura.TabIndex = 28;
            this.buscarBajaEstructura.Text = "Buscar";
            this.buscarBajaEstructura.UseVisualStyleBackColor = true;
            this.buscarBajaEstructura.Click += new System.EventHandler(this.buscarBajaEstructura_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvPrecio);
            this.panel3.Controls.Add(this.lbprecio);
            this.panel3.Controls.Add(this.lbtipoprecio);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.comboEstructuraAlta);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.btnGuardarEstructura);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.txtEstructuraAlta);
            this.panel3.Location = new System.Drawing.Point(8, 36);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(776, 316);
            this.panel3.TabIndex = 29;
            // 
            // dgvPrecio
            // 
            this.dgvPrecio.AllowUserToAddRows = false;
            this.dgvPrecio.AllowUserToDeleteRows = false;
            this.dgvPrecio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrecio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tipoprecio,
            this.precio});
            this.dgvPrecio.Location = new System.Drawing.Point(88, 144);
            this.dgvPrecio.Name = "dgvPrecio";
            this.dgvPrecio.Size = new System.Drawing.Size(296, 168);
            this.dgvPrecio.TabIndex = 72;
            this.dgvPrecio.Visible = false;
            // 
            // tipoprecio
            // 
            this.tipoprecio.HeaderText = "Tipo de precio";
            this.tipoprecio.Name = "tipoprecio";
            // 
            // precio
            // 
            this.precio.HeaderText = "Precio";
            this.precio.Name = "precio";
            // 
            // lbprecio
            // 
            this.lbprecio.AutoSize = true;
            this.lbprecio.Location = new System.Drawing.Point(22, 157);
            this.lbprecio.Name = "lbprecio";
            this.lbprecio.Size = new System.Drawing.Size(47, 16);
            this.lbprecio.TabIndex = 70;
            this.lbprecio.Text = "Precio";
            this.lbprecio.Visible = false;
            // 
            // lbtipoprecio
            // 
            this.lbtipoprecio.AutoSize = true;
            this.lbtipoprecio.Location = new System.Drawing.Point(134, 100);
            this.lbtipoprecio.Name = "lbtipoprecio";
            this.lbtipoprecio.Size = new System.Drawing.Size(103, 16);
            this.lbtipoprecio.TabIndex = 68;
            this.lbtipoprecio.Text = "Tipos de precio";
            this.lbtipoprecio.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 16);
            this.label9.TabIndex = 67;
            this.label9.Text = "Crear estructura";
            // 
            // comboEstructuraAlta
            // 
            this.comboEstructuraAlta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboEstructuraAlta.FormattingEnabled = true;
            this.comboEstructuraAlta.Items.AddRange(new object[] {
            "Fraccionamiento",
            "Sector",
            "Viña"});
            this.comboEstructuraAlta.Location = new System.Drawing.Point(96, 39);
            this.comboEstructuraAlta.Name = "comboEstructuraAlta";
            this.comboEstructuraAlta.Size = new System.Drawing.Size(179, 24);
            this.comboEstructuraAlta.TabIndex = 65;
            this.comboEstructuraAlta.SelectedIndexChanged += new System.EventHandler(this.comboEstructuraAlta_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 71);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 16);
            this.label10.TabIndex = 3;
            this.label10.Text = "Nombre";
            // 
            // btnGuardarEstructura
            // 
            this.btnGuardarEstructura.ForeColor = System.Drawing.Color.Black;
            this.btnGuardarEstructura.Location = new System.Drawing.Point(342, 24);
            this.btnGuardarEstructura.Name = "btnGuardarEstructura";
            this.btnGuardarEstructura.Size = new System.Drawing.Size(90, 53);
            this.btnGuardarEstructura.TabIndex = 25;
            this.btnGuardarEstructura.Text = "Guardar";
            this.btnGuardarEstructura.UseVisualStyleBackColor = true;
            this.btnGuardarEstructura.Click += new System.EventHandler(this.btnGuardarEstructura_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(22, 45);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 16);
            this.label11.TabIndex = 1;
            this.label11.Text = "Estructura";
            // 
            // txtEstructuraAlta
            // 
            this.txtEstructuraAlta.Location = new System.Drawing.Point(96, 68);
            this.txtEstructuraAlta.Name = "txtEstructuraAlta";
            this.txtEstructuraAlta.Size = new System.Drawing.Size(179, 22);
            this.txtEstructuraAlta.TabIndex = 2;
            // 
            // ProcesosEspeciales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 543);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.MenuGeneral);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ProcesosEspeciales";
            this.ShowIcon = false;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProcesosEspeciales_FormClosing);
            this.Load += new System.EventHandler(this.ProcesosEspeciales_Load);
            this.MenuGeneral.ResumeLayout(false);
            this.MenuGeneral.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBajaUsuario)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaja)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrecio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuGeneral;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chbAdministrador;
        private System.Windows.Forms.CheckBox chbProcesosEsp;
        private System.Windows.Forms.CheckBox chbfinanciamiento;
        private System.Windows.Forms.CheckBox chbMonitoreo;
        private System.Windows.Forms.CheckBox chbAministracion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGuardarUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvBajaUsuario;
        private System.Windows.Forms.Button btnBuscarBaja;
        private System.Windows.Forms.TextBox txtUsuarioBaja;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboEstructuraBaja;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtnombreBaja;
        private System.Windows.Forms.DataGridView dgvBaja;
        private System.Windows.Forms.Button buscarBajaEstructura;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboEstructuraAlta;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnGuardarEstructura;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtEstructuraAlta;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem1;
        private System.Windows.Forms.Label lbprecio;
        private System.Windows.Forms.Label lbtipoprecio;
        private System.Windows.Forms.DataGridView dgvPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoprecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
    }
}