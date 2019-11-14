using System;

namespace StackInt
{
  class Stack<E>//stack tipo E de Entero
    {
     private E[] elementos;
     readonly int max_size;
     private int apuntador_pila=0;

     public Stack():this(100)
     {
     }


     public Stack(int size)
     {
         max_size=size;
         elementos=new E[max_size];
     }

     public void Push(E elemento)
     {
      elementos[apuntador_pila]=elemento;
      apuntador_pila++;
     }  

     public E Pop()
     {
         apuntador_pila--;
         return elementos[apuntador_pila];
     }

    }



    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> numeros= new Stack<int>(4); 
            numeros.Push(1);
            numeros.Push(2);
            numeros.Push(3);

            int numero=numeros.Pop();
            Console.WriteLine(numeros.Pop());
            Console.WriteLine(numeros.Pop());
    
        }
    }
}
