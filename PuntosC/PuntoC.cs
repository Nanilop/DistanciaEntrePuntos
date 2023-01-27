using System.Security.Cryptography.X509Certificates;

namespace PuntosC
{
    public class PuntoC
    {
        private int _x;
        private int _y;

        public int X {
            get { return _x; }
            set { _x = value; }
        }
        public int Y
        {
            get { return _y; }
            set { _y = value; }
        }

        public PuntoC()
        {
            _x= 0;  
            _y= 0;
        }

        public PuntoC(int x, int y)
        {
            _x = x;
            _y = y;
        }
        public double Distancia(PuntoC p) {
            double resultado=0;
            resultado = Math.Sqrt(Math.Pow((_x-p.X),2)+ Math.Pow((_y - p.Y), 2));
            return resultado;
        }

    }
}