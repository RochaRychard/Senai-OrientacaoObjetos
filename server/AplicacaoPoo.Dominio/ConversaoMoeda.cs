using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacaoPoo.Dominio
{
    public class ConversaoMoeda
    {
        public float DolarParaReal(float cotacaoAtual, float quantidadeDolar)
        {
            float valorReal = quantidadeDolar * cotacaoAtual;
            return valorReal;
        }

    }
}
