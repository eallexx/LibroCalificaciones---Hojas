namespace LibroCalificaciones_4
{
    //Fig 5.6: PruebaLibroCalificaciones.cs
    //Crea el bjeto LibroCalifcaciones e invoca a su metodo DeterminarPromedio.
    public class ProgramLibroCalificaciones_4
    {
        public static void Main(string[] args)
        {
            //crea el objeto milibroCalificaciones de LibroCalificaciones y 
            //pasa el nombre del curso al constructor
            LibroCalificaciones miLibroCalificaciones = new LibroCalificaciones
               ("CS101 Introduccion a la programacion en C#");

            miLibroCalificaciones.MostrarMensaje(); //muestra el mensaje de bienvenida
            miLibroCalificaciones.DeterminarPromedioClase(); //encuentra el promedio de calificaciones
            
        }//fin de main
    }//fin de la clase PriebaLibroCalificaicones
}

