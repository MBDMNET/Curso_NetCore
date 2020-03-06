using System;

namespace Ejemplo03
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("manuel\tbeltran\nvamos a probar");
            // // "\t" sirve para tabular, pero si usas el @, te elimina las tabulaciones
            // Console.WriteLine(@"manuel\tbeltran\nvamos a probar");

            // programa para introducir tu nombre
            // Console.WriteLine("Introduca su nombre");
            // string nombre = Console.ReadLine();// sirve para recoger datos metidos desde la consola.
            // Console.WriteLine("Introduca su apellidos");
            // string apellido = Console.ReadLine();
            // Console.WriteLine($"tu nombre es: {nombre} y tu apellido {apellido}");


            // Console.WriteLine("Pulse una tecla o combinaciones de teclas");
             //ConsoleKeyInfo tecla = Console.ReadKey(); // sirve para saber que tipo de letra es
            // Console.WriteLine(); // espacio en blanco
            // Console.WriteLine("tecla:{0}, caracter que representa: {1}, tecla modificador: {2} ",
            // arg0:tecla.Key, // los arg0, arg1, y arg2 se sustituyen por el {0},{1},{2}
            // arg1:tecla.KeyChar,
            // arg2: tecla.Modifiers
            
            // ); 
        int numero = 1;
        Console.WriteLine("el numero 1 se escribe como"+numero);
        Console.WriteLine($"el numero 1 se escribe como{numero}");
         Console.WriteLine("el numero 1 se escribe como: {0} y el siguiente es: {1}",
         arg0:numero++,
         arg1:numero);




        }
    }
}
