namespace MenuDeProgramas
{
    partial class FormConversaoTemperaturas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConversaoTemperaturas));
            this.labelEntradaTemperatura = new System.Windows.Forms.Label();
            this.textBoxTemperatura = new System.Windows.Forms.TextBox();
            this.comboBoxConversao = new System.Windows.Forms.ComboBox();
            this.buttonConverter = new System.Windows.Forms.Button();
            this.labelResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelEntradaTemperatura
            // 
            this.labelEntradaTemperatura.AutoSize = true;
            this.labelEntradaTemperatura.Location = new System.Drawing.Point(14, 16);
            this.labelEntradaTemperatura.Name = "labelEntradaTemperatura";
            this.labelEntradaTemperatura.Size = new System.Drawing.Size(140, 16);
            this.labelEntradaTemperatura.TabIndex = 0;
            this.labelEntradaTemperatura.Text = "Informe a temperatura:";
            // 
            // textBoxTemperatura
            // 
            this.textBoxTemperatura.Location = new System.Drawing.Point(161, 13);
            this.textBoxTemperatura.Name = "textBoxTemperatura";
            this.textBoxTemperatura.Size = new System.Drawing.Size(114, 22);
            this.textBoxTemperatura.TabIndex = 1;
            // 
            // comboBoxConversao
            // 
            this.comboBoxConversao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxConversao.FormattingEnabled = true;
            this.comboBoxConversao.Items.AddRange(new object[] {
            "Celsius para Fahrenheit",
            "Fahrenheit para Celsius",
            "Celsius para Kelvin",
            "Kelvin para Celsius"});
            this.comboBoxConversao.Location = new System.Drawing.Point(14, 44);
            this.comboBoxConversao.Name = "comboBoxConversao";
            this.comboBoxConversao.Size = new System.Drawing.Size(261, 24);
            this.comboBoxConversao.TabIndex = 2;
            // 
            // buttonConverter
            // 
            this.buttonConverter.Location = new System.Drawing.Point(14, 75);
            this.buttonConverter.Name = "buttonConverter";
            this.buttonConverter.Size = new System.Drawing.Size(86, 25);
            this.buttonConverter.TabIndex = 3;
            this.buttonConverter.Text = "Converter";
            this.buttonConverter.UseVisualStyleBackColor = true;
            this.buttonConverter.Click += new System.EventHandler(this.buttonConverter_Click);
            // 
            // labelResultado
            // 
            this.labelResultado.AutoSize = true;
            this.labelResultado.Location = new System.Drawing.Point(14, 102);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(72, 16);
            this.labelResultado.TabIndex = 4;
            this.labelResultado.Text = "Resultado:";
            // 
            // FormConversaoTemperaturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MenuDeProgramas.Properties.Resources.Superbolt_Lightning_Art_Concept1;
            this.ClientSize = new System.Drawing.Size(782, 428);
            this.Controls.Add(this.labelResultado);
            this.Controls.Add(this.buttonConverter);
            this.Controls.Add(this.comboBoxConversao);
            this.Controls.Add(this.textBoxTemperatura);
            this.Controls.Add(this.labelEntradaTemperatura);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(645, 190);
            this.Name = "FormConversaoTemperaturas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Conversão de Temperaturas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label labelEntradaTemperatura;
        private System.Windows.Forms.TextBox textBoxTemperatura;
        private System.Windows.Forms.ComboBox comboBoxConversao;
        private System.Windows.Forms.Button buttonConverter;
        private System.Windows.Forms.Label labelResultado;
    }
}

