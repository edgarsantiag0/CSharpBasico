using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasico
{
    class Loops
    {
        static void Main(string[] args)
        {
            // Estructura repetitiva while

            int valor = 1;

            while (valor <= 100)
            {
                Console.WriteLine("El valor es: " + valor);
                valor++; // valor = valor + 1;
            }

            Console.WriteLine("Termina el while");

            // Introduzca un limite inferior [li]
            // Introduzca un limite superior [ls]

            //5 10 = 5 6 7 8 9 10

            // Imprimir los numeros [li - ls]
            Console.WriteLine();
            Console.WriteLine("For ... ");

            for (int i = 0; i <= 50; i++)
            {
                Console.WriteLine("El valor de i es: " + i);
            }

            int suma = 0, value, promedio;

            int cantidadIngresos = 5;

            for (int i = 0; i < cantidadIngresos; i++)
            {
                Console.WriteLine("Ingrese valor:");
                value = int.Parse(Console.ReadLine());
                suma = suma + value;
            }

            Console.WriteLine("La suma es: " + suma);
            Console.WriteLine();
            Console.WriteLine("El promedio es: " + suma / cantidadIngresos);

            var entero = 0;

            // DO WHILE

            do
            {
                entero++;
                // Otras Operaciones

            } while (entero < 10);

        }


        
    }
}
