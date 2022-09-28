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
            this.lblIdDoVendedor = new System.Windows.Forms.Label();
            this.txtIdDoVendedor = new System.Windows.Forms.TextBox();
            this.lblCodioDaPeca = new System.Windows.Forms.Label();
            this.txtCodigoDaPeca = new System.Windows.Forms.TextBox();
            this.lblValorUnitario = new System.Windows.Forms.Label();
            this.txtValorUnitario = new System.Windows.Forms.TextBox();
            this.lblQuantidadeVendida = new System.Windows.Forms.Label();
            this.txtQuantidadeVendida = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblIdDoVendedor
            // 
            this.lblIdDoVendedor.AutoSize = true;
            this.lblIdDoVendedor.Location = new System.Drawing.Point(31, 23);
            this.lblIdDoVendedor.Name = "lblIdDoVendedor";
            this.lblIdDoVendedor.Size = new System.Drawing.Size(91, 15);
            this.lblIdDoVendedor.TabIndex = 0;
            this.lblIdDoVendedor.Text = "ID do vendedor:";
            // 
            // txtIdDoVendedor
            // 
            this.txtIdDoVendedor.Location = new System.Drawing.Point(128, 20);
            this.txtIdDoVendedor.Name = "txtIdDoVendedor";
            this.txtIdDoVendedor.Size = new System.Drawing.Size(161, 23);
            this.txtIdDoVendedor.TabIndex = 1;
            // 
            // lblCodioDaPeca
            // 
            this.lblCodioDaPeca.AutoSize = true;
            this.lblCodioDaPeca.Location = new System.Drawing.Point(31, 68);
            this.lblCodioDaPeca.Name = "lblCodioDaPeca";
            this.lblCodioDaPeca.Size = new System.Drawing.Size(93, 15);
            this.lblCodioDaPeca.TabIndex = 2;
            this.lblCodioDaPeca.Text = "Código da peça:";
            // 
            // txtCodigoDaPeca
            // 
            this.txtCodigoDaPeca.Location = new System.Drawing.Point(125, 65);
            this.txtCodigoDaPeca.Name = "txtCodigoDaPeca";
            this.txtCodigoDaPeca.Size = new System.Drawing.Size(164, 23);
            this.txtCodigoDaPeca.TabIndex = 3;
            // 
            // lblValorUnitario
            // 
            this.lblValorUnitario.AutoSize = true;
            this.lblValorUnitario.Location = new System.Drawing.Point(31, 114);
            this.lblValorUnitario.Name = "lblValorUnitario";
            this.lblValorUnitario.Size = new System.Drawing.Size(98, 15);
            this.lblValorUnitario.TabIndex = 4;
            this.lblValorUnitario.Text = "Valor da unidade:";
            // 
            // txtValorUnitario
            // 
            this.txtValorUnitario.Location = new System.Drawing.Point(135, 111);
            this.txtValorUnitario.Name = "txtValorUnitario";
            this.txtValorUnitario.Size = new System.Drawing.Size(154, 23);
            this.txtValorUnitario.TabIndex = 5;
            // 
            // lblQuantidadeVendida
            // 
            this.lblQuantidadeVendida.AutoSize = true;
            this.lblQuantidadeVendida.Location = new System.Drawing.Point(31, 160);
            this.lblQuantidadeVendida.Name = "lblQuantidadeVendida";
            this.lblQuantidadeVendida.Size = new System.Drawing.Size(117, 15);
            this.lblQuantidadeVendida.TabIndex = 6;
            this.lblQuantidadeVendida.Text = "Quantidade Vendida:";
            // 
            // txtQuantidadeVendida
            // 
            this.txtQuantidadeVendida.Location = new System.Drawing.Point(154, 157);
            this.txtQuantidadeVendida.Name = "txtQuantidadeVendida";
            this.txtQuantidadeVendida.Size = new System.Drawing.Size(135, 23);
            this.txtQuantidadeVendida.TabIndex = 7;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(160, 216);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(129, 42);
            this.btnCalcular.TabIndex = 8;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // frmComissaoDeVendedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 312);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtQuantidadeVendida);
            this.Controls.Add(this.lblQuantidadeVendida);
            this.Controls.Add(this.txtValorUnitario);
            this.Controls.Add(this.lblValorUnitario);
            this.Controls.Add(this.txtCodigoDaPeca);
            this.Controls.Add(this.lblCodioDaPeca);
            this.Controls.Add(this.txtIdDoVendedor);
            this.Controls.Add(this.lblIdDoVendedor);
            this.Name = "frmComissaoDeVendedores";
            this.Text = "frmComissaoDeVendedores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblIdDoVendedor;
        private TextBox txtIdDoVendedor;
        private Label lblCodioDaPeca;
        private TextBox txtCodigoDaPeca;
        private Label lblValorUnitario;
        private TextBox txtValorUnitario;
        private Label lblQuantidadeVendida;
        private TextBox txtQuantidadeVendida;
        private Button btnCalcular;
    }
}