using System;

namespace Paso
{
    
  class Multiplicar{

	public void multi(ref int n) { 
			n = n*5;
	}

}
  class resta{

	public void re(in int n3) { 
			
	}

}

    class Program
    {
         static void division(int n1,int n2,out int r){
     r = n1/n2;

    }
    static int division(int n1,int n2)
    {
        return n1/n2;
    }

        static void Main(string[] args)
        {
        /*Uso de ref con multiplicacion  */
       Multiplicar m = new Multiplicar();
       int x = 4;
       m.multi(ref x);
       Console.WriteLine(x);

       /*Uso de out con division*/
       int y=2;
       int z=2;
       int r;
       division(y,z,out r);
       Console.WriteLine(division(y,z));

       /*Uso de in con resta*/
       resta res = new resta();
        int i=10;
        i=i-8;
        res.re(in i);
        Console.WriteLine(i);
        }
    }


}
