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

            //coloca os valores da nossa classe dentro do combobox.
            var list = new List<string>();
            list.Add(MoedaHelper.Dolar);
            list.Add(MoedaHelper.Euro);
            list.Add(MoedaHelper.Libra);
            cmbMoedas.DataSource = list;
            cmbMoedas.SelectedIndex = 0;

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
        
        

        private void cmbMoedas_SelectedIndexChanged(object sender, EventArgs e)
        {
            //var quantidadeDolar = decimal.Parse(txtQuantidadeDolar.Text);

            //var moeda = new ConverterMoedaService();
            //var resultado = moeda.CoverterDolarEmReal(quantidadeDolar);
            if (txtQuantidadeDolar.Text == "") return;
            var quantidadeDolar = decimal.Parse(txtQuantidadeDolar.Text);
            var moedaService = new ConverterMoedaService();
            
            switch (cmbMoedas.SelectedValue)
            {
                //CTRL + K + C (Comenta todo código selecionado)
                //CTRL + K + U (Descomenta todo código selecionado)
                #region MEU PROGRAMA

                //case 0:
                //    lblPrimeiroValor.Text = $"{quantidadeDolar} {MoedaHelper.Dolar} igual a";
                //    lblSegundoValor.Text = $"{resultado} {MoedaHelper.Real}";

                //    break;

                //case 1:

                //    lblPrimeiroValor.Text = $"{quantidadeEuro} {MoedaHelper.Euro} igual a";
                //    lblSegundoValor.Text = $"{resultado} {MoedaHelper.Real}";

                //    break;

                //case 2:
                //    lblPrimeiroValor.Text = $"{quantidadeLibra} {MoedaHelper.Libra} igual a";
                //    lblSegundoValor.Text = $"{resultado} {MoedaHelper.Real}";

                //    break;
                #endregion
                case MoedaHelper.Dolar:
                    {
                        var valorConvertido = 
                        moedaService.CoverterDolarEmReal(quantidadeDolar);
                        lblPrimeiroValor.Text = $"{quantidadeDolar} {MoedaHelper.Dolar} igual a";
                        lblSegundoValor.Text = $"{valorConvertido} {MoedaHelper.Real}";
                        break;
                    }
                case MoedaHelper.Euro:
                    {
                        var valorConvertido =
                        moedaService.CoverterEuroEmReal(quantidadeDolar);
                        lblPrimeiroValor.Text = $"{quantidadeDolar} {MoedaHelper.Euro} igual a";
                        lblSegundoValor.Text = $"{valorConvertido} {MoedaHelper.Real}";
                        break;
                    }
                case MoedaHelper.Libra:
                    {
                        var valorConvertido =
                        moedaService.CoverterLibrasEmReal(quantidadeDolar);
                        lblPrimeiroValor.Text = $"{quantidadeDolar} {MoedaHelper.Libra} igual a";
                        lblSegundoValor.Text = $"{valorConvertido} {MoedaHelper.Real}";
                        break;
                    }
            }
        }
    }
}
