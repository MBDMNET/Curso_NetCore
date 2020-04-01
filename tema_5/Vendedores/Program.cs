using System;
using static System.Console; // esto vale para que no tengas que escribir el Console....
using classCabecera;
using classVendedor1;


namespace Ejemplo02
{
    class Program
    {
    

        static void Main(string[] args)
        {
            
                WriteLine("¿Cuantos Vendedores Desea Ingresar?");
                int cont=int.Parse(ReadLine());
           
                Cabecera2 cabecera = new Cabecera2();
                cabecera.pintarCabecera2();
                SetCursorPosition(0,10);
                Vendedor  [] vendedores;           
                vendedores = new Vendedor[cont];
               
               for(int i=0;i<vendedores.Length;i++)
               {
                   
                    WriteLine("Introduzca El nombre del vendedor");               
                    string Nombre=ReadLine();            
                    WriteLine("Introduzca LAs ventas de enero y a aprtir de ahi se generaran el resto");
                    int enero=int.Parse(ReadLine());
                    Vendedor vendedor= new Vendedor(Nombre,enero);
                    vendedores[i]=vendedor;  
                    WriteLine("¿Desea Salir? (S) press enter para continuar");
                    string salida=ReadLine();
                    if(salida=="s")
                    {
                        goto salir;
                    }   
                         
               
               }

                salir:
                double TotalVentas=0.0;
               for(int z=0;z<vendedores.Length;z++)
               {
                   vendedores[z].imprVentas();
                   TotalVentas=TotalVentas+vendedores[z].total();
                   

               }
               WriteLine($"El total de venta de todos los vendedores es: {TotalVentas}");

               

               
            
              
            


              

               

            
              
        }


      
        
    }
}
