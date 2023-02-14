using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prepa_02
{
    class Program
    {
        static void Main(string[] args)
        {
    
            Vector my_vector = new Vector(1,2,5,7);
            Vector my_vector_2 = new Vector(3,4,2,6);
            Vector vector_resultado = new Vector();
            double multiplicacion_vectores;

            Console.WriteLine("Información de vector 1\n");
            my_vector.mostrar_info();

            Console.WriteLine("Información de vector 2\n");
            my_vector_2.mostrar_info();

            Console.WriteLine("--------------------------");

            Console.WriteLine("Suma de vectores: ");
            vector_resultado = my_vector + my_vector_2;
            Console.WriteLine("Información de vector resultado");
            vector_resultado.mostrar_info();

            Console.WriteLine("--------------------------");

            Console.WriteLine("Resta de vectores: ");
            vector_resultado = my_vector - my_vector_2;
            Console.WriteLine("Información de vector resultado");
            vector_resultado.mostrar_info();

            Console.WriteLine("--------------------------");

            Console.WriteLine("Multiplicación de vectores: ");
            multiplicacion_vectores = my_vector * my_vector_2;
            Console.WriteLine($"El resultado de la multiplicación es {multiplicacion_vectores}\n");

            Console.WriteLine("--------------------------");

            Console.WriteLine("Multiplicación de vector 1 por un escalar: ");
            vector_resultado = my_vector * 2;
            vector_resultado.mostrar_resultado();

            Console.ReadLine();
        }
    }
}
