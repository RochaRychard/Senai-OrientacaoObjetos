namespace AplicacaoPoo.Windows
{
    partial class frmCliente
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
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblCpf = new System.Windows.Forms.Label();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.lblDebito = new System.Windows.Forms.Label();
            this.txtDebito = new System.Windows.Forms.TextBox();
            this.lblCredito = new System.Windows.Forms.Label();
            this.txtCredito = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNome.Location = new System.Drawing.Point(25, 22);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(43, 15);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(76, 19);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(299, 23);
            this.txtNome.TabIndex = 1;
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Location = new System.Drawing.Point(25, 74);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(31, 15);
            this.lblCpf.TabIndex = 2;
            this.lblCpf.Text = "CPF:";
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(67, 71);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(160, 23);
            this.txtCpf.TabIndex = 3;
            // 
            // lblDebito
            // 
            this.lblDebito.AutoSize = true;
            this.lblDebito.Location = new System.Drawing.Point(25, 120);
            this.lblDebito.Name = "lblDebito";
            this.lblDebito.Size = new System.Drawing.Size(89, 15);
            this.lblDebito.TabIndex = 4;
            this.lblDebito.Text = "Valor de débito:";
            // 
            // txtDebito
            // 
            this.txtDebito.Location = new System.Drawing.Point(123, 117);
            this.txtDebito.Name = "txtDebito";
            this.txtDebito.Size = new System.Drawing.Size(104, 23);
            this.txtDebito.TabIndex = 5;
            // 
            // lblCredito
            // 
            this.lblCredito.AutoSize = true;
            this.lblCredito.Location = new System.Drawing.Point(29, 171);
            this.lblCredito.Name = "lblCredito";
            this.lblCredito.Size = new System.Drawing.Size(92, 15);
            this.lblCredito.TabIndex = 6;
            this.lblCredito.Text = "Valor de crédito:";
            // 
            // txtCredito
            // 
            this.txtCredito.Location = new System.Drawing.Point(127, 163);
            this.txtCredito.Name = "txtCredito";
            this.txtCredito.Size = new System.Drawing.Size(100, 23);
            this.txtCredito.TabIndex = 7;
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 212);
            this.Controls.Add(this.txtCredito);
            this.Controls.Add(this.lblCredito);
            this.Controls.Add(this.txtDebito);
            this.Controls.Add(this.lblDebito);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.lblCpf);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Name = "frmCliente";
            this.Text = "frmCliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblNome;
        private TextBox txtNome;
        private Label lblCpf;
        private TextBox txtCpf;
        private Label lblDebito;
        private TextBox txtDebito;
        private Label lblCredito;
        private TextBox txtCredito;
    }
}