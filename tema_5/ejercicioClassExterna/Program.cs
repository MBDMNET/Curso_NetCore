using System;
using classlib;
using claseExternaNueva;

namespace ejercicioClassExterna
{
    class Program
    {
        static void Main(string[] args)
        {
            Prueba prueba=new Prueba();
            prueba.Escribir();

            ClaseExterna claseExterna = new ClaseExterna();
            claseExterna.EscriboDesdeFuera();

        }
    }
}
