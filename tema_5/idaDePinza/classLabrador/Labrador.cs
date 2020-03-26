using System;
using classPerro;
using classPerroDeCampo;
using static System.Console; // esto vale para que no tengas que escribir el Console....

namespace classLabrador
{
                public  class Labrador:PerroDeCampo
            {
                public string Raza;
                public string Tipo;
                 public Labrador(string nombre,int edad,string sexo,string colorOjos,string color,string tamaño,string raza,string tipo):base(nombre,edad,sexo,colorOjos,color,tamaño)
                {
                    this.Raza=raza;
                    this.Tipo=tipo;
                }
                  public override void Colocar() //Constructor
                {
                    SetCursorPosition(0,17);
                    WriteLine("Soy un labrador");
                }
                public override string VerDatos()
                {
                    return "Mi nombre es: "+Nombre+", Mi edad es :"+Edad+" Mi sexo es: "+Sexo+" Mi raza es: "+Raza+" Soy un perro de: "+Tipo+" Mi tamaño es: "+Tamaño+" Mi color de ojos es: "+ColoOjos+" Mi color de pelo es: "+Color;
                }
            }
}
