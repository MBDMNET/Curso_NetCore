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
            




   
            

        
        StreamReader Peliculas;
       
       
        string linea;
        int pos=12 ;


           try
           {
               Peliculas= File.OpenText("disney.txt"); 
               
                     
                   SetCursorPosition(0,pos);
                   linea = Peliculas.ReadLine();                                  
                    
                    WriteLine(linea);
                   if(linea.StartsWith('1'))
                   {
                    
                        anadirPeliculas( linea);              
                                                      
                   }

                    
                   
               
               
                Peliculas.Close();
           } 
           catch(Exception exp)
           {
               WriteLine($"Ha habido un error: {exp.Message}");
               return ;
           }
            
            
               
        

        
              
        
           
            
    }
         static void anadirPeliculas( string linea)
         {
             StreamWriter Peliculas2;
             WriteLine(linea);
             for(int i =0; i>=0;i++)
               {
                   
                   if(!File.Exists("peliculasPorA.txt"))
                    {
                        WriteLine("entro en no existe el fichero");
                            Peliculas2 = File.CreateText("peliculasPorA.txt");
                           Peliculas2.WriteLine(linea);                            
                           Peliculas2.Close(); 
                    }
                    if(File.Exists("peliculasPorA.txt"))
                    {
                        WriteLine("entro en  existe el fichero");
                        WriteLine(linea);
                            Peliculas2 = File.AppendText(linea);                          
                            Peliculas2.Close();  
                            if(linea=="")
                            {
                                break;
                            }
                    } 
                           
               }
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
