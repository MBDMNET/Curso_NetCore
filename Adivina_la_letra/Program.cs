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
             //var tecla = ReadKey();
            
            
             WriteLine("acierta la letra y gana 100€");
            
            
            WriteLine("\a");
            do
            {
                    
                    WriteLine("\a");
                    Clear();
                    WriteLine("acierta la letra y gana 100€");
                   
                    
                
                
            }while(ReadKey().KeyChar!='r');    
            Clear();
            WriteLine("Enhorabuena has ganado 100€");
            
            
            
          
        }
    }
}
