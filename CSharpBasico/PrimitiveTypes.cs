using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasico.Class_2
{
    class PrimitiveTypes
    {
        static void Main(string[] args)
        {
            // Primitive Types and Expressions
            // Variables and Constants

            byte number = 2;

            Console.WriteLine(number); // 2

            number = 3;

            Console.WriteLine(number); // 3

            int contador = 10;
            float precioTotal = 20.95f;
            char caracter = 'A';
            string primerNombre = "Benjamin";
            bool estaFuncionando = false;


            Console.WriteLine(contador);
            Console.WriteLine(precioTotal);
            Console.WriteLine(caracter);
            Console.WriteLine(primerNombre);
            Console.WriteLine(estaFuncionando);

            Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);

            const float Pi = 3.14f;

            var numero = 80;
            var miNombre = "Edgar";


            byte b = 1;
            int i = b;

            // Console.WriteLine("La conversion es: "+i);

            int entero = 2;
            byte convertido = (byte)entero;

            Console.WriteLine("La conversion es: " + convertido);


            int a2 = 1500;
            byte b2 = (byte)a2;
            //                      1011 = 220
            //  000000 000000 100101 1011 = 1500
            Console.WriteLine(b2);

            var cadenaNumerica = "1234";

            // Covertir valor de string a int
            int entero2 = int.Parse(cadenaNumerica);
            int entero3 = Convert.ToInt32(cadenaNumerica);


            Console.WriteLine(entero2);

        }
    }
}
