﻿using System;
using static System.Console; // esto vale para que no tengas que escribir el Console....
using static System.Environment;
using System.IO;


namespace Ejemplo02
{
    class Program
    {
        class Archivo_temporal
        {
            public string Nombre;
            
            public string Version;
            public int Tiempo;

            public Archivo_temporal()
            {

            }
            public Archivo_temporal(string nombre,  string version,int tiempo)
            {
                this.Nombre=nombre;
                this.Tiempo=tiempo;
                this.Version=version;
            }

        }
        
        static void Main(string[] args)
        {
            
           
           
               Cabecera2(); 
               SetCursorPosition(0,10); 
                  //Environment.CurrentDirectory = Environment.GetEnvironmentVariable("windir");
                  

                string direcTemp=Environment.GetEnvironmentVariable("TEMP");
                
                
               
                StreamWriter fichero;
                fichero=File.CreateText($"{direcTemp}\\archivo_temporal.txt");
                WriteLine($"directTemp: {direcTemp}");  

                Archivo_temporal Arch = new Archivo_temporal();
                Arch.Nombre=Environment.MachineName;
                Arch.Tiempo=Environment.TickCount;
                Arch.Version=Environment.Version.ToString();
                
                fichero.WriteLine($"Nombre Maquina: {Arch.Nombre}");
                fichero.WriteLine($"Tiempo Encendia: {Arch.Tiempo}");
                fichero.WriteLine($"Version: {Arch.Version}");                
                fichero.Close();

                StreamReader ficheroLectura;
                string fila;
                ficheroLectura = File.OpenText($"{direcTemp}\\archivo_temporal.txt");
                do
                {
                    fila=ficheroLectura.ReadLine();
                    if(fila!=null)
                    {
                        WriteLine(fila);
                    }

                }while(fila!=null);
                ficheroLectura.Close();

                
               
               
                 
                //  WriteLine($"Environment.GetLogicalDrives: { Environment.GetFolderPath()}");

               

            
              
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
