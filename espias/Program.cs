using System;

namespace espias
{

    class Persona 
    {
       public string nombre;
       public string apellido;

       public Persona()
       {
           nombre="Fulano";
           apellido="De tal";

       }
    }
    class Anonymous{
        public static void anonimiza (  Persona p)
        {
            p.nombre="xxxxx";
            p.apellido="xxxxxx";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        Persona p =new Persona();
        Console.WriteLine(p.nombre);
        Anonymous.anonimiza(p);
        Console.WriteLine(p.nombre);
        
        }
    }
}
