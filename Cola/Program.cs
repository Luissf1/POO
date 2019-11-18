using System;


namespace Cola
{
    class Cola<C>//Creacion de clase 
    {
     //Declaracion de variable
     private C[] elemento;
     readonly int size_max;
     private int pointer=0;

     //Creacion de constructor
     public Cola():this(100)
     {

     }

     //Sobre carga del constructor
     public Cola(int size)
     {
         //Asignacion de size
         size_max=size;
         //Asignacion de size a elemento
         elemento=new C[size_max];
     }
     
     //Creacion de push ingresa los valores al stack
     public void Push(C elementos)
     {
         //creacion de un if para una excepcion
         if(pointer>=size_max)
         {
            throw new StackOverflowException();
         }
         else{
         //permite que los elementos ingresen al stack
         elemento[pointer]=elementos;
         //permite el subir un nivel del Stack ,empezando de 0 y sube a 1
         pointer++;
         }
     }  
     
     //Creacion del pop ,saca los elementos de stack
     public C Pop()
     {
         //Permite bajar un nivel del stack
         pointer--;
         //Creacion de if para excepcion de Pop
         if(pointer>=0)
         {
         //regresa el valor del elemento sacado
         return elemento[pointer];
         }
         else{
             pointer=0;
             throw new InvalidOperationException("Error stack contiene espacio vacio");
         }
     }

    }
    class Program
    {
        static void Main(string[] args)
        {
             //Creacion de objeto tipo Cola llamado numeros
            Cola<int> numero= new Cola<int>(4); 
            //push de numeros
            numero.Push(1);
            numero.Push(2);
            numero.Push(3);
          
           for (int i=0; i<3; i++) 
        {
            int numeros;
            numeros =(int) numero.Pop();
            Console.WriteLine(numeros);
           
         }
           
        }
    }
}
