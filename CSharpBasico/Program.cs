using System;
using System.CodeDom;
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

            //int valor = 1;

            //while(valor <= 100)
            //{
            //    Console.WriteLine("El valor es: "+valor);
            //    valor++; // valor = valor + 1;
            //}

            //Console.WriteLine("Termina el while");


            //// Introduzca un limite inferior [li]
            //// Introduzca un limite superior [ls]

            ////5 10 = 5 6 7 8 9 10

            //// Imprimir los numeros [li - ls]
            //Console.WriteLine();
            //Console.WriteLine("For ... ");
            ////for(int i = 0; i <= 50; i++)
            ////{
            ////    Console.WriteLine("El valor de i es: "+i);
            ////    Console.WriteLine("");
            ////}

            //int suma = 0, value, promedio;

            //int cantidadIngresos = 5;

            //for (int i = 0; i < cantidadIngresos; i++)
            //{
            //    Console.WriteLine("Ingrese valor:");
            //    value = int.Parse(Console.ReadLine());
            //    suma = suma + value;
            //}

            //Console.WriteLine("La suma es: "+suma);
            //Console.WriteLine();
            //Console.WriteLine("El promedio es: "+suma/cantidadIngresos);

            //var entero = 0;

            //// DO WHILE

            //do
            //{
            //    entero++;
            //    // Operaciones

            //} while (entero < 10);



            // Arreglos

            var sueldos = new int[10];

            var size = sueldos.Length; // tamaño del arreglo

            sueldos[0] = 5000;

            sueldos[1] = 6500;

            sueldos[2] = 8500;

            //Console.WriteLine("El sueldo en la pos. 2 es = " + sueldos[1]);

            //for (int i = 0; i < 100; i++)
            //{
            //    //sueldos[i] = i;
            //    //Console.WriteLine("El sueldo en la pos. "+i+ " es: "+ sueldos[i]);
            //}

            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine("Ingrese un sueldo: ");
            //    string valor = Console.ReadLine();
            //    sueldos[i] = int.Parse(valor);
            //}

            //Console.WriteLine("Los valores ingresados fueron: ");
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine("El valor ingresado es: "+sueldos[i]);
            //}

            //Console.WriteLine("Cuantos sueldos va a cargar: ");

            //string valor = Console.ReadLine();

            //int cantidad = int.Parse(valor);

            //int[] sueldosArray = new int[cantidad];

            //for (int i = 0; i < sueldosArray.Length; i++)
            //{
            //    Console.WriteLine("Ingrese el sueldo No. "+(i+1));
            //    string sueldo = Console.ReadLine();
            //    sueldosArray[i] = int.Parse(sueldo);
            //}

            //Console.WriteLine("Los sueldos ingresados son: ");
            //for (int i = 0; i < sueldosArray.Length; i++)
            //{
            //    Console.WriteLine("El sueldo No. {0} es {1}", (i+1), sueldosArray[i]);
            //}

            //// 0   1   2   3   4   5   
            ////100 200 300 400 500 600 
            //Console.WriteLine("Los sueldos ingresados son: (utilizando foreach...)");
            //foreach (var sueldo in sueldosArray)
            //{
            //    Console.WriteLine("El sueldo es {0}", sueldo);
            //}

            //var sumatoriaSueldos = 0;
            //var promedioSueldos = 0;

            //foreach (var sueldo in sueldosArray)
            //{
            //    sumatoriaSueldos += sueldo;
            //}

            //promedioSueldos = sumatoriaSueldos / sueldosArray.Length;

            //Console.WriteLine("El promedio de sueldo es: "+ promedioSueldos);

            //// buscar el mayor sueldo ingresado

            //var mayorSueldo = sueldosArray[0];
            
            //// 0   1   2   3   4   5   
            ////100 200 800 400 500 600

            //for (int i = 1; i < sueldosArray.Length; i++)
            //{
            //    if(mayorSueldo < sueldosArray[i])
            //    {
            //        mayorSueldo = sueldosArray[i];
            //    }
            //}

            //Console.WriteLine("El mayor sueldo es: "+mayorSueldo);

            // Matrices
            // [filas, columnas]

            var matriz = new int[4, 4];

            matriz[0, 0] = 1;
            matriz[0, 1] = 10;
            matriz[0, 2] = 15;
            matriz[0, 3] = 20;

            matriz[1, 0] = 30;
            matriz[1, 1] = 35;
            matriz[1, 2] = 40;
            matriz[1, 3] = 45;

            matriz[2, 0] = 30;
            matriz[2, 1] = 35;
            matriz[2, 2] = 40;
            matriz[2, 3] = 45;

            //for (int fila = 0; fila < 4; fila++)
            //{
            //    for (int columna = 0; columna < 4; columna++)
            //    {
            //        matriz[fila, columna] = fila * columna;
            //    }
            //}

            //Console.WriteLine("La matriz en [1,3] es: "+matriz[1,3]);

            //Console.WriteLine("Todos los valores de la matriz: ");

            //for (int fila = 0; fila < 4; fila++)
            //{
            //    for (int columna = 0; columna < 4; columna++)
            //    {
            //        Console.WriteLine("El valor en {0},{1} es {2}",fila,columna,matriz[fila,columna]);
            //    }
            //}

            // [0,0] [0,1] [0,2] [0,3]
            // [1,0] [1,1] [1,2] [1,3]
            // [2,0] [2,1] [2,2] [2,3]

            for (int fila = 0; fila < 4; fila++)
            {
                for (int columna = 0; columna < 4; columna++)
                {
                    if(fila == columna)
                    {
                        matriz[fila, columna] = 1;
                    }
                    else
                    {
                        matriz[fila, columna] = 0;
                    }
                }
            }

            for (int fila = 0; fila < 4; fila++)
            {
                for (int columna = 0; columna < 4; columna++)
                {
                    Console.WriteLine("El valor en {0},{1} es {2}", fila, columna, matriz[fila, columna]);
                }
            }




        }
    }
}
