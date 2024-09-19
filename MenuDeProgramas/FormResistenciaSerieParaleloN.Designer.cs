using System.Linq;
using System.Windows.Forms;
using System;

namespace MenuDeProgramas
{
    partial class FormResistenciaSerieParaleloN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormResistenciaSerieParaleloN));
            this.labelResistencias = new System.Windows.Forms.Label();
            this.textBoxResistencias = new System.Windows.Forms.TextBox();
            this.buttonCalcular = new System.Windows.Forms.Button();
            this.labelResultadoSerie = new System.Windows.Forms.Label();
            this.labelResultadoParalelo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelResistencias
            // 
            this.labelResistencias.AutoSize = true;
            this.labelResistencias.Location = new System.Drawing.Point(14, 16);
            this.labelResistencias.Name = "labelResistencias";
            this.labelResistencias.Size = new System.Drawing.Size(239, 16);
            this.labelResistencias.TabIndex = 0;
            this.labelResistencias.Text = "Insira as resistências separadas por \',\':";
            // 
            // textBoxResistencias
            // 
            this.textBoxResistencias.Location = new System.Drawing.Point(14, 35);
            this.textBoxResistencias.Name = "textBoxResistencias";
            this.textBoxResistencias.Size = new System.Drawing.Size(297, 22);
            this.textBoxResistencias.TabIndex = 1;
            // 
            // buttonCalcular
            // 
            this.buttonCalcular.Location = new System.Drawing.Point(14, 66);
            this.buttonCalcular.Name = "buttonCalcular";
            this.buttonCalcular.Size = new System.Drawing.Size(86, 25);
            this.buttonCalcular.TabIndex = 2;
            this.buttonCalcular.Text = "Calcular";
            this.buttonCalcular.UseVisualStyleBackColor = true;
            this.buttonCalcular.Click += new System.EventHandler(this.buttonCalcular_Click);
            // 
            // labelResultadoSerie
            // 
            this.labelResultadoSerie.AutoSize = true;
            this.labelResultadoSerie.Location = new System.Drawing.Point(14, 105);
            this.labelResultadoSerie.Name = "labelResultadoSerie";
            this.labelResultadoSerie.Size = new System.Drawing.Size(116, 16);
            this.labelResultadoSerie.TabIndex = 3;
            this.labelResultadoSerie.Text = "Resistência Série:";
            // 
            // labelResultadoParalelo
            // 
            this.labelResultadoParalelo.AutoSize = true;
            this.labelResultadoParalelo.Location = new System.Drawing.Point(14, 131);
            this.labelResultadoParalelo.Name = "labelResultadoParalelo";
            this.labelResultadoParalelo.Size = new System.Drawing.Size(135, 16);
            this.labelResultadoParalelo.TabIndex = 4;
            this.labelResultadoParalelo.Text = "Resistência Paralelo:";
            // 
            // FormResistenciaSerieParaleloN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MenuDeProgramas.Properties.Resources.Superbolt_Lightning_Art_Concept1;
            this.ClientSize = new System.Drawing.Size(782, 428);
            this.Controls.Add(this.labelResultadoParalelo);
            this.Controls.Add(this.labelResultadoSerie);
            this.Controls.Add(this.buttonCalcular);
            this.Controls.Add(this.textBoxResistencias);
            this.Controls.Add(this.labelResistencias);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(645, 190);
            this.Name = "FormResistenciaSerieParaleloN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Resistência para N Resistências";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label labelResistencias;
        private System.Windows.Forms.TextBox textBoxResistencias;
        private System.Windows.Forms.Button buttonCalcular;
        private System.Windows.Forms.Label labelResultadoSerie;
        private System.Windows.Forms.Label labelResultadoParalelo;
    }
}
