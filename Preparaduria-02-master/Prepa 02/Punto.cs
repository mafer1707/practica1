using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prepa_02
{
    class Punto
    {
        private double x;
        private double y;
        public Punto()
        {

        }
        public Punto(double _x, double _y)
        {
            x = _x;
            y = _y;
        }

        public void SetX(double _x)
        {
            x = _x;
        }
        public void SetY(double _y)
        {
            y = _y;
        }
        public double GetX()
        {
            return x;
        }
        public double GetY()
        {
            return y;
        }

        ~Punto()
        {
            Console.WriteLine($"\nMe estoy destruyendo ({x},{y})");
            //Console.ReadLine();
        }
    }
}
