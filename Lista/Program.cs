using System;
using System.Collections.Generic;

namespace Lista
{
    class Program
    {
        static void Main()
        {
            List<String> lista =new List<String>();
                lista.Add("1.El padrino");
                lista.Add("2.Forrest Gump");
                lista.Add("3.Coco");
                lista.Add("4.El Rey León");
                lista.Add("5.Toy Story");

           foreach(String Pelicula in lista)
                Console.WriteLine(Pelicula);
        }
    }
}
