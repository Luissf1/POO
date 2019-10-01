using System;
using System.Collections.Generic;

namespace gol
{
    enum Estado{viva, muerta}

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
    }

    class Tablero{
        private list <list<Celula>> grid;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("▒▒▒▒▒▒▒");
            Console.WriteLine("▒▒▒▒▒▒▒");
        }
    }
}