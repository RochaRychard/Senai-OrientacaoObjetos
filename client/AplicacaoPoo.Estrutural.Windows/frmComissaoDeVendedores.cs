using AplicacaoPoo.Dominio;
using Microsoft.VisualBasic.Logging;
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
            btnCalcular.Enabled = false;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                var valorUnitario = float.Parse(txtValorUnitario.Text);
                var quantidadeVendida = int.Parse(txtQuantidadeVendida.Text);
                var idVendedor = txtIdDoVendedor.Text;
                //var codPeca = txtCodigoDaPeca.Text;
                var calcula = new ComissaoVendas();
                lblResposta.Text = (" Vendedor(a): " + idVendedor + " terá a comissão de R$" + calcula.ComissionarVendas(valorUnitario, quantidadeVendida) + " Reais.");
                lblResposta.Visible = true;
                txtIdDoVendedor.Text = String.Empty;
                txtCodigoDaPeca.Text = String.Empty;
                txtValorUnitario.Text = String.Empty;
                txtQuantidadeVendida.Text = String.Empty;
            }
            catch (Exception)
            {
                MessageBox.Show("Todos os campos precisam ser preenchidos!");
                btnCalcular.Enabled = false;
            }
        }
        private void VerificarSeTextBoxFoiPreenchido(object sender, EventArgs e)
        {
            if (txtIdDoVendedor.Text != "" & txtCodigoDaPeca.Text != "" &
                txtValorUnitario.Text != "" & txtQuantidadeVendida.Text != "")
            {
                btnCalcular.Enabled = true;
            }

        }
        private void VerificarTxtValorUnitarioPreenchido()
        {
            try
            {
                var valorUnitario = float.Parse(txtValorUnitario.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Você precisa informar um valor numérico!");
                txtValorUnitario.Text = String.Empty;
                txtValorUnitario.Focus();
            }
            try
            {
                var valorUnitario = float.Parse(txtQuantidadeVendida.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Você precisa informar um valor numérico!");
                txtQuantidadeVendida.Text = String.Empty;
                txtQuantidadeVendida.Focus();
            }
        }

        private void VerificarTxtQuantidadeVendidaPreenchido()
        {
            try
            {
                var valorUnitario = float.Parse(txtQuantidadeVendida.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Você precisa informar um valor numérico!");
                txtQuantidadeVendida.Text = String.Empty;
                txtQuantidadeVendida.Focus();
            }
        }

        private void frmComissaoDeVendedores_TextChanged(object sender, EventArgs e)
        {
            VerificarTxtValorUnitarioPreenchido();
        }

        private void txtQuantidadeVendida_TextChanged(object sender, EventArgs e)
        {
            VerificarTxtQuantidadeVendidaPreenchido();
        }
    }
}
