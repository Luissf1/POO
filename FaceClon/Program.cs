using System;
using System.Collections.Generic;

namespace FaceClon
{   


    abstract class Publicacion
    {
    protected string comentario;
    protected string reacciones;
    protected int fecha;
    

    public Publicacion(string comentario,string reacciones,int fecha)
    {
      this.comentario=comentario;
      this.reacciones=reacciones;
      this.fecha=fecha;
    }

    public abstract void Imprime();


    }
 
 class Estado:Publicacion
 {
public Estado(string comentario,string reaccion,int fecha):base(comentario,reaccion,fecha)
{

}

public override void Imprime()
{
    Console.WriteLine("Se publico un estado el {0},recibio de reaccion {1},y comentaron {} ", fecha,reacciones,comentario);
}

 }


/*/ class Foto:Publicacion
{

}
class Link:Publicacion
{

}*/


    class Program
    {
        static void Main(string[] args)
        {
        List<Publicacion>Pub=new List<Publicacion>;
        Pub.Add(new Estado(0,"like","hola"));
        foreach(var E in Pub)
        {
        
        }
        }
    }
}
