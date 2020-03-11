using System;
using static System.Console; // esto vale para que no tengas que escribir el Console....

namespace Ejemplo02
{
    class Program
    {
        static void Main(string[] args)
        {
            




              Clear();  
            
            int numero = (new Random()).Next(1,100);
            int elegido =-1;
            WriteLine($"eliga un numero del 1 al 100 ");
                    elegido = int.Parse( ReadLine());

            for( int i = 0;i<=5;i++)
            {
                try
                {
                    do
                    {
                        WriteLine($"Debe elegir un numero del 1 al 100 ");
                    elegido = int.Parse( ReadLine());
                    }while(elegido<0 && elegido>100);
                }
                catch(FormatException)  
                {
                    WriteLine("El numero elegido  no tiene un formato valido");
                }
                 
                if(numero==elegido)
                {
                    WriteLine("Enhorabuena ha acertado")    ;
                    break;
                }
            }

            WriteLine("lo siento pero ha fallado 6 veces");

             
             


        }
    }
}
