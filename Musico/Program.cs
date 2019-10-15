using System;
using System.Collections.Generic;

namespace Musico
{

    
    class Musico 
    {

        protected string nombre;
        public Musico(string n)
        {
        nombre=n;

        }
        public void Saludo()
        {
        Console.WriteLine("Hola,soy {0}",nombre);
        }

        public virtual void Afina()
        {
            Console.WriteLine("{0},Afina su instrumento ",nombre);
        }

    }

    class Bajista:Musico
    {
       private string bajo;
       public Bajista(string no,string bajo):base(no)
       {
       this.bajo=bajo;
       } 

       public override void Afina()
       {
           Console.WriteLine("{0} esta afinando su bajo {1}",nombre,bajo);
       }
    }
    class Program
    { 

        static void Main()
        {
            Musico tom=new Musico("Tom");
            Bajista flea=new Bajista("Flea","Gibson");
            
            tom.Saludo();
            flea.Saludo();

            tom.Afina();
            flea.Afina();

            List<Musico> grupo =new List<Musico>();
            grupo.Add(tom);
            grupo.Add(flea);
            foreach(Musico m in grupo)
            {
                m.Saludo();
                m.Afina();
            }

        }
    }
}
