using System;
using System.Collections.Generic;

namespace Figuras
{

    abstract class Figuras 
    {
    protected int ancho,alto;
    protected int px,py;
    protected string color_relleno,color_borde;

    public Figuras(int ancho,int alto,int px, int py, string color_relleno,string color_borde)
    {
    this.ancho=ancho;
    this.alto=alto;
    this.px=px;
    this.py=py;
    this.color_relleno=color_relleno;
    this.color_borde=color_borde;
    }
    public abstract void dibuja();//no puede haber metodo abstracto si clase no es abstracta
    

    }


    class Rectangulo:Figuras
    {
    public Rectangulo(int a, int al,int x ,int y ,string cr,string cb ):base(a,al,x,y,cr,cb)
    {
    }
  public override void dibuja()
    {

    Console.WriteLine("Se dibuja un rectangulo color {0}, en x:{1} y  y:{2}",color_relleno,px,py);
    
    }

    }

    class Program
    {
        static void Main()
        {
            List<Figuras> f =new List<Figuras>();
          Figuras.Add(new Rectangulo(10,10));

        }
    }
}
