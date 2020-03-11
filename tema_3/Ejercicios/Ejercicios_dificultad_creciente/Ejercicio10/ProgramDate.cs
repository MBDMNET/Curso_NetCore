using System;
using static System.Console; // esto vale para que no tengas que escribir el Console....

namespace Ejemplo02
{
    class Program
    {
        static void Main(string[] args)
        {
            




              Clear();  
            
        int[][] dimensiones;         // Array de dos dimensiones
        dimensiones = new int[79][];  // Seran 3 bloques de datos
        int alto =0;
        int ancho =0;
         int ColOriginal, RowOriginal;
            
            RowOriginal= Console.CursorTop;
            ColOriginal=Console.CursorLeft;
        // dimensiones[0] = new int[10];  // 10 dimensiones en un grupo
        // dimensiones[1] = new int[15];  // 15 dimensiones en otro grupo
        // dimensiones[2] = new int[12];  // 12 dimensiones en el ultimo
 
        // Damos valores de ejemplo
        for (int i=0;i<79;i++)
        {
            dimensiones[i] = new int[24];
            for (int j=0;j<24;j++)
            {
                
                dimensiones[i][j] = i + j;
            }
        }
            


        //    for (int i=0;i<79;i++)
        // {
        //     alto =  alto = (new Random()).Next(0,79);
        //     for (int j=0;j<24;j++)
        //     {
                
        //         // alto = dimensiones[i];
        //         ancho = dimensiones[i][j];
                
               
        //         // SetCursorPosition(ColOriginal+alto, RowOriginal+ancho);
        //         // Write("*");
        //     }
           
        // }    


           
        for(int p=0; p<=100;p++)
        {
                alto = (new Random()).Next(0,79);
                ancho = (new Random()).Next(0,24);
                Console.SetCursorPosition(ColOriginal+alto, RowOriginal+ancho);
                Console.Write("*");
        }

             
             


        }
    }
}
