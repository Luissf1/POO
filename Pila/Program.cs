using System;

namespace Pila
{
     //https://sites.google.com/site/ittprogoo/generics
    public class Pila<T>/*T es de tipo */
    {
    readonly int tamaño;
    int apuntador=0;
    T[] elementos;

    public Pila(int size)
    {
        tamaño=size;
        elementos=new T[tamaño];
    }
    

    public void Push(T elementos)
    {
        if(apuntador<tamaño)
        {
        elementos[apuntador]=elementos;
        apuntador++;
        }
        else
        {
         throw new StackOverflowException();//error
        }
    }

    public T Pop()
    {
      apuntador--;
      return elementos[apuntador];

    }

    }

   
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
