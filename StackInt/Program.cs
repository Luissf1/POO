using System;

namespace StackInt
{
  class Stack<E>//stack tipo E de Entero
    {
     //Declaracion de variables   
     private E[] elementos;
     readonly int max_size;
     private int apuntador_pila=0;
    
    //Constructor 
     public Stack():this(100)
     {
     }

    //Sobre carga de constructor con size
     public Stack(int size)
     {
         //asignacion de valor a size
         max_size=size;
         //Declaracion de tamaño del entero y asignacion como elementos
         elementos=new E[max_size];
     }

     //Creacion de push ingresa los valores al stack
     public void Push(E elemento)
     {
         //creacion de un if para una excepcion
         if(apuntador_pila>=max_size)
         {
            throw new StackOverflowException();
         }
         else{
         //permite que los elementos ingresen al stack
         elementos[apuntador_pila]=elemento;
         //permite el subir un nivel del Stack ,empezando de 0 y sube a 1
         apuntador_pila++;
         }
     }  

     //Creacion del pop ,saca los elementos de stack
     public E Pop()
     {
         //Permite bajar un nivel del stack
         apuntador_pila--;
         //Creacion de if para excepcion de Pop
         if(apuntador_pila>=0)
         {
         //regresa el valor del elemento sacado
         return elementos[apuntador_pila];
         }
         else{
             apuntador_pila=0;
             throw new InvalidOperationException("Error stack contiene espacio vacio");
         }
     }

    }



    class Program
    {
        static void Main(string[] args)
        {
            //Creacion de objeto tipo Stack llamado numeros
            Stack<int> numeros= new Stack<int>(4); 
            //push de numeros
            numeros.Push(1);
            numeros.Push(2);
            numeros.Push(3);
          

           //Pop de los numeros
            Console.WriteLine(numeros.Pop());
            Console.WriteLine(numeros.Pop());
            Console.WriteLine(numeros.Pop());
            
          
          
    
        }
    }
}
