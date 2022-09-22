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
            this.lblQuantidadeDeDolar = new System.Windows.Forms.Label();
            this.txtQuantidadeDolar = new System.Windows.Forms.TextBox();
            this.btnConverter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblQuantidadeDeDolar
            // 
            this.lblQuantidadeDeDolar.AutoSize = true;
            this.lblQuantidadeDeDolar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblQuantidadeDeDolar.ForeColor = System.Drawing.Color.Black;
            this.lblQuantidadeDeDolar.Location = new System.Drawing.Point(12, 19);
            this.lblQuantidadeDeDolar.Name = "lblQuantidadeDeDolar";
            this.lblQuantidadeDeDolar.Size = new System.Drawing.Size(375, 21);
            this.lblQuantidadeDeDolar.TabIndex = 2;
            this.lblQuantidadeDeDolar.Text = "Quantos dólares você quer converter em reais? US$";
            // 
            // txtQuantidadeDolar
            // 
            this.txtQuantidadeDolar.Location = new System.Drawing.Point(153, 71);
            this.txtQuantidadeDolar.Name = "txtQuantidadeDolar";
            this.txtQuantidadeDolar.PlaceholderText = "Valor em dólar";
            this.txtQuantidadeDolar.Size = new System.Drawing.Size(87, 23);
            this.txtQuantidadeDolar.TabIndex = 3;
            this.txtQuantidadeDolar.TextChanged += new System.EventHandler(this.txtQuantidadeDolar_TextChanged);
            // 
            // btnConverter
            // 
            this.btnConverter.ForeColor = System.Drawing.Color.Red;
            this.btnConverter.Location = new System.Drawing.Point(153, 154);
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
            this.ClientSize = new System.Drawing.Size(393, 218);
            this.Controls.Add(this.btnConverter);
            this.Controls.Add(this.txtQuantidadeDolar);
            this.Controls.Add(this.lblQuantidadeDeDolar);
            this.Name = "frmConversaoDoDolar";
            this.Text = "ConversaoDoDolar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lblQuantidadeDeDolar;
        private TextBox txtQuantidadeDolar;
        private Button btnConverter;
    }
}