using System;
using System.Collections.Generic;

namespace Pelicula
{
 
  class Actor
  {
      public String nombre;
      public Int16 año;
      public Actor(String nombre,Int16 año)
      {
          this.nombre=nombre;
          this.año=año;
      }
  }
    class Pelicula
    {
    private String titulo;
    private Int16 año;
    private String pais;
    private String director; 
    
    private  List<Actor> actores =new List<Actor>();
  
  

   public void SetTitulo(String titulo)
   {
       this.titulo=titulo;
   }
   public String GetTitulo()
   {
       return this.titulo;
   }
   
    public void SetAño(Int16 año)
   {
       this.año=año;
   }
   public Int16 GetAño()
   {
       return this.año;
   }

   public void SetPais(String pais)
   {
       this.pais=pais;
   }

   public String GetPais()
   {
       return this.pais;
   }

   public void SetDirector(String director)
   {
       this.director=director;
   }

   public String GetDirector()
   {
       return this.director;
   }
  
  
   
  public Pelicula()
  {

  }
  public Pelicula(String titulo,Int16 año,String pais,String director)
  {
  this.titulo=titulo;
  this.año=año;
  this.pais=pais;
  this.director=director;
  
  
  }
  
  public void Imprime()
  {
 Console.WriteLine("{0}({1}){2},{3}", this.titulo, this.año,this.pais,this.director);
  }
  public void AgregarActor(Actor actor)
  {
                actores.Add(actor);
              
  }
  public void ImprimeActores()
  {
      foreach(Actor act in actores)
      {
      Console.WriteLine("{0},{1}",act.nombre,act.año);
      }
  }
 
    }
    class Program
    {
        static void Main()
        {

           Pelicula P1 = new Pelicula();
           Pelicula P2 = new Pelicula();
           
               
          
           P1.SetTitulo("Titanic:");
           P1.SetAño(1997);
           P1.SetPais("Estados Unidos");
           P1.SetDirector("James Cameron");
           
           P2.SetTitulo("El Señor de los Anillos: el retorno del Rey:");
           P2.SetAño(2003);
           P2.SetPais("Nueva Zelanda");
           P2.SetDirector("Peter Jackson");

           P1.AgregarActor(new Actor("Leonardo Dicaprio",1974));
           P2.AgregarActor(new Actor("Elijah Woods",1981));
           P1.Imprime();
           P1.ImprimeActores();
           P2.Imprime();
           P2.ImprimeActores();

           //Console.WriteLine(P1.GetTitulo()+P1.GetAño()+P1.GetPais()+P1.GetDirector());
           //Console.WriteLine(P2.GetTitulo()+P2.GetAño()+P2.GetPais()+P2.GetDirector());
           //Console.WriteLine("{0}({1}){2},{3}", P1.GetTitulo(), P1.GetAño(),P1.GetPais(),P1.GetDirector());
           //Console.WriteLine("{0}({1}){2},{3}", P2.GetTitulo(), P2.GetAño(),P2.GetPais(),P2.GetDirector());
        }
    }
}
