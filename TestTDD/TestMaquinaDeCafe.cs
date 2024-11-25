using Proyecto_TDD;

namespace TestTDD
{
    [TestClass]
    public class TestMaquinaDeCafe
    {
        private Cafetera _Cafetera;
        private Vaso _VasosPequeno;
        private Vaso _VasosMediano;
        private Vaso _VasosGrande;
        private Azucarero _Azucarero;
        private MaquinaDeCafe _MaquinaDeCafe;

        [TestInitialize]
        public void SetUp()
        {
            _Cafetera = new Cafetera(50);
            _VasosPequeno = new Vaso(5, 10);
            _VasosMediano = new Vaso(5, 20);
            _VasosGrande = new Vaso(5, 30);
            _Azucarero = new Azucarero(20);

            _MaquinaDeCafe = new MaquinaDeCafe();

            _MaquinaDeCafe.SetCafetera(_Cafetera);
            _MaquinaDeCafe.SetVasoGrande(_VasosGrande);
            _MaquinaDeCafe.SetVasoPequeno(_VasosPequeno);
            _MaquinaDeCafe.SetVasoMediano(_VasosMediano);
            _MaquinaDeCafe.SetAzucarero(_Azucarero);
        }

        [TestMethod]
        public void DeberiaDevolverUnVasoPequeno()
        {
            Vaso vaso = _MaquinaDeCafe.GetTipoDeVaso("pequeno");

            Assert.AreEqual(_MaquinaDeCafe.GetVasoPequeno(), vaso);
        }
        [TestMethod]
        public void DeberiaDevolverUnVasoMediano()
        {
            Vaso vaso = _MaquinaDeCafe.GetTipoDeVaso("mediano");

            Assert.AreEqual(_MaquinaDeCafe.GetVasoMediano(), vaso);
        }
        [TestMethod]
        public void DeberiaDevolverUnVasoGrande()
        {
            Vaso vaso = _MaquinaDeCafe.GetTipoDeVaso("grande");

            Assert.AreEqual(_MaquinaDeCafe.GetVasoGrande(), vaso);
        }
        [TestMethod]
        public void DeberiaDevolverNoHayVasos()
        {
            Vaso vaso = _MaquinaDeCafe.GetTipoDeVaso("pequeno");

            string resultado = _MaquinaDeCafe.GetVasoDeCafe(vaso, 10, 2);

            Assert.AreEqual("No hay Vasos", resultado);

        }

        [TestMethod]
        public void DeberiaDevolverNoHayCafe()
        {
            var cafetera = new Cafetera(5);
            _MaquinaDeCafe.SetCafetera(cafetera);

            Vaso vaso = _MaquinaDeCafe.GetTipoDeVaso("pequeno");

            string resultado = _MaquinaDeCafe.GetVasoDeCafe(vaso, 1, 2);

            Assert.AreEqual("No hay Cafe", resultado);
        }
        [TestMethod]
        public void DeberiaDevolverNoHayAzucar()
        {
            var azucarero = new Azucarero(2);
            _MaquinaDeCafe.SetAzucarero(azucarero);

            Vaso vaso = _MaquinaDeCafe.GetTipoDeVaso("pequeno");

            string resultado = _MaquinaDeCafe.GetVasoDeCafe(vaso, 1, 3);

            Assert.AreEqual("No hay Azucar", resultado);
        }

        [TestMethod]
        public void DeberiaRestarCafe() 
        {
            Vaso vaso = _MaquinaDeCafe.GetTipoDeVaso("pequeno");

            _MaquinaDeCafe.GetVasoDeCafe(vaso, 1, 3);

            int resultado = _MaquinaDeCafe.GetCafetera().GetCantidadDeCafe();

            Assert.AreEqual(40, resultado);
        }
        [TestMethod]
        public void DeberiaRestarVasos()
        {
            Vaso vaso = _MaquinaDeCafe.GetTipoDeVaso("pequeno");
            _MaquinaDeCafe.GetVasoDeCafe(vaso, 1, 3);

            int resultado = _MaquinaDeCafe.GetVasoPequeno().GetCantidadDeVasos();

            Assert.AreEqual(4, resultado);
        }

        [TestMethod]
        public void DeberiaRestarAzucar()
        {
            Vaso vaso = _MaquinaDeCafe.GetTipoDeVaso("pequeno");

            _MaquinaDeCafe.GetVasoDeCafe(vaso, 1, 3);

            int resultado = _MaquinaDeCafe.GetAzucarero().GetCantidadDeAzucar();

            Assert.AreEqual(17, resultado);
        }

        [TestMethod]
        public void DeberiaDevolverFelicitaciones() 
        {
            Vaso vaso = _MaquinaDeCafe.GetTipoDeVaso("pequeno");
            string resultado = _MaquinaDeCafe.GetVasoDeCafe(vaso, 1, 3);

            Assert.AreEqual("Felicitaciones", resultado);
        }
    }
}
