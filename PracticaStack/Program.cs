using System;

namespace PracticaStack
{ 
    class Stack<S>
    {
        readonly int S_Size;
        int S_StackPointer=0;
        S[]S_Items;

        public Stack():this(100)
        {
        }

        public Stack(int size)
        {
        S_Size=size;
        S_Items=new S[S_Size];
        } 

        public void Push(S item)
        {
        if(S_StackPointer>=S_Size)
        {
            throw new StackOverflowException();
        }
        S_Items[S_StackPointer]=item;
        S_StackPointer++;
        }

        public S Pop()
        {
            S_StackPointer--;
            if(S_StackPointer>=0)
            {
                return S_Items[S_StackPointer];
            }
            else
            {
                S_StackPointer=0;
                throw new InvalidOperationException("Cannot pop an empty stack");
            }
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
           Stack<string> hola=new Stack<string>(4);
           hola.Push("Mundo");
           hola.Push("  ");
           hola.Push("Hola");

           Console.Write(hola.Pop());
           Console.Write(hola.Pop());
           Console.Write(hola.Pop());
        }
    }
}
