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
    public partial class FormMediaNNotas : Form
    {
        private List<TextBox> notaTextBoxes = new List<TextBox>();

        public FormMediaNNotas()
        {
            InitializeComponent();
        }

        private void buttonGerarCampos_Click(object sender, EventArgs e)
        {
            panelNotas.Controls.Clear();
            notaTextBoxes.Clear();

            if (!int.TryParse(textBoxNumNotas.Text, out int numNotas) || numNotas <= 0)
            {
                MessageBox.Show("Por favor, insira um número válido de notas.");
                return;
            }

            for (int i = 0; i < numNotas; i++)
            {
                Label labelNota = new Label
                {
                    Text = $"Nota {i + 1}:",
                    Location = new System.Drawing.Point(3, i * 30),
                    AutoSize = true
                };
                TextBox textBoxNota = new TextBox
                {
                    Location = new System.Drawing.Point(60, i * 30),
                    Size = new System.Drawing.Size(100, 23)
                };
                panelNotas.Controls.Add(labelNota);
                panelNotas.Controls.Add(textBoxNota);
                notaTextBoxes.Add(textBoxNota);
            }
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            List<double> notas = new List<double>();

            foreach (TextBox textBox in notaTextBoxes)
            {
                if (double.TryParse(textBox.Text, out double nota))
                {
                    notas.Add(nota);
                }
                else
                {
                    MessageBox.Show("Por favor, insira notas válidas.");
                    return;
                }
            }

            double media = notas.Average();
            string resultado = media >= 7 ? "Aprovado" : "Reprovado";

            labelResultado.Text = $"Média: {media:F2} - {resultado}";
        }
    }
}