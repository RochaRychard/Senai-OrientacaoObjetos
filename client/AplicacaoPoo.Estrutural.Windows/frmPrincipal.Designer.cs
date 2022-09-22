namespace AplicacaoPoo.Estrutural.Windows
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.btnConverterDolar = new System.Windows.Forms.Button();
            this.btnComissãoDoVendedor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnConverterDolar
            // 
            this.btnConverterDolar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConverterDolar.Image = ((System.Drawing.Image)(resources.GetObject("btnConverterDolar.Image")));
            this.btnConverterDolar.Location = new System.Drawing.Point(12, 40);
            this.btnConverterDolar.Name = "btnConverterDolar";
            this.btnConverterDolar.Size = new System.Drawing.Size(131, 132);
            this.btnConverterDolar.TabIndex = 0;
            this.btnConverterDolar.Text = "Converter Dolar";
            this.btnConverterDolar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnConverterDolar.UseVisualStyleBackColor = true;
            this.btnConverterDolar.Click += new System.EventHandler(this.btnConverterDolar_Click);
            // 
            // btnComissãoDoVendedor
            // 
            this.btnComissãoDoVendedor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnComissãoDoVendedor.Image = ((System.Drawing.Image)(resources.GetObject("btnComissãoDoVendedor.Image")));
            this.btnComissãoDoVendedor.Location = new System.Drawing.Point(233, 40);
            this.btnComissãoDoVendedor.Name = "btnComissãoDoVendedor";
            this.btnComissãoDoVendedor.Size = new System.Drawing.Size(124, 132);
            this.btnComissãoDoVendedor.TabIndex = 1;
            this.btnComissãoDoVendedor.Text = "Comissão";
            this.btnComissãoDoVendedor.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnComissãoDoVendedor.UseVisualStyleBackColor = true;
            this.btnComissãoDoVendedor.Click += new System.EventHandler(this.btnComissãoDoVendedor_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 207);
            this.Controls.Add(this.btnComissãoDoVendedor);
            this.Controls.Add(this.btnConverterDolar);
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.Text = "Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnConverterDolar;
        private Button btnComissãoDoVendedor;
    }
}