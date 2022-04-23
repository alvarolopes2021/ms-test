using ConsoleApp1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestaCopoCom200ml()
        {
            Copo copo = new Copo();
            Assert.AreEqual(copo.adicionar(200), 200.ToString());
        }

        [TestMethod]
        public void TetsCopoTransbordado()
        {
            Copo copo = new Copo();
            Assert.AreEqual(copo.adicionar(300), Constants.Constants.TRANSBORDOU);
        }
    }
}