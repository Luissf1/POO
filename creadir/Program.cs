﻿using System;
using System.IO;
using System.Collections.Generic;

namespace creadir
{
    class Producto
    {
     public string code;
     public string descripcion;
     public double precio;

     public Producto(string c,string d,double p)
     {
       this.code=c;
       this.descripcion=d;
       this.precio=p;
     }
    }

    class ProductoArchivo
    {
     public static void EscribeProductosBIN(string archivo,List<Producto> productos)
     {
       FileStream fs=new FileStream(archivo,FileMode.OpenOrCreate,FileAccess.Write);
       BinaryWriter binOut=new BinaryWriter(fs);
       foreach(Producto p in productos)
       {
           binOut.Write(p.codigo);
           binOut.Write(p.descripcion);
           binOut.Write(p.precio);

       }



       
     }



     public static void EscribeProductosTXT(string archivo,List<Producto> productos)
     {
        FileStream fs=new FileStream(archivo,FileMode.OpenOrCreate,FileAccess.Write);
        StreamWriter txtout =new StreamWriter(fs);
            
        foreach(Producto p in productos)
         {
            txtout.WriteLine("{0}|{1}|{2}",p.code,p.descripcion,p.precio);
          }
            txtout.Close();
     }
 


     public static List<Producto> LeeProductosTXT(string archivo)
     {
        using(StreamReader sr=new StreamReader(archivo))//se utiliza using para no utilizar el close
        {
           string line ="";
            while((line= sr.ReadLine()) != null )//No lleguemos al final del archivo
           {
                  
               string[] columnas=line.Split("|");
               //Console.WriteLine(columnas[0]);
                productos.Add(new Producto(columnas[0],columnas[1],Double.Parse(columnas[2])));
            }
        }
     }

    }


    class Program
    {
        static void Main(string[] args)
        { 
            List<Producto> productos=new List<Producto>();

            productos.Add(new Producto("Bic","Lapiz Azul N2",12.23d));
            productos.Add(new Producto("Bic","Lapiz rojo N2",12.23d));
            productos.Add(new Producto("Bic","Pluma verde",12.23d));
            productos.Add(new Producto("Bic","Pluma negra",12.23d));

            ProductoArchivo.EscribeProductosTXT(@"productos.txt",productos);
            
           
            Console.WriteLine("Archivo grabado");
            Console.ReadKey();


            List<Producto> productos_leidos =ProductoArchivo.LeeProductosTXT("productos.txt");

            

            
            foreach(Producto p in productos_leidos)
            {
                Console.WriteLine("{0}|{1}|{2}",p.code,p.descripcion,p.precio);
            }







           /* Console.WriteLine("Captura el archivo a ocultar");
            string archivo=Console.ReadLine();
            File.SetAttributes(archivo,FileAttributes.Hidden); 
            string directorio=Console.ReadLine();
            if(Directory.Exists(directorio))
            {
             Console.WriteLine("Ya existe directorio");
            }
            else{*/
           // Directory.Delete(directorio,true);
           /* Directory.CreateDirectory(directorio);
            Console.WriteLine("Directorio creado");*/
            /*}*/
        }
    }
}