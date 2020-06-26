using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasico
{
    class Arrays2d
    {
        static void Main(string[] args)
        {

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

            // 2 for anidados
            for (int fila = 0; fila < 4; fila++)
            {
                for (int columna = 0; columna < 4; columna++)
                {
                    matriz[fila, columna] = fila * columna;
                }
            }

            Console.WriteLine("La matriz en [1,3] es: "+matriz[1,3]);

            Console.WriteLine("Todos los valores de la matriz: ");

            for (int fila = 0; fila < 4; fila++)
            {
                for (int columna = 0; columna < 4; columna++)
                {
                    Console.WriteLine("El valor en {0},{1} es {2}", fila, columna, matriz[fila, columna]);
                }
            }

            // [0,0] [0,1] [0,2] [0,3]
            // [1,0] [1,1] [1,2] [1,3]
            // [2,0] [2,1] [2,2] [2,3]

            // Establecer '1' si el indice de la fila y columna es igual, de lo contrario establecer '0'
            for (int fila = 0; fila < 4; fila++)
            {
                for (int columna = 0; columna < 4; columna++)
                {
                    if (fila == columna)
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
