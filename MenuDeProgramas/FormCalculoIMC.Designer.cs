namespace MenuDeProgramas
{
    partial class FormCalculoIMC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCalculoIMC));
            this.labelPeso = new System.Windows.Forms.Label();
            this.textBoxPeso = new System.Windows.Forms.TextBox();
            this.labelAltura = new System.Windows.Forms.Label();
            this.textBoxAltura = new System.Windows.Forms.TextBox();
            this.buttonCalcularIMC = new System.Windows.Forms.Button();
            this.labelResultadoIMC = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelPeso
            // 
            this.labelPeso.AutoSize = true;
            this.labelPeso.Location = new System.Drawing.Point(14, 16);
            this.labelPeso.Name = "labelPeso";
            this.labelPeso.Size = new System.Drawing.Size(42, 16);
            this.labelPeso.TabIndex = 0;
            this.labelPeso.Text = "Peso:";
            // 
            // textBoxPeso
            // 
            this.textBoxPeso.Location = new System.Drawing.Point(58, 13);
            this.textBoxPeso.Name = "textBoxPeso";
            this.textBoxPeso.Size = new System.Drawing.Size(114, 22);
            this.textBoxPeso.TabIndex = 1;
            // 
            // labelAltura
            // 
            this.labelAltura.AutoSize = true;
            this.labelAltura.Location = new System.Drawing.Point(14, 47);
            this.labelAltura.Name = "labelAltura";
            this.labelAltura.Size = new System.Drawing.Size(44, 16);
            this.labelAltura.TabIndex = 2;
            this.labelAltura.Text = "Altura:";
            // 
            // textBoxAltura
            // 
            this.textBoxAltura.Location = new System.Drawing.Point(58, 44);
            this.textBoxAltura.Name = "textBoxAltura";
            this.textBoxAltura.Size = new System.Drawing.Size(114, 22);
            this.textBoxAltura.TabIndex = 3;
            // 
            // buttonCalcularIMC
            // 
            this.buttonCalcularIMC.Location = new System.Drawing.Point(14, 75);
            this.buttonCalcularIMC.Name = "buttonCalcularIMC";
            this.buttonCalcularIMC.Size = new System.Drawing.Size(159, 25);
            this.buttonCalcularIMC.TabIndex = 4;
            this.buttonCalcularIMC.Text = "Calcular IMC";
            this.buttonCalcularIMC.UseVisualStyleBackColor = true;
            this.buttonCalcularIMC.Click += new System.EventHandler(this.buttonCalcularIMC_Click);
            // 
            // labelResultadoIMC
            // 
            this.labelResultadoIMC.AutoSize = true;
            this.labelResultadoIMC.Location = new System.Drawing.Point(14, 102);
            this.labelResultadoIMC.Name = "labelResultadoIMC";
            this.labelResultadoIMC.Size = new System.Drawing.Size(72, 16);
            this.labelResultadoIMC.TabIndex = 5;
            this.labelResultadoIMC.Text = "Resultado:";
            // 
            // FormCalculoIMC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MenuDeProgramas.Properties.Resources.Superbolt_Lightning_Art_Concept1;
            this.ClientSize = new System.Drawing.Size(782, 428);
            this.Controls.Add(this.labelResultadoIMC);
            this.Controls.Add(this.buttonCalcularIMC);
            this.Controls.Add(this.textBoxAltura);
            this.Controls.Add(this.labelAltura);
            this.Controls.Add(this.textBoxPeso);
            this.Controls.Add(this.labelPeso);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(645, 190);
            this.Name = "FormCalculoIMC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Cálculo de IMC";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label labelPeso;
        private System.Windows.Forms.TextBox textBoxPeso;
        private System.Windows.Forms.Label labelAltura;
        private System.Windows.Forms.TextBox textBoxAltura;
        private System.Windows.Forms.Button buttonCalcularIMC;
        private System.Windows.Forms.Label labelResultadoIMC;
    }
}
