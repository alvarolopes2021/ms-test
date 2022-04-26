using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class CocaCola : Liquido
    {        
        public CocaCola(double capacidade, double preco)
        {
            this.capacidade = capacidade;
            this.quantidade = capacidade; // garrafa cheia
            this.preco = preco;
        }

        public override double removeLiquido(double quantidade)
        {
            if (quantidade == 0) //tenta remover nada da garrafa
                return -1;

            double sub = this.quantidade - quantidade;

            if (sub <= 0)
            {
                return -1;
            }

            return sub;
        }
    }
}
