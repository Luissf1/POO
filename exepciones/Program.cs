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
            int valor ;
            Console.WriteLine("Ingresa tu edad:");
             try {
                 string captura=Console.ReadLine();
                 valor=int.Parse(captura);
                 Console.WriteLine("En diez años tendras {0}",valor+10);
             }
              catch (Exception) {
              Console.WriteLine("Formato incorrecto");
             }
             Console.ReadKey();
             
            
             Console.WriteLine("Ahora captura un entero positivo");       
             try{
              int valor2 =int.Parse(Console.ReadLine());
              if(valor2<0)
                 {
                    throw new NegativeIntegerException();
                 }
                  Console.WriteLine("El numero entero es:{0}",valor2);
             
             }
             catch(Exception e){
                  Console.WriteLine("Hubo un error"); 
                  Console.WriteLine(e.Message);
             }
             finally{
                 Console.WriteLine("Fin del programa");
             }
              Console.ReadKey();
        }
    }
}
