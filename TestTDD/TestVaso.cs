using Proyecto_TDD;

namespace TestTDD
{
    [TestClass]
    public class TestVaso
    {
        [TestMethod]
        public void DeberiaDevolverVerdaderoSiExistenVasos()
        {
            Vaso vasosPequenos = new Vaso(2, 10);

            bool resultado = vasosPequenos.HasVasos(1);

            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public void DeberiaDevolverFalsoSiNoExistenVasos()
        {
            Vaso vasosPequenos = new Vaso(1, 10);

            bool resultado = vasosPequenos.HasVasos(2);

            Assert.IsFalse(resultado);
        }

        [TestMethod]
        public void DeberiaRestarCantidadDeVasos()
        {
            Vaso vasosPequenos = new Vaso(5, 10);

            vasosPequenos.GiveVasos(1);

            Assert.AreEqual(4, vasosPequenos.GetCantidadDeVasos());
        }
    }
}