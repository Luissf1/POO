using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace ProyectoFinal
{
    class Producto
    {
     public string Codigo;
     public string Descripcion;
     public double Precio;
     public int Departamento;
     public int Likes;

     public Producto(string C,string D,double P,int Dep,int L)
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
        public List<Producto> productos =new List<Producto>();
    public static void ProductosTXTOUT(string datos,List<Producto> productos)
    {
        try
        {
         FileStream FileS1 = new FileStream(datos, FileMode.OpenOrCreate, FileAccess.Write);
         StreamWriter TXTOUT = new StreamWriter(FileS1);

             foreach (Producto p in productos)
             {
              TXTOUT.WriteLine("{0}|{1}|{2}|{3}|{4}", p.Codigo, p.Descripcion, p.Precio, p.Departamento, p.Likes);
              }
              TXTOUT.Close();
        }
       catch(FileNotFoundException)
        {
        Console.Write("Archivo no encontrado");
        }
        catch(DirectoryNotFoundException)
        {
        Console.Write("Directorio no encontrado");
        }
        catch(IOException )
        {
        Console.Write("IOException");
        }
                 
    }

    public static void ProductosBINOUT(string datos,List<Producto> productos)
    {   
        try{
         FileStream FileS2 = new FileStream(datos, FileMode.OpenOrCreate, FileAccess.Write);
         BinaryWriter binOut = new BinaryWriter(FileS2);
         foreach (Producto pb in productos)
         {
          binOut.Write(pb.Codigo);
          binOut.Write(pb.Descripcion);
          binOut.Write(pb.Precio);
          binOut.Write(pb.Departamento);
          binOut.Write(pb.Likes);
         }
         binOut.Close();
        }
         catch (FileNotFoundException)
         {
         Console.Write("Archivo no encontrado");
         }
         catch (DirectoryNotFoundException)
         {
          Console.Write("Directorio no encontrado");
         }
         catch (IOException)
         {
         Console.Write("IOException");
         }
         
    }

    public static List<Producto> ProductosTXTIN(string datos)
    {  
    StreamReader TXTIN=new StreamReader(new FileStream(datos,FileMode.Open,FileAccess.Read));
    List<Producto> productos =new List<Producto>();
      
    while (TXTIN.Peek()!= -1)
    {
       string row=TXTIN.ReadLine();
       string[] columna= row.Split('|');
       Producto producto =new Producto();
       producto.Codigo= columna[0];
       producto.Descripcion= columna[1];
       producto.Precio= Convert.ToDouble(columna[2]);
       producto.Departamento= Convert.ToInt32(columna[3]);
       producto.Likes=Convert.ToInt32(columna[4]);
       productos.Add(producto);
    }
    return productos;
    }

    public static List<Producto> ProductosBININ(string datos)
    {
    BinaryReader BININ =new BinaryReader(new FileStream(datos,FileMode.Open,FileAccess.Read));    
    List<Producto> productos =new List<Producto>();
    while (BININ.PeekChar() != -1)
    {
    Producto producto =new Producto();
    producto.Codigo= BININ.ReadString();
    producto.Descripcion= BININ.ReadString();
    producto.Precio= BININ.ReadDouble();
    producto.Departamento= BININ.ReadInt32();
    producto.Likes= BININ.ReadInt32();
    productos.Add(producto);
    } 
    BININ.Close();
    return productos;
    }
    
    public void GetDepartment(int depo)
    {
        IEnumerable<Producto> dep =
        from p in productos
        where p.Departamento == depo
        select p;
        Console.WriteLine(" Departamento seleccionado : "+ depo);
        Console.WriteLine("----------------------------");
        foreach(Producto p in dep)
        {
            Console.WriteLine("{0} {1} {2} {3} {4}", p.Codigo, p.Descripcion,p.Precio, p.Departamento,p.Likes);
        }

    /*string eleccion = Console.ReadLine();
    int depo=Convert.ToInt32(eleccion);
    
     switch (depo)
     {
      case 1:
       Console.WriteLine("1|Libreta Scribe|40.52|Departamento 1|40");
      break;

      case 2:
       Console.WriteLine("2|Pluma Negra Bic|5.53|Departamento 2|50");      
      break;

      case 3:
       Console.WriteLine("3|Lapiz Bic|4.42|Departamento 3|60");
      break;

      case 4:
       Console.WriteLine("4|Libreta Norma|11.54|Departamento 4|70");
      break;

      case 5:
       Console.WriteLine("Salida");
      break;

      default:
      Console.WriteLine("Fin de lista");
      break;
      
     }*/
    }

    public void OrdenarLikes()
    {
    IEnumerable<Producto> likes=
    from p in productos
    orderby p.Likes
    select p;
    Console.WriteLine("Productos ordenados por likes: " + likes);
    Console.WriteLine("----------------------------");
    foreach (Producto p in likes)
    {
    Console.WriteLine("{0} {1} {2} {3} {4}", p.Codigo, p.Descripcion, p.Precio, p.Departamento, p.Likes);
    }

    }

    }


    class Program
    {
        static void Main(string[] args)
        {
        List<Producto> productos =new List<Producto>();
        ProductoDB pro=new ProductoDB();
        pro.productos.Add(new Producto("1","Libreta Scribe",40.52d,1,50));
        pro.productos.Add(new Producto("2","Pluma Negra Bic",5.53d,2,30));
        pro.productos.Add(new Producto("3","Lapiz Bic",4.42d,3,60));
        pro.productos.Add(new Producto("4","Libreta Norma",11.54d,4,20));

        productos.Add(new Producto("1", "Libreta Scribe", 40.52d, 1, 50));
        productos.Add(new Producto("2", "Pluma Negra Bic", 5.53d, 2, 30));
        productos.Add(new Producto("3", "Lapiz Bic", 4.42d, 3, 60));
        productos.Add(new Producto("4", "Libreta Norma", 11.54d, 4, 20));

        ProductoDB.ProductosBINOUT(@"Producto.bin",productos);
        Console.WriteLine("Datos guardados en formato bin");
        Console.WriteLine("--------------------------------");

        List<Producto> ProductosINB = ProductoDB.ProductosBININ(@"Producto.bin");
        foreach(Producto PB in ProductosINB)
        {
            Console.WriteLine("{0} {1} {2} {3} {4}",PB.Codigo,PB.Descripcion,PB.Precio,PB.Departamento,PB.Likes);
        }

        ProductoDB.ProductosTXTOUT(@"Producto.txt", productos);
        Console.WriteLine("Datos guardados en formato txt");
        Console.WriteLine("--------------------------------");
        
        List<Producto> ProductoINT = ProductoDB.ProductosTXTIN(@"Producto.txt");
        foreach(Producto PT in ProductoINT)
        {
         Console.WriteLine("{0} {1} {2} {3} {4}",PT.Codigo,PT.Descripcion,PT.Precio,PT.Departamento,PT.Likes);
        }

        /*Console.WriteLine("Escoge un Departamento");
        Console.WriteLine("--------------------------------");
        Console.WriteLine("1)Departamento 1");
        Console.WriteLine("2)Departamento 2");
        Console.WriteLine("3)Departamento 3");
        Console.WriteLine("4)Departamento 4");
        Console.WriteLine("5)Salir");*/
        pro.GetDepartment(4);
        pro.OrdenarLikes();

        }
    }
}
