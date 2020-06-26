using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasico
{
    class ControlFlow
    {
        static void Main(string[] args) 
        {
            bool estoyTrabajando = false;

            // Condicionales

            if (estoyTrabajando)
            {
                Console.WriteLine("Si, estoy trabajando");
            }
            else
            {
                Console.WriteLine("No, no estoy trabajando");
            }

            Console.WriteLine("Ingrese un valor entre 10 y 15:");

            // Todo lo que viene de la consola, es string
            int valor = int.Parse(Console.ReadLine());

            // Rango [10 - 15]
            if ((valor >= 10) && (valor <= 15))
            {
                Console.WriteLine("Usted ingresó un valor >= 10 y <= 15");
            }
            else
            {
                Console.WriteLine("Usted ingresó un valor fuera del rango.");
            }

            Console.WriteLine("Bienvenido a su calculadora de peso:");
            Console.WriteLine();

            Console.WriteLine("Ingrese su masa:");
            float masa = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese 1 para saber su peso en la tierra");
            Console.WriteLine("Ingrese 2 para saber su peso en la luna");
            int menu = int.Parse(Console.ReadLine());

            const float gravedadTierra = 9.8f;
            const float gravedadLuna = 1.62f;

            float peso = 0;


            switch (menu)
            {
                case 1:
                    peso = masa * gravedadTierra;
                    Console.WriteLine("Su peso en la tierra es: " + peso);
                    break;
                case 2:
                    peso = masa * gravedadLuna;
                    Console.WriteLine("Su peso en la luna es: " + peso);
                    break;

                default:
                    Console.WriteLine("Debe seleccionar 1 ó 2");
                    break;
            }

        }

    }
}
