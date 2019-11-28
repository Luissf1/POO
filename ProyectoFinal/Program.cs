using System;
using System.IO;
using System.Collections.Generic;

namespace ProyectoFinal
{
    class Producto
    {
     public string Codigo;
     public string Descripcion;
     public double Precio;
     public string Departamento;
     public int Likes;

     public Producto(string C,string D,double P,string Dep,int L)
     {
      this.Codigo=C;
      this.Descripcion=D;
      this.Precio=P;
      this.Departamento=Dep;
      this.Likes=L;
     }

     public Producto()
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
        List<Producto> productos =new List<Producto>();
        productos.Add(new Producto("1","Libreta Scribe",40.52d,"Papeleria",40));
        productos.Add(new Producto("2","Pluma Negra Bic",5.53d,"Papeleria",50));
        productos.Add(new Producto("3","Lapiz Bic",4.42d,"Papeleria",60));
        productos.Add(new Producto("4","Libreta Norma",11.54d,"Papeleria",70));


        FileStream FS=new FileStream(@"Producto.txt",FileMode.OpenOrCreate,FileAccess.Write);
        StreamWriter TXTOUT =new StreamWriter(FS);
            
        foreach(Producto p in productos)
        {
            TXTOUT.WriteLine("{0}|{1}|{2}|{3}|{4}|{5}",p.Codigo,p.Descripcion,p.Precio,p.Departamento,p.Likes);
        }
            TXTOUT.Close(); 

         FileStream FS2=new FileStream(@"Producto.bin",FileMode.OpenOrCreate,FileAccess.Write);    
         BinaryWriter binOut=new BinaryWriter(FS2);
         foreach(Producto pb in productos)
         {
          binOut.Write(pb.Codigo);
          binOut.Write(pb.Descripcion);
          binOut.Write(pb.Precio);
          binOut.Write(pb.Departamento);
          binOut.Write(pb.Likes);


         }
         binOut.Close();
        }
    }
}
