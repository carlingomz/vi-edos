using System;
using System.Windows.Forms;
using viñedos.Lote;

namespace viñedos.Planes_de_financiamiento
{
    public partial class Planesdefinanciamiento : Form
    {
        lote _lote=new lote();
        public Planesdefinanciamiento()
        {
            InitializeComponent();
        }
        private void btnBuscarlote_Click(object sender, EventArgs e)
        {
            if (txtNlote.Text != "")
            {
                _lote = new lote(txtNlote.Text,0);
                txtPrecio.Text = _lote._Precio;
            }
        }
        /*private void EstructuraSeleccionada()
        {
            SqlConnection cn = new SqlConnection(@"Integrated Security=SSPI;Initial Catalog=viñedos;Data Source=localhost; MultipleActiveResultSets=true; MultipleActiveResultSets=true; max pool size=1000");
            cn.Open();

            try
            {
                var conDd = cn;
                string idlote = "";
                string queryDatosClien;
               
                    queryDatosClien = "select *,v.descripcion as viña,f.descripcion as fraccionamiento,s.descripcion as sector,pr.precio as precio from poligono E left join lote d on e.idlote = d.idlote left join viña v on v.idviña=d.idviña left join fraccionamiento f on d.idfraccionamiento=f.idfraccionamiento left join sector s on d.idzector=s.idzector left join preciolote pr on d.idprecio=pr.idprecio  where numerolote='" + txtNlote.Text + "'";


                var cmdDd = new SqlCommand(queryDatosClien, conDd);
                var readerDd = cmdDd.ExecuteReader();
                if (readerDd.HasRows)
                {
                    if (readerDd.Read())
                    {
                        txtLote.Text = readerDd["descripcion"] + "\r\n";
                        txtLote.Text += @"Numero  de lote :" + readerDd["numerolote"] + "\r\n";
                        txtLote.Text += @"Fraccionamiento :" + readerDd["fraccionamiento"] + "\r\n";
                        txtLote.Text += @"Sector :" + readerDd["sector"] + "\r\n";
                        txtLote.Text += @"Viña :" + readerDd["Viña"] + "\r\n";

                        txtLote.Text += @"Colindancia norte :" + readerDd["cnorte"] + " " + @"Medida :" + readerDd["mnorte"] + "\r\n";
                        txtLote.Text += @"Colindancia sur :" + readerDd["csur"] + " " + @"Medida :" + readerDd["msur"] + "\r\n";
                        txtLote.Text += @"Colindancia oriente :" + readerDd["coriente"] + " " + @"Medida :" + readerDd["moriente"] + "\r\n";
                        txtLote.Text += @"Colindancia poniente :" + readerDd["cponiente"] + " " + @"Medida :" + readerDd["mponiente"] + "\r\n";
                        //--
                        //txtLote.Text += @"Medida norte :" + readerDd["mnorte"] + "\r\n";
                        //txtLote.Text += @"Medida sur :" + readerDd["msur"] + "\r\n";
                        //txtLote.Text += @"Medida oriente :" + readerDd["moriente"] + "\r\n";
                        //txtLote.Text += @"Medida poniente :" + readerDd["mponiente"] + "\r\n";
                        //--
                        txtLote.Text += @"Superficie :" + readerDd["superficie"] + " metros cuadrados\r\n";
                        txtLote.Text += @"Estatus :" + readerDd["estatus"] + "\r\n";
                        txtLote.Text += @"Precio : $" + readerDd["precio"] + "\r\n";
                        _lote = new lote(readerDd["idlote"].ToString());
                        txtPrecio.Text = _lote._Precio;
                    }
                    conDd.Close();
                    if (idlote != "")
                    {

                    }
                }
            }
            catch (Exception e)
            {
                // ignored
                MessageBox.Show(e.ToString());
            }
        }*/
        private void Calculapagos()
        {
            dgvPagos.Rows.Clear();
            int numeropagos = int.Parse(txtMensualidades.Text);
            double monto = double.Parse(txtPrecio.Text);
            double tasa = double.Parse(txtinteresanual.Text);

            double interes = (tasa/100)/12;
            double anticipo = 0;
            if (txtAnticipo.Text != "")
            {
                anticipo = double.Parse(txtAnticipo.Text);
            }
            double pagoAcapital=((monto-anticipo)*interes)/(1-Math.Pow((1+interes),-numeropagos));
            double saldoi = (pagoAcapital*numeropagos);
            for (int i = 0; i <= numeropagos - 1; i++)
            {
                dgvPagos.Rows.Add();
                if (i == 0 && anticipo > 0)
                {
                    numeropagos++;
                    dgvPagos.Rows[i].Cells[0].Value = "Anticipo";
                    dgvPagos.Rows[i].Cells[1].Value = "0.00";
                    dgvPagos.Rows[i].Cells[2].Value = anticipo.ToString("N2");
                    dgvPagos.Rows[i].Cells[3].Value = saldoi.ToString("N2");
                }
                else
                {
                    int numeropago = (i+1);
                    if (anticipo>0)
                    {
                        numeropago = i;
                    }
                    saldoi = saldoi - pagoAcapital;
                    dgvPagos.Rows[i].Cells[0].Value = numeropago;
                    dgvPagos.Rows[i].Cells[1].Value = (saldoi*interes).ToString("N2");
                    dgvPagos.Rows[i].Cells[2].Value = pagoAcapital.ToString("N2");
                    dgvPagos.Rows[i].Cells[3].Value = saldoi.ToString("N2");
                }
            }
        }
        private void Planesdefinanciamiento_Load(object sender, EventArgs e)
        {

        }
        private void Planesdefinanciamiento_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void menuToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var m=new Menu();
            Hide();
            m.ShowDialog();
        }
        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var s=new LogIn();
            Hide();
            s.ShowDialog();
        }
        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btncalcular_Click(object sender, EventArgs e)
        {
            Calculapagos();
        }
    }
}