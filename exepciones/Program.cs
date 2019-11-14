using System;

namespace exepciones
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor ;
            Console.WriteLine("Ingresa tu edad:");
             /*string captura=Console.ReadLine();
             valor=int.Parse(captura);
             Console.WriteLine("En diez años tendras {0}",100/valor);
             Console.ReadKey();*/

             try {
                 string captura=Console.ReadLine();
                 valor=int.Parse(captura);
                 Console.WriteLine("En diez años tendras {0}",100/valor);
             }
              catch (FormatException) {
              Console.WriteLine("Formato incorrecto");
             }
             Console.ReadKey();
            
            
        }
    }
}
