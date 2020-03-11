using System;
using static System.Console; // esto vale para que no tengas que escribir el Console....

namespace Ejemplo02
{
    class Program
    {
        static void Main(string[] args)
        {
            Clear();  
            string fechaNac=args[0];
             DateTime fechaNacDate = Convert.ToDateTime(fechaNac);  
                     
            DateTime fechaAct=DateTime.Today;
            
            int dia=fechaNacDate.Day;
            int mes=fechaNacDate.Month;
            int año=fechaAct.AddYears(1).Year;
           
             DateTime fechaSigCumple=new DateTime(año,mes,dia);
                
             
                  
            TimeSpan diferencia = fechaSigCumple - fechaAct;
            int dias = diferencia.Days;
             WriteLine($"Faltan {dias} dias para tu cumpleaños");

             
             


        }
    }
}
