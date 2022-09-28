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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnConverterDolar_Click(object sender, EventArgs e)
        {
            var form = new frmConversaoDoDolar();
            form.Show();
        }

        private void btnComissãoDoVendedor_Click(object sender, EventArgs e)
        {
            var form = new frmComissaoDeVendedores();
            form.Show();
        }

        private void comissionamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new frmComissaoDeVendedores();
            form.MdiParent = this;
            form.Show();
        }

        private void conversorDeMoedasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new frmConversaoDoDolar();
            form.MdiParent = this;
            form.Show();
        }
    }
}
