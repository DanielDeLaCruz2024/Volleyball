using System;
using System.Windows.Forms;

namespace Volleyball
{
    public partial class Registrodeequipos : Form
    {
        private PantallaDeInicio inicio;

        // Declarar variables para almacenar la información de los equipos y jugadores
        public string equipoUnoNombre;
        public string equipoDosNombre;
        public string[] jugadoresEquipoUno = new string[6]; // Ajusta el tamaño según el número de jugadores por equipo
        public string[] jugadoresEquipoDos = new string[6];

        // Constructor que recibe el formulario de inicio como parámetro
        public Registrodeequipos(PantallaDeInicio inicio)
        {
            InitializeComponent();
            this.inicio = inicio;
        }

        private void BtnRegistrarEquipos_Click(object sender, EventArgs e)
        {
            // Obtener el nombre de los equipos
            equipoUnoNombre = TBEquipo1.Text;
            equipoDosNombre = TBEquipo2.Text;

            // Obtener la información de los jugadores del equipo uno
            jugadoresEquipoUno[0] = TBNombreIntegrante1.Text + " - " + TBPosicionIntegrante1.Text + " - " + TBNumeroIntegrante1.Text;
            jugadoresEquipoUno[1] = TBNombreIntegrante2.Text + " - " + TBPosicionIntegrante2.Text + " - " + TBNumeroIntegrante2.Text;
            jugadoresEquipoUno[2] = TBNombreIntegrante3.Text + " - " + TBPosicionIntegrante3.Text + " - " + TBNumeroIntegrante3.Text;
            jugadoresEquipoUno[3] = TBNombreIntegrante4.Text + " - " + TBPosicionIntegrante4.Text + " - " + TBNumeroIntegrante4.Text;
            jugadoresEquipoUno[4] = TBNombreIntegrante5.Text + " - " + TBPosicionIntegrante5.Text + " - " + TBNumeroIntegrante5.Text;
            jugadoresEquipoUno[5] = TBNombreIntegrante6.Text + " - " + TBPosicionIntegrante6.Text + " - " + TBNumeroIntegrante6.Text;

            // Obtener la información de los jugadores del equipo dos
            jugadoresEquipoDos[0] = TBNombreIntegrante7.Text + " - " + TBPosicionIntegrante7.Text + " - " + TBNumeroIntegrante7.Text;
            jugadoresEquipoDos[1] = TBNombreIntegrante8.Text + " - " + TBPosicionIntegrante8.Text + " - " + TBNumeroIntegrante8.Text;
            jugadoresEquipoDos[2] = TBNombreIntegrante9.Text + " - " + TBPosicionIntegrante9.Text + " - " + TBNumeroIntegrante9.Text;
            jugadoresEquipoDos[3] = TBNombreIntegrante10.Text + " - " + TBPosicionIntegrante10.Text + " - " + TBNumeroIntegrante10.Text;
            jugadoresEquipoDos[4] = TBNombreIntegrante11.Text + " - " + TBPosicionIntegrante11.Text + " - " + TBNumeroIntegrante11.Text;
            jugadoresEquipoDos[5] = TBNombreIntegrante12.Text + " - " + TBPosicionIntegrante12.Text + " - " + TBNumeroIntegrante12.Text;

            // Mostrar la ventana RegistroExitoso
            RegistroExitoso ventanaRegistroExitoso = new RegistroExitoso(inicio, this);
            ventanaRegistroExitoso.ShowDialog();
            this.Hide();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            // Aquí puede ir cualquier código relacionado con la acción de cambiar el texto en textBox8, si es necesario
        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {
            // Aquí puede ir cualquier código relacionado con la acción de cambiar el texto en textBox20, si es necesario
        }

        private void textBox26_TextChanged(object sender, EventArgs e)
        {
            // Aquí puede ir cualquier código relacionado con la acción de cambiar el texto en textBox26, si es necesario
        }

        private void label41_Click(object sender, EventArgs e)
        {
            // Aquí puede ir cualquier código relacionado con la acción de hacer clic en label41, si es necesario
        }

        private void TBEquipo1_TextChanged(object sender, EventArgs e)
        {
            // Aquí puede ir cualquier código relacionado con la acción de cambiar el texto en TBEquipo1, si es necesario
        }

        private void NombreEquipo2_Click(object sender, EventArgs e)
        {
            // Aquí puede ir cualquier código relacionado con la acción de hacer clic en NombreEquipo2, si es necesario
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Aquí puede ir cualquier código relacionado con la acción de hacer clic en button1, si es necesario
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Aquí puede ir cualquier código relacionado con la carga inicial del formulario, si es necesario
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Aquí puede ir cualquier código relacionado con la acción de hacer clic en label1, si es necesario
        }

        private void label3_Click(object sender, EventArgs e)
        {
            // Aquí puede ir cualquier código relacionado con la acción de hacer clic en label3, si es necesario
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // Aquí puede ir cualquier código relacionado con la acción de hacer clic en button1_1, si es necesario
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Aquí puede ir cualquier código relacionado con la acción de cambiar el texto en textBox1, si es necesario
        }
    }
}
