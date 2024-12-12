using System;
using System.Windows.Forms;

namespace T2_InterfazGrafica_de_Usuarios_ALLANM
{
    public partial class frm_InterfazUser : Form
    {
        public frm_InterfazUser()
        {
            InitializeComponent();
        }

        private void frm_InterfazUser_Load(object sender, EventArgs e)
        {
            // Inicialización de eventos o acciones al cargar el formulario
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Verificamos que los campos no estén vacíos
            if (text_Nombre.Text != "" && text_Apellido.Text != "" && text_Cedula.Text != "" && text_Celular.Text != "")
            {
                // Aquí podrías guardar los datos del usuario en una base de datos o en una lista
                MessageBox.Show("Datos guardados correctamente.");
                this.Close(); // Cierra el formulario
            }
            else
            {
                MessageBox.Show("Por favor, complete todos los campos.");
            }
        }
    }
}


