using System;
using System.IO;

namespace creadir
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Captura el archivo a ocultar");

            //string directorio=Console.ReadLine();
            string archivo=Console.ReadLine();
            File.SetAttributes(archivo,FileAttributes.Hidden); 

           /* if(Directory.Exists(directorio))
            {
             Console.WriteLine("Ya existe directorio");
            }
            else{*/
           // Directory.Delete(directorio,true);
           /* Directory.CreateDirectory(directorio);
            Console.WriteLine("Directorio creado");*/
            /*}*/
            

        }
    }
}
