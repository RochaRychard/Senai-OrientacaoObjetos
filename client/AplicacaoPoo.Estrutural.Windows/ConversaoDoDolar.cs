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
    public partial class ConversaoDoDolar : Form
    {
        public ConversaoDoDolar()
        {
            InitializeComponent();
        }

        private void btnConverter_Click(object sender, EventArgs e)
        {
            var cotacaoAtual = float.Parse(txtCotacaoAtual.Text);
            var quantidadeDolar = float.Parse(txtQuantidadeDolar.Text);
            float valorReal = quantidadeDolar * cotacaoAtual;
             MessageBox.Show("US$" + quantidadeDolar + " dólares convertido é igual a: R$" + valorReal.ToString() + " Reais.");
        }
    }
}
