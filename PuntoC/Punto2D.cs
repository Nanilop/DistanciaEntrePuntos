using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoC
{
    public class Punto2D:Punto
    {
        protected int _y;

       
        public int Y
        {
            get { return _y; }
            set { _y = value; }
        }

        public Punto2D()
        {
            _x = 0;
            _y = 0;
        }

        public Punto2D(int x, int y)
        {
            _x = x;
            _y = y;
        }
        public override string ToString()
        {
            return "(" + _x + "," + _y + ")";
        }
        public double Distancia(Punto2D p)
        {
            double resultado = 0;
            double xp = (_x - p.X) * (_x - p.X);
            double yp = (_y - p.Y)* (_y - p.Y);
            resultado = Math.Sqrt(xp+yp);
            return resultado;
        }
    }
}
