using System;

using static System.Console; // esto vale para que no tengas que escribir el Console....

namespace Ejemplo02
{
    
    class Program
    {
        static void Main(string[] args)
        {
            
            /*sacar el primer dia del mes que le pases por parametro mes y año*/
            int mes=0;
            int año =0;
            try
            {
            WriteLine("Introduzca el mes");
             mes= int.Parse(ReadLine());
            }
            catch(FormatException)
            {
                WriteLine("El mes introducido no tiene un formato valido");
            }

             try
            {
                 WriteLine("Introduzca el año");
                    año= int.Parse(ReadLine());
            }
            catch(FormatException)
            {
                WriteLine("El año introducido no tiene un formato valido");
            }
           
            
           
           DateTime fecha=new DateTime(año,mes,01);
            WriteLine($"El dia 1 del mes {mes} :{fecha.ToString("dddd")}");

          
           




        

           
          

              

              





        }
    }
}
