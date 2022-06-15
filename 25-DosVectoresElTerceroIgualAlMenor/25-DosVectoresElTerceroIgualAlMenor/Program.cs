using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _25_DosVectoresElTerceroIgualAlMenor
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };          //Otra forma de declarar un array
            int[] b = { 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 }; //En este caso no se veria la posicion de los valores ingresados
            int[] c = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };                 //Se necesitaria de un for como en el ejercicio 51
            int menorA = a[0], menorB = b[0];

            Console.WriteLine("Los valores del Primer vector son: ");
            for (int d = 0; d < a.Length; d++)
            {
                Console.WriteLine(a[d]);
                if (a[d] < menorA)
                    menorA = a[d];
            }
            Console.WriteLine("Los valores del Segundo vector son: ");
            for (int e = 0; e < b.Length; e++)
            {
                Console.WriteLine(b[e]);
                if (b[e] < menorB)
                    menorB = b[e];
            }
            Console.WriteLine("Los valores del Tercer vector son: ");
            for (int f = 0; f < c.Length; f++)
            {
                Console.WriteLine(c[f]);

                if (c[f] == menorA)
                    Console.WriteLine("Este valor coincide con el minimo de a: " + menorA);
                if (c[f] == menorB)
                    Console.WriteLine("Este valor del tercer vector coincide con el vector b: " + menorB);
            }
            Console.ReadKey();
        }
    }
}
