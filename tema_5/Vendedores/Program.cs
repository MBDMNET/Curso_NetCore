using System;
using static System.Console; // esto vale para que no tengas que escribir el Console....

namespace Ejemplo02
{
    class Program
    {
        class Vendedor
        {
            string Nombre;
            double Enero;
            double Febrero;
            double Marzo;
            double Abril;
            double Mayo;
            double Junio;
            double Julio;
            double Agosto;
            double Septiembre;
            double Octubre;
            double Noviembre;
            double Diciembre;

            public  Vendedor(string nombre,double enero)
            {
                this.Nombre=nombre;
                 Random random = new Random();
                this.Enero=enero;
                this.Febrero=enero*random.Next(0,5);
                this.Marzo=enero*random.Next(0,5);
                this.Abril=enero*random.Next(0,5);
                this.Mayo=enero*random.Next(0,5);
                this.Junio=enero*random.Next(0,5);
                this.Julio=enero*random.Next(0,5);
                this.Agosto=enero*random.Next(0,5);
                this.Septiembre=enero*random.Next(0,5);
                this.Octubre=enero*random.Next(0,5);
                this.Noviembre=enero*random.Next(0,5);
                this.Diciembre=enero*random.Next(0,5);
            }

            public void imprVentas()
            {
                WriteLine($"Las de {Nombre} ventas de Enero son {Enero} € ");
                WriteLine($"Las de {Nombre} ventas de Febrero son {Febrero} € ");
                WriteLine($"Las de {Nombre} ventas de Marzo son {Marzo} € ");
                WriteLine($"Las de {Nombre} ventas de Abril son {Abril} € ");
                WriteLine($"Las de {Nombre} ventas de Mayo son {Mayo} € ");
                WriteLine($"Las de {Nombre} ventas de Junio son {Junio} € ");
                WriteLine($"Las de {Nombre} ventas de Julio son {Julio} € ");
                WriteLine($"Las de {Nombre} ventas de Agosto son {Agosto} € ");
                WriteLine($"Las de {Nombre} ventas de Septiembre son {Septiembre} € ");
                WriteLine($"Las de {Nombre} ventas de Octubre son {Octubre} € ");
                WriteLine($"Las de {Nombre} ventas de Noviembre son {Noviembre} € ");
                WriteLine($"Las de {Nombre} ventas de Diciembre son {Diciembre} € ");
            }
            public double total()
            {
                double total=Enero+Febrero+Marzo+Abril+Mayo+Junio+Julio+Agosto+Septiembre+Octubre+Noviembre+Diciembre;
                return total;
            }

            
        }

        
            


            
         
        
    
        
        static void Main(string[] args)
        {
            
                WriteLine("¿Cuantos Vendedores Desea Ingresar?");
                int cont=int.Parse(ReadLine());
           
                Cabecera2();
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


        static void Cabecera2()
        {
            Console.Clear();  
            Console.SetWindowSize(95,35);
            int ColOriginal, RowOriginal;
            Console.Clear();
            RowOriginal= Console.CursorTop;
            ColOriginal=Console.CursorLeft;
            Console.WriteLine("Introduzca el nombre del proyecto");
            string nombreProyecto= Console.ReadLine();
            Console.Clear();

            
            Console.SetCursorPosition(ColOriginal, RowOriginal);
            Console.Write("╔");
            int i=1;
            for(;i<=90;i++)
            {
                    
                    Console.SetCursorPosition(ColOriginal+i, RowOriginal);
                    Console.Write("═");
                    System.Threading.Thread.Sleep(10);
                    
            }
            

           
            
            int z=1;
            for(;z<=8;z++)
            {
                Console.SetCursorPosition(ColOriginal, RowOriginal+z);
                Console.Write("║");
                System.Threading.Thread.Sleep(10);
                    
            }
            Console.SetCursorPosition(ColOriginal, RowOriginal+z);
            Console.Write("╚");
            System.Threading.Thread.Sleep(10);
            int x=1;
            for(;x<=90;x++)
            {
                    Console.SetCursorPosition(ColOriginal+x, RowOriginal+z);
                    Console.Write("═");
                    System.Threading.Thread.Sleep(10);
            }
            Console.SetCursorPosition(ColOriginal+x, RowOriginal+z);
            Console.Write("╝");
            System.Threading.Thread.Sleep(10);
            int y=1;
            for(;y<=8;y++)
            {           
                Console.SetCursorPosition(ColOriginal+x, RowOriginal+y);
                Console.Write("║");
                System.Threading.Thread.Sleep(10);
                    
            }
            Console.SetCursorPosition(ColOriginal+x, RowOriginal);
                Console.Write("╗");
                System.Threading.Thread.Sleep(10);

                //aqui añado la zona de la fecha
            Console.SetCursorPosition(ColOriginal+2, RowOriginal+2);
            Console.WriteLine("Fecha: ");
            Console.SetCursorPosition(ColOriginal+10, RowOriginal+2);
            Console.WriteLine(DateTime.Now.ToString("dd/MM/yy"));

        //aqui añado el nombre del proyecto
        //Console.SetCursorPosition(ColOriginal+2, RowOriginal+4);
        //Console.WriteLine("Nombre del Proyecto: ");
        //Console.SetCursorPosition(ColOriginal+23, RowOriginal+4);
        //Console.WriteLine(nombreProyecto);
            Nombrificador(nombreProyecto);

            //aqui añado el nombre del proyecto
            Console.SetCursorPosition(ColOriginal+2, RowOriginal+6);
            Console.WriteLine("Nombre del Desarrollador: ");
            Console.SetCursorPosition(ColOriginal+23, RowOriginal+6);
            Console.WriteLine("Manuel Beltran Diaz-Meco");

             //aqui añado la zona de la Hora        
                    
                   
            string HoraActual = DateTime.Now.ToString("HH:mm:ss");     
            Console.SetCursorPosition(ColOriginal+70, RowOriginal+2);
            Console.WriteLine("Hora: ");
            Console.SetCursorPosition(ColOriginal+75, RowOriginal+2);                                
            Console.WriteLine(HoraActual);

            Console.SetCursorPosition(ColOriginal+75, RowOriginal+10);      
                    
        }
    
        static void Nombrificador(string nombreProyecto)
        {
            var colorDeTinta=ForegroundColor;
            SetCursorPosition(2,4);
            ForegroundColor= ConsoleColor.Yellow;
            WriteLine($"Proyecto : {nombreProyecto}");
            ForegroundColor=colorDeTinta;

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
