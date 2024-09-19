namespace MenuDeProgramas
{
    partial class FormMedia4Notas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMedia4Notas));
            this.labelNota1 = new System.Windows.Forms.Label();
            this.textBoxNota1 = new System.Windows.Forms.TextBox();
            this.labelNota2 = new System.Windows.Forms.Label();
            this.textBoxNota2 = new System.Windows.Forms.TextBox();
            this.labelNota3 = new System.Windows.Forms.Label();
            this.textBoxNota3 = new System.Windows.Forms.TextBox();
            this.labelNota4 = new System.Windows.Forms.Label();
            this.textBoxNota4 = new System.Windows.Forms.TextBox();
            this.buttonCalcular = new System.Windows.Forms.Button();
            this.labelResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelNota1
            // 
            this.labelNota1.AutoSize = true;
            this.labelNota1.Location = new System.Drawing.Point(14, 16);
            this.labelNota1.Name = "labelNota1";
            this.labelNota1.Size = new System.Drawing.Size(49, 16);
            this.labelNota1.TabIndex = 0;
            this.labelNota1.Text = "Nota 1:";
            // 
            // textBoxNota1
            // 
            this.textBoxNota1.Location = new System.Drawing.Point(72, 13);
            this.textBoxNota1.Name = "textBoxNota1";
            this.textBoxNota1.Size = new System.Drawing.Size(114, 22);
            this.textBoxNota1.TabIndex = 1;
            // 
            // labelNota2
            // 
            this.labelNota2.AutoSize = true;
            this.labelNota2.Location = new System.Drawing.Point(14, 47);
            this.labelNota2.Name = "labelNota2";
            this.labelNota2.Size = new System.Drawing.Size(49, 16);
            this.labelNota2.TabIndex = 2;
            this.labelNota2.Text = "Nota 2:";
            // 
            // textBoxNota2
            // 
            this.textBoxNota2.Location = new System.Drawing.Point(72, 44);
            this.textBoxNota2.Name = "textBoxNota2";
            this.textBoxNota2.Size = new System.Drawing.Size(114, 22);
            this.textBoxNota2.TabIndex = 3;
            // 
            // labelNota3
            // 
            this.labelNota3.AutoSize = true;
            this.labelNota3.Location = new System.Drawing.Point(14, 78);
            this.labelNota3.Name = "labelNota3";
            this.labelNota3.Size = new System.Drawing.Size(49, 16);
            this.labelNota3.TabIndex = 4;
            this.labelNota3.Text = "Nota 3:";
            // 
            // textBoxNota3
            // 
            this.textBoxNota3.Location = new System.Drawing.Point(72, 75);
            this.textBoxNota3.Name = "textBoxNota3";
            this.textBoxNota3.Size = new System.Drawing.Size(114, 22);
            this.textBoxNota3.TabIndex = 5;
            // 
            // labelNota4
            // 
            this.labelNota4.AutoSize = true;
            this.labelNota4.Location = new System.Drawing.Point(14, 109);
            this.labelNota4.Name = "labelNota4";
            this.labelNota4.Size = new System.Drawing.Size(49, 16);
            this.labelNota4.TabIndex = 6;
            this.labelNota4.Text = "Nota 4:";
            // 
            // textBoxNota4
            // 
            this.textBoxNota4.Location = new System.Drawing.Point(72, 106);
            this.textBoxNota4.Name = "textBoxNota4";
            this.textBoxNota4.Size = new System.Drawing.Size(114, 22);
            this.textBoxNota4.TabIndex = 7;
            // 
            // buttonCalcular
            // 
            this.buttonCalcular.Location = new System.Drawing.Point(14, 137);
            this.buttonCalcular.Name = "buttonCalcular";
            this.buttonCalcular.Size = new System.Drawing.Size(86, 25);
            this.buttonCalcular.TabIndex = 8;
            this.buttonCalcular.Text = "Calcular";
            this.buttonCalcular.UseVisualStyleBackColor = true;
            this.buttonCalcular.Click += new System.EventHandler(this.buttonCalcular_Click);
            // 
            // labelResultado
            // 
            this.labelResultado.AutoSize = true;
            this.labelResultado.Location = new System.Drawing.Point(14, 175);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(72, 16);
            this.labelResultado.TabIndex = 9;
            this.labelResultado.Text = "Resultado:";
            // 
            // FormMedia4Notas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MenuDeProgramas.Properties.Resources.Superbolt_Lightning_Art_Concept1;
            this.ClientSize = new System.Drawing.Size(782, 428);
            this.Controls.Add(this.labelResultado);
            this.Controls.Add(this.buttonCalcular);
            this.Controls.Add(this.textBoxNota4);
            this.Controls.Add(this.labelNota4);
            this.Controls.Add(this.textBoxNota3);
            this.Controls.Add(this.labelNota3);
            this.Controls.Add(this.textBoxNota2);
            this.Controls.Add(this.labelNota2);
            this.Controls.Add(this.textBoxNota1);
            this.Controls.Add(this.labelNota1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(645, 190);
            this.Name = "FormMedia4Notas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Média de 4 Notas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label labelNota1;
        private System.Windows.Forms.TextBox textBoxNota1;
        private System.Windows.Forms.Label labelNota2;
        private System.Windows.Forms.TextBox textBoxNota2;
        private System.Windows.Forms.Label labelNota3;
        private System.Windows.Forms.TextBox textBoxNota3;
        private System.Windows.Forms.Label labelNota4;
        private System.Windows.Forms.TextBox textBoxNota4;
        private System.Windows.Forms.Button buttonCalcular;
        private System.Windows.Forms.Label labelResultado;
    }
}
