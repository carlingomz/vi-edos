using System;
using System.Windows.Forms;

namespace viñedos
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Auxiliares.Auxiliares.CerrarFormulariosAbiertos(Name);
            Menu m = new Menu();
            Hide();
            m.ShowDialog();
        }
    }
}