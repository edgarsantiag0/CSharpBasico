using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasico
{
    class Fechas
    {

        static void Main(string[] args)
        {
            var fecha = new DateTime(2020, 6, 25);

            var fechaHoy = DateTime.Now;

            var hoy = DateTime.Today;

            Console.WriteLine("Hora: " + fechaHoy.Hour);
            Console.WriteLine("Minuto: " + fechaHoy.Minute);

            var manana = fechaHoy.AddDays(1);
            var ayer = fechaHoy.AddDays(-1);

            Console.WriteLine("La fecha de hoy es: " +fechaHoy);

            Console.WriteLine("La fecha de mañana es: " +manana);

            Console.WriteLine("La fecha de ayer es: " +ayer);


            Console.WriteLine();

            Console.WriteLine(fechaHoy.ToLongDateString());
            Console.WriteLine(fechaHoy.ToShortDateString());

            Console.WriteLine(fechaHoy.ToLongTimeString());
            Console.WriteLine(fechaHoy.ToShortTimeString());

            Console.WriteLine(fechaHoy.ToString("dd-MM-yyyy hh:mm")); // format date string c# 



            var timeSpan = new TimeSpan(1, 20, 15);

            var timeSpan1 = new TimeSpan(1, 0, 0);

            var timeSpan2 = TimeSpan.FromHours(1);

            var inicio = DateTime.Now;

            var final = DateTime.Now.AddMinutes(2);

            var duracion = final - inicio;

            Console.WriteLine("Duración: " + duracion);

            // propiedades

            Console.WriteLine("Minutos: " +timeSpan.Minutes);
            Console.WriteLine("Total minutos: " +timeSpan.TotalMinutes); // 1 * 60 + 20 + 15/60

            // Add

            Console.WriteLine("Add: "+ timeSpan.Add(TimeSpan.FromMinutes(50)));

        }
    }
}
