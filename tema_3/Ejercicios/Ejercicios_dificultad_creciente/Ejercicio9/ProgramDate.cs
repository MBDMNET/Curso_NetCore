using System;
using static System.Console; // esto vale para que no tengas que escribir el Console....

namespace Ejemplo02
{
    class Program
    {
        static void Main(string[] args)
        {
            




              Clear();  
            
            double [] numeros ;
            numeros = new double[100];
            double total=1;
            for(int i=0; i<=99; i++)
            {
                 numeros[i] = (new Random()).Next(-1000,1000);
                 WriteLine($"El numero {i+1} es el  {numeros[i]}");
                 total= total+numeros[i];
                 
                 
                 
            }
            
            double media = total/(numeros.Length);
            WriteLine($"La media de todos los numeros es: {media:R0}");

             
             


        }
    }
}
