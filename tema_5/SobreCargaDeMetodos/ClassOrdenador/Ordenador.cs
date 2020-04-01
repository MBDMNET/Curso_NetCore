using System;

namespace ClassOrdenador
{
    public class Ordenador
    {
        string Modelo;
        int Años;

        public void MostrarOrdenador()
        {
            
            
        }

        public void MostrarOrdenador(string modelo)
        {
            this.Modelo=modelo;
            
            Console.WriteLine($"Soy un ordenador y mi modelo es: {this.Modelo}");
            
        }
        public void MostrarOrdenador(string modelo, int años)
        {
            this.Modelo=modelo;
            this.Años=años;
            Console.WriteLine($"Soy un ordenador y mi modelo es: {this.Modelo} y tengo {this.Años} años");
            
        }
    }
}
