namespace MenuDeProgramas
{
    partial class FormCondicaoPagamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCondicaoPagamento));
            this.labelValorProduto = new System.Windows.Forms.Label();
            this.textBoxValorProduto = new System.Windows.Forms.TextBox();
            this.labelFormaPagamento = new System.Windows.Forms.Label();
            this.comboBoxFormaPagamento = new System.Windows.Forms.ComboBox();
            this.buttonCalcular = new System.Windows.Forms.Button();
            this.labelResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelValorProduto
            // 
            this.labelValorProduto.AutoSize = true;
            this.labelValorProduto.Location = new System.Drawing.Point(12, 15);
            this.labelValorProduto.Name = "labelValorProduto";
            this.labelValorProduto.Size = new System.Drawing.Size(111, 16);
            this.labelValorProduto.TabIndex = 0;
            this.labelValorProduto.Text = "Valor do Produto:";
            // 
            // textBoxValorProduto
            // 
            this.textBoxValorProduto.Location = new System.Drawing.Point(125, 12);
            this.textBoxValorProduto.Name = "textBoxValorProduto";
            this.textBoxValorProduto.Size = new System.Drawing.Size(166, 22);
            this.textBoxValorProduto.TabIndex = 1;
            // 
            // labelFormaPagamento
            // 
            this.labelFormaPagamento.AutoSize = true;
            this.labelFormaPagamento.Location = new System.Drawing.Point(12, 44);
            this.labelFormaPagamento.Name = "labelFormaPagamento";
            this.labelFormaPagamento.Size = new System.Drawing.Size(141, 16);
            this.labelFormaPagamento.TabIndex = 2;
            this.labelFormaPagamento.Text = "Forma de Pagamento:";
            // 
            // comboBoxFormaPagamento
            // 
            this.comboBoxFormaPagamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFormaPagamento.FormattingEnabled = true;
            this.comboBoxFormaPagamento.Items.AddRange(new object[] {
            "1 - À Vista em Dinheiro ou Pix (15% de desconto)",
            "2 - À Vista no cartão de crédito (10% de desconto)",
            "3 - Parcelado no cartão em duas vezes (sem juros)",
            "4 - Parcelado no cartão em três vezes ou mais (10% de juros)"});
            this.comboBoxFormaPagamento.Location = new System.Drawing.Point(154, 41);
            this.comboBoxFormaPagamento.Name = "comboBoxFormaPagamento";
            this.comboBoxFormaPagamento.Size = new System.Drawing.Size(282, 24);
            this.comboBoxFormaPagamento.TabIndex = 3;
            // 
            // buttonCalcular
            // 
            this.buttonCalcular.Location = new System.Drawing.Point(12, 70);
            this.buttonCalcular.Name = "buttonCalcular";
            this.buttonCalcular.Size = new System.Drawing.Size(75, 23);
            this.buttonCalcular.TabIndex = 4;
            this.buttonCalcular.Text = "Calcular";
            this.buttonCalcular.UseVisualStyleBackColor = true;
            this.buttonCalcular.Click += new System.EventHandler(this.buttonCalcular_Click);
            // 
            // labelResultado
            // 
            this.labelResultado.AutoSize = true;
            this.labelResultado.Location = new System.Drawing.Point(12, 96);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(72, 16);
            this.labelResultado.TabIndex = 5;
            this.labelResultado.Text = "Resultado:";
            // 
            // FormCondicaoPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MenuDeProgramas.Properties.Resources.Superbolt_Lightning_Art_Concept1;
            this.ClientSize = new System.Drawing.Size(782, 428);
            this.Controls.Add(this.labelResultado);
            this.Controls.Add(this.buttonCalcular);
            this.Controls.Add(this.comboBoxFormaPagamento);
            this.Controls.Add(this.labelFormaPagamento);
            this.Controls.Add(this.textBoxValorProduto);
            this.Controls.Add(this.labelValorProduto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(645, 190);
            this.Name = "FormCondicaoPagamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Condição de Pagamento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label labelValorProduto;
        private System.Windows.Forms.TextBox textBoxValorProduto;
        private System.Windows.Forms.Label labelFormaPagamento;
        private System.Windows.Forms.ComboBox comboBoxFormaPagamento;
        private System.Windows.Forms.Button buttonCalcular;
        private System.Windows.Forms.Label labelResultado;
    }
}
