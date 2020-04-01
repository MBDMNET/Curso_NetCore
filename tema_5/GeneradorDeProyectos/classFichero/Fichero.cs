using System;
using System.IO;
using static System.Console;
using  System.Diagnostics;
using System.Linq;







namespace classFichero
{
    public class Fichero
    {
        
        string NombreArchivo;
        public int Z;
        public string [] usables ;


        public Fichero(string Namearchivo,int z)
        {
            this.NombreArchivo=Namearchivo;
            this.Z=z;
            this.usables= new string[Z];
        }
        
        
        


        public void guardarEnArchivoAssamble(string url)
        {
            Directory.SetCurrentDirectory(url);
            string[] lines = { "<Project Sdk='Microsoft.NET.Sdk'>", "<PropertyGroup>", "<OutputType>Exe</OutputType>","<TargetFramework>netcoreapp3.1</TargetFramework>","<GenerateAssemblyInfo>false</GenerateAssemblyInfo>","</PropertyGroup>","</Project>" };
            if(File.Exists(this.NombreArchivo))
            {       
                 
                url=url+"\\"+this.NombreArchivo; 
                   
                System.IO.File.WriteAllLines(url, lines);    
            } 
        }

        public void guardarEnArchivoProgram(string url,string NameUsing,int i)
        {
            Directory.SetCurrentDirectory(url);
            //recogemos todas las lineas del archivo
            
            string[] TodasLasLineasLeidas = System.IO.File.ReadAllLines(url+"\\"+this.NombreArchivo);
            
            if(File.Exists(this.NombreArchivo))
            {       
                usables[i]="using "+NameUsing+";";               
            }
            string[] TotalLineas=usables.Concat(TodasLasLineasLeidas).ToArray();
            url=url+"\\"+this.NombreArchivo;
                System.IO.File.WriteAllLines(url, TotalLineas);  

        }

        public void renameArchivoClass(string url,string oldName,string newName)
        {
            string newNameUp=newName+".cs";
                Directory.SetCurrentDirectory(url);
                System.IO.File.Move(oldName, newNameUp);
                System.Threading.Thread.Sleep(7000);
                renameClass(url,newName);
        }
        public void renameClass(string url,string newName)
        {
            
            
            Directory.SetCurrentDirectory(url);
            url=url+"\\"+newName+".cs";
            string[] TodasLasLineasLeidas = System.IO.File.ReadAllLines(url);          
            int index = Array.IndexOf(TodasLasLineasLeidas, "    public class Class1");
            TodasLasLineasLeidas[index]="    public class "+newName;
            System.IO.File.WriteAllLines(url, TodasLasLineasLeidas); 
        }



            
        
    }
}
