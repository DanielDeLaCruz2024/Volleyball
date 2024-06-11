using System;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace Volleyball
{
    public partial class PantallaDeInicio : Form
    {
        public Registrodeequipos registro;

        public PantallaDeInicio()
        {
            InitializeComponent();
        }

        private void btIniciarJuego_Click(object sender, EventArgs e)
        {
            if (registro != null && !string.IsNullOrWhiteSpace(registro.equipoUnoNombre) && !string.IsNullOrWhiteSpace(registro.equipoDosNombre))
            {
                FormPuntaje partido1 = new FormPuntaje(registro);
                partido1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Debes registrar los equipos antes de iniciar el juego.");
            }
        }

        private void btRegistrarEquipos_Click(object sender, EventArgs e)
        {
            registro = new Registrodeequipos(this);
            registro.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Aquí puede ir cualquier código relacionado con la acción de hacer clic en label1, si es necesario
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Aquí puede ir cualquier código relacionado con la acción de hacer clic en pictureBox1, si es necesario
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // Aquí puede ir cualquier código relacionado con la acción de hacer clic en pictureBox2, si es necesario
        }

        private void PantallaDeInicio_Load(object sender, EventArgs e)
        {
            // Aquí puede ir cualquier código relacionado con la carga inicial del formulario, si es necesario
        }
    }
}
