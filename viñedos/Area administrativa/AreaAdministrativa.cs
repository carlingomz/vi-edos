using System;
using System.Globalization;
using System.Windows.Forms;
using WW.Cad.Model;
using WW.Math;

namespace viñedos.Area_administrativa
{
    public partial class AreaAdministrativa : Form
    {
        private bool _crearlote = false;
        private int X {get;set;}
        private int Y {get;set;}
        public AreaAdministrativa()
        {
            InitializeComponent();
        }
        public AreaAdministrativa(DxfModel model)
        {
            InitializeComponent();
            viewControl.Model = model;
            timer1.Start();
        }
        private void menuToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var m = new Menu();
            Hide();
            m.ShowDialog();
        }
        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var l = new LogIn();
            Hide();
            l.ShowDialog();
        }
        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void AreaAdministrativa_Load(object sender, EventArgs e)
        {
            
        }
        private void viewControl_Click(object sender, EventArgs e)
        {
            if (_crearlote)
            {
                MessageBox.Show(@"X : " + X);
                MessageBox.Show(@"Y : " + Y);
            }
        }
        private void viewControl_MouseMove(object sender, MouseEventArgs e)
        {
            var point = viewControl.GetModelSpaceCoordinates(new Point2D(e.X, e.Y));
            X = int.Parse(Math.Truncate(point.X).ToString(CultureInfo.CurrentCulture));
            Y = int.Parse(Math.Truncate(point.Y).ToString(CultureInfo.CurrentCulture));
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (viewControl.Focused)
            {
                var coord = Coordenadas().Split('-');
                tooltipCordenada.SetToolTip(viewControl, "X:" + coord[0] + " , Y:" + coord[1]);
            }
        }
        private void viewControl_MouseHover(object sender, EventArgs e)
        {
            //var coord = Coordenadas().Split('-');
            //tooltipCordenada.SetToolTip(viewControl, "X:" + coord[0] + " , Y:" + coord[1]);
        }
        private string Coordenadas()
        {
            return X + "-" + Y;
        }
        private void comboFraccionamiento_DropDown(object sender, EventArgs e)
        {
            comboFraccionamiento.DataSource = null;
            var l = consultas.Fraccionamientos();
            comboFraccionamiento.DataSource = l;
        }
        private void combosector_DropDown(object sender, EventArgs e)
        {
            combosector.DataSource = null;
            var l = consultas.Sectores();
            combosector.DataSource = l;
        }
        private void comboViña_DropDown(object sender, EventArgs e)
        {
            comboViña.DataSource = null;
            var l = consultas.Viñas();
            comboViña.DataSource = l;
        }
        private void comboEstatus_DropDown(object sender, EventArgs e)
        {
            if (comboEstatus.SelectedIndex == 2)
            {
                lbPlanpago.Visible = true;
                comboPlandepago.Visible = true;
            }
            else
            {
                lbPlanpago.Visible = false;
                comboPlandepago.Visible = false;
            }
        }
        private void btnGuardarAlta_Click(object sender, EventArgs e)
        {
            string nlote = txtNolote.Text;
            string descripcion = txtDescripcion.Text;
            string colindanciaN = txtNorte.Text;
            string colindanciaS = txtSur.Text;
            string colindanciaO = txtOriente.Text;
            string colindanciaP = txtPoniente.Text;
            //--
            string medidaN = txtMedidaN.Text;
            string medidaS = txtMedidaS.Text;
            string medidaO = txtMedidaO.Text;
            string medidaP = txtMedidaP.Text;
            //--
            string direccion = txtDireccion.Text;
            string fraccionamiento = comboFraccionamiento.Text;
            string sector = combosector.Text;
            string viña = comboViña.Text;
            string superficie = txtSuperficie.Text;
            string titular = txtTitular.Text;
            //- -//-//- -//-//-//-//-//-/-/-/-/~~
            string estatus = comboEstatus.Text;
            string plandepago = comboPlandepago.Text;

            string coordenadas = txtCoord1X.Text + " " + txtCoord1Y.Text + "," + txtCoord2X.Text + " " + txtCoord2Y.Text + "," + txtCoord3X.Text + " " + txtCoord3Y.Text + "," + txtCoord4X.Text + " " + txtCoord4Y.Text + "," + txtCoord1X.Text + " " + txtCoord1Y.Text;

            string x1 = txtCoord1X.Text;
            string y1 = txtCoord1Y.Text;

            string x2 = txtCoord2X.Text;
            string y2 = txtCoord2Y.Text;

            string x3 = txtCoord3X.Text;
            string y3 = txtCoord3Y.Text;

            string x4 = txtCoord4X.Text;
            string y4 = txtCoord4Y.Text;

            if (nlote != "" && coordenadas != ""&& fraccionamiento != "" && sector != "" && viña != "" && estatus != "")
            {
                string idfraccionaiento = consultas.Idfraccionamiento(fraccionamiento);
                string idsector = consultas.Idsector(sector);
                string idviña = consultas.Idviña(viña);
                consultas.Insertalote(nlote, descripcion, colindanciaN, colindanciaS, colindanciaO, colindanciaP,
                    medidaN, medidaS, medidaO, medidaP, direccion, fraccionamiento, sector, viña, superficie, titular,
                    estatus, plandepago, coordenadas, x1, y1, x2, y2, x3, y3, x4, y4, idfraccionaiento, idsector, idviña);
                LimpiarAltaLote();
            }
            else
            {
                MessageBox.Show(@"Ingresa los datos necesarios");
            }
        }
        private void LimpiarAltaLote()
        {
            txtNolote.Clear();
            txtDescripcion.Clear();
            txtNorte.Clear();
            txtSur.Clear();
            txtOriente.Clear();
            txtPoniente.Clear();
            //--
            txtMedidaN.Clear();
            txtMedidaS.Clear();
            txtMedidaO.Clear();
            txtMedidaP.Clear();
            //--
            txtDireccion.Clear();

            comboFraccionamiento.DataSource = null;
            comboFraccionamiento.Items.Clear();

            combosector.DataSource = null;
            combosector.Items.Clear();

            comboViña.DataSource = null;
            comboViña.Items.Clear();

            txtSuperficie.Clear();
            txtTitular.Clear();
            //--
            txtCoord1X.Clear();
            txtCoord1Y.Clear();

            txtCoord2X.Clear();
            txtCoord2Y.Clear();

            txtCoord3X.Clear();
            txtCoord3Y.Clear();

            txtCoord4X.Clear();
            txtCoord4Y.Clear();
        }
        private void btnBuscarBaja_Click(object sender, EventArgs e)
        {
            string nlote = txtNoloteBaja.Text;
            string descripcion = txtDescripcionBaja.Text;
            if (nlote != "")
            {
                dgvBorrar.DataSource = null;
                dgvBorrar.Columns.Clear();
                dgvBorrar.DataSource = consultas.InfoBorrarLote(" numerolote='" + nlote + "'");
            }
            if (descripcion != "")
            {
                dgvBorrar.DataSource = null;
                dgvBorrar.Columns.Clear();
                dgvBorrar.DataSource = consultas.InfoBorrarLote(" descripcion like '%" + descripcion + "%'");
            }
            if (dgvBorrar.Rows.Count > -1)
            {
                var btn = new DataGridViewButtonColumn();
                dgvBorrar.Columns.Add(btn);
                btn.HeaderText = @"Borrar";
                btn.Name = @"borrar";

                var dataGridViewColumn = dgvBorrar.Columns["borrar"];
                if (dataGridViewColumn != null) dataGridViewColumn.DisplayIndex = 0;
                { dgvBorrar.Columns["idlote"].Visible = false; }
            }
        }
        private void dgvBorrar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var dataGridViewColumn = dgvBorrar.Columns["Borrar"];
            if (dataGridViewColumn != null && (e.ColumnIndex == dataGridViewColumn.Index && e.RowIndex > -1))
            {
                if (MessageBox.Show(@"Borrar lote", @"Administracion", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk) == DialogResult.OK)
                {
                    string idlote = dgvBorrar.Rows[e.RowIndex].Cells["idlote"].Value.ToString();
                    consultas.BorrarLote(idlote);
                    MessageBox.Show(@"Borrado");

                    btnBuscarBaja.PerformClick();
                }
            }
        }
        private void btnBuscarModificacion_Click(object sender, EventArgs e)
        {
            string nlote = nloteModifica.Text;
            string descripcion = txtdescripcionModifica.Text;
            if (nlote != "")
            {
                dgvModificar.DataSource = null;
                dgvModificar.Columns.Clear();
                dgvModificar.DataSource = consultas.InfoModificarLote(" numerolote='" + nlote + "'");
            }
            if (descripcion != "")
            {
                dgvModificar.DataSource = null;
                dgvModificar.Columns.Clear();
                dgvModificar.DataSource = consultas.InfoModificarLote(" descripcion like '%" + descripcion + "%'");
            }
            if (dgvModificar.DataSource != null)
            {
                var btn = new DataGridViewButtonColumn();
                dgvModificar.Columns.Add(btn);
                btn.HeaderText = @"Modificar";
                btn.Name = "Modificar";
                var dataGridViewColumn = dgvModificar.Columns["Modificar"];
                if (dataGridViewColumn != null) dataGridViewColumn.DisplayIndex = 0;
                var gridViewColumn = dgvModificar.Columns["idlote"];
                if (gridViewColumn != null)
                    gridViewColumn.Visible = false;


                var viewColumn = dgvModificar.Columns["idfraccionamiento"];
                if (viewColumn != null) viewColumn.Visible = false;

                viewColumn = dgvModificar.Columns["idzector"];
                if (viewColumn != null) viewColumn.Visible = false;

                viewColumn = dgvModificar.Columns["idviña"];
                if (viewColumn != null) viewColumn.Visible = false;

                viewColumn = dgvModificar.Columns["idprecio"];
                if (viewColumn != null) viewColumn.Visible = false;

                viewColumn = dgvModificar.Columns["idestatus"];
                if (viewColumn != null) viewColumn.Visible = false;

                var F = consultas.Fraccionamientos();
                var S = consultas.Sectores();
                var V = consultas.Viñas();

                var E = new string[] {"Disponible", "Apartado", "Vendido", "Escriturado"};
                //var P = new string[] { "Disponible", "Apartado", "Vendido", "Escriturado" };

                DataGridViewComboBoxColumn cb = new DataGridViewComboBoxColumn { DataSource = E };
                dgvModificar.Columns.Add(cb);
                cb.HeaderText = @"Estatus";
                cb.Name = "Estatus";
                var column = dgvModificar.Columns["Estatus"];
                //if (column != null) column.DisplayIndex = dgvModificar.ColumnCount-1;

                cb = new DataGridViewComboBoxColumn { DataSource = F };
                dgvModificar.Columns.Add(cb);
                cb.HeaderText = @"Fraccionamiento";
                cb.Name = "Fraccionamiento";
                column = dgvModificar.Columns["Fraccionamiento"];
                //if (column != null) column.DisplayIndex = dgvModificar.ColumnCount-1;

                cb = new DataGridViewComboBoxColumn { DataSource = S };
                dgvModificar.Columns.Add(cb);
                cb.HeaderText = @"Sector";
                cb.Name = "sector";
                column = dgvModificar.Columns["sector"];
                //if (column != null) column.DisplayIndex = dgvModificar.ColumnCount - 2;

                cb = new DataGridViewComboBoxColumn { DataSource = V };
                dgvModificar.Columns.Add(cb);
                cb.HeaderText = @"Viña";
                cb.Name = "viña";
                column = dgvModificar.Columns["viña"];
                //if (column != null) column.DisplayIndex = dgvModificar.ColumnCount - 3;
                
                for (int i = 0; i <= dgvModificar.RowCount - 1; i++)
                {
                    dgvModificar.Rows[i].Cells["Fraccionamiento"].Value =
                        consultas.Fraccionamiento(dgvModificar.Rows[i].Cells["idfraccionamiento"].Value.ToString());

                    dgvModificar.Rows[i].Cells["viña"].Value =
                        consultas.Viña(dgvModificar.Rows[i].Cells["idviña"].Value.ToString());

                    dgvModificar.Rows[i].Cells["sector"].Value =
                        consultas.Sector(dgvModificar.Rows[i].Cells["idzector"].Value.ToString());

                    dgvModificar.Rows[i].Cells["Estatus"].Value = dgvModificar.Rows[i].Cells["idestatus"].Value.ToString();
                }
            }
        }
        private void dgvModificar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var dataGridViewColumn = dgvModificar.Columns["Modificar"];
            if (dataGridViewColumn != null && (e.ColumnIndex == dataGridViewColumn.Index && e.RowIndex > -1))
            {
                if (MessageBox.Show(@"Modificar lote", @"Administracion", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk) == DialogResult.OK)
                {
                    string nlote = dgvModificar.Rows[e.RowIndex].Cells["Numero de lote"].Value.ToString();
                    string descripcion = dgvModificar.Rows[e.RowIndex].Cells["Descripcion"].Value.ToString();
                    string colindanciaN = dgvModificar.Rows[e.RowIndex].Cells["Colindancia norte"].Value.ToString();
                    string colindanciaS = dgvModificar.Rows[e.RowIndex].Cells["Colindancia sur"].Value.ToString();
                    string colindanciaO = dgvModificar.Rows[e.RowIndex].Cells["Colindancia oriente"].Value.ToString();
                    string colindanciaP = dgvModificar.Rows[e.RowIndex].Cells["Colindancia poniente"].Value.ToString();
                    //--
                    string medidaN = dgvModificar.Rows[e.RowIndex].Cells["Medida norte"].Value.ToString();
                    string medidaS = dgvModificar.Rows[e.RowIndex].Cells["Medida sur"].Value.ToString();
                    string medidaO = dgvModificar.Rows[e.RowIndex].Cells["Medida oriente"].Value.ToString();
                    string medidaP = dgvModificar.Rows[e.RowIndex].Cells["Medida poniente"].Value.ToString();
                    //--
                    string direccion = dgvModificar.Rows[e.RowIndex].Cells["Direccion"].Value.ToString();
                    string superficie = dgvModificar.Rows[e.RowIndex].Cells["Superficie"].Value.ToString();
                    string titular = dgvModificar.Rows[e.RowIndex].Cells["Titular"].Value.ToString();
                    //--
                    string estatus = dgvModificar.Rows[e.RowIndex].Cells["Estatus"].Value.ToString();
                    string plandepago = dgvModificar.Rows[e.RowIndex].Cells["Plan de pago"].Value.ToString();
                    //--
                    string fraccionamiento = dgvModificar.Rows[e.RowIndex].Cells["Fraccionamiento"].Value.ToString();
                    string sector = dgvModificar.Rows[e.RowIndex].Cells["Sector"].Value.ToString();
                    string viña = dgvModificar.Rows[e.RowIndex].Cells["Viña"].Value.ToString();
                    //--
                    string idfraccionaiento = consultas.Idfraccionamiento(fraccionamiento);
                    string idsector = consultas.Idsector(sector);
                    string idviña = consultas.Idviña(viña);
                    //--
                    consultas.ModificaLote(nlote,descripcion,colindanciaN,colindanciaS,colindanciaO,colindanciaP,medidaN,medidaS,medidaO,medidaP,direccion,superficie,titular,estatus,plandepago,idfraccionaiento,idsector,idviña);
                    MessageBox.Show(@"Modificado");
                    btnBuscarModificacion.PerformClick();
                }
            }
        }
        private void AreaAdministrativa_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}