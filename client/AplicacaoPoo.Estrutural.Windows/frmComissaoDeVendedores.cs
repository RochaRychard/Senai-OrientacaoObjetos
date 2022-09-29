﻿using AplicacaoPoo.Dominio;
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
            
            

            float valorUnitario = float.Parse(txtValorUnitario.Text);
            int quantidadeVendida = int.Parse(txtQuantidadeVendida.Text);
            var idVendedor = txtIdDoVendedor.Text;
            int codPeca = int.Parse(txtCodigoDaPeca.Text);
            var total = valorUnitario * quantidadeVendida;
            var comissao = total * 0.05;
            var converte = new ComissaoVendas();
            MessageBox.Show("Vendedor de ID: " + idVendedor + " terá a comissão de R$" + converte.ComissionarVendas(valorUnitario, quantidadeVendida) + " Reais.");
        }
        private void VerificarSeTextBoxFoiPreenchido(object sender, EventArgs e)
        {
            if (txtIdDoVendedor.Text != "" & txtCodigoDaPeca.Text != "" & 
                txtValorUnitario.Text != "" & txtQuantidadeVendida.Text != "")
            {
                btnCalcular.Enabled = true;
                
            }
        } 
    }
}
