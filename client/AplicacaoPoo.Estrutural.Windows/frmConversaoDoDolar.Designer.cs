namespace AplicacaoPoo.Estrutural.Windows
{
    partial class frmConversaoDoDolar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCotacaoAtual = new System.Windows.Forms.Label();
            this.txtCotacaoAtual = new System.Windows.Forms.TextBox();
            this.lblQuantidadeDeDolar = new System.Windows.Forms.Label();
            this.txtQuantidadeDolar = new System.Windows.Forms.TextBox();
            this.btnConverter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCotacaoAtual
            // 
            this.lblCotacaoAtual.AutoSize = true;
            this.lblCotacaoAtual.Location = new System.Drawing.Point(119, 22);
            this.lblCotacaoAtual.Name = "lblCotacaoAtual";
            this.lblCotacaoAtual.Size = new System.Drawing.Size(165, 15);
            this.lblCotacaoAtual.TabIndex = 0;
            this.lblCotacaoAtual.Text = "Digite a cotação do dólar: US$";
            // 
            // txtCotacaoAtual
            // 
            this.txtCotacaoAtual.Location = new System.Drawing.Point(134, 56);
            this.txtCotacaoAtual.Name = "txtCotacaoAtual";
            this.txtCotacaoAtual.PlaceholderText = "Cotação atual do dólar";
            this.txtCotacaoAtual.Size = new System.Drawing.Size(132, 23);
            this.txtCotacaoAtual.TabIndex = 1;
            this.txtCotacaoAtual.TextChanged += new System.EventHandler(this.txtCotacaoAtual_TextChanged);
            // 
            // lblQuantidadeDeDolar
            // 
            this.lblQuantidadeDeDolar.AutoSize = true;
            this.lblQuantidadeDeDolar.Location = new System.Drawing.Point(75, 99);
            this.lblQuantidadeDeDolar.Name = "lblQuantidadeDeDolar";
            this.lblQuantidadeDeDolar.Size = new System.Drawing.Size(276, 15);
            this.lblQuantidadeDeDolar.TabIndex = 2;
            this.lblQuantidadeDeDolar.Text = "Quantos dólares você quer converter em reais? US$";
            // 
            // txtQuantidadeDolar
            // 
            this.txtQuantidadeDolar.Location = new System.Drawing.Point(153, 127);
            this.txtQuantidadeDolar.Name = "txtQuantidadeDolar";
            this.txtQuantidadeDolar.PlaceholderText = "Valor em dólar";
            this.txtQuantidadeDolar.Size = new System.Drawing.Size(87, 23);
            this.txtQuantidadeDolar.TabIndex = 3;
            this.txtQuantidadeDolar.TextChanged += new System.EventHandler(this.txtQuantidadeDolar_TextChanged);
            // 
            // btnConverter
            // 
            this.btnConverter.Location = new System.Drawing.Point(153, 185);
            this.btnConverter.Name = "btnConverter";
            this.btnConverter.Size = new System.Drawing.Size(87, 23);
            this.btnConverter.TabIndex = 4;
            this.btnConverter.Text = "Converter";
            this.btnConverter.UseVisualStyleBackColor = true;
            this.btnConverter.Click += new System.EventHandler(this.btnConverter_Click);
            // 
            // frmConversaoDoDolar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 244);
            this.Controls.Add(this.btnConverter);
            this.Controls.Add(this.txtQuantidadeDolar);
            this.Controls.Add(this.lblQuantidadeDeDolar);
            this.Controls.Add(this.txtCotacaoAtual);
            this.Controls.Add(this.lblCotacaoAtual);
            this.Name = "frmConversaoDoDolar";
            this.Text = "ConversaoDoDolar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblCotacaoAtual;
        private TextBox txtCotacaoAtual;
        private Label lblQuantidadeDeDolar;
        private TextBox txtQuantidadeDolar;
        private Button btnConverter;
    }
}