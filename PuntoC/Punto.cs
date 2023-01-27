using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoC
{
    public class Punto
    {
        private int _x;
        private int _y;

        public int X
        {
            get { return _x; }
            set { _x = value; }
        }
        public int Y
        {
            get { return _y; }
            set { _y = value; }
        }

        public Punto()
        {
            _x = 0;
            _y = 0;
        }

        public Punto(int x, int y)
        {
            _x = x;
            _y = y;
        }
        public double Distancia(Punto p)
        {
            double resultado = 0;
            double xp = (_x - p.X) * (_x - p.X);
            double yp = (_y - p.Y)* (_y - p.Y);
            resultado = Math.Sqrt(xp+yp);
            return resultado;
        }
    }
}
