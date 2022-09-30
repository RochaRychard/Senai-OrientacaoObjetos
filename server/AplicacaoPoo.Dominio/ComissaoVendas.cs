using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacaoPoo.Dominio
{
    public class ComissaoVendas
    {
        public float ComissionarVendas(float valorUnitario, int quantidadeVendida)
        {
            float total = valorUnitario * quantidadeVendida;
            var comissao = total * 0.05;
            return (float)comissao;
        }

    }
}
