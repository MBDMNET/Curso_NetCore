using System;
using static System.Console; // esto vale para que no tengas que escribir el Console....

namespace Ejemplo02
{
    class Program
    {
        static void Main(string[] args)
        {
            




              Clear();  
              for(int i=0; i<=10; i++)
              {
                    int mes = new Random().Next(3, 5);
                    int dia = new Random().Next(12, 31);
                    DateTime diaAleatorio=new DateTime(2020,mes,dia);
                    string diaStr=diaAleatorio.ToString("dddd");

                    if(diaStr!="viernes" || diaStr!="sabado" || diaStr!="domingo")
                    {
                            
                    }
             
              }  
             
                  
            // TimeSpan diferencia = fechaSigCumple - fechaAct;
            // int dias = diferencia.Days;
            //  WriteLine($"Faltan {dias} dias para tu cumpleaños");

             
             


        }
    }
}
