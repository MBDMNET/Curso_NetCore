using System;

namespace animales
{
    public class Animal
    {
        string Tipo;
        int Edad;

          public void MostrarAnimal()
        {

        }

        public  void  MostrarAnimal(string tipo)
        {
            this.Tipo=tipo;
            Console.WriteLine($"Soy un animal de tipo: {this.Tipo}");
        }

         public  void  MostrarAnimal(string tipo,int edad)
        {
            this.Tipo=tipo;
            this.Edad=edad;
            Console.WriteLine($"Soy un animal de tipo: {this.Tipo} y mi edad es: {this.Edad}");
        }
    }

}
