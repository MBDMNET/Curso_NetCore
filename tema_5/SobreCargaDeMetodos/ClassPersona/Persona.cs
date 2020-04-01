using System;

namespace ClassPersona
{
    public class Persona
    {
        string Nombre;
        int Edad;
        public void MostrarPersona()
        {

        }
        public void MostrarPersona(string nombre)
        {
            this.Nombre=nombre;
             Console.WriteLine($"Mi nombre es: {this.Nombre}");
            
        }
        public void MostrarPersona(string nombre, int edad)
        {
            this.Nombre=nombre;
            this.Edad=edad;
            Console.WriteLine($"Mi nombre es: {this.Nombre} y tengo {this.Edad} años");
            
        }
    }
}
