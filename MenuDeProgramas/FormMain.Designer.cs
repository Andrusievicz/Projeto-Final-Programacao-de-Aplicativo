using System;
using System.Windows.Forms;

namespace MenuDeProgramas
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.btnResistenciaSerieParalelo3 = new System.Windows.Forms.Button();
            this.btnResistenciaSerieParaleloN = new System.Windows.Forms.Button();
            this.btnMedia4Notas = new System.Windows.Forms.Button();
            this.btnMediaNNotas = new System.Windows.Forms.Button();
            this.btnConsumoCombustivel = new System.Windows.Forms.Button();
            this.btnConversaoTemperaturas = new System.Windows.Forms.Button();
            this.btnCalculoIMC = new System.Windows.Forms.Button();
            this.btnCondicaoPagamento = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnResistenciaSerieParalelo3
            // 
            this.btnResistenciaSerieParalelo3.BackColor = System.Drawing.Color.Cyan;
            this.btnResistenciaSerieParalelo3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResistenciaSerieParalelo3.Location = new System.Drawing.Point(754, 222);
            this.btnResistenciaSerieParalelo3.Name = "btnResistenciaSerieParalelo3";
            this.btnResistenciaSerieParalelo3.Size = new System.Drawing.Size(293, 28);
            this.btnResistenciaSerieParalelo3.TabIndex = 0;
            this.btnResistenciaSerieParalelo3.Text = "Resistência (Série/Paralelo) - 3 Resistências";
            this.btnResistenciaSerieParalelo3.UseVisualStyleBackColor = false;
            this.btnResistenciaSerieParalelo3.Click += new System.EventHandler(this.btnResistenciaSerieParalelo3_Click);
            // 
            // btnResistenciaSerieParaleloN
            // 
            this.btnResistenciaSerieParaleloN.BackColor = System.Drawing.Color.Cyan;
            this.btnResistenciaSerieParaleloN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResistenciaSerieParaleloN.Location = new System.Drawing.Point(754, 251);
            this.btnResistenciaSerieParaleloN.Name = "btnResistenciaSerieParaleloN";
            this.btnResistenciaSerieParaleloN.Size = new System.Drawing.Size(293, 28);
            this.btnResistenciaSerieParaleloN.TabIndex = 1;
            this.btnResistenciaSerieParaleloN.Text = "Resistência (Série/Paralelo) - N Resistências";
            this.btnResistenciaSerieParaleloN.UseVisualStyleBackColor = false;
            this.btnResistenciaSerieParaleloN.Click += new System.EventHandler(this.btnResistenciaSerieParaleloN_Click);
            // 
            // btnMedia4Notas
            // 
            this.btnMedia4Notas.BackColor = System.Drawing.Color.Cyan;
            this.btnMedia4Notas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMedia4Notas.Location = new System.Drawing.Point(754, 280);
            this.btnMedia4Notas.Name = "btnMedia4Notas";
            this.btnMedia4Notas.Size = new System.Drawing.Size(293, 28);
            this.btnMedia4Notas.TabIndex = 2;
            this.btnMedia4Notas.Text = "Média Aritmética - 4 Notas";
            this.btnMedia4Notas.UseVisualStyleBackColor = false;
            this.btnMedia4Notas.Click += new System.EventHandler(this.btnMedia4Notas_Click);
            // 
            // btnMediaNNotas
            // 
            this.btnMediaNNotas.BackColor = System.Drawing.Color.Cyan;
            this.btnMediaNNotas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMediaNNotas.Location = new System.Drawing.Point(754, 309);
            this.btnMediaNNotas.Name = "btnMediaNNotas";
            this.btnMediaNNotas.Size = new System.Drawing.Size(293, 28);
            this.btnMediaNNotas.TabIndex = 3;
            this.btnMediaNNotas.Text = "Média Aritmética - N Notas";
            this.btnMediaNNotas.UseVisualStyleBackColor = false;
            this.btnMediaNNotas.Click += new System.EventHandler(this.btnMediaNNotas_Click);
            // 
            // btnConsumoCombustivel
            // 
            this.btnConsumoCombustivel.BackColor = System.Drawing.Color.Cyan;
            this.btnConsumoCombustivel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnConsumoCombustivel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsumoCombustivel.Location = new System.Drawing.Point(754, 338);
            this.btnConsumoCombustivel.Name = "btnConsumoCombustivel";
            this.btnConsumoCombustivel.Size = new System.Drawing.Size(293, 28);
            this.btnConsumoCombustivel.TabIndex = 4;
            this.btnConsumoCombustivel.Text = "Consumo de Combustível";
            this.btnConsumoCombustivel.UseVisualStyleBackColor = false;
            this.btnConsumoCombustivel.Click += new System.EventHandler(this.btnConsumoCombustivel_Click);
            // 
            // btnConversaoTemperaturas
            // 
            this.btnConversaoTemperaturas.BackColor = System.Drawing.Color.Cyan;
            this.btnConversaoTemperaturas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConversaoTemperaturas.Location = new System.Drawing.Point(754, 401);
            this.btnConversaoTemperaturas.Name = "btnConversaoTemperaturas";
            this.btnConversaoTemperaturas.Size = new System.Drawing.Size(293, 28);
            this.btnConversaoTemperaturas.TabIndex = 5;
            this.btnConversaoTemperaturas.Text = "Conversão de Temperaturas";
            this.btnConversaoTemperaturas.UseVisualStyleBackColor = false;
            this.btnConversaoTemperaturas.Click += new System.EventHandler(this.btnConversaoTemperaturas_Click);
            // 
            // btnCalculoIMC
            // 
            this.btnCalculoIMC.BackColor = System.Drawing.Color.Cyan;
            this.btnCalculoIMC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculoIMC.Location = new System.Drawing.Point(754, 430);
            this.btnCalculoIMC.Name = "btnCalculoIMC";
            this.btnCalculoIMC.Size = new System.Drawing.Size(293, 28);
            this.btnCalculoIMC.TabIndex = 6;
            this.btnCalculoIMC.Text = "Cálculo do IMC";
            this.btnCalculoIMC.UseVisualStyleBackColor = false;
            this.btnCalculoIMC.Click += new System.EventHandler(this.btnCalculoIMC_Click);
            // 
            // btnCondicaoPagamento
            // 
            this.btnCondicaoPagamento.BackColor = System.Drawing.Color.Cyan;
            this.btnCondicaoPagamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCondicaoPagamento.Location = new System.Drawing.Point(754, 459);
            this.btnCondicaoPagamento.Name = "btnCondicaoPagamento";
            this.btnCondicaoPagamento.Size = new System.Drawing.Size(293, 28);
            this.btnCondicaoPagamento.TabIndex = 7;
            this.btnCondicaoPagamento.Text = "Condição de Pagamento";
            this.btnCondicaoPagamento.UseVisualStyleBackColor = false;
            this.btnCondicaoPagamento.Click += new System.EventHandler(this.btnCondicaoPagamento_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Cyan;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(754, 488);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(293, 28);
            this.button1.TabIndex = 8;
            this.button1.Text = "Fechar Programa";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormMain
            // 
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::MenuDeProgramas.Properties.Resources.resize_720p2_0;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1082, 722);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCondicaoPagamento);
            this.Controls.Add(this.btnCalculoIMC);
            this.Controls.Add(this.btnConversaoTemperaturas);
            this.Controls.Add(this.btnConsumoCombustivel);
            this.Controls.Add(this.btnMediaNNotas);
            this.Controls.Add(this.btnMedia4Notas);
            this.Controls.Add(this.btnResistenciaSerieParaleloN);
            this.Controls.Add(this.btnResistenciaSerieParalelo3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button btnResistenciaSerieParalelo3;
        private System.Windows.Forms.Button btnResistenciaSerieParaleloN;
        private System.Windows.Forms.Button btnMedia4Notas;
        private System.Windows.Forms.Button btnMediaNNotas;
        private System.Windows.Forms.Button btnConsumoCombustivel;
        private System.Windows.Forms.Button btnConversaoTemperaturas;
        private System.Windows.Forms.Button btnCalculoIMC;
        private System.Windows.Forms.Button btnCondicaoPagamento;
        private Button button1;
    }
}
