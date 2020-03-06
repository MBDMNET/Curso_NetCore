using System;
using static System.Console; // esto vale para que no tengas que escribir el Console....

namespace Ejericio1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* pedir un nombre y una ciudad y mostrar "hola nombre bienvenido a ciudad"*/
            WriteLine("introduzca su nombre");
            string nombre = ReadLine();
        WriteLine("introduzca una ciudad");
            string ciudad = ReadLine();

           
            WriteLine($"Hola{nombre}, bienvenido a {ciudad}");

        }
    }
}
