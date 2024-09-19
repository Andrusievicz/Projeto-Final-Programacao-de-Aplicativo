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
    public partial class FormConversaoTemperaturas : Form
    {
        public FormConversaoTemperaturas()
        {
            InitializeComponent();
        }

        private void buttonConverter_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBoxTemperatura.Text, out double temperatura))
            {
                string resultado = string.Empty;

                switch (comboBoxConversao.SelectedItem.ToString())
                {
                    case "Celsius para Fahrenheit":
                        resultado = $"{temperatura}°C = {CelsiusParaFahrenheit(temperatura)}°F";
                        break;
                    case "Fahrenheit para Celsius":
                        resultado = $"{temperatura}°F = {FahrenheitParaCelsius(temperatura)}°C";
                        break;
                    case "Celsius para Kelvin":
                        resultado = $"{temperatura}°C = {CelsiusParaKelvin(temperatura)}K";
                        break;
                    case "Kelvin para Celsius":
                        resultado = $"{temperatura}K = {KelvinParaCelsius(temperatura)}°C";
                        break;
                    default:
                        MessageBox.Show("Por favor, selecione uma conversão válida.");
                        return;
                }

                labelResultado.Text = $"Resultado: {resultado}";
            }
            else
            {
                MessageBox.Show("Por favor, insira uma temperatura válida.");
            }
        }

        private double CelsiusParaFahrenheit(double celsius)
        {
            return celsius * 1.8 + 32;
        }

        private double FahrenheitParaCelsius(double fahrenheit)
        {
            return (fahrenheit - 32) / 1.8;
        }

        private double CelsiusParaKelvin(double celsius)
        {
            return celsius + 273.15;
        }

        private double KelvinParaCelsius(double kelvin)
        {
            return kelvin - 273.15;
        }
    }
}