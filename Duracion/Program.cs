using System;

namespace Duracion
{
    
    class Duracion
    {
    private int horas;
    private int minutos;
    private int segundo;
   
    
    
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
    public Duracion(int horas,int minutos,int segundo)
    {
       this.horas=horas;
       this.minutos=minutos;
       this.segundo=segundo;
    }
  
   public Duracion()
   {

   }
   public void Conversion()
   {
   int ConvM=horas*60;
    Console.WriteLine("La duracion en minutos es: " );
    Console.WriteLine("{0}",ConvM);
    int ConvS=horas*360;
    Console.WriteLine("La duracion en segundos es: " );
    Console.WriteLine("{0}",ConvS);

   }

}

    class Program
    {
        static void Main()
        {
            Duracion D1 =new Duracion();

            D1.SetHoras(2);
            D1.SetMinutos(15);
            D1.SetSegundo(2);
            Console.WriteLine("La duracion es de: " );
            Console.WriteLine("{0}:{1}:{2}", D1.GetHoras(), D1.GetMinutos(),D1.GetSegundo());
            D1.Conversion();
            
            
        }
    }
}