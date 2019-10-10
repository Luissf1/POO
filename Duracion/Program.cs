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
            
        }
    }
}