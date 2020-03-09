using System;
using static System.Console; // esto vale para que no tengas que escribir el Console....

namespace Ejemplo09
{
    class Program
    {
        static void Main(string[] args)
        {
            Clear();
            WriteLine($"Existen {args.Length} Argumentos");

            foreach(string arg in args)
            {
                //WriteLine(args);// asi te devuelve System.String[] para saber que estas metiendo string
                 WriteLine(arg);
            }
        }
    }
}
