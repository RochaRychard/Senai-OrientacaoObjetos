
using AplicacaoPoo.Dominio;
using AplicacaoPoo.Dominio.services;
using AplicacaoPoo.Dominio.Services;
using Microsoft.VisualBasic.Logging;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AplicacaoPoo.Estrutural.Windows
{
    public partial class frmComissaoDeVendedores : Form
    {
        public frmComissaoDeVendedores()
        {
            InitializeComponent();
            btnCalcular.Enabled = false;
            
            var vendedor = new VendedorService();
            cmbVendedores.DataSource = vendedor.ListaDEVendedores();   
            cmbVendedores.DisplayMember = "Nome";
            
            

            var produto = new ProdutoService();
            cmbCodigoDaPeca.DataSource = produto.ListagemProdutosFake();
            cmbCodigoDaPeca.DisplayMember = "Nome";
            cmbCodigoDaPeca.ValueMember = "Id";
            /*
            var listaVendedor = new List<string>();
            listaVendedor.Add(ListaDeVendedores.Nome0);
            listaVendedor.Add(ListaDeVendedores.Nome1);
            listaVendedor.Add(ListaDeVendedores.Nome2);
            listaVendedor.Add(ListaDeVendedores.Nome3);
            listaVendedor.Add(ListaDeVendedores.Nome4);
            listaVendedor.Add(ListaDeVendedores.Nome5);
            listaVendedor.Add(ListaDeVendedores.Nome6);
            listaVendedor.Add(ListaDeVendedores.Nome7);
            listaVendedor.Add(ListaDeVendedores.Nome8);
            listaVendedor.Add(ListaDeVendedores.Nome9);
            listaVendedor.Add(ListaDeVendedores.Nome10);
            cmbVendedores.DataSource = listaVendedor;
            cmbVendedores.SelectedIndex = 0;
            
            var codPeca = new List<string>();
            codPeca.Add(CodigoDaPeca.Prod0);
            codPeca.Add(CodigoDaPeca.Prod1);
            codPeca.Add(CodigoDaPeca.Prod2);
            codPeca.Add(CodigoDaPeca.Prod3);
            codPeca.Add(CodigoDaPeca.Prod4);
            codPeca.Add(CodigoDaPeca.Prod5);
            codPeca.Add(CodigoDaPeca.Prod6);
            codPeca.Add(CodigoDaPeca.Prod7);
            codPeca.Add(CodigoDaPeca.Prod8);
            codPeca.Add(CodigoDaPeca.Prod9);
            codPeca.Add(CodigoDaPeca.Prod10);
            cmbCodigoDaPeca.DataSource = codPeca;
            cmbCodigoDaPeca.SelectedIndex = 0;  
            */


        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                var valorUnitario = float.Parse(txtValorUnitario.Text);
                var quantidadeVendida = int.Parse(txtQuantidadeVendida.Text);
                
                //var codPeca = txtCodigoDaPeca.Text;
                var calcula = new ComissaoVendas();
                lblResposta.Text = (" Vendedor(a): " + cmbVendedores + " terá a comissão de R$" + calcula.ComissionarVendas(valorUnitario, quantidadeVendida) + " Reais.");
                lblResposta.Visible = true;
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


        private void VerificarcmbCodigoEPreco()
        {
            var produtoSelecionado = (Produtos)cmbCodigoDaPeca.SelectedValue;
            var produto = new ProdutoService();
            var produtosFake = produto.ListagemProdutosFake();

            var dado = produtosFake.Where(x => x.Id == produtoSelecionado.Id).FirstOrDefault();
            txtValorUnitario.Text = dado.ValorUnitario.ToString();
            
        }

    }
}
