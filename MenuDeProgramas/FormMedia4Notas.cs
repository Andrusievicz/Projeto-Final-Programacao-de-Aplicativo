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
    public partial class FormMedia4Notas : Form
    {
        public FormMedia4Notas()
        {
            InitializeComponent();
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            double nota1, nota2, nota3, nota4;

            if (!double.TryParse(textBoxNota1.Text, out nota1) ||
                !double.TryParse(textBoxNota2.Text, out nota2) ||
                !double.TryParse(textBoxNota3.Text, out nota3) ||
                !double.TryParse(textBoxNota4.Text, out nota4))
            {
                MessageBox.Show("Por favor, insira notas válidas.");
                return;
            }

            double media = (nota1 + nota2 + nota3 + nota4) / 4;
            string resultado = media >= 7 ? "Aprovado" : "Reprovado";

            labelResultado.Text = $"Média: {media:F2} - {resultado}";
        }
    }
}