namespace MenuDeProgramas
{
    partial class FormConsumoCombustivel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConsumoCombustivel));
            this.labelDistancia = new System.Windows.Forms.Label();
            this.textBoxDistancia = new System.Windows.Forms.TextBox();
            this.labelConsumo = new System.Windows.Forms.Label();
            this.textBoxConsumo = new System.Windows.Forms.TextBox();
            this.labelPrecoCombustivel = new System.Windows.Forms.Label();
            this.textBoxPrecoCombustivel = new System.Windows.Forms.TextBox();
            this.labelTamanhoTanque = new System.Windows.Forms.Label();
            this.textBoxTamanhoTanque = new System.Windows.Forms.TextBox();
            this.buttonCalcularConsumo = new System.Windows.Forms.Button();
            this.labelResultadoConsumo = new System.Windows.Forms.Label();
            this.comboBoxCombustivel = new System.Windows.Forms.ComboBox();
            this.labelCombustivel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelDistancia
            // 
            this.labelDistancia.AutoSize = true;
            this.labelDistancia.Location = new System.Drawing.Point(14, 16);
            this.labelDistancia.Name = "labelDistancia";
            this.labelDistancia.Size = new System.Drawing.Size(66, 16);
            this.labelDistancia.TabIndex = 0;
            this.labelDistancia.Text = "Distância:";
            // 
            // textBoxDistancia
            // 
            this.textBoxDistancia.Location = new System.Drawing.Point(151, 13);
            this.textBoxDistancia.Name = "textBoxDistancia";
            this.textBoxDistancia.Size = new System.Drawing.Size(114, 22);
            this.textBoxDistancia.TabIndex = 1;
            // 
            // labelConsumo
            // 
            this.labelConsumo.AutoSize = true;
            this.labelConsumo.Location = new System.Drawing.Point(14, 47);
            this.labelConsumo.Name = "labelConsumo";
            this.labelConsumo.Size = new System.Drawing.Size(104, 16);
            this.labelConsumo.TabIndex = 2;
            this.labelConsumo.Text = "Consumo (Km/l):";
            // 
            // textBoxConsumo
            // 
            this.textBoxConsumo.Location = new System.Drawing.Point(151, 44);
            this.textBoxConsumo.Name = "textBoxConsumo";
            this.textBoxConsumo.Size = new System.Drawing.Size(114, 22);
            this.textBoxConsumo.TabIndex = 3;
            // 
            // labelPrecoCombustivel
            // 
            this.labelPrecoCombustivel.AutoSize = true;
            this.labelPrecoCombustivel.Location = new System.Drawing.Point(14, 78);
            this.labelPrecoCombustivel.Name = "labelPrecoCombustivel";
            this.labelPrecoCombustivel.Size = new System.Drawing.Size(123, 16);
            this.labelPrecoCombustivel.TabIndex = 4;
            this.labelPrecoCombustivel.Text = "Preço Combustível:";
            // 
            // textBoxPrecoCombustivel
            // 
            this.textBoxPrecoCombustivel.Location = new System.Drawing.Point(151, 75);
            this.textBoxPrecoCombustivel.Name = "textBoxPrecoCombustivel";
            this.textBoxPrecoCombustivel.Size = new System.Drawing.Size(114, 22);
            this.textBoxPrecoCombustivel.TabIndex = 5;
            // 
            // labelTamanhoTanque
            // 
            this.labelTamanhoTanque.AutoSize = true;
            this.labelTamanhoTanque.Location = new System.Drawing.Point(14, 109);
            this.labelTamanhoTanque.Name = "labelTamanhoTanque";
            this.labelTamanhoTanque.Size = new System.Drawing.Size(118, 16);
            this.labelTamanhoTanque.TabIndex = 6;
            this.labelTamanhoTanque.Text = "Tamanho Tanque:";
            // 
            // textBoxTamanhoTanque
            // 
            this.textBoxTamanhoTanque.Location = new System.Drawing.Point(151, 106);
            this.textBoxTamanhoTanque.Name = "textBoxTamanhoTanque";
            this.textBoxTamanhoTanque.Size = new System.Drawing.Size(114, 22);
            this.textBoxTamanhoTanque.TabIndex = 7;
            // 
            // buttonCalcularConsumo
            // 
            this.buttonCalcularConsumo.Location = new System.Drawing.Point(14, 167);
            this.buttonCalcularConsumo.Name = "buttonCalcularConsumo";
            this.buttonCalcularConsumo.Size = new System.Drawing.Size(251, 25);
            this.buttonCalcularConsumo.TabIndex = 8;
            this.buttonCalcularConsumo.Text = "Calcular Consumo";
            this.buttonCalcularConsumo.UseVisualStyleBackColor = true;
            this.buttonCalcularConsumo.Click += new System.EventHandler(this.buttonCalcularConsumo_Click);
            // 
            // labelResultadoConsumo
            // 
            this.labelResultadoConsumo.AutoSize = true;
            this.labelResultadoConsumo.Location = new System.Drawing.Point(14, 195);
            this.labelResultadoConsumo.Name = "labelResultadoConsumo";
            this.labelResultadoConsumo.Size = new System.Drawing.Size(72, 16);
            this.labelResultadoConsumo.TabIndex = 9;
            this.labelResultadoConsumo.Text = "Resultado:";
            // 
            // comboBoxCombustivel
            // 
            this.comboBoxCombustivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCombustivel.FormattingEnabled = true;
            this.comboBoxCombustivel.Items.AddRange(new object[] {
            "Gasolina",
            "Álcool",
            "Diesel"});
            this.comboBoxCombustivel.Location = new System.Drawing.Point(151, 137);
            this.comboBoxCombustivel.Name = "comboBoxCombustivel";
            this.comboBoxCombustivel.Size = new System.Drawing.Size(114, 24);
            this.comboBoxCombustivel.TabIndex = 10;
            // 
            // labelCombustivel
            // 
            this.labelCombustivel.AutoSize = true;
            this.labelCombustivel.Location = new System.Drawing.Point(14, 140);
            this.labelCombustivel.Name = "labelCombustivel";
            this.labelCombustivel.Size = new System.Drawing.Size(84, 16);
            this.labelCombustivel.TabIndex = 11;
            this.labelCombustivel.Text = "Combustível:";
            // 
            // FormConsumoCombustivel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MenuDeProgramas.Properties.Resources.Superbolt_Lightning_Art_Concept1;
            this.ClientSize = new System.Drawing.Size(782, 428);
            this.Controls.Add(this.labelCombustivel);
            this.Controls.Add(this.comboBoxCombustivel);
            this.Controls.Add(this.labelResultadoConsumo);
            this.Controls.Add(this.buttonCalcularConsumo);
            this.Controls.Add(this.textBoxTamanhoTanque);
            this.Controls.Add(this.labelTamanhoTanque);
            this.Controls.Add(this.textBoxPrecoCombustivel);
            this.Controls.Add(this.labelPrecoCombustivel);
            this.Controls.Add(this.textBoxConsumo);
            this.Controls.Add(this.labelConsumo);
            this.Controls.Add(this.textBoxDistancia);
            this.Controls.Add(this.labelDistancia);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(645, 190);
            this.Name = "FormConsumoCombustivel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Consumo de Combustível";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label labelDistancia;
        private System.Windows.Forms.TextBox textBoxDistancia;
        private System.Windows.Forms.Label labelConsumo;
        private System.Windows.Forms.TextBox textBoxConsumo;
        private System.Windows.Forms.Label labelPrecoCombustivel;
        private System.Windows.Forms.TextBox textBoxPrecoCombustivel;
        private System.Windows.Forms.Label labelTamanhoTanque;
        private System.Windows.Forms.TextBox textBoxTamanhoTanque;
        private System.Windows.Forms.Button buttonCalcularConsumo;
        private System.Windows.Forms.Label labelResultadoConsumo;
        private System.Windows.Forms.ComboBox comboBoxCombustivel;
        private System.Windows.Forms.Label labelCombustivel;
    }
}
