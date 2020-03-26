using System;
using classlib;

namespace tema5C
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            ClasePadre padre=new ClasePadre();
                padre.show();

                padre=new ClaseHija();
                padre.show();        
                         
        }
    }
}
