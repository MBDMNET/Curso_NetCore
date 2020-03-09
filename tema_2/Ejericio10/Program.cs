using System;
using static System.Console; // esto vale para que no tengas que escribir el Console....

namespace Ejericio1
{
    enum dias {lunes=1,martes,miercoles,jueves,viernes,sabado,domingo};
    class Program
    {
         
        static void Main(string[] args)
        {
            Clear();
            /*para 5 numeros por argumentos, suma los 3 ultimos, y
             divide el resultado entra la suma de los dos primeros*/
            int suma2Primeros = (int.Parse(args[0]))+(int.Parse(args[1]));
            int suma3Ultimos = (int.Parse(args[4]))+(int.Parse(args[3]))+(int.Parse(args[2]));

            int total = suma3Ultimos/suma2Primeros;

            WriteLine($"El resultado de sumar los 3 ultimos y dividirlo entre la suma de los dos primeros es : {total}");
            
            
            
          
        }
    }
}
