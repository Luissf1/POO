using System;

namespace Alumnos
{   

    class Alumnos
    {
        //Se utiliza protected por private no se puede heredar
        //solamente protected y public
        //y protected es equivalente a private pero si se puede heredar
         protected string nombre;
         protected string carrera;
     
     //Sobre carga de constructor 
    public Alumnos(string nombre,string carrera)
    {
        //this utilizado adentro del constructor para los atributos de la clase
     this.nombre=nombre;
     this.carrera=carrera;

    }
   
    //Metodo que lleva virtual 
    //el cual permite que despues se pueda realizar el override y new
    public virtual void Print()
    {
        Console.WriteLine("Mi nombre es {0} ,estudio :{1} :",nombre,carrera);
    }
    }
    
    //creacion de clase y que hereda la clase Alumnos
    class Licenciatura:Alumnos
    {

        //Declaracion de atributos en clase 
       protected string servicio_social;
       protected string residencia;
        
        //sobre carga de constructor con base permitiendo heredar los atributos de clase Alumnos
       public Licenciatura(string nombre,string carrera,string servicio_social ,string residencia):base(nombre, carrera)
        {
            //Solo se uso this con los atributos de la clase Licenciatura
         this.servicio_social=servicio_social;
         this.residencia=residencia;

        }
        
        //metodo que permite imprimir con los atributos heredados
        //igualmente permitiendo utilizar nuevamente el metodo Print
        public override void Print()
        {
             Console.WriteLine("Mi nombre es {0} ,estoy en la carrera de :{1} ,hare mis servicios en :{2} y mi residencia en :{3}",nombre,carrera,servicio_social,residencia);
        }
    }
    
    //Creacion de clase posgrado heredando clase Alumnos
    class Posgrado:Alumnos
    {
        //atributos de la clase posgrado
     protected string investigacion;
     

     //SObre carga de constructor y heredando 
     //atributos de clase alumnos con base
     public Posgrado(string nombre,string carrera,string investigacion):base(nombre,carrera)
     {
         //this solo usado con atributo creado en posgrado 

      this.investigacion=investigacion;
     }
    
    //Creacion de metodo Print
    //Utilizando new para permitir crear nuevo metodo 
    //podiendo seguir usando el nombre Print
     public new void Print()
    {
        Console.WriteLine("Mi nombre es {0} ,estoy en la maestria de :{1} ,hare una investigacion sobre :{2}",nombre, carrera, investigacion);
    }
    }

    class Program
    {
        static void Main(string[] args)
        {   
            //Creacion de tres objetos 
            //el primero siendo el de Licenciatura
            Licenciatura Jerry=new Licenciatura("Jerry","Sistemas","CENIDE","Planatronics");
            //el segundo siendo el de posgrado 
            Posgrado Tom=new Posgrado("Tom","Ciencias computacionales","Inteligencia artificial");
            //el tercero siendo el de un alumno en general 
            Alumnos Jeff=new Alumnos("Jeff","TICS");
          
          //Impresion por medio del print creado en las tres clases
          Jerry.Print();
          Tom.Print();
          Jeff.Print();
            
        }
    }
}
