using System;
using static System.Console; // esto vale para que no tengas que escribir el Console....
using classCabecera;
using ClassCubo;
using classOperaciones;
namespace Ejemplo02
{
    class Program
    {
        


    
        
        static void Main(string[] args)
        {
            
           
           
               //Cabecera2();
               Cabecera2 cabecera=new Cabecera2();
               cabecera.pintarCabecera2();
               
                
               SetCursorPosition(0,10);
               WriteLine("Introduzca Un numero");
               int num1=int.Parse(ReadLine());
                WriteLine("Introduzca otro numero");
               int num2=int.Parse(ReadLine());
               Operaciones operaciones=new Operaciones(num1,num2);
              operaciones.suma();
              operaciones.resta();
              operaciones.multiplicacion();
              operaciones.division();
              operaciones.modulo();

              WriteLine("------Aqui el ejercicio del cubo-------");
               WriteLine("Introduzca el lado del cubo en cm");
                num1=int.Parse(ReadLine());

                Cubo cubo = new Cubo(num1);
                cubo.imprSuperficie();
                cubo.imprVolumen();

                
              


              

               

            
              
        }


       
    
        
    
    
        static int getSuma(int num1,int num2)
        {         
            return (num1 + num2);
        }
        static int getProducto(int num1,int num2)
        {
            return (num1 * num2);
        }
        static int getDivision(int num1,int num2)
        {
            return (num1 / num2);
        }
        static int getResto(int num1,int num2)
        {
            return (num1%num2);
        }
        
    }
}
