using System;
using static System.Console; // esto vale para que no tengas que escribir el Console....

namespace Ejericio1
{
    enum dias {lunes=1,martes,miercoles,jueves,viernes,sabado,domingo};
    class Program
    {
         
        static void Main(string[] args)
        {
            Clear();
            int producto = (int.Parse(args[0]))*(int.Parse(args[1]));
            /* pedir un dia de la semana y decir si es finde semana o no"*/
            WriteLine($"La multiplicacion es : {producto}");
            
          
        }
    }
}
