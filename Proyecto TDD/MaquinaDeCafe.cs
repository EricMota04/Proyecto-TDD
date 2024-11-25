namespace Proyecto_TDD
{
    public class MaquinaDeCafe
    {
        private Cafetera _Cafe;
        private Azucarero _Azucarero;
        private Vaso _VasoPequeno;
        private Vaso _VasoMediano;
        private Vaso _VasoGrande;

        public void SetCafetera(Cafetera cafe)
        {
            _Cafe = cafe;
        }
        public Cafetera GetCafetera()
        {
            return _Cafe;
        }
        public void SetAzucarero(Azucarero azucarero)
        {
            _Azucarero = azucarero;
        }
        public Azucarero GetAzucarero()
        {
            return _Azucarero;
        }
        public void SetVasoPequeno(Vaso vasoPequeno)
        {
            _VasoPequeno = vasoPequeno;
        }
        public Vaso GetVasoPequeno()
        {
            return _VasoPequeno;
        }
        public void SetVasoMediano(Vaso vasoMediano)
        {
            _VasoMediano = vasoMediano;
        }
        public Vaso GetVasoMediano()
        {
            return _VasoMediano;
        }
        public void SetVasoGrande(Vaso vasoGrande)
        {
            _VasoGrande = vasoGrande;
        }
        public Vaso GetVasoGrande()
        {
            return _VasoGrande;
        }
        public Vaso GetTipoDeVaso(string tipoDeVaso)
        {
            switch (tipoDeVaso)
            {
                case "Pequeno" or "pequeno":
                    return _VasoPequeno;
                case "Mediano" or "mediano":
                    return _VasoMediano;
                case "Grande" or "grande":
                    return _VasoGrande;
                default:
                    break;
            }
            return null;
        }

        public string GetVasoDeCafe(Vaso tipoDeVaso, int cantidadDeVasos, int cantidadDeAzucar)
        {
            if (!tipoDeVaso.HasVasos(cantidadDeVasos))
                return "No hay Vasos";
            if (!_Azucarero.HasAzucar(cantidadDeAzucar * cantidadDeVasos))
                return "No hay Azucar";
            if (!_Cafe.HasCafe(tipoDeVaso.GetContenido() * cantidadDeVasos))
                return "No hay Cafe";

            tipoDeVaso.GiveVasos(cantidadDeVasos);
            _Cafe.GiveCafe(cantidadDeVasos * tipoDeVaso.GetContenido());
            _Azucarero.GiveAzucar(cantidadDeAzucar * cantidadDeVasos);

            return "Felicitaciones";
        }
            
    }
}
