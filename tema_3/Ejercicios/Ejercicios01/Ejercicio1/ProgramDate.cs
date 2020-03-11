using System;
using static System.Console; // esto vale para que no tengas que escribir el Console....

namespace Ejemplo02
{
    class Program
    {
        static void Main(string[] args)
        {
            Clear();  
            WriteLine("Introduzca su Nombre");   
             string nombre = ReadLine();
              WriteLine("Introduzca sus Apellidos");   
             string apellidos = ReadLine();

              WriteLine("Introduzca su Edad");   
             string edad = ReadLine();
              WriteLine("Introduzca su Numero de telefono");   
             string telefono = ReadLine();

             ForegroundColor= ConsoleColor.Blue;
             WriteLine($"Su nombre es: {nombre}");
             Console.ForegroundColor= ConsoleColor.DarkRed;
             WriteLine($"Sus apellidos son: {apellidos}");
                Console.ForegroundColor= ConsoleColor.Cyan;
             WriteLine($"Su edad es: {edad}");
                Console.ForegroundColor= ConsoleColor.DarkGreen;
             WriteLine($"Su telefono es: {telefono}");
              Console.ForegroundColor= ConsoleColor.White;



        }
    }
}
