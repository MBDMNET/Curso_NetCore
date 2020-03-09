using System;
using static System.Console; // esto vale para que no tengas que escribir el Console....

namespace Ejemplo10
{
    class Program
    {
        static void Main(string[] args)
        {
            if(args.Length<4)
            {
                WriteLine("debes especificar  dos colores y dimensiones de la ventana ejemplo: red green 10 30");
                return ; // termino la ejecucion
            }

             var ColoFondoOriginal = BackgroundColor;
            var ColoTintaOriginal = ForegroundColor;

            int AnchuraOriginal= WindowWidth;
            int AlturaOriginal= WindowHeight;


            var anchura = int.Parse(args[2]);
            var altura = int.Parse(args[3]);

            Console.SetWindowSize(anchura,altura);

            ForegroundColor = (ConsoleColor)Enum.Parse(
                enumType: typeof(ConsoleColor),
                value: args[0],
                ignoreCase:true

            );

             BackgroundColor = (ConsoleColor)Enum.Parse(
                enumType: typeof(ConsoleColor),
                value :args [1],
                ignoreCase:true

            );

            WriteLine("pulsa una tecla para volver al original");
            ReadLine();

            WindowWidth = AnchuraOriginal;
            WindowHeight = AlturaOriginal;

            BackgroundColor = ColoFondoOriginal;
            ForegroundColor = ColoTintaOriginal;

            Console.SetWindowSize( WindowWidth, WindowHeight);

            




        }
    }
}
