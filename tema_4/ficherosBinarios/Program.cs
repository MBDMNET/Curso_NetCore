using System;
using static System.Console; // esto vale para que no tengas que escribir el Console....
using System.IO;

namespace Ejemplo02
{
    class Program
    {
        

        static void Main(string[] args)
        {
                        
            WriteLine("Seleccione que tipo de cabecera necesita 1 si es completo 2 si es para una lista");
            int cabecera=int.Parse(ReadLine());
           //Funciones para que el codigo no sea repetitivo y se crean fuera del main  
           if(cabecera==1)
           {
               Cabecera1();
           } 
           else{
               Cabecera2();
           }
            

        //Ficheros Binarios
        // BinaryReader fichero;
        // string nombreFichero;
        // byte datoFichero;
        // nombreFichero="ejemplo.bmp"; 
        // fichero = new BinaryReader(File.Open(nombreFichero,FileMode.Open));
        // datoFichero= fichero.ReadByte();
        // SetCursorPosition(0,12);
        // WriteLine($"El byte leido es: {datoFichero}");
        // fichero.Close();

        //leer 10 bytes de un fichero
        FileStream fichero;
        string nombreFichero;
        byte [] datos;
        int numByteLeidos;
        nombreFichero="pinza.gif";
        fichero=File.OpenRead(nombreFichero);
        datos= new byte [128];
        int pos=0;
        int cantidadaleer =128;
        int xmin;
        int xmax;
        int ymin;
        int ymax;
        numByteLeidos=fichero.Read(datos,pos,cantidadaleer);
        if(numByteLeidos<10)
        {
            SetCursorPosition(0,10);
            WriteLine("NO se han podido leer datos");
        }
        else
        {
             SetCursorPosition(0,10);
            
                                 
                xmax = datos[6] | (datos[7] << 8);                 
                 WriteLine($"El ancho es: {xmax}");               
                 
                ymax = datos[8] | (datos[9] << 8);                 
                 WriteLine($"El alto es: {ymax}");
                
                 
             

            //   for(int z=16; z<64;z++)
            //  {
            //     WriteLine(datos[z] | (datos[z+1] << 8));

            //  }
            
            
        }

        fichero.Close();
   
            

        
         
               
        

        
              
        
           
            
    }


        static void Cabecera1()
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
            for(;z<=30;z++)
            {
                if(z==8)
                    {
                            Console.SetCursorPosition(ColOriginal, RowOriginal+z);
                            Console.Write("╠");
                            System.Threading.Thread.Sleep(10);
                            for(int l=1;l<=90;l++)
                            {
                                     Console.SetCursorPosition(ColOriginal+l, RowOriginal+z);
                                    Console.Write("═");
                                    System.Threading.Thread.Sleep(10);
                            }
                    }
                    else{
                            Console.SetCursorPosition(ColOriginal, RowOriginal+z);
                            Console.Write("║");
                            System.Threading.Thread.Sleep(10);
                    }
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
            for(;y<=30;y++)
            {
                     if(y==8)
                    {
                           Console.SetCursorPosition(ColOriginal+i, RowOriginal+y);
                            Console.Write("╣");
                            System.Threading.Thread.Sleep(10);
                          
                    }
                    else{
                        Console.SetCursorPosition(ColOriginal+x, RowOriginal+y);
                        Console.Write("║");
                        System.Threading.Thread.Sleep(10);
                    }
            }
            Console.SetCursorPosition(ColOriginal+x, RowOriginal);
            Console.Write("╗");
            System.Threading.Thread.Sleep(10);              

            pintaFechaYHora();
            Nombrificador(nombreProyecto);       
            Console.SetCursorPosition(ColOriginal+75, RowOriginal+8);      
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

                

            pintaFechaYHora();
            Nombrificador(nombreProyecto);

            

             
                    
        }
    
        static void pintaFechaYHora()
        {
             //aqui añado la zona de la Hora                          
            var colorDeTinta=ForegroundColor;
            string HoraActual = DateTime.Now.ToString("HH:mm:ss"); 
             ForegroundColor= ConsoleColor.DarkGreen;    
            Console.SetCursorPosition(70, 2);           
            Console.WriteLine("Hora: ");
            Console.SetCursorPosition(75, 2);
            ForegroundColor=colorDeTinta;                                
            Console.WriteLine(HoraActual);
              

            //aqui añado la zona de la fecha
            ForegroundColor= ConsoleColor.DarkGreen; 
            Console.SetCursorPosition(2, 2);
            Console.WriteLine("Fecha: ");
            ForegroundColor=colorDeTinta; 
            Console.SetCursorPosition(8, 2);
            Console.WriteLine(DateTime.Now.ToString("dd/MM/yy"));   
        }
        static void Nombrificador(string nombreProyecto)
        {
            var colorDeTinta=ForegroundColor;
            ForegroundColor= ConsoleColor.Blue;
            Console.SetCursorPosition(2, 6);
            Console.WriteLine("Nombre del Desarrollador: ");
            ForegroundColor=colorDeTinta;
            Console.SetCursorPosition(28,6);
            Console.WriteLine("Manuel Beltran Diaz-Meco");

              
            SetCursorPosition(2,4);
            ForegroundColor= ConsoleColor.Blue;
            Console.WriteLine("Nombre del Proyecto: ");
            ForegroundColor=colorDeTinta;
            SetCursorPosition(24,4);
            WriteLine(nombreProyecto);
            ForegroundColor=colorDeTinta;

        }
    
    
       
      
     

         
       
    }
}
