namespace MenuDeProgramas
{
    partial class FormResistenciaSerieParalelo3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormResistenciaSerieParalelo3));
            this.labelR1 = new System.Windows.Forms.Label();
            this.labelR2 = new System.Windows.Forms.Label();
            this.labelR3 = new System.Windows.Forms.Label();
            this.textBoxR1 = new System.Windows.Forms.TextBox();
            this.textBoxR2 = new System.Windows.Forms.TextBox();
            this.textBoxR3 = new System.Windows.Forms.TextBox();
            this.labelResultadoSerie = new System.Windows.Forms.Label();
            this.labelResultadoParalelo = new System.Windows.Forms.Label();
            this.buttonCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelR1
            // 
            this.labelR1.AutoSize = true;
            this.labelR1.Location = new System.Drawing.Point(14, 16);
            this.labelR1.Name = "labelR1";
            this.labelR1.Size = new System.Drawing.Size(27, 16);
            this.labelR1.TabIndex = 0;
            this.labelR1.Text = "R1:";
            // 
            // labelR2
            // 
            this.labelR2.AutoSize = true;
            this.labelR2.Location = new System.Drawing.Point(14, 47);
            this.labelR2.Name = "labelR2";
            this.labelR2.Size = new System.Drawing.Size(27, 16);
            this.labelR2.TabIndex = 1;
            this.labelR2.Text = "R2:";
            // 
            // labelR3
            // 
            this.labelR3.AutoSize = true;
            this.labelR3.Location = new System.Drawing.Point(14, 78);
            this.labelR3.Name = "labelR3";
            this.labelR3.Size = new System.Drawing.Size(27, 16);
            this.labelR3.TabIndex = 2;
            this.labelR3.Text = "R3:";
            // 
            // textBoxR1
            // 
            this.textBoxR1.Location = new System.Drawing.Point(48, 13);
            this.textBoxR1.Name = "textBoxR1";
            this.textBoxR1.Size = new System.Drawing.Size(114, 22);
            this.textBoxR1.TabIndex = 3;
            // 
            // textBoxR2
            // 
            this.textBoxR2.Location = new System.Drawing.Point(48, 44);
            this.textBoxR2.Name = "textBoxR2";
            this.textBoxR2.Size = new System.Drawing.Size(114, 22);
            this.textBoxR2.TabIndex = 4;
            // 
            // textBoxR3
            // 
            this.textBoxR3.Location = new System.Drawing.Point(48, 75);
            this.textBoxR3.Name = "textBoxR3";
            this.textBoxR3.Size = new System.Drawing.Size(114, 22);
            this.textBoxR3.TabIndex = 5;
            // 
            // labelResultadoSerie
            // 
            this.labelResultadoSerie.AutoSize = true;
            this.labelResultadoSerie.Location = new System.Drawing.Point(14, 114);
            this.labelResultadoSerie.Name = "labelResultadoSerie";
            this.labelResultadoSerie.Size = new System.Drawing.Size(116, 16);
            this.labelResultadoSerie.TabIndex = 6;
            this.labelResultadoSerie.Text = "Resistência Série:";
            // 
            // labelResultadoParalelo
            // 
            this.labelResultadoParalelo.AutoSize = true;
            this.labelResultadoParalelo.Location = new System.Drawing.Point(14, 141);
            this.labelResultadoParalelo.Name = "labelResultadoParalelo";
            this.labelResultadoParalelo.Size = new System.Drawing.Size(135, 16);
            this.labelResultadoParalelo.TabIndex = 7;
            this.labelResultadoParalelo.Text = "Resistência Paralelo:";
            // 
            // buttonCalcular
            // 
            this.buttonCalcular.Location = new System.Drawing.Point(14, 171);
            this.buttonCalcular.Name = "buttonCalcular";
            this.buttonCalcular.Size = new System.Drawing.Size(86, 25);
            this.buttonCalcular.TabIndex = 8;
            this.buttonCalcular.Text = "Calcular";
            this.buttonCalcular.UseVisualStyleBackColor = true;
            this.buttonCalcular.Click += new System.EventHandler(this.buttonCalcular_Click);
            // 
            // FormResistenciaSerieParalelo3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MenuDeProgramas.Properties.Resources.Superbolt_Lightning_Art_Concept1;
            this.ClientSize = new System.Drawing.Size(782, 428);
            this.Controls.Add(this.buttonCalcular);
            this.Controls.Add(this.labelResultadoParalelo);
            this.Controls.Add(this.labelResultadoSerie);
            this.Controls.Add(this.textBoxR3);
            this.Controls.Add(this.textBoxR2);
            this.Controls.Add(this.textBoxR1);
            this.Controls.Add(this.labelR3);
            this.Controls.Add(this.labelR2);
            this.Controls.Add(this.labelR1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(645, 190);
            this.Name = "FormResistenciaSerieParalelo3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Resistência para 3 Resistências";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label labelR1;
        private System.Windows.Forms.Label labelR2;
        private System.Windows.Forms.Label labelR3;
        private System.Windows.Forms.TextBox textBoxR1;
        private System.Windows.Forms.TextBox textBoxR2;
        private System.Windows.Forms.TextBox textBoxR3;
        private System.Windows.Forms.Label labelResultadoSerie;
        private System.Windows.Forms.Label labelResultadoParalelo;
        private System.Windows.Forms.Button buttonCalcular;
    }
}
