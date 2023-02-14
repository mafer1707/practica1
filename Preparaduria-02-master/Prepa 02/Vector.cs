using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prepa_02
{
    class Vector
    {
        Punto origen;
        Punto fin;
        double magnitud;

        public Vector()
        {
            origen = new Punto(0, 0);
            fin = new Punto(1, 1);
            calcular_magnitud();
        }
        public Vector(double x, double y)
        {
            origen = new Punto(x, y);
            fin = new Punto(x, y);
            calcular_magnitud();
        }
        public Vector(Punto _origen, Punto _fin)
        {
            origen = new Punto(_origen.GetX(), _origen.GetY());
            fin = new Punto(_fin.GetX(), _fin.GetY());
            calcular_magnitud();
        }
        public Vector(double x_origen, double y_origen, double x_fin, double y_fin)
        {
            origen = new Punto(x_origen, y_origen);
            fin = new Punto(x_fin, y_fin);
            calcular_magnitud();
        }
        private void calcular_magnitud()
        {
            magnitud = Math.Sqrt(Math.Pow((fin.GetX() - origen.GetX()), 2) + Math.Pow((fin.GetY() - origen.GetY()), 2));
        }
        public double get_magnitud()
        {
            return magnitud;
        }

        public void set_origen(Punto _origen)
        {
            origen = new Punto(_origen.GetX(), _origen.GetY());
            calcular_magnitud();
        }
        public void set_origen(double x, double y)
        {
            origen = new Punto(x, y);
            calcular_magnitud();
        }

        //********** setter punto fin ********************

        public void set_fin(Punto _fin)
        {
            fin = new Punto(_fin.GetX(), _fin.GetY());
            calcular_magnitud();
        }
        public void set_fin(double x, double y)
        {
            fin = new Punto(x, y);
            calcular_magnitud();
        }

        //******** resta de vectores****************
        public static Vector operator -(Vector restando1, Vector restando2)
        {
            Punto nuevo_origen = new Punto(restando1.origen.GetX() - restando2.origen.GetX(),
                                           restando1.origen.GetY() - restando2.origen.GetY());

            Punto nuevo_fin = new Punto(restando1.fin.GetX() - restando2.fin.GetX(),
                                        restando1.fin.GetY() - restando2.fin.GetY());


            return new Vector(nuevo_origen, nuevo_fin);
        }

        //********* multiplicación de vectores *************

        public static double operator *(Vector multiplicar1, Vector multiplicar2)
        {
            Punto vector1 = new Punto(multiplicar1.fin.GetX() - multiplicar1.origen.GetX(),
                                      multiplicar1.fin.GetY() - multiplicar1.origen.GetY());

            Punto vector2 = new Punto(multiplicar2.fin.GetX() - multiplicar2.origen.GetX(),
                                      multiplicar2.fin.GetY() - multiplicar2.origen.GetY());

            double resultado = (vector1.GetX() * vector2.GetX() + vector1.GetY() * vector2.GetY());

            return resultado;
        }

        //********** multiplicación por un escalar *****************
        public static Vector operator *(Vector vector_multiplicacion, double valor)
        {
            Punto vector = new Punto(vector_multiplicacion.fin.GetX() - vector_multiplicacion.origen.GetX(),
                                     vector_multiplicacion.fin.GetY() - vector_multiplicacion.origen.GetY());

            double x = valor * vector.GetX();
            double y = valor * vector.GetY();

            return new Vector(x, y);
        }


        //********** Imprimir vector***********
        public void mostrar_info()
        {
            Console.WriteLine($"Punto de Origen: {origen.GetX()},{origen.GetY()}\n Punto fin: {fin.GetX()},{fin.GetY()}\n Magnitud: {magnitud}\n");
        }

        //********* Imprimir multiplicación por escalar**********************
        public void mostrar_resultado()
        {
            Console.WriteLine($"Resultado de la multiplicación: Vector ({origen.GetX()},{origen.GetY()})\n");
        }



        public static Vector operator +(Vector sumando1, Vector sumando2)
        {
            Punto nuevo_origen = new Punto(sumando1.origen.GetX() + sumando2.origen.GetX(),
                                           sumando1.origen.GetY() + sumando2.origen.GetY());

            Punto nuevo_fin = new Punto(sumando1.fin.GetX() + sumando2.fin.GetX(),
                                        sumando1.fin.GetY() + sumando2.fin.GetY());


            return new Vector(nuevo_origen, nuevo_fin);
        }
    }
}
