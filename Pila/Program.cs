using System;

namespace Pila
{
     //https://sites.google.com/site/ittprogoo/generics
    public class Pila<T>/*T es de tipo */
    {
    readonly int tamaño;
    private int apuntador=0;
    private T[] elementos;

public Pila():this(100)
{
}
    public Pila(int size)
    {
        tamaño=size;
        elementos=new T[tamaño];
    }
    

    public void Push(T elemento)
    {
        if(apuntador<tamaño)
        {
        elementos[apuntador]=elemento;
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

            Pila<string>apellidos=new Pila<string>(4);
                       
            apellidos.Push("Reyes");
            apellidos.Push("  ");
            apellidos.Push("Silva");

          
            Console.Write(apellidos.Pop());
            Console.Write(apellidos.Pop());
            Console.Write(apellidos.Pop());
        }
    }
}
