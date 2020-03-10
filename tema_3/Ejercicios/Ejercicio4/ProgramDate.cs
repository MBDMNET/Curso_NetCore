using System;

using static System.Console; // esto vale para que no tengas que escribir el Console....

namespace Ejemplo02
{
    
    class Program
    {
        static void Main(string[] args)
        {
            
            /*crear un programa que muestre el calendario  del mes actual, (pista, 
            primero deberas calcular que dia de la semana es el dia 1 de este mes)*/
            
          

           //buscar el año que coincida con el el dia 1 de febrero de X, 
           DateTime fecha=new DateTime(2020,02,01);
            WriteLine(fecha.Year);

           for(int i=fecha.Year;i<=fecha.Year; i--)
           {
               fecha=fecha.AddYears(-1);
               WriteLine(fecha.ToString("dddd"));          
              
              
             if(fecha.ToString("dddd")=="viernes")
             {
                 
                 break;
             }
           }
            
            int cont =10;
            String [] dias ;
            dias = new String[6];
            dias[0]="lunes";
            dias[1]="martes";
            dias[2]="miercoles";
            dias[3]="jueves";
            dias[4]="viernes";
            dias[5]="sabado";
            dias[6]="domingo";
            int ColOriginal, RowOriginal;            
            RowOriginal= Console.CursorTop;
            ColOriginal=Console.CursorLeft;

            WriteLine(dias.Length);
           for(int z=0; z<=dias.Length;z++)
           {
               WriteLine("entro al for");
               Console.SetCursorPosition(ColOriginal+cont, RowOriginal);
               WriteLine($"{dias[z]}");
               //Write($"{dias[z]}");
               cont=cont+3;
           }




        

           
          

              

              





        }
    }
}
