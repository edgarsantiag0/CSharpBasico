using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasico
{
    class Arrays
    {
        static void Main(string[] args)
        {
            // Arreglos

            var sueldos = new int[10];

            var size = sueldos.Length; // tamaño del arreglo

            sueldos[0] = 5000;

            sueldos[1] = 6500;

            sueldos[2] = 8500;

            Console.WriteLine("El sueldo en la pos. 2 es = " + sueldos[1]);

            for (int i = 0; i < 100; i++)
            {
                sueldos[i] = i;
                Console.WriteLine("El sueldo en la pos. "+i+ " es: "+ sueldos[i]);
            }

            string valor = string.Empty;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese un sueldo: ");
                valor = Console.ReadLine();
                sueldos[i] = int.Parse(valor);
            }

            Console.WriteLine("Los valores ingresados fueron: ");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("El valor ingresado es: " + sueldos[i]);
            }

            Console.WriteLine("Cuantos sueldos va a cargar: ");

            valor = Console.ReadLine();

            int cantidad = int.Parse(valor);

            int[] sueldosArray = new int[cantidad];

            for (int i = 0; i < sueldosArray.Length; i++)
            {
                Console.WriteLine("Ingrese el sueldo No. " + (i + 1));
                string sueldo = Console.ReadLine();
                sueldosArray[i] = int.Parse(sueldo);
            }

            Console.WriteLine("Los sueldos ingresados son: ");
            for (int i = 0; i < sueldosArray.Length; i++)
            {
                Console.WriteLine("El sueldo No. {0} es {1}", (i + 1), sueldosArray[i]);
            }

            //// 0   1   2   3   4   5   
            ////100 200 300 400 500 600 
            Console.WriteLine("Los sueldos ingresados son: (utilizando foreach...)");
            foreach (var sueldo in sueldosArray)
            {
                Console.WriteLine("El sueldo es {0}", sueldo);
            }

            var sumatoriaSueldos = 0;
            var promedioSueldos = 0;

            foreach (var sueldo in sueldosArray)
            {
                sumatoriaSueldos += sueldo;
            }

            promedioSueldos = sumatoriaSueldos / sueldosArray.Length;

            Console.WriteLine("El promedio de sueldo es: "+ promedioSueldos);

            // buscar el mayor sueldo ingresado

            //// 0   1   2   3   4   5   
            ////100 200 800 400 500 600
            
            var mayorSueldo = sueldosArray[0];

            for (int i = 1; i < sueldosArray.Length; i++)
            {
                if (mayorSueldo < sueldosArray[i])
                {
                    mayorSueldo = sueldosArray[i];
                }
            }

            Console.WriteLine("El mayor sueldo es: "+mayorSueldo);

        }
    }
}
