using System;
using System.Text; //hay que importarlo para poder usar el stringBuilder
using static System.Console; // esto vale para que no tengas que escribir el Console....

namespace Ejericio1
{
   
    class Program
    {
         
        static void Main(string[] args)
        {
            Clear();
            StringBuilder nombres = new StringBuilder("Manuel Beltran"); //Podemos crear cadenas de texto mutables que si pueden ser modificables
            nombres[0]='p'; // esto modifica en laposicion 0 del array de la cadena de tecto y la sustutye por el caracter
             nombres.AppendLine(); // metodo que genera un salto de linea
            nombres.Append(" Diaz-Meco").Append(" y tengo 20 años"); // sierve para añadir al final de una cadena de texto, mas texto
           
             nombres.Capacity=130; // la capacidad de caracteres de texto que suportara
            // y podemos añadir mas texto
            WriteLine(nombres.ToString());
            WriteLine(nombres.GetHashCode()); 
            WriteLine(nombres.Length); // numero que mide nuestra cadena de texto
            WriteLine(nombres.AppendFormat(" Hobbie: {0}","informatica"));
           

            //WriteLine(nombres);


            


            
            
            
            
          
        }
    }
}
