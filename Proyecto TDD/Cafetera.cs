namespace Proyecto_TDD
{
    public class Cafetera
    {
        private int _CantidadDeCafe;

        public void SetCantidadDeCafe(int cantidadDeCafe)
        {
            _CantidadDeCafe = cantidadDeCafe;
        }
        public int GetCantidadDeCafe()
        {
            return _CantidadDeCafe;
        }
        public bool HasCafe(int cantidadDeCafe)
        {
            return _CantidadDeCafe >= cantidadDeCafe;
        }
        public void GiveCafe(int cantidadDeCafe)
        {
            _CantidadDeCafe -= cantidadDeCafe;
        }
        public Cafetera(int cantidadDeCafe)
        {
            _CantidadDeCafe = cantidadDeCafe;
        }
    }
}
