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
            TimeSpan diferencia = fechaAct-fechaNacDate;
            int dias = diferencia.Days;
             WriteLine($"Han pasado {dias} dias desde que naciste");

             
             


        }
    }
}
