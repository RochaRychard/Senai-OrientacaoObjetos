using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacaoPoo.Estrutural.Windows
{
    public partial class frmComissaoDeVendedores : Form
    {
        public frmComissaoDeVendedores()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            float valorUnitario = float.Parse(txtValorUnitario.Text);
            int quantidadeVendida = int.Parse(txtQuantidadeVendida.Text);
            var total = valorUnitario * quantidadeVendida;
            var comissao = total * 0.05;
            MessageBox.Show("Comissão de R$" + comissao + " Reais.");
        }
    }
}
