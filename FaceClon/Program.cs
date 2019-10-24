using System;
using System.Collections.Generic;

namespace FaceClon
{   


    abstract class Publicacion
    {
    protected string comentario;
    protected string reacciones;
    protected int fecha;
    

    public Publicacion(int fecha,string reacciones,string comentario)
    {
      this.fecha=fecha;
      this.reacciones=reacciones;
      this.comentario=comentario;
     
    }

    public abstract void Imprime();


    }
 
 class Estado:Publicacion
 {
public Estado(int fecha,string reaccion,string comentario):base(fecha,reaccion,comentario)
{

}

public override void Imprime()
{
    Console.WriteLine("Se publico un estado el {0} del mes,recibio de reaccion {1},y comentaron {2} ", fecha,reacciones,comentario);
}

 }


class Foto:Publicacion
{
protected string fotografia;
public Foto(string fotografia,int fecha,string reaccion,string comentario):base(fecha,reaccion,comentario)
{
 this.fotografia=fotografia;
}

public override void Imprime()
{
    Console.WriteLine("Se publico una {0} el {1} del mes,recibio de reaccion {2} ,y comentaron {3} ", fotografia,fecha,reacciones,comentario);
}

}


/*class Link:Publicacion
{

} */


    class Program
    {
        static void Main(string[] args)
        {
        List<Publicacion> Accion =new List<Publicacion>();
        Accion.Add(new Estado(22,"like","hola"));
        Accion.Add(new Foto("foto",14,"me encanta","hola"));
        foreach(Publicacion a in Accion)
        { 
            a.Imprime();
            
        }


        }
    }
}
