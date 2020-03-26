using System;
using static System.Console; // esto vale para que no tengas que escribir el Console....

namespace ClassCubo
{
   public class Cubo
        {
            public int Lado;

            public Cubo (int lado)
            {
                this.Lado=lado;
            }

            public void imprSuperficie()
            {
                WriteLine($"La superficie del cubo es {Lado*Lado*6} cm") ;
            }

             public void imprVolumen()
            {
                 WriteLine($"La Volumen del cubo es {Lado*Lado*Lado} cm") ;
            }      
            
        }
}
