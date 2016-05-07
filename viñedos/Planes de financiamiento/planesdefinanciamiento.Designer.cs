namespace viñedos.Planes_de_financiamiento
{
    partial class Planesdefinanciamiento
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
            this.dgvPagos = new System.Windows.Forms.DataGridView();
            this.pago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pagointeres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pagocapital = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPagoMensual = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtinteresanual = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.btnBuscarlote = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNlote = new System.Windows.Forms.TextBox();
            this.tabParametros = new System.Windows.Forms.TabPage();
            this.txtMensualidades = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btncalcular = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAnticipo = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtmesesAlta = new System.Windows.Forms.TextBox();
            this.btnGuardarPlan = new System.Windows.Forms.Button();
            this.comboMesesBaja = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnMesesBaja = new System.Windows.Forms.Button();
            this.MenuGeneral.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagos)).BeginInit();
            this.tabParametros.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuGeneral
            // 
            this.MenuGeneral.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.MenuGeneral.Location = new System.Drawing.Point(0, 0);
            this.MenuGeneral.Name = "MenuGeneral";
            this.MenuGeneral.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.MenuGeneral.Size = new System.Drawing.Size(1223, 25);
            this.MenuGeneral.TabIndex = 2;
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
            this.cerrarToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.cerrarToolStripMenuItem.Text = "cerrar";
            this.cerrarToolStripMenuItem.Click += new System.EventHandler(this.cerrarToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabParametros);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 25);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1223, 571);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.txtAnticipo);
            this.tabPage1.Controls.Add(this.btncalcular);
            this.tabPage1.Controls.Add(this.dgvPagos);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.txtPagoMensual);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txtMensualidades);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtinteresanual);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtPrecio);
            this.tabPage1.Controls.Add(this.btnBuscarlote);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtNlote);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1215, 545);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cotizacion pagos ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvPagos
            // 
            this.dgvPagos.AllowUserToAddRows = false;
            this.dgvPagos.AllowUserToDeleteRows = false;
            this.dgvPagos.AllowUserToOrderColumns = true;
            this.dgvPagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPagos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pago,
            this.Pagointeres,
            this.pagocapital,
            this.saldo});
            this.dgvPagos.Location = new System.Drawing.Point(344, 32);
            this.dgvPagos.Name = "dgvPagos";
            this.dgvPagos.Size = new System.Drawing.Size(472, 376);
            this.dgvPagos.TabIndex = 16;
            // 
            // pago
            // 
            this.pago.HeaderText = "pago";
            this.pago.Name = "pago";
            this.pago.ReadOnly = true;
            // 
            // Pagointeres
            // 
            this.Pagointeres.HeaderText = "Pago interes";
            this.Pagointeres.Name = "Pagointeres";
            this.Pagointeres.ReadOnly = true;
            // 
            // pagocapital
            // 
            this.pagocapital.HeaderText = "Pago capital";
            this.pagocapital.Name = "pagocapital";
            this.pagocapital.ReadOnly = true;
            // 
            // saldo
            // 
            this.saldo.HeaderText = "Saldo";
            this.saldo.Name = "saldo";
            this.saldo.ReadOnly = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 304);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 26);
            this.label5.TabIndex = 15;
            this.label5.Text = "Pago\r\nMensual\r\n";
            this.label5.Visible = false;
            // 
            // txtPagoMensual
            // 
            this.txtPagoMensual.Location = new System.Drawing.Point(112, 304);
            this.txtPagoMensual.Name = "txtPagoMensual";
            this.txtPagoMensual.Size = new System.Drawing.Size(208, 20);
            this.txtPagoMensual.TabIndex = 14;
            this.txtPagoMensual.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Interes anual";
            // 
            // txtinteresanual
            // 
            this.txtinteresanual.Location = new System.Drawing.Point(112, 240);
            this.txtinteresanual.Name = "txtinteresanual";
            this.txtinteresanual.Size = new System.Drawing.Size(208, 20);
            this.txtinteresanual.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "precio";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(112, 208);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(208, 20);
            this.txtPrecio.TabIndex = 8;
            // 
            // btnBuscarlote
            // 
            this.btnBuscarlote.Location = new System.Drawing.Point(112, 81);
            this.btnBuscarlote.Name = "btnBuscarlote";
            this.btnBuscarlote.Size = new System.Drawing.Size(208, 23);
            this.btnBuscarlote.TabIndex = 7;
            this.btnBuscarlote.Text = "Buscar";
            this.btnBuscarlote.UseVisualStyleBackColor = true;
            this.btnBuscarlote.Click += new System.EventHandler(this.btnBuscarlote_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Numero de lote";
            // 
            // txtNlote
            // 
            this.txtNlote.Location = new System.Drawing.Point(112, 32);
            this.txtNlote.Name = "txtNlote";
            this.txtNlote.Size = new System.Drawing.Size(208, 20);
            this.txtNlote.TabIndex = 5;
            // 
            // tabParametros
            // 
            this.tabParametros.Controls.Add(this.panel1);
            this.tabParametros.Location = new System.Drawing.Point(4, 22);
            this.tabParametros.Name = "tabParametros";
            this.tabParametros.Padding = new System.Windows.Forms.Padding(3);
            this.tabParametros.Size = new System.Drawing.Size(1215, 545);
            this.tabParametros.TabIndex = 1;
            this.tabParametros.Text = "Parametros";
            this.tabParametros.UseVisualStyleBackColor = true;
            // 
            // txtMensualidades
            // 
            this.txtMensualidades.Location = new System.Drawing.Point(112, 272);
            this.txtMensualidades.Name = "txtMensualidades";
            this.txtMensualidades.Size = new System.Drawing.Size(208, 20);
            this.txtMensualidades.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Mensualidades";
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(112, 344);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(208, 23);
            this.btncalcular.TabIndex = 17;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Anticipo";
            // 
            // txtAnticipo
            // 
            this.txtAnticipo.Location = new System.Drawing.Point(112, 176);
            this.txtAnticipo.Name = "txtAnticipo";
            this.txtAnticipo.Size = new System.Drawing.Size(208, 20);
            this.txtAnticipo.TabIndex = 18;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnMesesBaja);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.comboMesesBaja);
            this.panel1.Controls.Add(this.btnGuardarPlan);
            this.panel1.Controls.Add(this.txtmesesAlta);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(32, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(416, 168);
            this.panel1.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Planes de pago";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(104, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Alta";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(208, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Meses";
            // 
            // txtmesesAlta
            // 
            this.txtmesesAlta.Location = new System.Drawing.Point(192, 64);
            this.txtmesesAlta.Name = "txtmesesAlta";
            this.txtmesesAlta.Size = new System.Drawing.Size(72, 20);
            this.txtmesesAlta.TabIndex = 3;
            // 
            // btnGuardarPlan
            // 
            this.btnGuardarPlan.Location = new System.Drawing.Point(312, 64);
            this.btnGuardarPlan.Name = "btnGuardarPlan";
            this.btnGuardarPlan.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarPlan.TabIndex = 4;
            this.btnGuardarPlan.Text = "Guardar";
            this.btnGuardarPlan.UseVisualStyleBackColor = true;
            // 
            // comboMesesBaja
            // 
            this.comboMesesBaja.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboMesesBaja.FormattingEnabled = true;
            this.comboMesesBaja.Location = new System.Drawing.Point(192, 112);
            this.comboMesesBaja.Name = "comboMesesBaja";
            this.comboMesesBaja.Size = new System.Drawing.Size(80, 21);
            this.comboMesesBaja.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(104, 120);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "Baja";
            // 
            // btnMesesBaja
            // 
            this.btnMesesBaja.Location = new System.Drawing.Point(312, 112);
            this.btnMesesBaja.Name = "btnMesesBaja";
            this.btnMesesBaja.Size = new System.Drawing.Size(75, 23);
            this.btnMesesBaja.TabIndex = 7;
            this.btnMesesBaja.Text = "Eliminar";
            this.btnMesesBaja.UseVisualStyleBackColor = true;
            // 
            // Planesdefinanciamiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1223, 596);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.MenuGeneral);
            this.Name = "Planesdefinanciamiento";
            this.ShowIcon = false;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Planesdefinanciamiento_FormClosing);
            this.Load += new System.EventHandler(this.Planesdefinanciamiento_Load);
            this.MenuGeneral.ResumeLayout(false);
            this.MenuGeneral.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagos)).EndInit();
            this.tabParametros.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuGeneral;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabParametros;
        private System.Windows.Forms.Button btnBuscarlote;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNlote;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtinteresanual;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPagoMensual;
        private System.Windows.Forms.DataGridView dgvPagos;
        private System.Windows.Forms.DataGridViewTextBoxColumn pago;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pagointeres;
        private System.Windows.Forms.DataGridViewTextBoxColumn pagocapital;
        private System.Windows.Forms.DataGridViewTextBoxColumn saldo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMensualidades;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAnticipo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGuardarPlan;
        private System.Windows.Forms.TextBox txtmesesAlta;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnMesesBaja;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboMesesBaja;
    }
}