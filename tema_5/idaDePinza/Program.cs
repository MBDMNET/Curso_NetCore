using System;
using classPerro;
using classPerroDeCiudad;
using classPerroDeCampo;
using classCaniche;
using classLabrador;
using classCabecera;
using static System.Console; // esto vale para que no tengas que escribir el Console....

namespace Ejemplo02
{
    class Program
    {


    
        static void Main(string[] args)
        {
            
           
                Cabecera2 cabecera = new Cabecera2();
                cabecera.pintarCabecera2();
                
                Labrador labrador=new Labrador("Lula",7,"Hembra","Azul","Marron","1 metro","labrador","De campo");             
                labrador.Colocar();
                WriteLine(labrador.VerDatos());
                
                Caniche caniche=new Caniche("tobi",8,"Macho","gris",3,"caniche","De Ciudad");
                caniche.Colocar();
                WriteLine( caniche.VerDatos());
               

               

            
              
        }

    }

}
