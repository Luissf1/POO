using System;
using System.Collections.Generic;

namespace Musicos
{   
    //Creacion de clase Musicos
    class Musicos
    {   
        //Atributos de clase usando protected por que solo 
        //con protected y public se puede heredar
        protected string nombre;
         
         //Sobre carga de constructor 
        public Musicos(string nombre)
        {
            //se usa this. siempre en el constructor 
           this.nombre=nombre;
        }
        
        //Creacion de metodo con vitrual
        //lo que permite que se pueda realizar el override despues
        public virtual void Afina()
        {
            Console.WriteLine("{0} afina su voz y instrumento ",nombre);
        }
        //Creacion de metodo de saluda y igualmente usando el virtual 
        public virtual void Saluda()
        {
            Console.WriteLine("Hola soy {0}",nombre);
        }
        //Creacion de metodo toca y usando virtual 
        //para igualmente realizar el override en siguiente clase
        public virtual void Toca()
        {
        Console.WriteLine("{0} empezo a cantar y tocar",nombre);
        }
    }
    
    //Creacion de clase Baterista que hereda clase Musicos
    class Baterista:Musicos
    {   
        //Atributo de la clase Baterista
        protected string Bateria;
        
        //Sobre carga de constructor
        //heredando nombre atravez de base
        public Baterista(string nombre,string Bateria):base(nombre)
        {
            //this es solo utilizado con el atributo creado en clase Bateria
         this.Bateria=Bateria;
        }
          
          //creacion de metodo Afina usando override para volver utilizarlo 
          //Ya que se uso virtual en clase de Musicos
        public override void Afina()
        {
            Console.WriteLine("{0} afina su bateria {1}",nombre,Bateria);
        }
        //Metodo de saluda y utiliza el override por que
        //se utilizo el virtual en clase Musicos
        public override void Saluda()
        {
            Console.WriteLine("Hola soy {0} ",nombre);
        }
        //Creacion de metodo toca y utiliza override
        //para volver utilizar el metodo
        public override void Toca()
        {
        Console.WriteLine("{0} empezo tocar su bateria {1}",nombre,Bateria);
        }
    }

    //Creacion de clase  Bajista y hereda Musicos
    class Bajista:Musicos
    {   
        //Atributos de Bajista
        protected string Bajo;
        
        //Sobre carga de contructor
        //y hereda nombre atravez de nombre
        public Bajista(string nombre,string Bajo):base(nombre)
        {   
            //this es solamente usado en atributo creado dentro de bajista
            this.Bajo=Bajo;
        }
           
        //Metodo afina con override 
        //ya que se esta usando nuevamente 
        //dentro de la clase Bajista
        public override void Afina()
        {
            Console.WriteLine("{0} afina su bajo {1}",nombre,Bajo);
        }
        //Metodo de saluda
        //el cual permite que el bajista salude
        public override void Saluda()
        {
            Console.WriteLine("Hola soy {0} ",nombre);
        }
        //Metodo de toca
        //Permite que el bajista empieze a tocar bajo
        public override void Toca()
        {
        Console.WriteLine("{0} empezo tocar su bajo {1}",nombre,Bajo);
        }

    }
    
    //Creacion de clase Guitarrista heredando Musico
    class Guitarrista:Musicos
    { 
        //Atributo de Guitarrista
        protected string Guitarra;
        //Sobre carga del constructor
        //Resive nombre de musicos 
        //utilizando el base 
        public Guitarrista(string nombre,string Guitarra):base(nombre)
        { 
            //this solo contendra los atributos de la clase GUitarrista
             this.Guitarra=Guitarra;
        }
        

        //Creacion de metodo Afina
        //PErmite que el guitarrista afine su guitarra
        //y lleva override por el virtual de clase MUsicos
         public override void Afina()
        {
            Console.WriteLine("{0} afina su guitarra {1}",nombre,Guitarra);
        }

        //Creacion de metodo Saluda
        //PErmite que guitarrista salude
        //Y el override es por que ya se usado el metodo en otras clases
        public override void Saluda()
        {
            Console.WriteLine("Hola soy {0} ",nombre);
        }

        //Metodo de toca 
        //PErmite que guitarrista toque 
        //Y el override por el motivo de que otras clases la usan
        //y por que se utilizo el virtual en clase Musicos
        public override void Toca()
        {
        Console.WriteLine("{0} empezo tocar su guitarra {1}",nombre,Guitarra);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Creacion de objeto Musicos
            //Y la impresion de Afinar ,Saludar y Tocar
            Musicos Chester=new Musicos("Chester");
            Chester.Afina();
            Chester.Saluda();
            Chester.Toca();
            
            //Creacion de objeto Baterista
            //Y la impresion de Afinar ,Saludar y Tocar
            Baterista Rob=new Baterista("Rob","Pearl");
            Rob.Afina();
            Rob.Saluda();
            Rob.Toca();
            
            //Creacion de objeto Bajista
            //Y la impresion de Afinar ,Saludar y Tocar
            Bajista Brad =new Bajista("Brad","Ibanez");
            Brad.Afina();
            Brad.Saluda();
            Brad.Toca();
            
            //Creacion de objeto Guitarrista
            //Y la impresion de Afinar ,Saludar y Tocar
            Guitarrista Mike =new Guitarrista("Mike","Fender");
             Mike.Afina();
             Mike.Saluda();
             Mike.Toca();
            
              

             Console.WriteLine("Impresion por medio de list:");
             //Creacion de lista de Musicos
             List<Musicos> Linkinpark =new List<Musicos>();
             //Agregacion de objetos a lista
             Linkinpark.Add(Chester);
             Linkinpark.Add(Rob);
             Linkinpark.Add(Brad);
             Linkinpark.Add(Mike);
             foreach(Musicos miembros in Linkinpark)
            {  
                //Permite realziar la impresion de cada miembro de la lista
                miembros .Afina();
                miembros .Saluda();
                miembros .Toca();
            }

        }
    }
}
