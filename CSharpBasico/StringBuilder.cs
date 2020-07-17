using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasico
{
    class StringBuilder
    {
        static void Main(string[] args)
        {
            var builder = new StringBuilder("Hello world");

            builder.Append('-', 10)
                .AppendLine()
                .Append("Hola Mundo")
                .Append('-', 10)
                .Replace('-', '+')
                .Remove(0, 11)
                .Insert(0, new string('-', 10));


            Console.WriteLine(builder);

        }
    }
}
