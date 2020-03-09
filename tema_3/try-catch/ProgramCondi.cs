using System;
using static System.Console; // esto vale para que no tengas que escribir el Console....

namespace Ejemplo02
{
    class Program
    {
        static void Main(string[] args)
        {
            //TRY CATCH
            Clear(); 
            Write("¿Cual es tu edad?"); 
            string EdadIntro = ReadLine();
            try
            {
                int edad = int.Parse(EdadIntro);
                WriteLine($"Tu edad es: {edad}");
            }
            catch(OverflowException)  
            {
                WriteLine("La edad es demasiado grande, te has pasado el juego de la vida");
            }
            catch(FormatException)  
            {
                WriteLine("La edad introducida no tiene un formato valido");
            }
            catch(Exception ex)                
            {
                
                //EXCEPTION Ver que tipo de escepcion y que dato te da
                WriteLine($"{ex.GetType()} dice que {ex.Message}");
            }
            
            
                


            
            
        }
    }
}
