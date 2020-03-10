using System;

using static System.Console; // esto vale para que no tengas que escribir el Console....

namespace Ejemplo02
{
    class Program
    {
        static void Main(string[] args)
        {
            Clear();
            /*Crear un reloj que se muestre en pantalla y que se actualice cada segundo usando Sleep
            , en esta primera aproximacion el reloj se ewcribira con writeline()
            de mofo que aparecera en la primeralinea y luego en la segunda, y luego en la recera etc*/
            WriteLine("introduca la hora de la alarma en formato HH:MM:ss");
           DateTime alarma = DateTime.Parse(ReadLine());
           
           do
           {

          
                for(int i=0; i<10000;i++)
                {
                    Clear();
                   
                    string HoraActual = DateTime.Now.ToString("HH:mm:ss");
                    if(DateTime.Parse(HoraActual)==alarma)
                    {
                        do
                        {
                            for(int z=1600; z>=1600;z++)
                            {
                                Beep(z,1000); 
                                
                                
                            }
                            
                        }while(true);
                        
                    }
                    WriteLine(HoraActual);
                    
                        System.Threading.Thread.Sleep(1000);
                }
            }while(ReadKey().KeyChar!='r');

              

              





        }
    }
}
