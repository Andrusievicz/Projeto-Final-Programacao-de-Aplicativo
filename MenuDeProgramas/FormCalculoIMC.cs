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
    public partial class FormCalculoIMC : Form
    {
        public FormCalculoIMC()
        {
            InitializeComponent();
        }

        private void buttonCalcularIMC_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBoxPeso.Text, out double peso) && double.TryParse(textBoxAltura.Text, out double altura))
            {
                double imc = peso / (altura * altura);
                string condicao;

                if (imc < 18.5)
                {
                    condicao = "Abaixo do peso";
                }
                else if (imc < 24.9)
                {
                    condicao = "Peso ideal (parabéns)";
                }
                else if (imc < 29.9)
                {
                    condicao = "Levemente acima do peso";
                }
                else if (imc < 34.9)
                {
                    condicao = "Obesidade grau I";
                }
                else if (imc < 39.9)
                {
                    condicao = "Obesidade grau II (severa)";
                }
                else
                {
                    condicao = "Obesidade grau III (mórbida)";
                }

                labelResultadoIMC.Text = $"Resultado: IMC = {imc:F2} - {condicao}";
            }
            else
            {
                MessageBox.Show("Por favor, insira valores válidos para peso e altura.");
            }
        }
    }
}