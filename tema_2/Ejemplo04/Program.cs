using System;

namespace Ejemplo04
{
    class Program
    {
        enum Color {yellow=1, blue, green};
        enum Meses {enero=1, febrero, marzo, abril, mayo, junio=10, julio, agosto, septiembre, octubre, noviembre, diciembre};
        static void Main(string[] args)
        {
            // Console.Clear();
            // Console.WriteLine("Enumeraciones");
            // Console.WriteLine(
            //     "General (G) \t {0:G}\n"+
            //     "Defecto  \t {0} (default = 'G')\n"+
            //     "Flags  \t {0:F} (flags o integer)\n"+
            //     "Numero Decimal  \t {0:D}\n"+
            //     "Hexadecimal  \t {0:X}\n",Color.green

            // );

            // Console.WriteLine(
            //     "General (G) \t {0:G}\n"+
            //     "Defecto  \t {0} (default = 'G')\n"+
            //     "Flags  \t {0:F} (flags o integer)\n"+
            //     "Numero Decimal  \t {0:D}\n"+
            //     "Hexadecimal  \t {0:X}\n",Meses.marzo

            // );
            //el 0 antes de los : es la posicion en la que el mes le pases al final del array o de la concatenacion
            //Console.WriteLine("el mes de {0:D} y el numero del mes de {1:G} es: {1:D}",Meses.julio,Meses.enero);
             Console.WriteLine("\r //r=Otra Linea. \a //a=Timbre  //n=nueva linea");
             Console.WriteLine("\t texto tabulado");
        }
    }
}
