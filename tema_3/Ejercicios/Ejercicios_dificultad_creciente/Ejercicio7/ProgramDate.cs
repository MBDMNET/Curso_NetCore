using System;
using static System.Console; // esto vale para que no tengas que escribir el Console....

namespace Ejemplo02
{
    class Program
    {
        static void Main(string[] args)
        {
            Clear();  
            WriteLine("Presione una tecla para tirar el dado");
            ReadLine();
             var dado = (new Random()).Next(1,6);
            WriteLine($"En el dado ha salido un :{dado}");
             
             


        }
    }
}
