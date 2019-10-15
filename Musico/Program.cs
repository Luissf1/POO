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
        public string Saludo()
        {
        return String.Format("Hola,soy {0}",nombre);
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

       

       /*  class Guitarista:Musico
       {
          private string guitarra;
          public Guitarista(string no,string guitarra):base(no)
          {
              this.guitarra=guitarra;
          }
          public override void Afina()
          {
              Console.WriteLine("{0} esta afinando su guitarra {1}",nombre,guitarra);
          }*/
    }
    }
    class Program
    { 

        static void Main()
        {
            Musico tom=new Musico("Tom");
            Bajista flea=new Bajista("Flea","Gibson");
            /*Guitarista jeff=new Guitarista("Jeff","Fender");*/
            
            Console.WriteLine(tom.Saludo());
            Console.WriteLine(flea.Saludo());

            tom.Afina();
            flea.Afina();

            List<Musico> grupo =new List<Musico>();
            grupo.Add(tom);
            grupo.Add(flea);
            foreach(Musico m in grupo)
            {
                Console.WriteLine(m.Saludo());
                m.Afina();
            }

        }
    }
}


