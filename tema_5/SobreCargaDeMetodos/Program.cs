using System;
using animales;
using classCabecera;
using ClassPersona;
using ClassOrdenador;

namespace tema5C
{
    class Program
    {
        static void Main(string[] args)
        {
             Cabecera2 cabecera = new Cabecera2();
                cabecera.pintarCabecera2();
                Console.SetCursorPosition(0,10);
                Console.WriteLine("Introduzca El tipo del animal");
                string tipo= Console.ReadLine();
                Console.WriteLine("Introduzca la edad del animal");
                int edad = int.Parse(Console.ReadLine());

                Animal animal = new Animal();
                animal.MostrarAnimal();
                animal.MostrarAnimal(tipo);
                animal.MostrarAnimal(tipo,edad);

                Console.WriteLine("Introduzca el nombre ");
                string nombre= Console.ReadLine();
                Console.WriteLine("Introduzca la edad");
                int edadP = int.Parse(Console.ReadLine());

                Persona persona = new Persona();
                persona.MostrarPersona();
                persona.MostrarPersona(nombre);
                persona.MostrarPersona(nombre,edadP);

                Console.WriteLine("Introduzca el Modelo ");
                string modelo= Console.ReadLine();
                Console.WriteLine("Introduzca Los años");
                int edadO = int.Parse(Console.ReadLine());

                Ordenador pc = new Ordenador();
                pc.MostrarOrdenador();
                pc.MostrarOrdenador(modelo);
                pc.MostrarOrdenador(modelo,edadO);
                

               
                
        }
    }
}
