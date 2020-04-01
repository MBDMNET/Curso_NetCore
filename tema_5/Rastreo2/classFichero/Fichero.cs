using System;
using System.IO;
using static System.Console;
using  System.Diagnostics;







namespace classFichero
{
    public class Fichero
    {
        public int i=0;
        public double peso=0;
        string NombreArchivo;
        public Fichero(string Namearchivo)
        {
            this.NombreArchivo=Namearchivo;
        }
        
        public void LeerFichero(string url,DateTime horaIni)
        {
         
          try
          {
        
            string [] fileEntries = Directory.GetFiles(url);
            foreach(string fileName in fileEntries)
            {
                
                

                this.i++;
                guardarEnArchivo(fileName,fileName.Length,horaIni,url);
                this.peso=this.peso+fileName.Length;
            }

            
            string [] subdirectoryEntries = Directory.GetDirectories(url);
            foreach(string subdirectory in subdirectoryEntries)
            {
                LeerFichero(subdirectory,horaIni); 
                            
            }
           this.i++;
          }
          catch(System.UnauthorizedAccessException)
          {
              return;
          }
          catch(System.IO.DirectoryNotFoundException)
          {
              WriteLine("Lo siento la direccion introducida no existe");
          }
           
        }
       
    

        public  void totalArchivos(DateTime horaIni, Stopwatch timeMeasure) 
        {
            DateTime horaFinal= DateTime.Now;
             long TicksInicio    = horaIni.Ticks;             
            long TicksFinal     = horaFinal.Ticks;
            long TicksTotal=TicksFinal-TicksInicio;
            timeMeasure.Stop();
            Console.WriteLine("El numero total de archivos procesados es:  '{0}'.", this.i+1);
            Console.WriteLine("El Peso total de los archivos procesados es:  '{0}' bytes.", this.peso);	
            Console.WriteLine("El Tiempo en ticks que ha tardado en procesar los archivos es:  '{0}' ticks.", TicksTotal);	               
            Console.WriteLine($"Tiempo: {timeMeasure.Elapsed.TotalMilliseconds} ms");
        }
        public void guardarEnArchivo(string path,int peso,DateTime inicio,string url)
        {
            
             
            StreamWriter Archivos;
            int last= path.LastIndexOf("\\");
            string nombre=path.Remove(0,last+1);
            string linea1 = "Ruta del archivo: "+path;//	 qui muestro el peso y el nombre de cada fichero
             string linea3="Nombre del archivo: "+nombre;
            string linea2 = "Tamaño del archivo: "+peso+" bytes";//	 qui muestro el peso y el nombre de cada fichero
            string fecha = "Fecha: "+inicio.ToString();
            if(!File.Exists(this.NombreArchivo+".txt"))
            {
                
                Archivos = File.CreateText(this.NombreArchivo+".txt");
                Archivos.WriteLine(fecha); 
                Archivos.WriteLine($"Directorio inicial: "+url); 
                
                
                Archivos.WriteLine(linea1); 
                Archivos.WriteLine(linea3);
                Archivos.WriteLine(linea2);
                     
                Archivos.Close(); 
            }
            if(File.Exists(this.NombreArchivo+".txt"))
            {               
                Archivos = File.AppendText(this.NombreArchivo+".txt");     
                Archivos.WriteLine(linea1);  
                Archivos.WriteLine(linea3);
                Archivos.WriteLine(linea2);                                      
                Archivos.Close();  
                
            } 
        }
        
       
    }
}
