using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasico
{
    class LogicalOperations
    {
        static void Main(string[] args)
        {
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

        }
    }
}
