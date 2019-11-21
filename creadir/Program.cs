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


    class Program
    {
        static void Main(string[] args)
        { 
            List<Producto> productos=new List<Producto>();
            productos.Add(new Producto("Bic","Lapiz Azul N2",12.23d));
            productos.Add(new Producto("Bic","Lapiz rojo N2",12.23d));
            productos.Add(new Producto("Bic","Pluma verde",12.23d));
            productos.Add(new Producto("Bic","Pluma negra",12.23d));
            
            FileStream fs=new FileStream(@"productos.tx",FileMode.OpenOrCreate,FileAccess.Write);
            StreamWriter txtout =new StreamWriter(fs);
            
            foreach(Producto p in productos)
            {
                //txtout.Write(p.descripcion+"");
                txtout.WriteLine("{0}|{1}|{2}",p.code,p.descripcion,p.precio);
            }
            txtout.Close();
            Console.ReadKey();

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
