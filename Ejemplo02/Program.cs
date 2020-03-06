using System;

namespace Ejemplo02
{
    class Program
    {
        static void Main(string[] args)
        {
            double anchura = 2400.50;
            string nombre = "mesa de trabajo";
            // para concatenar y mostrar en una linea de la consola.
            // Console.WriteLine($"{nombre} es {anchura}");

            // // lo que usa un bit de entero
            //  Console.WriteLine($"int emplea {sizeof(int)} bit");

            //  // lo que usa un bit de entero y puede almacenar el numero desde 
            //   Console.WriteLine($"int emplea {sizeof(int)} bit y almacena numeros desde {int.MinValue:N0}");
            //  Console.WriteLine($"int emplea {sizeof(double)} bit y almacena numeros desde {double.MinValue:N0}");
            //   Console.WriteLine($"int emplea {sizeof(float)} bit y almacena numeros desde {float.MinValue:N0}");

             //  // lo que usa un bit de entero y puede almacenar el numero desde  el min al maximo
              Console.WriteLine($"int emplea {sizeof(int)} bit y almacena numeros desde {int.MinValue:N0} y el numero maximo {int.MaxValue:N0}");
             Console.WriteLine($"int emplea {sizeof(double)} bit y almacena numeros desde {double.MinValue:N0} y el numero maximo {double.MaxValue:N0}");
              Console.WriteLine($"int emplea {sizeof(float)} bit y almacena numeros desde {float.MinValue:N0} y el numero maximo {float.MaxValue:N0}");
              Console.WriteLine($"int emplea {sizeof(byte)} bit y almacena numeros desde {byte.MinValue:N0} y el numero maximo {byte.MaxValue:N0}");
              Console.WriteLine($"int emplea {sizeof(short)} bit y almacena numeros desde {short.MinValue:N0} y el numero maximo {short.MaxValue:N0}");
              Console.WriteLine($"int emplea {sizeof(long)} bit y almacena numeros desde {long.MinValue:N0} y el numero maximo {long.MaxValue:N0}");
              Console.WriteLine($"int emplea {sizeof(uint)} bit y almacena numeros desde {uint.MinValue:N0} y el numero maximo {uint.MaxValue:N0}");
              Console.WriteLine($"int emplea {sizeof(ulong)} bit y almacena numeros desde {ulong.MinValue:N0} y el numero maximo {ulong.MaxValue:N0}");
              Console.WriteLine($"int emplea {sizeof(bool)} ");
              Console.WriteLine($"int emplea {sizeof(char)} bit y almacena numeros desde {char.MinValue:N0} y el numero maximo {char.MaxValue:N0}");
              
              

              





        }
    }
}
