using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoC
{
    public class Punto3D:Punto2D
    {
        protected int _z;

        public int Z
        {
            get { return _z; }
            set { _z = value; }
        }
        public Punto3D()
        {
            _x = 0;
            _y= 0;
            _z = 0;
        }
        public Punto3D(int x, int y, int z) {
            _x = x;
            _y = y;
            _z = z;
        }
        public override string ToString()
        {
            return "("+_x+","+_y+","+_z+")";
        }
        public double Distancia(Punto3D p)
        {
            double resultado = 0;
            double xp = (_x - p.X) * (_x - p.X);
            double yp = (_y - p.Y) * (_y - p.Y);
            double zp = (_z - p.Z) * (_z - p.Z);
            resultado = Math.Sqrt(xp + yp+zp);
            return resultado;
        }
    }

}
