using System;
using static System.Console; // esto vale para que no tengas que escribir el Console....
using System.IO;
using System.Collections;

namespace Ejemplo02
{

    class Program
    {
         struct Pelicula
        {
            public DateTime Fecha;
            public string Titulo;
            public string Tamaño;
           
        }

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



            //aqui leemos el archivo que existe
            StreamReader Peliculas;
            Peliculas = File.OpenText("disney2.txt");
            int total=0;
            string linea;
            for(total=0;total>=0;total++)
            {
                linea=Peliculas.ReadLine(); 
                if(linea==null)
                {
                    WriteLine($"El nuermo total de peliculas es: {total}");
                    break;
                }
            }
            
            StreamReader Peliculas2;
            Peliculas2 = File.OpenText("disney2.txt");
            Pelicula [] ColleccionPeliculas ;
            ColleccionPeliculas = new Pelicula[total];
            DateTime Fecha;
          
            string Tamaño;
            string linea2;
             
            SetCursorPosition(0,12);

            WriteLine(total);
           for(int i=0; i<total;i++)
           {
            Pelicula film;
            
            
            linea2=Peliculas2.ReadLine();
            Fecha=DateTime.Parse(linea2.Substring(0,17));   
            linea2=linea2.Remove(0,22);            
            Tamaño=linea2.Substring(0,13);
            Tamaño=Tamaño.Replace(" ","");
            linea2=linea2.Remove(0,14);
                //WriteLine(Tamaño);
            
            
            film.Fecha=Fecha;
            film.Tamaño= Tamaño ;
            film.Titulo=linea2;
            ColleccionPeliculas[i]=film;
            //WriteLine($" el tamaño es : {ColleccionPeliculas[i].Titulo}, el titulo es {film.Titulo} y la fecha es {film.Fecha}");             
           
            
           }
            Peliculas.Close();  

           
            for(int j=0; j<total;j++)
            {
                    for(int z=0; z<=1;z++)
                    {
                    WriteLine(ColleccionPeliculas[j].Titulo);
                    WriteLine(ColleccionPeliculas[j].Tamaño);
                    WriteLine(ColleccionPeliculas[j].Fecha);
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
