using ConsoleApp1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void TestRemoveDoCopoVazio() // remove 100ml do copo vazio, continua vazio
        {
            Copo copo = new Copo(200);
            Assert.AreEqual(copo.remover(100), Constants.Constants.VAZIO);
        }

        [TestMethod]
        public void TestAdiciona180mlNoCopoDe200()
        {
            Copo copo = new Copo(200); // 200 é a capacidade do copo
            CocaCola coca = new CocaCola(2000, 5.5);            
            Assert.AreEqual(copo.adicionar(180, coca), 180.ToString());
        }

        [TestMethod]
        public void TestCopoTransbordado()
        {
            Copo copo = new Copo(200);
            CocaCola coca = new CocaCola(2000, 5.5);
            Assert.AreEqual(copo.adicionar(300, coca), Constants.Constants.TRANSBORDOU);
        }

        [TestMethod]
        public void TestRemoveDoCopoComConteudo() // remove 50ml do copo com 150ml
        {
            Copo copo = new Copo(200);
            copo.quantidade = 150;
            double sub = copo.quantidade - 50;
            Assert.AreEqual(copo.remover(50), sub.ToString());
        }

        [TestMethod]
        public void AdicionaCocaColaComGarrafaVazia() 
        {
            Copo copo = new Copo(200);
            CocaCola coca = new CocaCola(2000, 5.5);
            coca.quantidade = 0;
            Assert.AreEqual(copo.adicionar(50, coca), Constants.Constants.ORIGEM_VAZIA);
        }

        [TestMethod]
        public void AdicionaCocaColaComQuantidade()
        {
            Copo copo = new Copo(200);
            CocaCola coca = new CocaCola(2000, 5.5);
            coca.quantidade = 1000;
            Assert.AreNotEqual(copo.adicionar(50, coca), Constants.Constants.ORIGEM_VAZIA);
        }
    }
}