using System;
using static System.Console; // esto vale para que no tengas que escribir el Console....

namespace Ejemplo02
{
    class Program
    {
        static void Main(string[] args)
        {
            //operadores unitarios
            Clear();  
            // uint a  = 5;
            // var b = -a;
            // WriteLine(b);
            // WriteLine(b.GetType());
            // WriteLine(a.GetType());

            int p = 6;
            p += 3;
            WriteLine(p);
            p -= 3;
            WriteLine(p);
            p *= 3;
            WriteLine(p);
            p /= 3;
            WriteLine(p);


            // FOR VS FOREACH
            /*
            Tipo de dato debe tener un numero llamada GetEnumerator
            Current y movenext
            El metodo moveNext deve devulver true, si no enumeran o false

            Conversiones:
                -Implicita:
                    Se realiza automaticamente
                -Explicita
                    convert


            
            
            */
            //implicita
            int a = 10;
            double b = a;
            WriteLine(b);

            // double c = 9.8;
            // int d= c;
            // WeakReference(d); // no se puede hacer hay perdida de datoss

            //Explicita
            double g = 9.8;
            int h = Convert.ToInt32(g);
            WriteLine(h); // no se puede hacer hay perdida de datoss

            //Conversion de cualquier tipo a String
            int numero =  12;
            WriteLine(numero.ToString());

            bool booleano =  true;
            WriteLine(booleano.ToString());

            DateTime fecha =   DateTime.Now;
            WriteLine(fecha.ToString());

             object objeto =   new Object();
            WriteLine(objeto.ToString());

            //convertir cadena a numero
            
            int edad = int.Parse("27");
            DateTime Cumpleaños = DateTime.Parse(" agosto 1998");
            WriteLine(Cumpleaños);


            


            
            
        }
    }
}
