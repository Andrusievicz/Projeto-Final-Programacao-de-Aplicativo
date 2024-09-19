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
    public partial class FormConsumoCombustivel : Form
    {
        public FormConsumoCombustivel()
        {
            InitializeComponent();
        }

        private void buttonCalcularConsumo_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBoxDistancia.Text, out double distancia) &&
                double.TryParse(textBoxConsumo.Text, out double consumo) &&
                double.TryParse(textBoxPrecoCombustivel.Text, out double precoCombustivel) &&
                double.TryParse(textBoxTamanhoTanque.Text, out double tamanhoTanque))
            {
                double valorTotalGasto = (distancia / consumo) * precoCombustivel;
                double consumoPorLitro = valorTotalGasto / precoCombustivel;
                double quantidadeTanquesUtilizados = valorTotalGasto / (tamanhoTanque * precoCombustivel);

                string tipoCombustivel = comboBoxCombustivel.SelectedItem.ToString();

                labelResultadoConsumo.Text = $"Resultado para {tipoCombustivel}:\n" +
                                             $"Valor Total Gasto: R$ {valorTotalGasto:F2}\n" +
                                             $"Consumo por Litro: R$ {consumoPorLitro:F2}/L\n" +
                                             $"Quantidade de Tanques Utilizados: {quantidadeTanquesUtilizados:F2}";
            }
            else
            {
                MessageBox.Show("Por favor, insira valores válidos.");
            }
        }
    }
}