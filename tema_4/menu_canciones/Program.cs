﻿using System;
using static System.Console; // esto vale para que no tengas que escribir el Console....

namespace Ejemplo02
{
    class Program
    {
        struct Cancion
        {
            public string Artista;
            public string Titulo;
            public int Duracion;
            public int Tamaño;
        }

        static void Main(string[] args)
        {
            var ColoFondoOriginal = Console.BackgroundColor;
            var ColoTintaOriginal = Console.ForegroundColor;
            
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

           Cancion [] canciones;           
            canciones = new Cancion[100];
           SetCursorPosition(0,12);
           do
           {
               int menu;
               WriteLine("Pulse 1 si quiere añadir una cancion");
               WriteLine("Pulse 2 si quiere mostrar todas las canciones");
               WriteLine("Pulse 3 si quiere buscar una cancion que dure menos de X seg");
               WriteLine("Pulse S si quiere salir del programa");
                menu=int.Parse(ReadLine());
                switch (menu)
                {
                    case 1:
                    Cancion cancion=anadirCancion();
                        
                        
                      for(int i =0; i<100; i++)
                        {
                            
                            // var index = Array.LastIndexOf(canciones,"");
                            // WriteLine(index);

                            if(canciones[i].Titulo =="" )
                            {
                                WriteLine("Entro a añadir la cancion");
                                canciones[i]=cancion;
                            }
                        } 
                        break;
                    case 2:
                    for(int z =0; z<canciones.Length;z++)
                    {

                        WriteLine($" el Artista es: {canciones[z].Artista}"); 
                        WriteLine($" el Titulo es: {canciones[z].Titulo}"); 
                        WriteLine($" la Duracion es: {canciones[z].Duracion}"); 
                        WriteLine($" el Tamaño es: {canciones[z].Tamaño}"); 

                    }
                        break;
                    case 3:
                    WriteLine("Introduzca los segundos que desea buscar o menor");
                        int seg=int.Parse(ReadLine());
                        for(int j =0; j<canciones.Length;j++)
                        {
                            
                            if(canciones[j].Duracion<seg  && canciones[j].Duracion!=0)
                            {
                                WriteLine($"La cancion {canciones[j].Titulo} su diracion es{canciones[j].Duracion}");
                            }
                        }
                        break;
                    default:
                    break;
                }



           }while(ReadKey().KeyChar!='s');



           
           
           
              
           
           
            
    }
        static Cancion anadirCancion()
        {
            Cancion cancion;
            WriteLine("Introduzca el nombre del Artista");
           cancion.Artista=ReadLine();
            WriteLine("Introduzca el titulo de la cancion");
           cancion.Titulo=ReadLine();
           WriteLine("Introduzca la duracion de la cancion");
           cancion.Duracion= int.Parse(ReadLine());

           WriteLine("Introduzca el tamaño de la cancion");
           cancion.Tamaño= int.Parse( ReadLine());
            return cancion;
          
        }

        // static void mostrarTodas(Cancion canciones)
        // {
        //     for(int i =0; i<=canciones.Length;i++)
        //     {
        //        WriteLine($" el Artista es: {canciones[i].Artista}"); 
        //        WriteLine($" el Titulo es: {canciones[i].Titulo}"); 
        //        WriteLine($" la Duracion es: {canciones[i].Duracion}"); 
        //        WriteLine($" el Tamaño es: {canciones[i].Tamaño}"); 
        //     }
        // }

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
    
    
        static long Calculaticks(DateTime horaInicio,DateTime horaFinal)
        {
            long TicksInicio    = horaInicio.Ticks;
            long TicksFinal     = horaFinal.Ticks;
           
            return (TicksFinal-TicksInicio);
        }

         static void Sonido(){  
            int beepgen1, beepgen2, beepgen3, beepgen4, beepgen5, beepgen6, beepgen7, beepgen8, beepgenn1, beepgenn2, beepgenn3, beepgenn4, beepgenn5, beepgenn6, beepgenn7, beepgenn8;
            Random randomgen = new Random();

            beepgen1 = (randomgen.Next(37, 7000));
            beepgen2 = (randomgen.Next(37, 6000));
            beepgen3 = (randomgen.Next(37, 6000));
            beepgen4 = (randomgen.Next(37, 7000));
            beepgen5 = (randomgen.Next(37, 8000));
            beepgen6 = (randomgen.Next(37, 7000));
            beepgen7 = (randomgen.Next(37, 7000));
            beepgen8 = (randomgen.Next(37, 5000));
            beepgenn1 = (randomgen.Next(50, 200));
            beepgenn2 = (randomgen.Next(50, 250));
            beepgenn3 = (randomgen.Next(50, 300));
            beepgenn4 = (randomgen.Next(50, 200));
            beepgenn5 = (randomgen.Next(50, 250));
            beepgenn6 = (randomgen.Next(50, 200));
            beepgenn7 = (randomgen.Next(50, 300));
            beepgenn8 = (randomgen.Next(50, 250));

            Console.Beep(beepgen1, beepgenn1);
            Console.Beep(beepgen2, beepgenn2);
            Console.Beep(beepgen3, beepgenn3);
            Console.Beep(beepgen4, beepgenn4);
            Console.Beep(beepgen5, beepgenn5);
            Console.Beep(beepgen6, beepgenn6);
            Console.Beep(beepgen7, beepgenn7);
            Console.Beep(beepgen8, beepgenn8);
        }
       
    }
}
