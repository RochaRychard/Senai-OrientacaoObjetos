﻿using AplicacaoPoo.Dominio;
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
        }

        private void btnConverter_Click(object sender, EventArgs e)
        {
            var cotacaoAtual = float.Parse(txtCotacaoAtual.Text);
            var quantidadeDolar = float.Parse(txtQuantidadeDolar.Text);
            var conversor = new ConversaoMoeda();

            MessageBox.Show("US$" + quantidadeDolar + " dólares convertido é igual a: R$" + conversor.DolarParaReal(float.Parse(txtCotacaoAtual.Text), float.Parse(txtQuantidadeDolar.Text)) + " Reais.");
        }
    }
}
