using System;
using System.IO;

namespace creadir
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Captura el folder a crear");

            string directorio=Console.ReadLine();
            if(Directory.Exists(directorio))
            {
             Console.WriteLine("Ya existe directorio");
            }
            else{
            Directory.CreateDirectory(directorio);
            Console.WriteLine("Directorio creado");
            }
            

        }
    }
}
