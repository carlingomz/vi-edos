using System;
using System.Windows.Forms;

namespace viñedos.Procesos_especiales
{
    public partial class ProcesosEspeciales : Form
    {
        public ProcesosEspeciales()
        {
            InitializeComponent();
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
        private void btnGuardarEstructura_Click(object sender, EventArgs e)
        {
            string estructura = txtEstructuraAlta.Text;
            if (comboEstructuraAlta.SelectedIndex > -1)
            {
                int tipo = comboEstructuraAlta.SelectedIndex + 1;
                Consultas.InsertaEstructura(estructura, tipo);

                if (comboEstructuraAlta.SelectedIndex == 2)
                {
                    string idviña = Consultas.Idviña(estructura);
                    Consultas.InsertaPrecios(idviña,dgvPrecio.Rows[0].Cells[1].Value.ToString(),0);
                    Consultas.InsertaPrecios(idviña,dgvPrecio.Rows[1].Cells[1].Value.ToString(), 0);
                    Consultas.InsertaPrecios(idviña,dgvPrecio.Rows[2].Cells[1].Value.ToString(), 0);
                    Consultas.InsertaPrecios(idviña, dgvPrecio.Rows[3].Cells[1].Value.ToString(), 0);
                    Consultas.InsertaPrecios(idviña, dgvPrecio.Rows[4].Cells[1].Value.ToString(), 0);
                }
            }
        }
        private void buscarBajaEstructura_Click(object sender, EventArgs e)
        {
            if (comboEstructuraBaja.SelectedIndex > -1)
            {
                int tipo = comboEstructuraBaja.SelectedIndex + 1;
                dgvBaja.DataSource = null;
                dgvBaja.Columns.Clear();
                dgvBaja.DataSource = Consultas.Estructura(txtnombreBaja.Text, tipo);

                if (dgvBaja.RowCount > 0)
                {
                    var btn = new DataGridViewButtonColumn();
                    dgvBaja.Columns.Add(btn);
                    btn.HeaderText = @"Borrar";
                    btn.Name = "Borrar";
                    var dataGridViewColumn = dgvBaja.Columns["Borrar"];
                    if (dataGridViewColumn != null) dataGridViewColumn.DisplayIndex = 0;
                    //dgvBaja.Columns["idusuario"].Visible = false;
                }
            }
        }
        private void btnGuardarUsuario_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contraseña = txtContraseña.Text;
            int monitoreo = 0;
            if (chbMonitoreo.Checked)
            {
                monitoreo = 1;
            }
            int areaadministrativa = 0;
            if (chbAministracion.Checked)
            {
                areaadministrativa = 1;
            }
            int planesdefinanciamiento = 0;
            if (chbfinanciamiento.Checked)
            {
                planesdefinanciamiento = 1;
            }
            int procesosespeciales = 0;
            if (chbProcesosEsp.Checked)
            {
                procesosespeciales = 1;
            }
            int administrador = 0;
            if (chbAdministrador.Checked)
            {
                administrador = 1;
            }
            Consultas.InsertaUsuario(usuario,contraseña,monitoreo,areaadministrativa,planesdefinanciamiento,procesosespeciales,administrador);
        }
        private void comboEstructuraAlta_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboEstructuraAlta.SelectedIndex == 2)
            {
                lbtipoprecio.Visible = true;
                lbprecio.Visible = true;
                dgvPrecio.Visible = true;
                dgvPrecio.Rows[0].Cells[1].Value = "0";
                dgvPrecio.Rows[1].Cells[1].Value = "0";
                dgvPrecio.Rows[2].Cells[1].Value = "0";
                dgvPrecio.Rows[3].Cells[1].Value = "0";
                dgvPrecio.Rows[4].Cells[1].Value = "0";
            }
            else
            {
                lbtipoprecio.Visible = false;
                lbprecio.Visible = false;
                dgvPrecio.Visible = false;
            }
        }
        private void ProcesosEspeciales_Load(object sender, EventArgs e)
        {
            Auxiliares.Auxiliares.CerrarFormulariosAbiertos(Name);
            dgvPrecio.Rows.Add(5);
            dgvPrecio.Rows[0].Cells[0].Value = "Precio de lista";
            dgvPrecio.Rows[1].Cells[0].Value = "Preventa";
            dgvPrecio.Rows[2].Cells[0].Value = "Preventa contado";
            dgvPrecio.Rows[3].Cells[0].Value = "Mayoreo";
            dgvPrecio.Rows[4].Cells[0].Value = "Preferencial";
        }
        private void btnBuscarBaja_Click(object sender, EventArgs e)
        {
            dgvBajaUsuario.DataSource = null;
            dgvBajaUsuario.Columns.Clear();
            dgvBajaUsuario.DataSource = Consultas.Usuarios(txtUsuarioBaja.Text);

            if (dgvBajaUsuario.RowCount > 0)
            {
                var btn = new DataGridViewButtonColumn();
                dgvBajaUsuario.Columns.Add(btn);
                btn.HeaderText = @"Borrar";
                btn.Name = "Borrar";
                var dataGridViewColumn = dgvBajaUsuario.Columns["Borrar"];
                if (dataGridViewColumn != null) dataGridViewColumn.DisplayIndex = 0;

                dgvBajaUsuario.Columns["idusuario"].Visible = false;
            }
        }
        private void dgvBajaUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && dgvBajaUsuario.Columns[e.ColumnIndex].Name=="Borrar")
            {
                Consultas.BorrarUsuario(dgvBajaUsuario.Rows[e.RowIndex].Cells["idusuario"].Value.ToString());
                btnBuscarBaja.PerformClick();
            }
        }
        private void dgvBaja_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && dgvBaja.Columns[e.ColumnIndex].Name == "Borrar")
            {
                Consultas.BorrarEstrucutra(dgvBaja.Rows[e.RowIndex].Cells["idestructura"].Value.ToString(),comboEstructuraBaja.SelectedIndex);
                buscarBajaEstructura.PerformClick();
            }
        }
        private void ProcesosEspeciales_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}