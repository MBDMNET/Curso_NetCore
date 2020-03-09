using System;
using static System.Console; // esto vale para que no tengas que escribir el Console....

namespace Ejemplo02
{
    class Program
    {
        static void Main(string[] args)
        {
            Clear();
            //incrmeneto postfijo
            int i = 3;
                WriteLine(i); //
                WriteLine(i++);
                WriteLine(i);
              //incrmeneto prefijo
             double z = 1.5;
                WriteLine(z);
                WriteLine(z++);
                WriteLine(z); 
            //descremento
               int a = 3;
                WriteLine(a);
                WriteLine(a--);
                WriteLine(a);  

                //DATETIME
                DateTime Fecha = new DateTime(2020,03,09);
                Write(Fecha);

                //fecha y hora actual
                DateTime Fecha2 =  DateTime.Now;
                Write(Fecha2);

                //fecha de hoy y el dia anterior
                DateTime fecha =  DateTime.Now;
                DateTime ayer =  DateTime.Today;
                Write($"fecha de ayer a la misma hora: {fecha.AddDays(-1) }\n");
                 Write($"fecha de ayer sin hora: {ayer.AddDays(-1)} \n ");              


                //fecha y hora de mañana
              
                Write($"fecha de ayer a la misma hora: {fecha.AddDays(1)}\n");
                 Write($"fecha de ayer sin hora: {ayer.AddDays(1)}\n");

                 //funcion para saber los dias del mes
                 int NumeroDeDias = DateTime.DaysInMonth(2020,2);
                 WriteLine($"El mes de febreto de 2020 tiene: {NumeroDeDias} dias");

                 //hora actual en un determinado formato
                 string HoraActual = DateTime.Now.ToString("HH:MM:ss zzz dddd");
                 WriteLine(HoraActual);

                 //mostrar por pantalla el dia de hoy y de mañana
                 
                  

                 WriteLine($"EL dia de hoy es: {fecha.ToString("dd/mm/yyyy dddd")}");
                 WriteLine($"EL dia de mañana es: { fecha.AddDays(1).ToString("dd/mm/yyyy dddd")}");

              

              





        }
    }
}
