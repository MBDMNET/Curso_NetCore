using System;
using static System.Console; // esto vale para que no tengas que escribir el Console....

namespace Ejemplo02
{
    class Program
    {
        static void Main(string[] args)
        {
            




              Clear();  
              DateTime horaInicio= DateTime.Now;
              string [] dias ;         // Array de dos dimensiones
                        dias = new string[10];
              
              for(int i=0; i<10; i++)
              {
                    int mes = new Random().Next(3, 5);
                    int dia = new Random().Next(12, 31);
                    bool buscar =false;
                    DateTime diaAleatorio=new DateTime(2020,mes,dia);
                    string diaStr=Convert.ToString( diaAleatorio.ToString("dddd"));
                    string diaStrCompleto=Convert.ToString( diaAleatorio.ToString("dd/mm/yy"));
                     
                    if(diaStr=="lunes" || diaStr=="martes" || diaStr=="miércoles"|| diaStr=="jueves")
                    {
                        
                          // WriteLine(diaAleatorio); 
                            
                           
                           //buscar = Array.IndexOf( dias ,diaStrCompleto);
                            buscar = Array.Exists(dias, element => element == diaStrCompleto);
                           
                          
                           if(buscar==false)
                           {
                                WriteLine(diaAleatorio);   
                           WriteLine(diaStr);
                                dias[i]=diaStrCompleto;
                           }
                           else{
                               i--;
                           }
                              
                    }
                    else
                    {
                             
                              i--;
                    
                    }
                  
              }  
              
             
                  
            // TimeSpan diferencia = fechaSigCumple - fechaAct;
            // int dias = diferencia.Days;
            //  WriteLine($"Faltan {dias} dias para tu cumpleaños");           
            //  for(int z=0; z<=dias.Length; z++)
            //  {
            //      WriteLine(dias[z]);
            //  }
            DateTime horaFin= DateTime.Now;
            TimeSpan diferencia = horaFin-horaInicio;
             
             WriteLine($"El programa ha tardado {diferencia.Milliseconds} milisegundos en terminar el programa");


        }
            
    }
}
