﻿using System;

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
        public static void cambia(ref Persona p)
        {
            p = new Persona();
            p.nombre="nuevo";
        }
    }

    class Program
    {
        static void duplica(ref int x)
        {
            x = x * 2;
        }
        static int suma(int x,int y)
        {
            return x + y;
        }
         static void suma(int x,int y,out int resultado)
        {
            resultado = x + y;
        }
        static void Main(string[] args)
        {
            int a=2;
            int b=3;
            int r=suma(a,b);
            int r2;
            suma(a,b,out r2);


            //duplica(ref a);
            Console.WriteLine(r2);
       /*  Persona p =new Persona();
        Console.WriteLine(p.nombre);
        Anonymous.anonimiza(p);
        Anonymous.cambia(ref p);
        Console.WriteLine(p.nombre);*/
        
        }
    }
}
