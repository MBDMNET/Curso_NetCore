using System;
using static System.Console; // esto vale para que no tengas que escribir el Console....

namespace Ejemplo02
{
    class Program
    {
        public abstract class Perro
        {
            public string Nombre;
            public int Edad;
            public string Sexo;
            public string ColoOjos;
            public string Color;
            public  Perro(string nombre,int edad,string sexo,string colorOjos,string color)
            {
                this.Nombre=nombre;
                this.Edad=edad;
                this.Sexo=sexo;
                this.ColoOjos=colorOjos;
                this.Color=color;
               
            }

            public Perro(string nombre,int edad,string sexo,string color)
            {
                this.Nombre=nombre;
                this.Edad=edad;
                this.Sexo=sexo;               
                this.Color=color;
               
            }

            public virtual void Colocar() //Constructor
            {
                SetCursorPosition(0,10);
                WriteLine("Soy un perro");
            }

            public abstract string VerDatos();
           
        }

            public abstract class PerroDeCampo:Perro
            {
                public string Tamaño;
                public PerroDeCampo(string nombre,int edad,string sexo,string colorOjos,string color,string tamaño):base(nombre,edad,sexo,colorOjos,color)
                {
                    this.Tamaño=tamaño;
                }
                public override void Colocar() //Constructor
                {
                    SetCursorPosition(0,15);
                    WriteLine("Soy un perro de campo");
                }
            

               
            }

            public abstract class PerroDeCiudad:Perro
            {
                public int NumeroDeHijos;
                 public PerroDeCiudad(string nombre,int edad,string sexo,string color,int numHijos):base(nombre,edad,sexo,color)
                {
                    this.NumeroDeHijos=numHijos;
                }

                public override void Colocar() //Constructor
                {
                    SetCursorPosition(0,20);
                    WriteLine("Soy un perro de ciudad");
                }
               
            }

            public  class Labrador:PerroDeCampo
            {
                public string Raza;
                public string Tipo;
                 public Labrador(string nombre,int edad,string sexo,string colorOjos,string color,string tamaño,string raza,string tipo):base(nombre,edad,sexo,colorOjos,color,tamaño)
                {
                    this.Raza=raza;
                    this.Tipo=tipo;
                }
                  public override void Colocar() //Constructor
                {
                    SetCursorPosition(0,17);
                    WriteLine("Soy un labrador");
                }
                public override string VerDatos()
                {
                    return "Mi nombre es: "+Nombre+", Mi edad es :"+Edad+" Mi sexo es: "+Sexo+" Mi raza es: "+Raza+" Soy un perro de: "+Tipo+" Mi tamaño es: "+Tamaño+" Mi color de ojos es: "+ColoOjos+" Mi color de pelo es: "+Color;
                }
            }
            public  class Caniche:PerroDeCiudad
            {
                public string Raza;
                public string Tipo;
                public Caniche(string nombre,int edad,string sexo,string color,int numHijos,string raza,string tipo):base(nombre,edad,sexo,color,numHijos)
                {
                    this.Raza=raza;
                    this.Tipo=tipo;
                }
                  public override void Colocar() //Constructor
                {
                    SetCursorPosition(0,22);
                    WriteLine("Soy un caniche");
                }
                public override string VerDatos()
                {
                    return "Mi nombre es: "+Nombre+", Mi edad es :"+Edad+" Mi sexo es: "+Sexo+" Mi raza es: "+Raza+" Soy un perro de: "+Tipo+ "Mi color de pelo es: "+Color+" y tengo "+NumeroDeHijos+" hijos";
                }
            }

        
    
        static void Main(string[] args)
        {
            
           
           
                Cabecera2();
                Labrador labrador=new Labrador("Lula",7,"Hembra","Azul","Marron","1 metro","labrador","De campo");             
                labrador.Colocar();
                WriteLine(labrador.VerDatos());
                
                Caniche caniche=new Caniche("tobi",8,"Macho","gris",3,"caniche","De Ciudad");
                caniche.Colocar();
                WriteLine( caniche.VerDatos());
               

               

            
              
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
