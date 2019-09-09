using System;
using System.Collections.Generic;
namespace practica2
{
    class Program
    {
        static void Main()
        {
           List<String> lista =new List<String>();
                lista.Add("Hola");
                lista.Add("Hey");
                lista.Add("Yes");

           foreach(String s in lista)
                Console.WriteLine(s);
        }
    }
}
