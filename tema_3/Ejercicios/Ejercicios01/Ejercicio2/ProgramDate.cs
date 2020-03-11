using System;
using static System.Console; // esto vale para que no tengas que escribir el Console....

namespace Ejemplo02
{
    class Program
    {
        static void Main(string[] args)
        {
            Clear();  
             ForegroundColor= ConsoleColor.Blue;
             WriteLine($"Su nombre es: {args[0]}");
             Console.ForegroundColor= ConsoleColor.DarkRed;
             WriteLine($"Sus apellidos son: {args[1]}");
                Console.ForegroundColor= ConsoleColor.Cyan;
             WriteLine($"Su edad es: {args[2]}");
                Console.ForegroundColor= ConsoleColor.DarkGreen;
             WriteLine($"Su telefono es: {args[3]}");
              Console.ForegroundColor= ConsoleColor.White;



        }
    }
}
