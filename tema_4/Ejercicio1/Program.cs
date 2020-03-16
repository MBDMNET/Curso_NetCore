using System;
using static System.Console; // esto vale para que no tengas que escribir el Console....

namespace Ejemplo02
{
    class Program
    {
        static void Main(string[] args)
        {
            
           //una funcion que sume dos numeros y mostrarlos con el cuadro pequeño
           
               Cabecera2();
               SetCursorPosition(1, 10);
            WriteLine("inserte el primer numero");
            int num1= int.Parse(ReadLine());
            SetCursorPosition(1, 12);
            int num2=1;
            
            WriteLine("inserte el segundo numero ");
             num2= int.Parse(ReadLine());
           
              // Ejercicio1 una funcion que sume dos numeros y mostrarlos con el cuadro pequeño
            SetCursorPosition(1, 14);
             int suma= getSuma(num1,num2);
                //Ejercicio 2 igual que el priemro pero el producto                    
            int producto= getProducto(num1,num2);
            int division= getDivision(num1,num2);
            int resto= getResto(num1,num2);
             SetCursorPosition(1, 16); 
            WriteLine($"La suma de {num1} + {num2} es: : {suma}");
            SetCursorPosition(1, 17); 
            WriteLine($"El producto de {num1} * {num2} es: : {producto}");
            SetCursorPosition(1, 18); 
            WriteLine($"El la division de {num1} / {num2} es: : {division}");
            SetCursorPosition(1, 19); 
            WriteLine($"El resto de {num1} % {num2} es: : {resto}");
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
