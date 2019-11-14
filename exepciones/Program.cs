using System;

namespace exepciones
{   
    class NegativeIntegerException:Exception
    {
      public NegativeIntegerException():base("No se pueden capturar enteros negativos")
      {

      }

    }


    class Program
    {
        static void Main(string[] args)
        {
             string captura=Console.ReadLine();
             valor=int.Parse(captura);
             Console.WriteLine("En diez años tendras {0}",100/valor);
             Console.ReadKey();
            int valor ;
            Console.WriteLine("Ingresa tu edad:");
             try {
                 string captura=Console.ReadLine();
                 valor=int.Parse(captura);
                 Console.WriteLine("En diez años tendras {0}",100/valor);
             }
              catch (FormatException) {
              Console.WriteLine("Formato incorrecto");
             }
             Console.ReadKey();
             
            int valor2=0;
             Console.WriteLine("Captura un entero positivo");       
             try{
              valor2 =int.Parse(Console.ReadLine());
              if(valor2<0)
                 {
                    throw new NegativeIntegerException();
                 }
                  Console.WriteLine("El valor 2 es:{0}",valor2);
             
             }
             catch(Exception e){
                  Console.WriteLine("Hubo un error"); 
                  Console.WriteLine(e.Message);
             }
             Console.ReadKey();
             finally{
                 Console.WriteLine("Finally");

             }
        }
    }
}
