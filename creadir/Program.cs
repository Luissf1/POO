using System;
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
     public static void EscribeProductos(string archivo,List<Producto> productos)
     {
        FileStream fs=new FileStream(archivo,FileMode.OpenOrCreate,FileAccess.Write);
        StreamWriter txtout =new StreamWriter(fs);
            
        foreach(Producto p in productos)
         {
            txtout.WriteLine("{0}|{1}|{2}",p.code,p.descripcion,p.precio);
          }
            txtout.Close();
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

            ProductoArchivo.EscribeProductos(@"productos.tx");
            
           
            Console.WriteLine("Archivo grabado");

            List<Producto> productos_leidos =new List<Producto>();

           

            using(StreamReader sr=new StreamReader(@"productos.tx"))//se utiliza using para no utilizar el close
            {
              string line ="";
              while((line= sr.ReadLine()) != null )//No lleguemos al final del archivo
              {
                  
                  string[] columnas=line.Split("|");
                  //Console.WriteLine(columnas[0]);
                  productos_leidos.Add(new Producto(columnas[0],columnas[1],Double.Parse(columnas[2])));
              }
            }

            
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
