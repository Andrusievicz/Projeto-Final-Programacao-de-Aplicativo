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
    public partial class FormCondicaoPagamento : Form
    {
        public FormCondicaoPagamento()
        {
            InitializeComponent();
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(textBoxValorProduto.Text, out decimal valorProduto))
            {
                decimal valorFinal = 0;
                switch (comboBoxFormaPagamento.SelectedIndex)
                {
                    case 0:
                        valorFinal = valorProduto * 0.85m;
                        break;
                    case 1:
                        valorFinal = valorProduto * 0.90m;
                        break;
                    case 2:
                        valorFinal = valorProduto;
                        break;
                    case 3:
                        valorFinal = valorProduto * 1.10m;
                        break;
                    default:
                        MessageBox.Show("Selecione uma forma de pagamento válida.");
                        return;
                }
                labelResultado.Text = $"Resultado: R$ {valorFinal:F2}";
            }
            else
            {
                MessageBox.Show("Digite um valor de produto válido.");
            }
        }
    }
}