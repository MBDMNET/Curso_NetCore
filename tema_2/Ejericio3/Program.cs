using System;
using static System.Console; // esto vale para que no tengas que escribir el Console....

namespace Ejericio1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* pedir un nombre y la edad y decir te llamas nombre y tu edad es : edad"*/
            WriteLine("introduzca su nombre");
            string nombre = ReadLine();
             WriteLine("introduzca su edad");
            int edad = int.Parse(ReadLine());
            WriteLine($"Te llamas {nombre}, y tienes {edad} años");
           
             WriteLine($"Te llamas {args[0]}, y tienes {args[1]} años"); // esta es por argumentos
            

        }
    }
}
