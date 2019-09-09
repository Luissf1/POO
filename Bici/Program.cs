using System;


namespace Bici
{


    class Bici 
    {
        //campos 
        public string marca;
        public string color;
        public string type;
        public int velocities;
        public int size;

        //metodos
        public void print(){
            Console.WriteLine("marca:{0},color:{1}",marca,color);
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
        Bici bici1 = new Bici();
        bici1.marca = "BiciMex";
        bici1.color="Rojo";
        bici1.print();
           // Console.WriteLine("Hello World!");
        }
    }
}
