using System;
using static System.Console; // esto vale para que no tengas que escribir el Console....

namespace Ejericio1
{
    enum dias {lunes=1,martes,miercoles,jueves,viernes,sabado,domingo};
    class Program
    {
         
        static void Main(string[] args)
        {
           int RowOriginal= CursorTop;
           int ColOriginal= CursorLeft;

           

            Clear();
            /* pedir al usuario un un precio del producto, y la forma de pagar (efectivo o tarjeta)
                si la forma de pago es mediante de tarjeta, pedir el numero de la tarjeta            
            */
            precio:  
             SetCursorPosition(ColOriginal+20, RowOriginal+20);
                 WriteLine("introduzca el precio");
                 SetCursorPosition(ColOriginal+20, RowOriginal+22);
                int precio = int.Parse(ReadLine());
                if (precio < 0) goto precio;
             Clear();
           
            SetCursorPosition(ColOriginal+20, RowOriginal+20);
            WriteLine("Pulse 1 si desea pagar con tarjeta, y puse 2 si desea pagar con efectivo");
            SetCursorPosition(ColOriginal+20, RowOriginal+22);
            string tipoPago = ReadLine();
             Clear();
            if(tipoPago=="1")
            {
                SetCursorPosition(ColOriginal+20, RowOriginal+20);
                WriteLine("introduzca el Numero de su tarjeta");
                SetCursorPosition(ColOriginal+20, RowOriginal+22);
                string tarjeta = ReadLine();
                 Clear();
                SetCursorPosition(ColOriginal+20, RowOriginal+20);
                WriteLine($"ha decidido pagar {precio}, en tarjeta, con la cuenta: {tarjeta}");
            }
            else
            {
                SetCursorPosition(ColOriginal+20, RowOriginal+22);
                WriteLine($"ha decidido pagar {precio}, en efectivo");
            }


          

        }

        
               

        }
    
}
