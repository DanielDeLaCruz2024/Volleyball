using System;
using System.Windows.Forms;
using Volleyball;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        private string ganador;
        private int puntajeA, setsA, puntajeB, setsB;

        public Form2(string ganador, int puntajeA, int setsA, int puntajeB, int setsB)
        {
            InitializeComponent();
            this.ganador = ganador;
            this.puntajeA = puntajeA;
            this.setsA = setsA;
            this.puntajeB = puntajeB;
            this.setsB = setsB;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            lbGanador2.Text = ganador;
            lbPuntajeA.Text = puntajeA.ToString();
            lbPuntajeB.Text = puntajeB.ToString();
            lbSetsA.Text = setsA.ToString();
            lbSetsB.Text = setsB.ToString();
        }

        private void btSigJuego_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
