namespace MenuDeProgramas
{
    partial class FormMediaNNotas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMediaNNotas));
            this.labelNumNotas = new System.Windows.Forms.Label();
            this.textBoxNumNotas = new System.Windows.Forms.TextBox();
            this.buttonGerarCampos = new System.Windows.Forms.Button();
            this.panelNotas = new System.Windows.Forms.Panel();
            this.buttonCalcular = new System.Windows.Forms.Button();
            this.labelResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelNumNotas
            // 
            this.labelNumNotas.AutoSize = true;
            this.labelNumNotas.Location = new System.Drawing.Point(14, 16);
            this.labelNumNotas.Name = "labelNumNotas";
            this.labelNumNotas.Size = new System.Drawing.Size(116, 16);
            this.labelNumNotas.TabIndex = 0;
            this.labelNumNotas.Text = "Número de Notas:";
            // 
            // textBoxNumNotas
            // 
            this.textBoxNumNotas.Location = new System.Drawing.Point(153, 13);
            this.textBoxNumNotas.Name = "textBoxNumNotas";
            this.textBoxNumNotas.Size = new System.Drawing.Size(114, 22);
            this.textBoxNumNotas.TabIndex = 1;
            // 
            // buttonGerarCampos
            // 
            this.buttonGerarCampos.Location = new System.Drawing.Point(274, 12);
            this.buttonGerarCampos.Name = "buttonGerarCampos";
            this.buttonGerarCampos.Size = new System.Drawing.Size(126, 25);
            this.buttonGerarCampos.TabIndex = 2;
            this.buttonGerarCampos.Text = "Gerar Campos";
            this.buttonGerarCampos.UseVisualStyleBackColor = true;
            this.buttonGerarCampos.Click += new System.EventHandler(this.buttonGerarCampos_Click);
            // 
            // panelNotas
            // 
            this.panelNotas.AutoScroll = true;
            this.panelNotas.Location = new System.Drawing.Point(14, 44);
            this.panelNotas.Name = "panelNotas";
            this.panelNotas.Size = new System.Drawing.Size(386, 192);
            this.panelNotas.TabIndex = 3;
            // 
            // buttonCalcular
            // 
            this.buttonCalcular.Location = new System.Drawing.Point(14, 242);
            this.buttonCalcular.Name = "buttonCalcular";
            this.buttonCalcular.Size = new System.Drawing.Size(86, 25);
            this.buttonCalcular.TabIndex = 4;
            this.buttonCalcular.Text = "Calcular";
            this.buttonCalcular.UseVisualStyleBackColor = true;
            this.buttonCalcular.Click += new System.EventHandler(this.buttonCalcular_Click);
            // 
            // labelResultado
            // 
            this.labelResultado.AutoSize = true;
            this.labelResultado.Location = new System.Drawing.Point(14, 270);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(72, 16);
            this.labelResultado.TabIndex = 5;
            this.labelResultado.Text = "Resultado:";
            // 
            // FormMediaNNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MenuDeProgramas.Properties.Resources.Superbolt_Lightning_Art_Concept1;
            this.ClientSize = new System.Drawing.Size(782, 428);
            this.Controls.Add(this.labelResultado);
            this.Controls.Add(this.buttonCalcular);
            this.Controls.Add(this.panelNotas);
            this.Controls.Add(this.buttonGerarCampos);
            this.Controls.Add(this.textBoxNumNotas);
            this.Controls.Add(this.labelNumNotas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(645, 190);
            this.Name = "FormMediaNNotas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Média de N Notas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label labelNumNotas;
        private System.Windows.Forms.TextBox textBoxNumNotas;
        private System.Windows.Forms.Button buttonGerarCampos;
        private System.Windows.Forms.Panel panelNotas;
        private System.Windows.Forms.Button buttonCalcular;
        private System.Windows.Forms.Label labelResultado;
    }
}
