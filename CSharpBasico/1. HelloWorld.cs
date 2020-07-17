using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasico
{
    class HelloWorld
    {
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Cual es tu nombre?");
        //    var nombre = Console.ReadLine();

        //    var reverso = ReversoNombre(nombre);

        //    Console.WriteLine("El nombre en reverso es: " + reverso);

        //}

        //public static string ReversoNombre(string nombre)
        //{
        //    var array = new char[nombre.Length];

        //    for (int i = nombre.Length; i > 0; i--)
        //    {
        //        array[nombre.Length - i] = nombre[i - 1];
        //    }

        //    var reverso = new string(array);

        //    return reverso;

        //}


        //static void Main(string[] args)
        //{
        //    var numbers = new List<int>();

        //    while (true) 
        //    {
        //        Console.WriteLine("Introduzca un número (o 'Quit' para salir ");

        //        var input = Console.ReadLine();

        //        if (input.ToLower() == "quit")
        //            break;

        //        numbers.Add(Convert.ToInt32(input));

        //    }

        //    var uniques = GetUniqueNumbers(numbers);

        //    foreach (var number in uniques)
        //    {
        //        Console.WriteLine(number);
        //    }

        //}

        //public static List<int> GetUniqueNumbers(List<int> numbers)
        //{
        //    var uniques = new List<int>();

        //    foreach (var number in numbers)
        //    {
        //        if (!uniques.Contains(number))
        //            uniques.Add(number);

        //    }

        //    return uniques;

        //}

        // Exceptions
        //static void Main(string[] args)
        //{

        //    var array = new int[5];

        //    array[0] = 1;
        //    array[1] = 1;
        //    array[2] = 1;
        //    array[3] = 1;
        //    array[4] = 1;
        //    array[5] = 1; // sexto argumento EXCEPTION!!! 

        //    bool sigue;


        //    do
        //    {
        //        sigue = false;

        //        try
        //        {
        //            Console.Write("Inserte un primer valor: ");
        //            string input1 = Console.ReadLine();

        //            Console.Write("Inserte un segundo valor: ");
        //            string input2 = Console.ReadLine();

        //            var num1 = int.Parse(input1);
        //            var num2 = int.Parse(input2);

        //            var mult = num1 * num2;

        //            Console.WriteLine("La multiplicación es: " + mult);

        //        }
        //        catch (FormatException e)
        //        {
        //            Console.WriteLine("Debe ingresar un numero entero.");
        //            sigue = true;

        //        }


        //    } while (sigue);


        //}

        static void Main(string[] args)
        {
            var path = @"C:\carpetac\archivo.txt";

            //File.Copy(@"c:\carpetac\archivo1.jpg", @"d:\carpetad\archivoMOvido.jpg");

            //File.Delete(path);

            if (File.Exists(path))
            {
                Console.WriteLine("El archivo existe!");
            }

            var contenido = File.ReadAllText(path);

            Console.WriteLine(contenido);

            // FileInfo

            var fileInfo = new FileInfo(path);

            fileInfo.CopyTo(@"d:\carpetad\archivoMOvido.jpg");

            fileInfo.Delete();

            if (fileInfo.Exists)
            {

            }

        }


    }


}

//namespace CSharpIntermedio
//{
//    class HelloWorld
//    {
//        static void Main(string[] args)
//        {

//            Console.WriteLine("Cual es tu nombre?");
//            var nombre = Console.ReadLine();

//            var array = new char[nombre.Length];

//            for (int i = nombre.Length; i > 0; i--)
//            {
//                array[nombre.Length - i] = nombre[i - 1];
//            }

//            var reverso = new string(array);
//            Console.WriteLine("El nombre en reverso es: "+reverso);





//        }


//    }


//}
