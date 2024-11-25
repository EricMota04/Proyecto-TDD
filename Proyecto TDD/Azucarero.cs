namespace Proyecto_TDD
{
    public class Azucarero
    {
        private int _CantidadDeAzucar;

        public void SetCantidadDeAzucar(int cantidadDeAzucar)
        {
            _CantidadDeAzucar = cantidadDeAzucar;
        }
        public int GetCantidadDeAzucar()
        {
            return _CantidadDeAzucar;
        }
        public bool HasAzucar(int cantidadDeAzucar)
        {
            return _CantidadDeAzucar >= cantidadDeAzucar;
        }
        public void GiveAzucar(int cantidadDeAzucar)
        {
            _CantidadDeAzucar -= cantidadDeAzucar;
        }
        public Azucarero(int cantidadDeAzucar)
        {
            _CantidadDeAzucar = cantidadDeAzucar;
        }
    }
}
