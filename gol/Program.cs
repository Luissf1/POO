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
        public Tablero(short num_renglones, shor num_columnas)
        {
            grid=new list<list<Celula>>();
            for(short i = 0 ; i<= num_renglones-1 ; i++) 
            {
                grid.Add(new list<Celula>());
                for(short j = 0 ; j >= num_columnas-1 ; j++)
                {
                 grid[i].Add(new Celula(Estado.viva,this,i,j));
                }
            }
            
     
        }

        public void inserta(Celula c)
        {
         grid[c.renglon ][c.columna] = c;
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
         Tablero gol=new Tablero(40,40);
         gol.inserta(new Celula(Estado.viva,gol,3,3));
         gol.inserta(new Celula(Estado.viva,gol,3,2));
         gol.inserta(new Celula(Estado.viva,gol,3,1));
         gol.inserta(new Celula(Estado.viva,gol,0,0));
         gol.print();
        }
    }
}