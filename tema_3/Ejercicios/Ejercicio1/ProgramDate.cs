using System;
using static System.Console; // esto vale para que no tengas que escribir el Console....

namespace Ejemplo02
{
    class Program
    {
        static void Main(string[] args)
        {
            Clear();
            /*Calcular cuantos dias hay entreo el 30/05/2020 y el 30/05/2020*/

             DateTime Fecha1 = new DateTime(2020,05,30);
             DateTime Fecha2 = new DateTime(2030,05,30);
             

        

             //SOLUCION CORRECTA
             String fecha1Str= "30/05/2020";
             String fecha2Str= "30/05/2030";
             DateTime fecha1 = new DateTime();
             DateTime fecha2 = new DateTime();

             fecha1 = Convert.ToDateTime(fecha1Str);
             fecha2 = Convert.ToDateTime(fecha2Str);

             TimeSpan diferencia = fecha2-fecha1;
             int dias = diferencia.Days;
             WriteLine(dias);

             

             

              

              





        }
    }
}
