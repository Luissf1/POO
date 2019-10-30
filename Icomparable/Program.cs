using System;
using System.Collections.Generic;

namespace Icomparable
{   
    class persona:IComparable 
    {
        int id;
        string nombre;
        public persona(int id,string nombre)
        {
         this.id=id;
         this.nombre=nombre;

        }

        public override string ToString()
        {
        return String.Format("{0},{1}",id,nombre);
        }
        public Int32 CompareTo(object o)
        {
            return this.id.CompareTo(((persona)o).id);
        }

        
       

    }
    
    class Program
    {
        static void Main()
        {   
            Console.WriteLine("Lista de personas ");
            List<persona> pers=new List<persona>();
            pers.Add(new persona(2,"Pam"));
            pers.Add(new persona(1,"Jim"));
            pers.Add(new persona(3,"Mike"));
            foreach(persona p in pers)
            {
                Console.WriteLine(p);
            }
            Console.WriteLine("------------------------------");
            Console.WriteLine("Lista de personas organizada por id");
            pers.Sort();
             foreach(persona p in pers)
            {
                Console.WriteLine(p);
            }

        }
    }
}
