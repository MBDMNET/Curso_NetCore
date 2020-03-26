using System;
using static System.Console; // esto vale para que no tengas que escribir el Console....

namespace classOperaciones
{
         public   class Operaciones
        {
            public int Num1;
            public int Num2;

            public Operaciones (int n1,int n2)
            {
                    this.Num1=n1;
                    this.Num2=n2;
            }

          

            public void suma()
            {
                WriteLine($"La suma de {Num1} y {Num2} es {Num1+Num2} ") ;
            }

             public void resta()
            {
                  WriteLine($"La resta de {Num1} y {Num2} es {Num1-Num2} ") ;
            }
              public void multiplicacion()
            {
                  WriteLine($"La multiplicacion de {Num1} y {Num2} es {Num1*Num2} ") ;
            }
              public void division()
            {
                try
                {
                    WriteLine($"La division de {Num1} y {Num2} es {Num1/Num2} ") ;
                }
                catch(DivideByZeroException)
                {
                    Console.WriteLine("Un numero dividido entre 0 da error ");
                }
                 
            }
              public void modulo()
            {
                 WriteLine($"El modulo de {Num1} y {Num2} es {Num1%Num2} ") ;
            }

            
            


            
         
        }
}
