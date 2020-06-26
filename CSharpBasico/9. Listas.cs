using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasico
{
    class Listas
    {
        static void Main(string[] args)
        {
            var numeros = new List<int>() { 1, 2, 3, 4 };

            numeros.Add(5);

            var array1 = new int[2] { 6, 7 };
            var lista2 = new List<int> { 8, 9, 3 };

            numeros.AddRange(array1);

            numeros.AddRange(lista2);

            foreach (var numero in numeros)
            {
                Console.WriteLine(numero);
            }

            Console.WriteLine();
            Console.WriteLine("Index of 3: " + numeros.IndexOf(3));
            Console.WriteLine("Last index of 3: " + numeros.LastIndexOf(3));


            Console.WriteLine("Cantidad de elementos: " + numeros.Count);


            numeros.Remove(3);

            for (int i = 0; i < numeros.Count; i++)
            {
                if (numeros[i] == 3)
                    numeros.Remove(numeros[i]);
            }

            foreach (var numero in numeros)
            {
                Console.WriteLine(numero);
            }

            numeros.Clear();

            Console.WriteLine("Count final: " + numeros.Count);


        }


    }
}
