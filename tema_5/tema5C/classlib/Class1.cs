using System;
using static System.Console; // esto vale para que no tengas que escribir el Console....

namespace classlib
{
     public class ClasePadre 
    {
        public virtual void show()
        {
            SetCursorPosition(2,10);
            WriteLine("Clase Base");
        }
    }

    public class ClaseHija:ClasePadre 
    {
        public override void show() 
        {
            SetCursorPosition(3,5);
            WriteLine("Clase Hija");
        }
    }
}
