using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpBasico
{
    class Metodos
    {
        //static void Main(string[] args)
        //{
        //   Console.WriteLine("La suma es: " + Sumar(2,4));

        //   Console.WriteLine("La suma de 5 y 10 es: " + Sumar(5, 10));

        //    var laSuma = Sumar2(1, 2, 3);

        //    var laSuma2 = Sumar2(5, 9, 10, 15);

        //    var laSuma3 = Sumar2(5, 9);

        //    //ImprimirMensaje("Hola mundo", 10, 15);
        //    //ImprimirMensaje("Hola mundo", 10, 50);

        //    MontosCliente("Edgar", 315, 450.98f, 1500);

        //    Imprimirxy("Hola", 20, 25);

        //}

        public static int Sumar(int numero1, int numero2)
        {
            return numero1 + numero2;
        }

        public static int Metodo(int numero1, int numero2, string mensaje)
        {
            return numero1 + numero2;
        }

        private static int Restar(int numero1, int numero2)
        {
            return numero1 - numero2;
        }

        public static int Sumar2(params int[] arreglo)
        {
            int suma = 0;

            for (int i = 0; i < arreglo.Length; i++)
            {
                suma = suma + arreglo[i];
            }

            return suma;
        }

        public static void ImprimirMensaje(string mensaje, int x, int y)
        {
            Console.SetCursorPosition(x, y);

            Console.WriteLine(mensaje);
        }

        public static void MontosCliente(string nombre, params float[] montos)
        {
            var suma = 0f;

            foreach (var monto in montos)
            {
                suma += monto;
            }

            Console.WriteLine("{0} Tiene la suma de: {1}", nombre, suma);
        }

        public static void Imprimirxy(string mensaje, int x = 10, int y = 15)
        {
            ImprimirMensaje(mensaje, x, y);
        }

        public static void Search(string search, int page = 0, int count = 0)
        {

        }


    }
}
