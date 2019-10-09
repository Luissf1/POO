using System;

namespace Duracion
{
    
    class Duracion
    {
    private Int16 horas;
    private Int16 minutos;
    private Int16 segundo;
    
    public void SetHoras(Int16 horas)
    {
        this.horas=horas;
    }
    public Int16 GetHoras()
    {
        return this.horas;
    }



    public void SetMinutos (Int16 minutos)
    {
        
        this.minutos=minutos;
    }
    public Int16 GetMinutos()
    {
        return this.minutos;
    }


    public void SetSegundo (Int16 segundo)
    {
        
        this.segundo=segundo;
    }
    public Int16 GetSegundo()
    {
        return this.segundo;
    }
 


   public  Duracion(Int16 horas,Int16 minutos,Int16 segundo)
   {
     this.horas=horas; 
     this.minutos=minutos; 
     this.segundo=segundo;
   }
  
    
}

    class Program
    {
        static void Main()
        {
            Duracion S=new Duracion();
            Duracion M=new Duracion();
            Duracion H=new Duracion();

            S.SetSegundo(2);
            M.SetMinutos(0);
            H.SetHoras(2);
           
           Console.WriteLine("(0)(1)(2)",S.SetSegundo,M.SetMinutos,H.SetHoras);
            
        }
    }
}