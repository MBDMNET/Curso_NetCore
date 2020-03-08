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
             var texto = "curso de c# de 2020 ";

            WriteLine(texto.Substring(5,11)); // muestra desde la posicion 5, y 11 posiciones mas
            WriteLine(texto.Replace("c","C")); // este metodo sustituye el primer parametro por lo que haya en el segundo
            WriteLine(texto.Remove(6,2)); // este metodo Elimina desde el primer parametro. y el segundo parametro indica cuantas posiciones mas va a eliminar
             
             var texto2 = "Curso de C# De 2020 ";
             var comparar = "de";
             var comparar2="Curso de C# De 2020 ";
             var num = 2;
          
            WriteLine(texto2.IndexOf('c')); //posicion en la que se encuentra un caracter en una cadena 
             WriteLine(texto2.IndexOf("2020")); //posicion en la que se encuentra un caracter en una cadena 
            //comillas simples es para un caracter, comillas dobles para una palabra
            WriteLine(texto2.ToCharArray()[0]); //convierte una cadena de texto en un array letra por letra
            WriteLine(texto2.ToCharArray()[1]);
            WriteLine(texto2.ToCharArray()[2]);
            WriteLine(texto2.ToCharArray()[3]);
            WriteLine(texto2.ToCharArray()[4]);

            WriteLine(texto2.ToLower()); // todos los caracteres en mayusculas las pasa a minusculas
            WriteLine(texto2.ToUpper());// todos los caracteres de minusculas a mayusculas
            WriteLine(texto2.Equals(comparar)); //compara dos cadenas de texto
            WriteLine(texto2.Equals(comparar2)); //compara dos cadenas de texto
            WriteLine(texto2.GetType()); //devuelve el tipo de la variable
             WriteLine(num.GetType()); //devuelve el tipo de la variable

             //recorer una cadena de string
             foreach (var item in texto2)
             {
                    WriteLine(item);
             }
            


            
            
            
            
          
        }
    }
}
