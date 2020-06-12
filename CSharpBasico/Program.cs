using System;
using System.Runtime.Remoting.Metadata.W3cXsd2001;

namespace CSharpBasico
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            // Operadores logicos

            bool estoyTrabajando = false;

            bool estoyDurmiendo = false;

            bool estoyEstudiando = true;

            bool tengoDiezHermanos = false;

            // AND
            Console.WriteLine(estoyTrabajando && estoyDurmiendo); // False

            Console.WriteLine(estoyTrabajando && estoyEstudiando); // True

            // OR

            Console.WriteLine(estoyTrabajando || estoyDurmiendo); // True

            Console.WriteLine(estoyDurmiendo && tengoDiezHermanos); // False

            // Not

            Console.WriteLine(!estoyTrabajando); // False


            // Condicionales

            if (estoyTrabajando)
            {
                Console.WriteLine("Si, estoy trabajando");
                Console.WriteLine("Hola");

                var suma = 5 + 7;
                Console.WriteLine("La suma es: "+suma);
            }
            else
            {
                Console.WriteLine("No, no estoy trabajando");
                int resta = 10 - 5;
            
                Console.WriteLine("La resta es: "+resta);
            }

            */

            //Console.WriteLine("Ingrese un valor entre 10 y 15:");

            //// Todo lo que viene de la consola, es string
            //int valor = int.Parse(Console.ReadLine());

            //// Rango [10 - 15]
            //if((valor >= 10) && (valor <= 15))
            //{
            //    Console.WriteLine("Usted ingresó un valor >= 10 y <= 15");
            //}
            //else
            //{
            //    Console.WriteLine("Usted ingresó un valor fuera del rango.");
            //}

            //Console.WriteLine("Bienvenido a su calculadora de peso:");
            //Console.WriteLine();

            //Console.WriteLine("Ingrese su masa:");
            //float masa = float.Parse(Console.ReadLine());

            //Console.WriteLine("Ingrese 1 para saber su peso en la tierra");
            //Console.WriteLine("Ingrese 2 para saber su peso en la luna");
            //int menu = int.Parse(Console.ReadLine());

            //const float gravedadTierra = 9.8f;
            //const float gravedadLuna = 1.62f;

            //float peso = 0;


            //switch (menu)
            //{
            //    case 1:
            //        peso = masa * gravedadTierra;
            //        Console.WriteLine("Su peso en la tierra es: "+peso);
            //        break;
            //    case 2:
            //        peso = masa * gravedadLuna;
            //        Console.WriteLine("Su peso en la luna es: " + peso);
            //        break;

            //    default:
            //        Console.WriteLine("Debe seleccionar 1 ó 2");
            //        break;
            //}


            // Estructura repetitiva while

            int valor = 1;

            while(valor <= 100)
            {
                Console.WriteLine("El valor es: "+valor);
                valor++; // valor = valor + 1;
            }

            Console.WriteLine("Termina el while");


            // Introduzca un limite inferior [li]
            // Introduzca un limite superior [ls]

            //5 10 = 5 6 7 8 9 10

            // Imprimir los numeros [li - ls]
            Console.WriteLine();
            Console.WriteLine("For ... ");
            //for(int i = 0; i <= 50; i++)
            //{
            //    Console.WriteLine("El valor de i es: "+i);
            //    Console.WriteLine("");
            //}

            int suma = 0, value, promedio;

            int cantidadIngresos = 5;
            
            for (int i = 0; i < cantidadIngresos; i++)
            {
                Console.WriteLine("Ingrese valor:");
                value = int.Parse(Console.ReadLine());
                suma = suma + value;
            }

            Console.WriteLine("La suma es: "+suma);
            Console.WriteLine();
            Console.WriteLine("El promedio es: "+suma/cantidadIngresos);

            var entero = 0;

            // DO WHILE

            do
            {
                entero++;
                // Operaciones

            } while (entero < 10);
        }
    }
}
