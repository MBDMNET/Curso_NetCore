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
            /*crear un array de 20 elementos, que empiece por el 5437,solo impares y sacar por pantalla en color rojo
            la suma, y en azul el producto*/

            int [] numeros ;
            numeros = new int[20];
            int numero = 5437;
            for(int i=0; i<numeros.Length;)
            {
                
                int resto= numero%2;
                if(resto!=0)
                {
                    numeros[i]=numero;
                    WriteLine($"El numero {numero} esta en la matriz");
                     i++;
                }
                numero++;

            }
            int totalSum =0;
            double totalPro=1;
            for(int z=0; z<numeros.Length; z++)
            {
                totalSum = totalSum+numeros[z];
                totalPro  = totalPro*numeros[z];
            }
            Console.ForegroundColor= ConsoleColor.Blue;
            WriteLine($"la suma es: {totalSum}");
            Console.ForegroundColor= ConsoleColor.Red;
            WriteLine($"el producto es : {totalPro}");

            Console.ForegroundColor= ConsoleColor.White;



            
            
            
            
          
        }
    }
}
