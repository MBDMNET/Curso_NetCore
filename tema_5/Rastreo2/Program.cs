using System;
using classRastreo;
using classCabecera;
using static System.Console;
using  System.Diagnostics;

namespace Rastreo2
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch timeMeasure = new Stopwatch();
            timeMeasure.Start();
             DateTime horaInicio= DateTime.Now;
            Cabecera2 cabecera = new Cabecera2();
                cabecera.pintarCabecera2();
                SetCursorPosition(0,10);
                string url = args[0];
                Rastreo rastreo = new Rastreo(url,horaInicio,timeMeasure);
                
        }
    }
}
