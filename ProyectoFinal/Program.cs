using System;

namespace ProyectoFinal
{
    class Producto
    {
     public string Codigo;
     public string Descripcion;
     public decimal Precio;
     public int Departamento;
     public int Likes;

     public void Producto(string Codigo,string Descripcion,decimal Precio,int Departamento,int Likes)
     {
      this.Codigo=Codigo;
      this.Descripcion=Descripcion;
      this.Precio=Precio;
      this.Departamento=Departamento;
      this.Likes=Likes;
     }

     public void Producto()
     {
     }
    }
    
    class ProductoDB
    {


    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
