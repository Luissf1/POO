using System;
using System.Collections.Generic;

//Pagina del ejemplo
//https://www.tutorialsteacher.com/csharp/csharp-interface

interface IPen
{
    string Color { get; set; }
    bool Open();
    bool Close();
    void Write(string text);
}

class Cello : IPen
{
    public string Color { get; set; }
        
    private bool isOpen = false;
        
    public bool Close()
    {
        isOpen = false;
        Console.WriteLine("Cello closed for writing!");

        return isOpen;
    }

    public bool Open()
    {
        isOpen = true;
        Console.WriteLine("Cello open for writing!");
            
        return isOpen;
    }

    public void Write(string text)
    {
        //write text if open
        if(isOpen)
            Console.WriteLine("Cello: " + text);
    }
}

class Parker : IPen
{
    public string Color { get; set; }
        
    private bool canWrite = false;
        
    public bool Close()
    {
        canWrite = false;
        Console.WriteLine("Parker is closed now!");

        return canWrite;
    }

    public bool Open()
    {
        canWrite = true;
        Console.WriteLine("Parker is open now!");
            
        return canWrite;
    }

    public void Write(string text)
    {
        //write text if open
        if(canWrite)
            Console.WriteLine("Parker: " + text);
    }
}

public class Program
{
	public static void Main()
	{
		
		Parker p=new Parker();
		IPen p2=new Parker();
		
		/*List<IPen> plumas=new List<IPen>();
		plumas.Add(p as IPen);
		plumas.Add(p2);
		foreach(IPen pluma in plumas)
			(pluma as IPen).Write("Hola");*/
		
		IPen pen1 = new Cello();
		pen1.Open();
		pen1.Write("This is my Cello pen.");
		pen1.Close();
		
		IPen pen2 = new Parker();
		pen2.Open();
		pen2.Write("This is my Parker pen.");
		pen2.Close();
	}
}