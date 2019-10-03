using System;
using System.Collections.Generic;

namespace gol
{
    enum Estado{viva, vacia}

    class Celula{
        public bool estado_actual;
        public bool estado_siguiente;
        public Tablero tablero;
        public short renglon;
        public short columna;
        

        public Celula(Estado inicial,Tablero tablero, short renglon, short columna){
            estado_actual = inicial;
            this.tablero = tablero;
            this.renglon = renglon;
            this.columna = columna;
        }
        public void print()
        {
            if(this.estado_actual==Estado.vacia
            {
            Console.WriteLine("▒");
            }
            else if (this.estado_actual== Estado.viva)
            {
            Console.WriteLine("▓");
            }
 
        }
    }

    class Tablero{
        private list <list<Celula>> grid;
        public Tablero()
        {
            grid=new list<list<Celula>>();
            grid.Add(new list<Celula>());
            grid[0].Add(new Celula(Estado.viva,this,0,0));
            grid[0].Add(new Celula(Estado.vacia,this,0,1));
            grid[0].Add(new Celula(Estado.vacia,this,0,3));

              grid=new list<list<Celula>>();
            grid.Add(new list<Celula>());
            grid[0].Add(new Celula(Estado.vacia,this,1,0));
            grid[0].Add(new Celula(Estado.vacia,this,1,1));
            grid[0].Add(new Celula(Estado.viva,this,1,3));

              grid=new list<list<Celula>>();
            grid.Add(new list<Celula>());
            grid[0].Add(new Celula(Estado.vacia,this,2,0));
            grid[0].Add(new Celula(Estado.vacia,this,2,1));
            grid[0].Add(new Celula(Estado.viva,this,2,3));
        }
        public void print()
        {
            foreach(list<Celula>renglon in grid)
            {
                foreach(Celula c in renglon )
                  c.print();
                Console.WriteLine();
            }
              
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
         Tablero gol=new Tablero();
         gol.print();
        }
    }
}