using System;
using static System.Console;
using classFichero;
using  System.Diagnostics;

namespace classRastreo
{
    public class Rastreo
    {
        string Url;
        public Rastreo(string url,DateTime HoraInicio,Stopwatch timeMeasure)
        {
            WriteLine("Introduzca el nombre de archivo donde guardar los datos");
            string nameArchivo=ReadLine();
            this.Url=url;
            WriteLine("Mi url es:"+this.Url);
            Fichero fichero= new Fichero(nameArchivo);
            fichero.LeerFichero(this.Url,HoraInicio);
            fichero.totalArchivos(HoraInicio,timeMeasure);

            
                
              
            
        }
    }
}
