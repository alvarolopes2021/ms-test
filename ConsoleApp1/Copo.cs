using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Copo
    {
        public float capacidade = 250;

        public float quantidade = 0;

        public String adicionar(float quantidade)
        {
            if (quantidade == 0)
                return string.Empty;

            float soma = this.quantidade += quantidade;

            if (soma > this.capacidade)
                return Constants.Constants.TRANSBORDOU;

            return soma.ToString();
        }



    }
}
