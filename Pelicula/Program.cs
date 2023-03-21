using System;
using System.Collections.Generic;

namespace Pelicula
{

    public class Pelicula
    {
        //Campos
         private string titulo;
        private Int16 anio;
        private string pais;
        private  string director;
        private List<Actor> actores = new List<Actor>();

        //Constructores
        public Pelicula(){}
        public Pelicula(string titulo, Int16 anio){ //manera de hacerlo publico y poder usarlos
            this.titulo = titulo;
            this.anio = anio;
           
        }
        //Métodos
        public string GetTitulo(){
            return titulo;
        }
        public Int16 GetAño(){
            return anio;
        }
        public string getPais(){
            return pais;
        }
        public string getDirector(){
            return director;
        }

        public void SetTitulo(string ti){
            titulo = ti;
        }
        public void SetAño(Int16 ani){
            anio = ani;
        }
        public void setpais(string pa){
            pais = pa;
        }
        public void SetDirector(string dir){
            director = dir;
        }

        public void AgregaActor(Actor actor){
            actores.Add(actor);
        }
        public void Imprime()
        {
         Console.WriteLine($"{titulo} ({anio})");

        }
        
        public void ImprimeActores(){
            foreach(Actor h in actores){
                Console.WriteLine($"{h.getNombre()} ({h.getAnioActor()})");
            }
        }


    }

    public class Actor
    {
        //Propiedades
         string Nombre;
        Int16 anioActor;
        //Constructores
         public Actor(string Nombre , Int16 anioActor){ //manera de hacerlo publico y poder usarlos
            this.Nombre = Nombre;
            this.anioActor = anioActor;

        }

        //Métodos 
        public string getNombre(){
            return Nombre;
        }
        public Int16 getAnioActor(){
            return anioActor;
        }
        public void setNombre(string nom){
            Nombre = nom;
        }
        public void setAnioActor(Int16 anac){
            anioActor = anac;
        }
        public void Imprime()
        {
            Console.WriteLine($"{Nombre} ({anioActor})");
        }
    }

    // Puedes probar tu código en Main() pero lo importante
    // es que pase las pruebas

    class Program
    {


        static void Main(string[] args)
        {
            Pelicula p1 = new Pelicula();
                Pelicula p2 = new Pelicula();

                p1.SetTitulo("La la land");
                p1.SetAño(2016);
                Console.WriteLine("{0}, ({1})", p1.GetTitulo(),p1.GetAño());
                p1.Imprime();

                p2.SetTitulo("Whiplash");
                p2.SetAño(2014);
                Console.WriteLine("{0}, ({1})", p1.GetTitulo(),p1.GetAño());
                p2.Imprime();

                p1.AgregaActor(new Actor ("Andrew Garlfield", 1983));
                p1.AgregaActor(new Actor ("Brad Pitt", 1963));
                p1.AgregaActor(new Actor ("Robert de Niro", 1943));
                p1.AgregaActor(new Actor ("Leonardo Di Caprio", 1974));
                

                List<Pelicula> peliculas = new List<Pelicula>();
                peliculas.Add(new Pelicula("Trainspotting",1996));
                peliculas.Add(new Pelicula("Forrest Gump",1994));
                peliculas.Add(new Pelicula("Amores Perros",2002));
                peliculas.Add(new Pelicula("Trainspotting",1996));

                foreach (Pelicula film in peliculas){
                        film.Imprime();

                }
            Console.WriteLine("Hello");
        }
    }
}
