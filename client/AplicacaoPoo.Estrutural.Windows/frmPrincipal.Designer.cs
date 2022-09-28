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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.conversorDeMoedasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comissionamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
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
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.conversorDeMoedasToolStripMenuItem,
            this.comissionamentoToolStripMenuItem,
            this.cadastrosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(368, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // conversorDeMoedasToolStripMenuItem
            // 
            this.conversorDeMoedasToolStripMenuItem.Name = "conversorDeMoedasToolStripMenuItem";
            this.conversorDeMoedasToolStripMenuItem.Size = new System.Drawing.Size(134, 20);
            this.conversorDeMoedasToolStripMenuItem.Text = "Conversor de Moedas";
            this.conversorDeMoedasToolStripMenuItem.Click += new System.EventHandler(this.conversorDeMoedasToolStripMenuItem_Click);
            // 
            // comissionamentoToolStripMenuItem
            // 
            this.comissionamentoToolStripMenuItem.Name = "comissionamentoToolStripMenuItem";
            this.comissionamentoToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.comissionamentoToolStripMenuItem.Text = "Comissionamento";
            this.comissionamentoToolStripMenuItem.Click += new System.EventHandler(this.comissionamentoToolStripMenuItem_Click);
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.funcionáriosToolStripMenuItem});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // funcionáriosToolStripMenuItem
            // 
            this.funcionáriosToolStripMenuItem.Name = "funcionáriosToolStripMenuItem";
            this.funcionáriosToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.funcionáriosToolStripMenuItem.Text = "Funcionários";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 195);
            this.Controls.Add(this.btnComissãoDoVendedor);
            this.Controls.Add(this.btnConverterDolar);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.Text = "Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnConverterDolar;
        private Button btnComissãoDoVendedor;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem conversorDeMoedasToolStripMenuItem;
        private ToolStripMenuItem comissionamentoToolStripMenuItem;
        private ToolStripMenuItem cadastrosToolStripMenuItem;
        private ToolStripMenuItem clientesToolStripMenuItem;
        private ToolStripMenuItem funcionáriosToolStripMenuItem;
    }
}