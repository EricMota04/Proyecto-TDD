using Proyecto_TDD;

namespace TestTDD
{
    [TestClass]
    public class TestAzucarero
    {
        private Azucarero azucarero;
        [TestInitialize]
        public void SetUp()
        {
            azucarero = new Azucarero(10);
        }

        [TestMethod]
        public void DeberiaDevolverVerdaderoSiHaySuficienteAzucarEnElAzucarero()
        {
            bool resultado = azucarero.HasAzucar(5);

            Assert.IsTrue(resultado);

            resultado = azucarero.HasAzucar(10);

            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public void DeberiaDevolverFalsoSiNoHaySuficienteAzucarEnElAzucarero()
        {
            bool resultado = azucarero.HasAzucar(15);

            Assert.IsFalse(resultado);
        }
        [TestMethod]
        public void DeberiaRestarAzucarAlAzucarero()
        {
            azucarero.GiveAzucar(5);

            Assert.AreEqual(5, azucarero.GetCantidadDeAzucar());

            azucarero.GiveAzucar(3);

            Assert.AreEqual(2, azucarero.GetCantidadDeAzucar());
        }

    }
}
