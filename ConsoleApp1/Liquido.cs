using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class Liquido
    {

        public double capacidade = 0; //quantidade em Litro

        public double preco = 0;

        public double quantidade = 0;


        public abstract double removeLiquido(double quantidade);

    }
}
