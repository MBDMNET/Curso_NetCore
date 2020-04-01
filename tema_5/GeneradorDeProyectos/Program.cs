using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;
using classFichero;
namespace GeneradorDeProyectos
{
    class Program
    {
        static void Main(string[] args)
        {

            Stopwatch timeMeasure = new Stopwatch();
            timeMeasure.Start();
            int z= args.Length;
            ProcessStartInfo startInfo = new ProcessStartInfo("dotnet");
            startInfo.WindowStyle = ProcessWindowStyle.Normal;
           
            string direccion=@"C:\laragon\www\Curso_NetCore\tema_5\"+args[0];
             DirectoryInfo proyecto = Directory.CreateDirectory(direccion);
            
            

            startInfo.WorkingDirectory =direccion;
            startInfo.Arguments = "new console";
            Process.Start(startInfo);
            for(int i=1;i<args.Length;i++)
            {                
                    string direccionProy=direccion;
                    startInfo.WindowStyle = ProcessWindowStyle.Normal;
                    string direccionClass =direccionProy+"\\"+args[i];
                    DirectoryInfo clase = Directory.CreateDirectory(direccionClass);
                    startInfo.WorkingDirectory =direccionClass;
                    startInfo.Arguments = "new classlib";
                    Process.Start(startInfo); 
                    System.Threading.Thread.Sleep(7000);  
                    //aqui una vez creada la clase vamos a cambiar el nombre al fichero .cs para que cuando haya varias clases no de error
                    string NameClass="Class1.cs";  
                    string newName=args[i];         
                    Fichero ficheroClass= new Fichero(NameClass,z);
                    ficheroClass.renameArchivoClass(direccionClass,NameClass,newName);  
                                 

            }
            System.Threading.Thread.Sleep(7000);
            //una vez creados los archivos necesarios buscamos el .csproj para añadir la linea para incluir la class
            string NameArchivo=args[0]+".csproj";           
            Fichero fichero= new Fichero(NameArchivo,z);
            fichero.guardarEnArchivoAssamble(direccion);
            for(int i=1;i<args.Length;i++)
            {
            NameArchivo="Program.cs";
            Fichero ficheroUsin= new Fichero(NameArchivo,z);
            string NameUsing=args[i];
            ficheroUsin.guardarEnArchivoProgram(direccion,args[i],i);
            }

            Console.WriteLine("El Proyecto se ha creado correctmaente");
            timeMeasure.Stop();
            Console.WriteLine($"el tiempo que ha tardado en crearse: {timeMeasure.Elapsed.TotalMilliseconds} ms");

        }
    }
}
