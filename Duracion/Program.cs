﻿using System;

namespace Duracion
{
    
    class Duracion
    {
    private int horas;
    private int minutos;
    private int segundo;
    
    private int segundo2;
   
    
    
    public void SetHoras(int horas)
    {
        this.horas=horas;
    }
    public int GetHoras()
    {
        return this.horas;
    }


    public void SetMinutos (int minutos)
    {
        
        this.minutos=minutos;
    }
    public int GetMinutos()
    {
        return this.minutos;
    }
    public void SetSegundo (int segundo)
    {
        
        this.segundo=segundo;
    }
    public int GetSegundo()
    {
        return this.segundo;
    }
     public void SetSegundo2 (int segundo2)
    {
        
        this.segundo2=segundo2;
    }
    public int GetSegundo2()
    {
        return this.segundo2;
    }
    
    public Duracion(int horas,int minutos,int segundo,int segundo2)
    {
       this.horas=horas;
       this.minutos=minutos;
       this.segundo=segundo;
       this.segundo2=segundo2;
    }
  
   public Duracion()
   {

   }

   public Duracion(int segundo)
   {
       this.segundo=segundo;
   }

   public void Conversion()//Conversion de horas y minutos a segundos
   {
   int ConvM=horas*60;
    Console.WriteLine("La duracion en minutos es: " );
    Console.WriteLine("{0}",ConvM);
    int ConvS=horas*360;
    Console.WriteLine("La duracion en segundos es: " );
    Console.WriteLine("{0}",ConvS);
   }

   public void ConversionHMS()//conversion de segundos a H:M:S
   {
       int tiempoh;
       int tiempom;
       int tiempos;
       int resto;
      
       tiempoh=segundo2/3600;
       resto=segundo2 % 3600;
       tiempom=resto/60;
       tiempos=resto%60;
       Console.WriteLine("La conversion de segundos a H:M:S es :");
        Console.WriteLine("{0}:{1}:{2}",tiempoh,tiempom,tiempos);
   }
   
   public void SumaD()//Suma de duracion 1 y 2
   {
       
   }
   


}

    class Program
    {
        static void Main()
        {
            
            Duracion D1 =new Duracion();
            Duracion D2 =new Duracion();
            
            D1.SetHoras(2);
            D1.SetMinutos(15);
            D1.SetSegundo(23);
            D1.SetSegundo2(6564);
            Console.WriteLine("La duracion 1 es de: " );
            Console.WriteLine("{0}:{1}:{2}", D1.GetHoras(), D1.GetMinutos(),D1.GetSegundo());
            D1.Conversion();
            D1.ConversionHMS();

            D2.SetHoras(3);
            D2.SetMinutos(12);
            D2.SetSegundo(43);
            D2.SetSegundo2(3264);
            Console.WriteLine("La duracion 2 es de: " );
            Console.WriteLine("{0}:{1}:{2}", D2.GetHoras(), D2.GetMinutos(),D2.GetSegundo());
            D2.Conversion();
            D2.ConversionHMS();
           
           
            
            
            
        }
    }
}