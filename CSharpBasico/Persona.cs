using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace CSharpBasico
{
    public class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        private int edad { get; set; }


        public void Introducir()
        {
            Console.WriteLine("Hola, mi nombre es: {0} {1}", this.Nombre, this.Apellido);
        }

        public static void IntroducirInformal()
        {
            Console.WriteLine("Hey! klk");
        }


    }
}
