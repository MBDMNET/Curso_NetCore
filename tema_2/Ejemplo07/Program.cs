using System;

namespace Ejemplo07
{
    class Program
    {
        static void Main(string[] args)
        {
            // // rizando el rizo
            var ColoFondoOriginal = Console.BackgroundColor;
            var ColoTintaOriginal = Console.ForegroundColor;

            Console.BackgroundColor= ConsoleColor.DarkGreen;
            Console.ForegroundColor= ConsoleColor.Cyan;

            Console.Clear();
            Console.WriteLine("presione una tecla para recuperar lo colers originales");
            Console.ReadLine();

             Console.BackgroundColor =ColoFondoOriginal ;
             Console.ForegroundColor = ColoTintaOriginal ;

             Console.Clear();




        }
    }
}
