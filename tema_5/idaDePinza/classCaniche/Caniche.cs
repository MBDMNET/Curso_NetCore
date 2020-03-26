using System;
using classPerro;
using classPerroDeCiudad;
using static System.Console; // esto vale para que no tengas que escribir el Console....

namespace classCaniche
{
   public  class Caniche:PerroDeCiudad
            {
                public string Raza;
                public string Tipo;
                public Caniche(string nombre,int edad,string sexo,string color,int numHijos,string raza,string tipo):base(nombre,edad,sexo,color,numHijos)
                {
                    this.Raza=raza;
                    this.Tipo=tipo;
                }
                  public override void Colocar() //Constructor
                {
                    SetCursorPosition(0,22);
                    WriteLine("Soy un caniche");
                }
                public override string VerDatos()
                {
                    return "Mi nombre es: "+Nombre+", Mi edad es :"+Edad+" Mi sexo es: "+Sexo+" Mi raza es: "+Raza+" Soy un perro de: "+Tipo+ "Mi color de pelo es: "+Color+" y tengo "+NumeroDeHijos+" hijos";
                }
            }
}
