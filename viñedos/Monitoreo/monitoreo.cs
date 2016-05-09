using System;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using WW.Cad.Model;
using WW.Math;
using iTextSharp.text;
using iTextSharp.text.pdf;
using viñedos.Properties;
using viñedos.Lote;

namespace viñedos.Monitoreo
{
    internal partial class Monitoreo : Form
    {
        private int X { get; set; }
        private int Y { get; set; }
        private lote _lote= new lote();
        public Monitoreo()
        {
            InitializeComponent();//-- 
        }
        public Monitoreo(DxfModel model)
        {
            InitializeComponent();
            viewControl.Model = model;
        }
        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var l=new LogIn();
            Hide();
            l.ShowDialog();
        }
        private void menuToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var m=new Menu();
            Hide();
            m.ShowDialog();
        }
        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void viewControl_MouseMove(object sender, MouseEventArgs e)
        {
            var point = viewControl.GetModelSpaceCoordinates(new Point2D(e.X, e.Y));
            X = int.Parse(Math.Truncate(point.X).ToString(CultureInfo.CurrentCulture));
            Y = int.Parse(Math.Truncate(point.Y).ToString(CultureInfo.CurrentCulture));
        }
        private void EstructuraSeleccionada(int x, int y,int i)
        {
            SqlConnection cn = new SqlConnection(@"Integrated Security=SSPI;Initial Catalog=viñedos;Data Source=localhost; MultipleActiveResultSets=true; MultipleActiveResultSets=true; max pool size=1000");
            cn.Open();

            try
            {
                var conDd = cn;
                string idlote = "";
                string queryDatosClien;
                if(i==0)
                {
                    queryDatosClien = "select *,v.descripcion as viña,f.descripcion as fraccionamiento,s.descripcion as sector,pr.precio as precio from poligono E left join lote d on e.idlote = d.idlote left join viña v on v.idviña=d.idviña left join fraccionamiento f on d.idfraccionamiento=f.idfraccionamiento left join sector s on d.idzector=s.idzector left join preciolote pr on d.idprecio=pr.idprecio  where E.poligono.STContains(geometry::STGeomFromText('POINT(" + x + " " + y + ")', 0)) > 0";
                }
                else
                {
                    queryDatosClien = "select *,v.descripcion as viña,f.descripcion as fraccionamiento,s.descripcion as sector,pr.precio as precio from poligono E left join lote d on e.idlote = d.idlote left join viña v on v.idviña=d.idviña left join fraccionamiento f on d.idfraccionamiento=f.idfraccionamiento left join sector s on d.idzector=s.idzector left join preciolote pr on d.idprecio=pr.idprecio  where numerolote='" + txtNlote.Text+"'";
                }

                var cmdDd = new SqlCommand(queryDatosClien, conDd);
                var readerDd = cmdDd.ExecuteReader();
                if (readerDd.HasRows)
                {
                    if (readerDd.Read())
                    {
                        txtLote.Text = readerDd["descripcion"] + "\r\n";
                        txtLote.Text += @"Numero  de lote :"+readerDd["numerolote"] + "\r\n";
                        txtLote.Text += @"Fraccionamiento :" + readerDd["fraccionamiento"] + "\r\n";
                        txtLote.Text += @"Sector :" + readerDd["sector"] + "\r\n";
                        txtLote.Text += @"Viña :" + readerDd["Viña"] + "\r\n";

                        txtLote.Text += @"Colindancia norte :" + readerDd["cnorte"] + @" " + @"Medida :" + readerDd["mnorte"] + "\r\n";
                        txtLote.Text += @"Colindancia sur :" + readerDd["csur"] + @" " + @"Medida :" + readerDd["msur"] + "\r\n";
                        txtLote.Text += @"Colindancia oriente :" + readerDd["coriente"] + @" " + @"Medida :" + readerDd["moriente"] + "\r\n";
                        txtLote.Text += @"Colindancia poniente :" + readerDd["cponiente"] + @" " + @"Medida :" + readerDd["mponiente"] + "\r\n";
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
                    }
                    conDd.Close();
                    if (idlote != "")
                    {

                    }
                }
            }
            catch(Exception e)
            {
                // ignored
                MessageBox.Show(e.ToString());
            }
        }
        private void viewControl_MouseClick(object sender, MouseEventArgs e)
        {
            EstructuraSeleccionada(int.Parse(X.ToString()), int.Parse(Y.ToString()),0);
        }
        private void monitoreo_Load(object sender, EventArgs e)
        {
            //Auxiliares.Auxiliares.CerrarFormulariosAbiertos(Name);
        }
        private void btnBuscarlote_Click(object sender, EventArgs e)
        {
            if (txtNlote.Text != "")
            {
                EstructuraSeleccionada(int.Parse(X.ToString()), int.Parse(Y.ToString()), 1);
            }
        }
        private void generarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var dirlogo = Auxiliares.Auxiliares.GetTempFilePathWithExtension() + ".png";
                Bitmap logo=new Bitmap(Resources.Logo);
                logo.Save(dirlogo);

                var document = new Document();
                string archivo = Auxiliares.Auxiliares.GetTempFilePathWithExtension()+".pdf";
                PdfWriter.GetInstance(document,
                    new FileStream(archivo, FileMode.OpenOrCreate));
                document.Open();
                //IMAGEN LOGO
                var jpg = iTextSharp.text.Image.GetInstance(dirlogo);
                jpg.Alignment = Element.ALIGN_CENTER;
                jpg.ScaleAbsoluteWidth(150);
                jpg.ScaleAbsoluteHeight(60);
                document.Add(jpg);
                var chunk = new Chunk("Lote : "+_lote._Numerolote, FontFactory.GetFont("ARIAL", 18));
                var p = new Paragraph(chunk);
                p.Alignment = Element.ALIGN_CENTER;
                document.Add(p);

                chunk = new Chunk("Fecha : "+DateTime.Now.ToString("yyyy-MM-dd"),FontFactory.GetFont("ARIAL", 12));
                document.Add(new Paragraph(chunk));
                document.Add(new Paragraph(" "));
                document.Add(new Paragraph(" "));
                var table = new PdfPTable(2);
                table.HorizontalAlignment = 0;


                var cell = new PdfPCell(new Phrase(""));
                
                cell = new PdfPCell(new Phrase("Descripcion : ", FontFactory.GetFont("ARIAL", 12)));
                cell.Border = 0;
                table.AddCell(cell);
                cell = new PdfPCell(new Phrase(_lote._Descripcion, FontFactory.GetFont("ARIAL", 12)));
                cell.Border = 0;
                table.AddCell(cell);

                cell = new PdfPCell(new Phrase("Fraccionamiento : ", FontFactory.GetFont("ARIAL", 12)));
                cell.Border = 0;
                table.AddCell(cell);
                cell = new PdfPCell(new Phrase(_lote._Fraccionamiento, FontFactory.GetFont("ARIAL", 12)));
                cell.Border = 0;
                table.AddCell(cell);

                cell = new PdfPCell(new Phrase("Sector : ", FontFactory.GetFont("ARIAL", 12)));
                cell.Border = 0;
                table.AddCell(cell);
                cell = new PdfPCell(new Phrase(_lote._Zector, FontFactory.GetFont("ARIAL", 12)));
                cell.Border = 0;
                table.AddCell(cell);

                cell = new PdfPCell(new Phrase("Viña : ", FontFactory.GetFont("ARIAL", 12)));
                cell.Border = 0;
                table.AddCell(cell);
                cell = new PdfPCell(new Phrase(_lote._Viña, FontFactory.GetFont("ARIAL", 12)));
                cell.Border = 0;
                table.AddCell(cell);

                cell = new PdfPCell(new Phrase("Superficie : ", FontFactory.GetFont("ARIAL", 12)));
                cell.Border = 0;
                table.AddCell(cell);
                cell = new PdfPCell(new Phrase(_lote._Superficie, FontFactory.GetFont("ARIAL", 12)));
                cell.Border = 0;
                table.AddCell(cell);

                cell = new PdfPCell(new Phrase("Precio : ", FontFactory.GetFont("ARIAL", 12)));
                cell.Border = 0;
                table.AddCell(cell);
                cell = new PdfPCell(new Phrase(_lote._Precio, FontFactory.GetFont("ARIAL", 12)));
                cell.Border = 0;
                table.AddCell(cell);

                //Renglon en blanco
                cell = new PdfPCell(new Phrase("\n"));
                cell.Border = 0;
                table.AddCell(cell);
                cell = new PdfPCell(new Phrase("\n"));
                cell.Border = 0;
                table.AddCell(cell);
                
                document.Add(table);


                var dirlote = viewControl.GuardarImagen();//GuardarImagen();                

                jpg = iTextSharp.text.Image.GetInstance(dirlote);
                jpg.Alignment = Element.ALIGN_CENTER;
                jpg.ScaleAbsoluteWidth(300);
                jpg.ScaleAbsoluteHeight(300);
                document.Add(jpg);

                var table2 = new PdfPTable(4);
                table2.HorizontalAlignment = 0;


                var cell2 = new PdfPCell(new Phrase("Colindancias ", FontFactory.GetFont("ARIAL", 12)));
                cell2.Border = 0;
                table2.AddCell(cell2);
                cell2 = new PdfPCell(new Phrase("", FontFactory.GetFont("ARIAL", 12)));
                cell2.Border = 0;
                table2.AddCell(cell2);
                cell2 = new PdfPCell(new Phrase("Medidas", FontFactory.GetFont("ARIAL", 12)));
                cell2.Border = 0;
                table2.AddCell(cell2);
                cell2 = new PdfPCell(new Phrase("", FontFactory.GetFont("ARIAL", 12)));
                cell2.Border = 0;
                table2.AddCell(cell2);
                
                                
                cell2 = new PdfPCell(new Phrase("Norte ", FontFactory.GetFont("ARIAL", 12)));
                cell2.Border = 0;
                table2.AddCell(cell2);
                cell2 = new PdfPCell(new Phrase(_lote._Cnorte, FontFactory.GetFont("ARIAL", 12)));
                cell2.Border = 0;
                table2.AddCell(cell2);
                cell2 = new PdfPCell(new Phrase(_lote._Mnorte, FontFactory.GetFont("ARIAL", 12)));
                cell2.Border = 0;
                table2.AddCell(cell2);
                cell2 = new PdfPCell(new Phrase("", FontFactory.GetFont("ARIAL", 12)));
                cell2.Border = 0;
                table2.AddCell(cell2);

                cell2 = new PdfPCell(new Phrase("Sur ", FontFactory.GetFont("ARIAL", 12)));
                cell2.Border = 0;
                table2.AddCell(cell2);
                cell2 = new PdfPCell(new Phrase(_lote._Csur, FontFactory.GetFont("ARIAL", 12)));
                cell2.Border = 0;
                table2.AddCell(cell2);
                cell2 = new PdfPCell(new Phrase(_lote._Msur, FontFactory.GetFont("ARIAL", 12)));
                cell2.Border = 0;
                table2.AddCell(cell2);
                cell2 = new PdfPCell(new Phrase("", FontFactory.GetFont("ARIAL", 12)));
                cell2.Border = 0;
                table2.AddCell(cell2);

                cell2 = new PdfPCell(new Phrase("Oriente ", FontFactory.GetFont("ARIAL", 12)));
                cell2.Border = 0;
                table2.AddCell(cell2);
                cell2 = new PdfPCell(new Phrase(_lote._Coriente, FontFactory.GetFont("ARIAL", 12)));
                cell2.Border = 0;
                table2.AddCell(cell2);
                cell2 = new PdfPCell(new Phrase(_lote._Moriente, FontFactory.GetFont("ARIAL", 12)));
                cell2.Border = 0;
                table2.AddCell(cell2);
                cell2 = new PdfPCell(new Phrase("", FontFactory.GetFont("ARIAL", 12)));
                cell2.Border = 0;
                table2.AddCell(cell2);

                cell2 = new PdfPCell(new Phrase("Poniente ", FontFactory.GetFont("ARIAL", 12)));
                cell2.Border = 0;
                table2.AddCell(cell2);
                cell2 = new PdfPCell(new Phrase(_lote._Cponiente, FontFactory.GetFont("ARIAL", 12)));
                cell2.Border = 0;
                table2.AddCell(cell2);
                cell2 = new PdfPCell(new Phrase(_lote._Mponiente, FontFactory.GetFont("ARIAL", 12)));
                cell2.Border = 0;
                table2.AddCell(cell2);
                cell2 = new PdfPCell(new Phrase("", FontFactory.GetFont("ARIAL", 12)));
                cell2.Border = 0;
                table2.AddCell(cell2);

                document.Add(table2);

                document.Close();
                Process.Start(archivo);

            }
            catch
            {
                // ignored
            }
        }
        private void monitoreo_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}