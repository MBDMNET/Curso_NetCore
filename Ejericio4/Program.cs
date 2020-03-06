using System;
using static System.Console; // esto vale para que no tengas que escribir el Console....

namespace Ejericio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Clear();
            /* pedir dos numeros y decir que numero es mayor"*/
            WriteLine("introduzca el primer numero");
            int num1 = int.Parse(ReadLine());
             WriteLine("introduzca el segundo numero");
            int num2 = int.Parse(ReadLine());
            if(num1>num2)
            {
                WriteLine($"el {num1} es mayor que el {num2}");
            }else if(num1==num2)
            {
                WriteLine("Los Numero son Iguales");
            }
            else{
                 WriteLine($"el {num2} es mayor que el {num1}");
            }

            
         

            
           
             
            

        }
    }
}
