using System;
using System.Collections.Generic;

namespace practica
{

    //metodos deben estar dentro de clases 

    class Auto {
    //campos
    //siempre se debe hacer primero el acceso ,conviene que sean privados
    private String marca;
    private String color; 
    private Int16 año;
    private String modelo;
      
      //Metodos Instancia
    public void setMarca (String marca)
    {
        
        this.marca=marca;//Escribir
    }

    public String getMarca()
    {
        return this.marca;//Leer
    }
   
   public void setModelo (String modelo)
    {
        
        this.modelo=modelo;//Escribir
    }

    public String getModelo()
    {
        return this.modelo;//Leer
    }
   
    public void setAño (Int16 año)
    {
        
        this.año=año;//Escribir
    }

    public Int16 getAño()
    {
        return this.año;//Leer
    }
     public void setColor (String color)
    {
        
        this.color=color;//Escribir
    }

    public String getColor()
    {
        return this.color;//Leer
    }
   //Constructores
   public Auto(string ma ,string mo,Int16 año,string color)//argumentos
   {
       //constructor
       this.marca=ma;
       this.modelo=mo;
       this.año=año;
       this.color=color;

   }
   public Auto(){//sobre carga de metodos

      año =2020;

   }
   public void Imprime(){
       
   }
    }

    

    class Program
    {
        static void Main(string[] args)
        {
            //
            Auto a=new Auto("Ford:","Focus,",2019,",Rojo") ;   
            Auto b = new Auto("Toyota:","Corolla,", 2019,",Azul" );
           
            Console.WriteLine(a.getMarca()+a.getModelo()+a.getAño()+a.getColor());
            Console.WriteLine(b.getMarca()+b.getModelo()+b.getAño()+b.getColor());
            
            // a.setMarca("Ford:");
           //string m="Ford:";
            //string mo="Focus";
            //a.setMarca(m);
            //a.modelo="Focus";
            //b.setMarca("Chevrolet:");
           // b.modelo="Aveo";
           //Console.WriteLine("{0},{1},{2}",b.getMarca(),b.getModelo());
            // b.imprime();


        
        }
    }
}
