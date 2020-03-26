using System;
using classPerro;
using static System.Console; // esto vale para que no tengas que escribir el Console....


namespace classPerroDeCiudad
{
            public abstract class PerroDeCiudad:Perro
            {
                public int NumeroDeHijos;
                 public PerroDeCiudad(string nombre,int edad,string sexo,string color,int numHijos):base(nombre,edad,sexo,color)
                {
                    this.NumeroDeHijos=numHijos;
                }

                public override void Colocar() //Constructor
                {
                    SetCursorPosition(0,20);
                    WriteLine("Soy un perro de ciudad");
                }
               
            }
}
