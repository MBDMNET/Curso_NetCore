using System;
using static System.Console; // esto vale para que no tengas que escribir el Console....

namespace Ejemplo08
{
    class Program
    {
        static void Main(string[] args)
        {
            // tratar textos
                //fallo por que hay que hacerle el casting
            Console.WriteLine("intriduca un numero");
            int Numero = int.Parse(Console.ReadLine())+10;
            
             Console.WriteLine("intriduca un numero + 10 es: "+Numero);


             //objetos no es aconsejable
             object anchura = 1.88; // es igual que una variable double
              object palabra = "mesa"; // es igual que una variable string
              Console.WriteLine($"el nombre es {palabra} y la anchura es {anchura}");
                Console.Clear();
              //visibilidad de las variables
                //Matrices
                string [] nombres;
                nombres = new string[4];
                nombres[0] = "nombre1";
                nombres[1] = "nombre2";
                nombres[2] = "nombre3";
                nombres[3] = "nombre4";

                for( int i=0; i<nombres.Length; i++)
                {
                    Console.WriteLine(nombres[i]);
                }

                Console.Clear();
                //Tipos Null por fallos de conexcion, etc se utiliza para indicar que 
                // variable no ha sido extablecida
                int? podriaSerNull = null;
                 Console.WriteLine(podriaSerNull);
                Console.WriteLine(podriaSerNull.GetValueOrDefault());
                podriaSerNull = 7;
                Console.WriteLine(podriaSerNull);
                Console.WriteLine(podriaSerNull.GetValueOrDefault());

                






        }
    }
}
