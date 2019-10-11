using System;

namespace HerenciaPersona
{

    class Persona
    {
        //Leva _ para recordarnos que es privado y protected es como privado pero puede ser heredado
     protected string _nombre;

     private string Nombre
     {get

     {return _nombre;}
     }

     public Persona(string n)
     {
      _nombre=n;
         }
     public void Print()
     {
         Console.WriteLine("Mi nombre es {0}",_nombre);
     }
     
    }


   /*Solo se puede heredar publico y protected*/
    class Alumno : Persona
    {
     protected string num_control;
     public Alumno(string _nombre,string num_control):base (_nombre)
     {

         /*Base para usar el constructor de la clase en la que estamos derivando ,solo podemos heredar de una clase en C# */
         this.num_control=num_control;
     }
     
     
     

    }

    
    class Program
    {
        static void Main()
        {
          Persona Tom= new Persona("Tom");
          Persona Jim=new Persona("Jim");

          Tom.Print();
          Jim.Print();


         Alumno Luis=new Alumno("Luis","1921059");
         Luis.Print();
        }
    }
}
