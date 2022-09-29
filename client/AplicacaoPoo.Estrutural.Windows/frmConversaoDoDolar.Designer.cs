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
            this.lblPrimeiroValor = new System.Windows.Forms.Label();
            this.txtQuantidadeDolar = new System.Windows.Forms.TextBox();
            this.lblSegundoValor = new System.Windows.Forms.Label();
            this.cmbMoedas = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblPrimeiroValor
            // 
            this.lblPrimeiroValor.AutoSize = true;
            this.lblPrimeiroValor.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblPrimeiroValor.ForeColor = System.Drawing.Color.White;
            this.lblPrimeiroValor.Location = new System.Drawing.Point(67, 9);
            this.lblPrimeiroValor.Name = "lblPrimeiroValor";
            this.lblPrimeiroValor.Size = new System.Drawing.Size(292, 21);
            this.lblPrimeiroValor.TabIndex = 2;
            this.lblPrimeiroValor.Text = "fgsfhghshshsghfghfshgghfdhgfdhfhgfdh";
            // 
            // txtQuantidadeDolar
            // 
            this.txtQuantidadeDolar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtQuantidadeDolar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtQuantidadeDolar.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.txtQuantidadeDolar.ForeColor = System.Drawing.SystemColors.Window;
            this.txtQuantidadeDolar.Location = new System.Drawing.Point(77, 121);
            this.txtQuantidadeDolar.Name = "txtQuantidadeDolar";
            this.txtQuantidadeDolar.PlaceholderText = "Valor ";
            this.txtQuantidadeDolar.Size = new System.Drawing.Size(115, 29);
            this.txtQuantidadeDolar.TabIndex = 3;
            this.txtQuantidadeDolar.TextChanged += new System.EventHandler(this.txtQuantidadeDolar_TextChanged_1);
            // 
            // lblSegundoValor
            // 
            this.lblSegundoValor.AutoSize = true;
            this.lblSegundoValor.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblSegundoValor.ForeColor = System.Drawing.Color.White;
            this.lblSegundoValor.Location = new System.Drawing.Point(67, 44);
            this.lblSegundoValor.Name = "lblSegundoValor";
            this.lblSegundoValor.Size = new System.Drawing.Size(410, 30);
            this.lblSegundoValor.TabIndex = 5;
            this.lblSegundoValor.Text = "fgsfhghshshsghfghfshgghfdhgfdhfhgfdh";
            // 
            // cmbMoedas
            // 
            this.cmbMoedas.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cmbMoedas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbMoedas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMoedas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbMoedas.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmbMoedas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cmbMoedas.FormattingEnabled = true;
            this.cmbMoedas.Items.AddRange(new object[] {
            "Dólar",
            "Euro",
            "Libra"});
            this.cmbMoedas.Location = new System.Drawing.Point(198, 121);
            this.cmbMoedas.Name = "cmbMoedas";
            this.cmbMoedas.Size = new System.Drawing.Size(128, 25);
            this.cmbMoedas.TabIndex = 6;
            this.cmbMoedas.SelectedIndexChanged += new System.EventHandler(this.cmbMoedas_SelectedIndexChanged);
            // 
            // frmConversaoDoDolar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(393, 218);
            this.Controls.Add(this.cmbMoedas);
            this.Controls.Add(this.lblSegundoValor);
            this.Controls.Add(this.txtQuantidadeDolar);
            this.Controls.Add(this.lblPrimeiroValor);
            this.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.Name = "frmConversaoDoDolar";
            this.Text = "ConversaoDoDolar";
            
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lblPrimeiroValor;
        private TextBox txtQuantidadeDolar;
        private Label lblSegundoValor;
        private ComboBox cmbMoedas;
    }
}