using System;
using static System.Console; // esto vale para que no tengas que escribir el Console....

namespace Ejericio1
{
    enum dias {lunes=1,martes,miercoles,jueves,viernes,sabado,domingo};
    class Program
    {
         
        static void Main(string[] args)
        {
            int RowOriginal= CursorTop;
           int ColOriginal= CursorLeft;
           int countPar = 0;
            int count3 = 0;
            Random random = new Random();
            Clear();
            /* recorrer los 100 primeros numeros y mostrar solo los pares*/
            WriteLine("Cuantos numeros quieres recorrer");
            int i = int.Parse(ReadLine());
            Clear();
            for(int z=0; z<=i; z++)
            {
                int restoPar = z%2;
                int resto3 = z%3;
                 
                if(restoPar == 0  )
                {
                 
                   int randomNumber = random.Next(0, 100);
                   int randomNumber2 = random.Next(0, 100);
                    SetCursorPosition(randomNumber2, randomNumber);
                    WriteLine($"El numero {z} es par");
                     countPar++;
                }
                if(resto3 == 0)
                {
                   int randomNumbe3 = random.Next(0, 100);
                   int randomNumber4 = random.Next(0, 100);
                    SetCursorPosition(randomNumbe3, randomNumber4);
                        WriteLine($"El numero {z} es divisible entre 3");
                         count3++;
                }
            }
          
        }
    }
}
