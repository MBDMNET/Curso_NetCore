using System;

namespace Ejemplo5
{
    class Program
    {
        static void Main(string[] args)
        {
            // dimensionar la ventana
            int AnchuraOriginal, anchura;
            int AlturaOriginal, altura;

            string texto1="la ventana original tiene de anchura {0} u de alltura {1}";
            string texto2="la ventana original tiene ahora la anchura {0} u de alltura {1}";
            string textoTecla="presiona una tecla para continuar";
            Console.WriteLine("Hello World!");

             AnchuraOriginal= Console.WindowWidth;
             AlturaOriginal= Console.WindowHeight;
             Console.Clear();

             Console.WriteLine(texto1, AnchuraOriginal, AlturaOriginal);
             Console.WriteLine(textoTecla);
             Console.ReadLine();

             anchura= AnchuraOriginal/2;
             altura= AlturaOriginal/2;
             Console.SetWindowSize(anchura,altura);
             Console.WriteLine(texto2, anchura, altura);
             Console.WriteLine(textoTecla);
             Console.ReadLine();

            anchura= AnchuraOriginal;
            altura= AlturaOriginal;
            Console.SetWindowSize(anchura,altura);
            Console.WriteLine(texto2, anchura, altura);




        }
    }
}
