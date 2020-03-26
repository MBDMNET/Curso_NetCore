using System;
using classPerro;
using static System.Console; // esto vale para que no tengas que escribir el Console....

namespace classPerroDeCampo
{
           public abstract class PerroDeCampo:Perro
            {
                public string Tamaño;
                public PerroDeCampo(string nombre,int edad,string sexo,string colorOjos,string color,string tamaño):base(nombre,edad,sexo,colorOjos,color)
                {
                    this.Tamaño=tamaño;
                }
                public override void Colocar() //Constructor
                {
                    SetCursorPosition(0,15);
                    WriteLine("Soy un perro de campo");
                }
            

               
            }
}
