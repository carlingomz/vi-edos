using System;
using System.Windows.Forms;
using Microsoft.Win32;
using viñedos.Area_administrativa;
using viñedos.Monitoreo;
using viñedos.Planes_de_financiamiento;
using viñedos.Procesos_especiales;
using WW.Cad.IO;

namespace viñedos
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            DeleteSubKeyTree();
        }
        private void btnAreaAdministrativa_Click(object sender, EventArgs e)
        {
            Auxiliares.Auxiliares.CerrarFormulariosAbiertos(Name);
            string filename = @"C:\Viñedos\Los Viñedos Lotificación.dwg";
            SendKeys.Send("{ESC}");
            var reader = new DwgReader(filename);
            var model = reader.Read();
            var a = new AreaAdministrativa(model);
            Hide();
            a.ShowDialog();
        }
        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Auxiliares.Auxiliares.CerrarFormulariosAbiertos(Name);
            var l = new LogIn();
            Hide();
            l.ShowDialog();
        }
        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dispose();
        }
        private void btnProcesosEspeciales_Click(object sender, EventArgs e)
        {
            var p = new ProcesosEspeciales();
            Hide();
            p.ShowDialog();
        }
        private void btnMonitoreo_Click(object sender, EventArgs e)
        {
            Auxiliares.Auxiliares.CerrarFormulariosAbiertos(Name);
            string filename = @"C:\Viñedos\Los Viñedos Lotificación.dwg";
            SendKeys.Send("{ESC}");
            var model = DwgReader.Read(filename);
            var a = new monitoreo(model);
            Hide();
            a.ShowDialog();
        }
        private void btnPlanesFinanciamiento_Click(object sender, EventArgs e)
        {
            Auxiliares.Auxiliares.CerrarFormulariosAbiertos(Name);
            var p=new Planesdefinanciamiento();
            Hide();
            p.ShowDialog();
        }
        private void DeleteSubKeyTree()
        {
            try
            {
                var baseRegistryKey = Registry.CurrentUser;

                var subKey= "SOFTWARE\\WW\\{F07847F9-0CED-4e2f-8771-9BEA3D1D10CC}";
                
                // Setting
                RegistryKey rk = baseRegistryKey;
                RegistryKey sk1 = rk.OpenSubKey(subKey);

                // Si el registro existe eliminalo
                if (sk1 != null)
                { rk.DeleteSubKeyTree(subKey);}
            }
            catch
            {
                // ignored
            }
        }
        private void Menu_Load(object sender, EventArgs e)
        {
            Auxiliares.Auxiliares.CerrarFormulariosAbiertos(Name);
        }
    }
}