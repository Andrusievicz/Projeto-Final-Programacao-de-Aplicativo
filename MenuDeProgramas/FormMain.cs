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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        private void btnResistenciaSerieParalelo3_Click(object sender, EventArgs e)
        {
            FormResistenciaSerieParalelo3 form = new FormResistenciaSerieParalelo3();
            form.ShowDialog();
        }

        private void btnResistenciaSerieParaleloN_Click(object sender, EventArgs e)
        {
            FormResistenciaSerieParaleloN form = new FormResistenciaSerieParaleloN();
            form.ShowDialog();
        }

        private void btnMedia4Notas_Click(object sender, EventArgs e)
        {
            FormMedia4Notas form = new FormMedia4Notas();
            form.ShowDialog();
        }

        private void btnMediaNNotas_Click(object sender, EventArgs e)
        {
            FormMediaNNotas form = new FormMediaNNotas();
            form.ShowDialog();
        }

        private void btnConsumoCombustivel_Click(object sender, EventArgs e)
        {
            FormConsumoCombustivel form = new FormConsumoCombustivel();
            form.ShowDialog();
        }

        private void btnConversaoTemperaturas_Click(object sender, EventArgs e)
        {
            FormConversaoTemperaturas form = new FormConversaoTemperaturas();
            form.ShowDialog();
        }

        private void btnCalculoIMC_Click(object sender, EventArgs e)
        {
            FormCalculoIMC form = new FormCalculoIMC();
            form.ShowDialog();
        }

        private void btnCondicaoPagamento_Click(object sender, EventArgs e)
        {
            FormCondicaoPagamento form = new FormCondicaoPagamento();
            form.ShowDialog();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

