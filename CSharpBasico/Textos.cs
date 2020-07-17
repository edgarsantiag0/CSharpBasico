using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasico
{
    class Textos
    {
        static void Main(string[] args)
        {
            var fullName = "Edgar Santiago ";

            Console.WriteLine("string: '{0}'", fullName);

            Console.WriteLine("Trim: '{0}'", fullName.Trim());

            Console.WriteLine("ToUpper: '{0}'", fullName.Trim().ToUpper());

            var index = fullName.IndexOf(' ');

            var firstName = fullName.Substring(0, index);

            var lastName = fullName.Substring(index + 1);

            Console.WriteLine("First Name: " + firstName);
            Console.WriteLine("Last Name: " + lastName);

            var names = fullName.Split(' ');

            foreach (var item in names)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("First Name: " + names[0]);
            Console.WriteLine("Last Name: " + names[1]);


            Console.WriteLine(fullName.Replace("Edgar", "Jose Alberto"));

            if (string.IsNullOrEmpty(" "))
            {
                Console.WriteLine("Invalid string");
            }

            if (string.IsNullOrWhiteSpace(" "))
            {
                Console.WriteLine("Invalid string");
            }

        }
    }
}
