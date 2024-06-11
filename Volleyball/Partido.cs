using System;
using System.Windows.Forms;
using Volleyball;

namespace WindowsFormsApp1
{
    public partial class FormPuntaje : Form
    {
        public Registrodeequipos registro;
        private int puntajeA = 0, puntajeB = 0, puntosGanar = 25, setsGanar = 2, setsA = 0, setsB = 0;
        private string equipoA, equipoB;

        public FormPuntaje(Registrodeequipos registro)
        {
            InitializeComponent();
            this.registro = registro;
            this.equipoA = registro.equipoUnoNombre;
            this.equipoB = registro.equipoDosNombre;
        }

        private void FormPuntaje_Load(object sender, EventArgs e)
        {
            lbEquipoA.Text = equipoA;
            lbEquipoB.Text = equipoB;
            lbSetsA2.Text = setsA.ToString();
            lbSetsB2.Text = setsB.ToString();
            lbPuntajeA.Text = puntajeA.ToString();
            lbPuntajeB.Text = puntajeB.ToString();
            lbPuntosGanar2.Text = puntosGanar.ToString();
        }

        private void MenosPuntoA_Click(object sender, EventArgs e)
        {
            if (puntajeA > 0)
            {
                puntajeA--;
                lbPuntajeA.Text = puntajeA.ToString();
            }
        }

        private void btMasPuntoA_Click(object sender, EventArgs e)
        {
            puntajeA++;
            lbPuntajeA.Text = puntajeA.ToString();
            VerificarPuntos();
        }

        private void btMasPuntoB_Click(object sender, EventArgs e)
        {
            puntajeB++;
            lbPuntajeB.Text = puntajeB.ToString();
            VerificarPuntos();
        }

        private void menosPuntoB_Click(object sender, EventArgs e)
        {
            if (puntajeB > 0)
            {
                puntajeB--;
                lbPuntajeB.Text = puntajeB.ToString();
            }
        }

        private void VerificarPuntos()
        {
            if (puntajeA >= 24 && puntajeB >= 24 && puntajeA == puntajeB)
            {
                puntosGanar++;
                lbPuntosGanar2.Text = puntosGanar.ToString();
            }

            if (puntajeA >= puntosGanar)
            {
                setsA++;
                if (setsA == setsGanar)
                {
                    Form2 ganador = new Form2(equipoA, puntajeA, setsA, puntajeB, setsB);
                    ganador.Show();
                    this.Close();
                }
                else
                {
                    ReiniciarPuntaje();
                }
            }
            else if (puntajeB >= puntosGanar)
            {
                setsB++;
                if (setsB == setsGanar)
                {
                    Form2 ganador = new Form2(equipoB, puntajeA, setsA, puntajeB, setsB);
                    ganador.Show();
                    this.Close();
                }
                else
                {
                    ReiniciarPuntaje();
                }
            }

            lbSetsA2.Text = setsA.ToString();
            lbSetsB2.Text = setsB.ToString();
        }

        private void ReiniciarPuntaje()
        {
            puntajeA = 0;
            puntajeB = 0;
            lbPuntajeA.Text = puntajeA.ToString();
            lbPuntajeB.Text = puntajeB.ToString();
        }
    }
}
