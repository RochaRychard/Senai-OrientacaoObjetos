namespace AplicacaoPoo.Estrutural.Windows
{
    partial class frmComissaoDeVendedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmComissaoDeVendedores));
            this.lblIdDoVendedor = new System.Windows.Forms.Label();
            this.txtIdDoVendedor = new System.Windows.Forms.TextBox();
            this.lblCodigoDaPeca = new System.Windows.Forms.Label();
            this.txtCodigoDaPeca = new System.Windows.Forms.TextBox();
            this.lblValorUnitario = new System.Windows.Forms.Label();
            this.txtValorUnitario = new System.Windows.Forms.TextBox();
            this.lblQuantidadeVendida = new System.Windows.Forms.Label();
            this.txtQuantidadeVendida = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblResposta = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIdDoVendedor
            // 
            this.lblIdDoVendedor.AutoSize = true;
            this.lblIdDoVendedor.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblIdDoVendedor.Location = new System.Drawing.Point(12, 34);
            this.lblIdDoVendedor.Name = "lblIdDoVendedor";
            this.lblIdDoVendedor.Size = new System.Drawing.Size(102, 17);
            this.lblIdDoVendedor.TabIndex = 0;
            this.lblIdDoVendedor.Text = "ID do vendedor:";
            // 
            // txtIdDoVendedor
            // 
            this.txtIdDoVendedor.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtIdDoVendedor.Location = new System.Drawing.Point(150, 28);
            this.txtIdDoVendedor.Name = "txtIdDoVendedor";
            this.txtIdDoVendedor.Size = new System.Drawing.Size(135, 23);
            this.txtIdDoVendedor.TabIndex = 1;
            this.txtIdDoVendedor.TextChanged += new System.EventHandler(this.VerificarSeTextBoxFoiPreenchido);
            // 
            // lblCodigoDaPeca
            // 
            this.lblCodigoDaPeca.AutoSize = true;
            this.lblCodigoDaPeca.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblCodigoDaPeca.Location = new System.Drawing.Point(12, 85);
            this.lblCodigoDaPeca.Name = "lblCodigoDaPeca";
            this.lblCodigoDaPeca.Size = new System.Drawing.Size(100, 17);
            this.lblCodigoDaPeca.TabIndex = 2;
            this.lblCodigoDaPeca.Text = "Código da peça:";
            // 
            // txtCodigoDaPeca
            // 
            this.txtCodigoDaPeca.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtCodigoDaPeca.Location = new System.Drawing.Point(150, 79);
            this.txtCodigoDaPeca.Name = "txtCodigoDaPeca";
            this.txtCodigoDaPeca.Size = new System.Drawing.Size(135, 23);
            this.txtCodigoDaPeca.TabIndex = 3;
            this.txtCodigoDaPeca.TextChanged += new System.EventHandler(this.VerificarSeTextBoxFoiPreenchido);
            // 
            // lblValorUnitario
            // 
            this.lblValorUnitario.AutoSize = true;
            this.lblValorUnitario.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblValorUnitario.Location = new System.Drawing.Point(12, 135);
            this.lblValorUnitario.Name = "lblValorUnitario";
            this.lblValorUnitario.Size = new System.Drawing.Size(112, 17);
            this.lblValorUnitario.TabIndex = 4;
            this.lblValorUnitario.Text = "Valor da unidade:";
            // 
            // txtValorUnitario
            // 
            this.txtValorUnitario.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtValorUnitario.Location = new System.Drawing.Point(150, 129);
            this.txtValorUnitario.Name = "txtValorUnitario";
            this.txtValorUnitario.Size = new System.Drawing.Size(135, 23);
            this.txtValorUnitario.TabIndex = 5;
            // 
            // lblQuantidadeVendida
            // 
            this.lblQuantidadeVendida.AutoSize = true;
            this.lblQuantidadeVendida.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblQuantidadeVendida.Location = new System.Drawing.Point(12, 178);
            this.lblQuantidadeVendida.Name = "lblQuantidadeVendida";
            this.lblQuantidadeVendida.Size = new System.Drawing.Size(132, 17);
            this.lblQuantidadeVendida.TabIndex = 6;
            this.lblQuantidadeVendida.Text = "Quantidade vendida:";
            // 
            // txtQuantidadeVendida
            // 
            this.txtQuantidadeVendida.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtQuantidadeVendida.Location = new System.Drawing.Point(150, 172);
            this.txtQuantidadeVendida.Name = "txtQuantidadeVendida";
            this.txtQuantidadeVendida.Size = new System.Drawing.Size(135, 23);
            this.txtQuantidadeVendida.TabIndex = 7;
            this.txtQuantidadeVendida.TextChanged += new System.EventHandler(this.txtQuantidadeVendida_TextChanged);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalcular.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnCalcular.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCalcular.Location = new System.Drawing.Point(338, 161);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(129, 42);
            this.btnCalcular.TabIndex = 8;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(367, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 129);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // lblResposta
            // 
            this.lblResposta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResposta.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblResposta.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblResposta.ForeColor = System.Drawing.Color.Red;
            this.lblResposta.Location = new System.Drawing.Point(12, 252);
            this.lblResposta.Name = "lblResposta";
            this.lblResposta.Size = new System.Drawing.Size(455, 63);
            this.lblResposta.TabIndex = 10;
            this.lblResposta.Visible = false;
            // 
            // frmComissaoDeVendedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(482, 324);
            this.Controls.Add(this.lblResposta);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtQuantidadeVendida);
            this.Controls.Add(this.lblQuantidadeVendida);
            this.Controls.Add(this.txtValorUnitario);
            this.Controls.Add(this.lblValorUnitario);
            this.Controls.Add(this.txtCodigoDaPeca);
            this.Controls.Add(this.lblCodigoDaPeca);
            this.Controls.Add(this.txtIdDoVendedor);
            this.Controls.Add(this.lblIdDoVendedor);
            this.MaximizeBox = false;
            this.Name = "frmComissaoDeVendedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmComissaoDeVendedores";
            this.TextChanged += new System.EventHandler(this.frmComissaoDeVendedores_TextChanged);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblIdDoVendedor;
        private TextBox txtIdDoVendedor;
        private Label lblCodigoDaPeca;
        private TextBox txtCodigoDaPeca;
        private Label lblValorUnitario;
        private TextBox txtValorUnitario;
        private Label lblQuantidadeVendida;
        private TextBox txtQuantidadeVendida;
        private Button btnCalcular;
        private PictureBox pictureBox1;
        private Label lblResposta;
    }
}