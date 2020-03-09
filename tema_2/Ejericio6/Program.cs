using System;
using static System.Console; // esto vale para que no tengas que escribir el Console....

namespace Ejericio1
{
    enum dias {lunes=1,martes,miercoles,jueves,viernes,sabado,domingo};
    class Program
    {
         
        static void Main(string[] args)
        {
            Clear();
            /* pedir al usuario un un precio del producto, y la forma de pagar (efectivo o tarjeta)
                si la forma de pago es mediante de tarjeta, pedir el numero de la tarjeta            
            */
            precio:  
                 WriteLine("introduzca el precio");
                int precio = int.Parse(ReadLine());
                if (precio < 0) goto precio;
            
           

            WriteLine("Pulse 1 si desea pagar con tarjeta, y puse 2 si desea pagar con efectivo");
            string tipoPago = ReadLine();

            if(tipoPago=="1")
            {
                
                WriteLine("introduzca el Numero de su tarjeta");
                string tarjeta = ReadLine();
                

                WriteLine($"ha decidido pagar {precio}, en tarjeta, con la cuenta: {tarjeta}");
            }
            else
            {
                WriteLine($"ha decidido pagar {precio}, en efectivo");
            }


          

        }

        
        
    }
}
