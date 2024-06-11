using System;
using System.Windows.Forms;

namespace Volleyball
{
    public partial class RegistroExitoso : Form
    {
        private PantallaDeInicio inicio;
        private Registrodeequipos registrodeequipos;

        public RegistroExitoso(PantallaDeInicio inicio, Registrodeequipos registrodeequipos)
        {
            InitializeComponent();
            this.inicio = inicio;
            this.registrodeequipos = registrodeequipos;
        }

        private void RegistroExitoso_Load(object sender, EventArgs e)
        {
            // Este método se llama cuando el formulario se carga
            // Puedes agregar aquí cualquier inicialización adicional que necesites
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Aquí puede ir cualquier código relacionado con la acción de hacer clic en label1, si es necesario
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // Aquí puede ir cualquier código relacionado con la acción de hacer clic en label2, si es necesario
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Este método se llama cuando se hace clic en el botón "Aceptar"
            this.Hide();
            inicio.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Aquí puede ir cualquier código relacionado con el tick del timer, si es necesario
        }
    }
}
