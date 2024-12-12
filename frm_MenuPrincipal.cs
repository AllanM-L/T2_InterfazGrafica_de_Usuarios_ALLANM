using System;
using System.Windows.Forms;
namespace T2_InterfazGrafica_de_Usuarios_ALLANM
{
    public partial class frm_MenuPrincipal : Form
    {
        public frm_MenuPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Usuarios_Click(object sender, EventArgs e)
        {
            Form Interfazuser = new frm_InterfazUser();
            Interfazuser.Show();
        }
    }
}
