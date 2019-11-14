using System;

namespace stack
{   
    class Stack<T>
    {
     private T[] elementos;
     readonly int max_size;
     private int apuntador_pila=0;

     public Stack():this(100)
     {
     }


     public Stack(int size)
     {
         max_size=size;
         elementos=new T[max_size];
     }

     public void Push(T elemento)
     {
      elementos[apuntador_pila]=elemento;
      apuntador_pila++;
     }  

     public T Pop()
     {
         apuntador_pila--;
         return elementos[apuntador_pila];
     }

    }



    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> nombres= new Stack<string>(4); 
            nombres.Push("Mundo");
            nombres.Push(" ");
            nombres.Push("Hola");

            string nombre=nombres.Pop();
            Console.Write(nombres.Pop());
            Console.Write(nombres.Pop());
            //Console.Write(nombres.Pop());
            //Console.Write(nombres.Pop());
        }
    }
}
