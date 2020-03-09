using System;
using static System.Console; // esto vale para que no tengas que escribir el Console....

namespace Ejericio1
{
    class Program
    {
        static void Main(string[] args)
        {
            // crear 3 variables numericas con el valor que tu quieras 
            //y en otra variable numerica guardar el valor de la suma de las 3 y mostrar pot consola
            WriteLine("introduzca 3 numeros");
            int numero = 0;
            for(int i=1; i<4; i++)
            {
                 WriteLine($"introduzca el numero {i}º");
                 
                 numero = numero + int.Parse(ReadLine());
            }
            WriteLine($"la suma total es :{numero}");

        }
    }
}
