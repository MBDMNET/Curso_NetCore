using System;
using static System.Console; // esto vale para que no tengas que escribir el Console....


namespace classVendedor1
{
    public partial class Vendedor
    {
        string Nombre;
            double Enero;
            double Febrero;
            double Marzo;
            double Abril;
            double Mayo;
            double Junio;
            double Julio;
            double Agosto;
            double Septiembre;
            double Octubre;
            double Noviembre;
            double Diciembre;

                 public  Vendedor(string nombre,double enero)
            {
                this.Nombre=nombre;
                 Random random = new Random();
                this.Enero=enero;
                this.Febrero=enero*random.Next(0,5);
                this.Marzo=enero*random.Next(0,5);
                this.Abril=enero*random.Next(0,5);
                this.Mayo=enero*random.Next(0,5);
                this.Junio=enero*random.Next(0,5);
                this.Julio=enero*random.Next(0,5);
                this.Agosto=enero*random.Next(0,5);
                this.Septiembre=enero*random.Next(0,5);
                this.Octubre=enero*random.Next(0,5);
                this.Noviembre=enero*random.Next(0,5);
                this.Diciembre=enero*random.Next(0,5);
            }


            public void imprVentas()
            {
                WriteLine($"Las de {Nombre} ventas de Enero son {Enero} € ");
                WriteLine($"Las de {Nombre} ventas de Febrero son {Febrero} € ");
                WriteLine($"Las de {Nombre} ventas de Marzo son {Marzo} € ");
                WriteLine($"Las de {Nombre} ventas de Abril son {Abril} € ");
                WriteLine($"Las de {Nombre} ventas de Mayo son {Mayo} € ");
                WriteLine($"Las de {Nombre} ventas de Junio son {Junio} € ");
                WriteLine($"Las de {Nombre} ventas de Julio son {Julio} € ");
                WriteLine($"Las de {Nombre} ventas de Agosto son {Agosto} € ");
                WriteLine($"Las de {Nombre} ventas de Septiembre son {Septiembre} € ");
                WriteLine($"Las de {Nombre} ventas de Octubre son {Octubre} € ");
                WriteLine($"Las de {Nombre} ventas de Noviembre son {Noviembre} € ");
                WriteLine($"Las de {Nombre} ventas de Diciembre son {Diciembre} € ");
            }
    }
}
