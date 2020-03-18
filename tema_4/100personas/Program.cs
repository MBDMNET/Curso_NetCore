using System;
using static System.Console; // esto vale para que no tengas que escribir el Console....

namespace Ejemplo02
{
    class Program
    {
        struct FechaNacimiento
        {
            public int Dia;
            public int Mes;
            public int Año;
            
            
        }
        struct Persona
        {
            public string Nombre;
            public int Edad;
            public FechaNacimiento FechaNacimiento;
            
            
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

           Persona [] personas;           
            personas = new Persona[101];
           SetCursorPosition(0,12);

            for(int i=1; i<=100;i++)
            {
                Persona humano;
                humano.Nombre="nombre "+i;
                humano.Edad=i;
                humano.FechaNacimiento.Dia=08;
                humano.FechaNacimiento.Mes=18;
                humano.FechaNacimiento.Año=20;

                personas[i]=humano;
                WriteLine($"El nombre es: {personas[i].Nombre} y la edad es {personas[i].Edad} y la fecha de nacimiento es {personas[i].FechaNacimiento.Dia}-{personas[i].FechaNacimiento.Mes}-{personas[i].FechaNacimiento.Año}");
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
