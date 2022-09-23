using AplicacaoPoo.Dominio;
using AplicacaoPoo.Dominio.Helpers;
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
            lblPrimeiroValor.Text = $"1 {MoedaHelper.Dolar} igual a";
            lblSegundoValor.Text = $"5,12 {MoedaHelper.Real}";

        }


        private void txtQuantidadeDolar_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                if (txtQuantidadeDolar.Text == "") return;

                var quantidadeDolar = decimal.Parse(txtQuantidadeDolar.Text);

                var moeda = new ConverterMoedaService();
                var resultado = moeda.CoverterDolarEmReal(quantidadeDolar);

                lblPrimeiroValor.Text = $"{quantidadeDolar} {MoedaHelper.Dolar} igual a";
                lblSegundoValor.Text = $"{resultado} {MoedaHelper.Real}";


            }
            catch (Exception)
            {
                MessageBox.Show("A quantidade de dólar deve ser um valor decimal!");
                txtQuantidadeDolar.Focus();
            }
        }
    }
}
