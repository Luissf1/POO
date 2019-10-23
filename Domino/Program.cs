using System;

namespace Domino
{
    class Domino
    {
        //Atributos
        public int espacio1;
        public int espacio2;

        //Sobre carga 
        public Domino(int  espacio1, int espacio2)
        {
            this.espacio1=espacio1;
            this.espacio2=espacio2;
        }


        //Sobre carga de operador
        public static int operator +(Domino espacio1, Domino espacio2){
            return (espacio1.espacio1+espacio1.espacio2+espacio2.espacio1+espacio2.espacio2);
        }
    }
    class Program
    {
        static void Main()
        {
            //objetos domino
            Domino a= new Domino(2,0);
            Domino b= new Domino(4,1);
            
            //print de suma de dominos
            Console.WriteLine(a+b);
        }
    }
}