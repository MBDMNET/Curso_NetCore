using System;
using static System.Console; // esto vale para que no tengas que escribir el Console....

namespace classPerro
{
            public abstract class Perro
        {
            public string Nombre;
            public int Edad;
            public string Sexo;
            public string ColoOjos;
            public string Color;
            public  Perro(string nombre,int edad,string sexo,string colorOjos,string color)
            {
                this.Nombre=nombre;
                this.Edad=edad;
                this.Sexo=sexo;
                this.ColoOjos=colorOjos;
                this.Color=color;
               
            }

            public Perro(string nombre,int edad,string sexo,string color)
            {
                this.Nombre=nombre;
                this.Edad=edad;
                this.Sexo=sexo;               
                this.Color=color;
               
            }

            public virtual void Colocar() //Constructor
            {
                SetCursorPosition(0,10);
                WriteLine("Soy un perro");
            }

            public abstract string VerDatos();
           
        }
}
