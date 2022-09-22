using AplicacaoPoo.Dominio;
using AplicacaoPoo.Dominio.services;
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
    public partial class frmConversaoDoDolar : Form
    {

        public frmConversaoDoDolar()
        {
            InitializeComponent();
            btnConverter.Enabled = false;
        }

        private void btnConverter_Click(object sender, EventArgs e)
        {
            var quantidadeDolar = decimal.Parse(txtQuantidadeDolar.Text);
            var moeda = new ConverterMoedaService();

            var resultado = moeda.CoverterDolarEmReal(quantidadeDolar);

            MessageBox.Show($"Valor convertido é: R$ {resultado} reais.");
            txtQuantidadeDolar.Clear();
        }

        private void txtQuantidadeDolar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtQuantidadeDolar.Text == "")
                {
                    btnConverter.Enabled = false;
                    return;

                }
                var resultado = decimal.Parse(txtQuantidadeDolar.Text);
                btnConverter.Enabled = true;
            }
            catch (Exception)
            {
                MessageBox.Show("A quantidade de dólar deve ser um valor decimal!");
                txtQuantidadeDolar.Focus();
                btnConverter.Enabled = false;
            }
        }
    }
}
