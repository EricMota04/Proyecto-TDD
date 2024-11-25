namespace Proyecto_TDD
{
    public class Vaso
    {
        private int _CantidadDeVasos;
        private int _Contenido;

        public void SetContenido(int contenido)
        {
            _Contenido = contenido;
        }
        public int GetContenido()
        {
            return _Contenido;
        }
        public void SetCantidadDeVasos(int cantidadDeVasos)
        {
            _CantidadDeVasos = cantidadDeVasos;
        }
        public int GetCantidadDeVasos()
        {
            return _CantidadDeVasos;
        }
        public bool HasVasos(int cantidadDeVasos)
        {
            return _CantidadDeVasos >= cantidadDeVasos;
        }
        public void GiveVasos(int cantidadDeVasos)
        {
            if(HasVasos(cantidadDeVasos))
                _CantidadDeVasos -= cantidadDeVasos;
        }

        public Vaso(int cantidadDeVasos, int contenido)
        {
            _CantidadDeVasos = cantidadDeVasos;
            _Contenido = contenido;
        }
    }
}
