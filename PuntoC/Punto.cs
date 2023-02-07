using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoC
{
    public class Punto
    {
        protected int _x;
        public int X
        {
            get { return _x; }
            set { _x = value; }
        }
        public Punto()
        {
            _x = 0;
        }

        public Punto(int x)
        {
            _x = x;
        }
        public override string ToString()
        {
            return "(" + _x + ")";
        }
        public double Distancia(Punto p)
        {
            double resultado = (_x - p.X);
            return resultado;
        }
    }
}
