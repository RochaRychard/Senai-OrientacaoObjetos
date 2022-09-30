
using AplicacaoPoo.Dominio;
using AplicacaoPoo.Dominio.services;
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
           // var preco = decimal.Parse(cmbCodigoDaPeca.Text);
            switch (cmbCodigoDaPeca.SelectedValue)
            {
                case CodigoDaPeca.Prod1:
                    {
                        txtValorUnitario.Text = $"{CodigoDaPeca.Preco1}";
                        break;
                    }

                case CodigoDaPeca.Prod2:
                case CodigoDaPeca.Prod3:
                    {
                        txtValorUnitario.Text = $"{CodigoDaPeca.Preco3}";
                        break;
                    }
                case CodigoDaPeca.Prod4:
                    {
                        txtValorUnitario.Text = $"{CodigoDaPeca.Preco4}";
                        break;
                    }
                case CodigoDaPeca.Prod5:
                    {
                        txtValorUnitario.Text = $"{CodigoDaPeca.Preco5}";
                        break;
                    }
                case CodigoDaPeca.Prod6:
                    {
                        txtValorUnitario.Text = $"{CodigoDaPeca.Preco6}";
                        break;
                    }
                case CodigoDaPeca.Prod7:
                    {
                        txtValorUnitario.Text = $"{CodigoDaPeca.Preco7}";
                        break;
                    }
                case CodigoDaPeca.Prod8:
                    {
                        txtValorUnitario.Text = $"{CodigoDaPeca.Preco8}";
                        break;
                    }
                case CodigoDaPeca.Prod9:
                    {
                        txtValorUnitario.Text = $"{CodigoDaPeca.Preco9}";
                        break;
                    }
                case CodigoDaPeca.Prod10:   
                    {
                        txtValorUnitario.Text = $"{CodigoDaPeca.Preco10}";
                        break;
                    }
            }
        }

        private void cmbCodigoDaPeca_SelectedIndexChanged(object sender, EventArgs e)
        {
            VerificarcmbCodigoEPreco();
        }
    }
}
