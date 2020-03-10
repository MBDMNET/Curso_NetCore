using System;

using static System.Console; // esto vale para que no tengas que escribir el Console....

namespace Ejemplo02
{
    class Program
    {
        static void Main(string[] args)
        {
            Clear();
            /*meter fecha y te devuelve el dia que era*/
            WriteLine("introduca su fecha de nacimieinto dd//mm//yyyy");
           DateTime fechaNac = DateTime.Parse(ReadLine());
           WriteLine($"Usted nacio un: {fechaNac.ToString(" dddd")}");
           WriteLine(DateTime.MinValue);

           
          

              

              





        }
    }
}
