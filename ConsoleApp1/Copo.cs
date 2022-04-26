using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Copo
    {
        public double capacidade;

        public double quantidade = 0;

        public Liquido? liquido;
        
        public Copo(double capacidade)
        {
            this.capacidade = capacidade;
        }

        /// <summary>
        /// Retorna se o copo TRANSBORDOU ou o resultado de adicionar líquido no copo (String)
        /// </summary>
        /// <param name="quantidade"></param>
        /// <returns></returns>
        public String adicionar(double quantidade, Liquido liquido)
        {
            if (quantidade == 0) // tenta adicionar nada
                return string.Empty;

            this.liquido = liquido;

            if (liquido.quantidade == 0)
                return Constants.Constants.ORIGEM_VAZIA;

            double restoGarrafa = liquido.removeLiquido(quantidade);

            if(restoGarrafa == -1) // TENTA ADICIONAR MAIS LÍQUIDO DO QUE TEM NA GARRAFA
                return Constants.Constants.REMOVE_MAIS_QUE_ORIGEM;


            double soma = this.quantidade + quantidade;

            if (soma > this.capacidade)
                return Constants.Constants.TRANSBORDOU;

            if (soma == this.capacidade)
                return Constants.Constants.CHEIO;

            return soma.ToString();
        }

        /// <summary>
        /// Retorna se o copo está VAZIO ou o resultado de retirar líquido do copo (String)
        /// </summary>
        /// <param name="quantidade"></param>
        /// <returns></returns>
        public String remover(double quantidade)
        {
            if (quantidade == 0) //tenta remover nada
                return string.Empty;

            double sub = this.quantidade - quantidade;

            if(sub <= 0)
            {
                this.quantidade = 0;
                return Constants.Constants.VAZIO;
            }                

            return sub.ToString();
        }



    }
}
