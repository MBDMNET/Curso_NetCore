using System;
using static System.Console; // esto vale para que no tengas que escribir el Console....

namespace Ejemplo02
{
    class Program
    {
        static void Main(string[] args)
        {
            Clear();  
            //Condicionales
            var numero = (new Random()).Next(1,7);
            WriteLine($"He creado este numero aleatorio :{numero}");
            switch (numero)
            {
                case 1:
                    WriteLine("Uno");
                    break;

                case 2:
                    WriteLine("Dos");
                    goto case 1;
                case 3:
                case 4:
                    WriteLine("uno");
                    break;


                case 5:
                    System.Threading.Thread.Sleep(500);
                    WriteLine("he tardado por que he puesto una pausa, no se ha estropeado tranquilo");
                    break;            
                
                default:
                WriteLine("no he acertado ninguno");
                break;
            }

            Clear();  
            //Practicas Numero aleatorios
            //Crear 5 numero aleatorio entre 1 y 500, mostrarlos y calcular el producto de todos ellos
            double [] numeros ;
            numeros = new double[5];
            double total=1;
            for(int i=0; i<=4; i++)
            {
                 numeros[i] = (new Random()).Next(1,500);
                 WriteLine($"El numero {i+1} es el  {numeros[i]}");
                 total= total*numeros[i];
                 
                 
                 
            }
            WriteLine($"El Producto de todos los numeros es: {total}");



            //GEnerar 10 numeros aleatorios entre (-45783 y 96431), muestralos en una misma linea y miltiplicalos y saca su resultado en un formato humano
            double [] numeros2 ;
            numeros2 = new double[10];
            double total2=1;
            string fila = "";
            for(int z=0; z<=9; z++)
            {
                 numeros2[z] = (new Random()).Next(-45783,96431);
                fila=fila+ $"El numero {z+1} es el  {numeros2[z]},";
                
                 total2= total2*numeros2[z];
                 
                 
                 
            }
             WriteLine(fila);
             WriteLine($"El total es  {total2:N0}"); //:N0 lo formatea a ponerle los . de los miles      



            //While
            
                int x = 0;
                Clear();
                while(true)
                {
                    x++;
                    if(x==2000)
                    {
                        break;
                    }
                }
            

            //do while
            string Contraseña= String.Empty; //string.Empty es para ver si no esta vacia
            do
            {
                    Clear();
                   WriteLine($"Escriba la contraseña: ");
                   Contraseña= ReadLine();

            }while(Contraseña != "C4C4");
            WriteLine("Lo has conseguido");
        }
    }
}
