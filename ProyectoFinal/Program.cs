﻿using System;
using System.IO;
using System.Collections.Generic;

namespace ProyectoFinal
{
    class Producto
    {
     public string Codigo{get;set;}
     public string Descripcion{get;set;}
     public double Precio{get;set;}
     public string Departamento{get;set;}
     public int Likes{get;set;}

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
    public static void ProductosTXTOUT(string datos,List<Producto> productos)
    {
     FileStream FileS1=new FileStream(datos,FileMode.OpenOrCreate,FileAccess.Write);
        StreamWriter TXTOUT =new StreamWriter(FileS1);
            
        foreach(Producto p in productos)
        {
         TXTOUT.WriteLine("{0}|{1}|{2}|{3}|{4}",p.Codigo,p.Descripcion,p.Precio,p.Departamento,p.Likes);
        }
        TXTOUT.Close(); 
    }

    public static void ProductosBINOUT(string datos,List<Producto> productos)
    {
    FileStream FileS2=new FileStream(datos,FileMode.OpenOrCreate,FileAccess.Write);    
         BinaryWriter binOut=new BinaryWriter(FileS2);
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

    public static List<Producto> ProductosTXTIN(string datos)
    {
    StreamReader TXTIN=new StreamReader(new FileStream(datos,FileMode.OpenOrCreate,FileAccess.Write));    
    List<Producto> productos =new List<Producto>();
    string row="";    
    while (TXTIN.Peek()!= -1)
    {
       string fila=TXTIN.ReadLine();
       string[] columna= row.Split('|');
       Producto producto =new Producto();
       producto.Codigo= columna[0];
       producto.Descripcion= columna[1];
       producto.Precio= Convert.ToDouble(columna[2]);
       producto.Departamento= columna[3];
       producto.Likes=Convert.ToInt32(columna[4]);
       productos.Add(producto);
    }
    TXTIN.Close();

    return productos;

    }

    public static List<Producto> ProductosBININ(string datos)
    {
    BinaryReader BININ=new BinaryReader(new FileStream(datos,FileMode.OpenOrCreate,FileAccess.Write));    
    List<Producto> productos =new List<Producto>();
    while (BININ.PeekChar()!= -1)
    {
    Producto producto =new Producto();
    producto.Codigo= BININ.ReadString();
    producto.Descripcion= BININ.ReadString();
    producto.Precio= BININ.ReadDouble();
    producto.Departamento= BININ.ReadString();
    producto.Likes= BININ.ReadInt32();
    productos.Add(producto);
    } 
    BININ.Close();
    }

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

        ProductoDB.ProductosTXTOUT(@"Producto.bin",productos);

        List<Producto> ProductosINB= ProductoDB.ProductosBININ("Producto.bin");
        foreach(Producto PB in ProductosINB)
        {
            Console.WriteLine("{0},{1},{2},{3},{4}",PB.Codigo,PB.Descripcion,PB.Precio,PB.Departamento,PB.Likes);
        }
        }
    }
}
