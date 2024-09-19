using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MenuDeProgramas
{
    public partial class FormResistenciaSerieParalelo3 : Form
    {
        public FormResistenciaSerieParalelo3()
        {
            InitializeComponent();
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            double r1, r2, r3;

            // Try to parse the resistances; if not possible, use the default value as 0.
            r1 = double.TryParse(textBoxR1.Text, out r1) ? r1 : 0;
            r2 = double.TryParse(textBoxR2.Text, out r2) ? r2 : 0;
            r3 = double.TryParse(textBoxR3.Text, out r3) ? r3 : 0;

            if (r1 == 0 || r2 == 0 || r3 == 0)
            {
                MessageBox.Show("Por favor, insira todos os valores de resistência.");
                return;
            }

            double resistenciaSerie = r1 + r2 + r3;
            double resistenciaParalelo = 1 / ((1 / r1) + (1 / r2) + (1 / r3));

            labelResultadoSerie.Text = $"Resistência Série: {resistenciaSerie:F2} Ω";
            labelResultadoParalelo.Text = $"Resistência Paralelo: {resistenciaParalelo:F2} Ω";
        }
    }
}
