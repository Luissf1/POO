using System;
using System.Collections;


namespace Cola
{
  
    class Program
    {
        static void Main(string[] args)
        {
        //Creacion de string Nombre
         string Nombre;
         
         //Queje es la clase creada apartir de utilizar el System.Collections
         Queue Cola =new Queue();//Queje es la clase creada apartir de utilizar el System.Collections
         
         //Enqueje permite que se inroduzcan los valores atraves de la cabeza
         Cola.Enqueue("Silva ");
         Cola.Enqueue("Reyes,");
         Cola.Enqueue("Luis ");
         Cola.Enqueue("Adrian");
         
         //Creamos un for para poder imprimir los 4 valores ingresados
         for(int i=0;i<4;i++)
         {
        //Declaramos a nombre como el Dequeue del objeto Cola
        //Dequeue es el que permite extrear los valores por el extremo opuesto
         Nombre=(string) Cola.Dequeue();
         //Imprimimos Nombre
         Console.Write(Nombre);
         //Se utilizo la regla de FiFo ,First in ,First out
         //Enqueje es el encolar y Dequeue es el desencolar 
         }
        }
    }
}
