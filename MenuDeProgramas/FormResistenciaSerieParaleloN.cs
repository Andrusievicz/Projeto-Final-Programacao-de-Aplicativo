using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuDeProgramas
{
    public partial class FormResistenciaSerieParaleloN : Form
    {
        public FormResistenciaSerieParaleloN()
        {
            InitializeComponent();
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            string[] resistenciasInput = textBoxResistencias.Text.Split(',');

            if (resistenciasInput.Length == 0)
            {
                MessageBox.Show("Por favor, insira pelo menos uma resistência.");
                return;
            }

            double[] resistencias = new double[resistenciasInput.Length];
            for (int i = 0; i < resistenciasInput.Length; i++)
            {
                if (!double.TryParse(resistenciasInput[i], out resistencias[i]))
                {
                    MessageBox.Show("Por favor, insira valores válidos de resistência.");
                    return;
                }
            }

            double resistenciaSerie = resistencias.Sum();
            double resistenciaParalelo = 1 / resistencias.Select(r => 1 / r).Sum();

            labelResultadoSerie.Text = $"Resistência Série: {resistenciaSerie:F2} Ω";
            labelResultadoParalelo.Text = $"Resistência Paralelo: {resistenciaParalelo:F2} Ω";
        }
    }
}