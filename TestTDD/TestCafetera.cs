using Microsoft.VisualStudio.TestTools.UnitTesting;
using Proyecto_TDD;

namespace TestTDD
{
    [TestClass]
    public class TestCafetera
    {
        [TestMethod]
        public void DeberiaDevolverVerdaderoSiExisteCafe()
        {
            Cafetera cafetera = new Cafetera(10);

            bool resultado = cafetera.HasCafe(5);

            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public void DeberiaDevolverFalsoSiNoExisteCafe()
        {
            Cafetera cafetera = new Cafetera(10);

            bool resultado = cafetera.HasCafe(11);

            Assert.IsFalse(resultado);
        }

        [TestMethod]
        public void DeberiaRestarCafeAlaCafetera()
        {
            Cafetera cafetera = new Cafetera(10);

            cafetera.GiveCafe(7);

            Assert.AreEqual(3, cafetera.GetCantidadDeCafe());
        }

    }
}
