using System;
using System.Collections.Generic;
using System.Text;

namespace LibroCalificaciones_4
{
    public class LibroCalificaciones1
    {
        private string nombreCurso; //nombre del curso que representa este LibroCalificaciones

        //el constructor inicializa nombreCurso
        public LibroCalificaciones1(string nombre)
        {
            nombreCurso = nombre; //inicializa nombreCurso usando la ropiedad
        }//fin del constructor

        //propiedad para obtener (get) y establecer set) el nombre del curso

        public string NombreCurso
        {
            get { return nombreCurso; }// fin de get
            set
            {
                nombreCurso = value; //set deberia validar
            } //fin del set
        } //fin de la propiedad NombreCurso

        //muestra un mensaje de bienvenida para el usuario de LibroCalificaciones
        public void MostrarMensaje()
        {
            //la propiedad NombreCurso obtiene el nombre del curso
            Console.WriteLine("Bienvenido al libro de calificaciones de \n{0}!", NombreCurso);
        } //Fin del metodo MostrarMensaje

        //determina el promedio de la clase con base en las 10 calificaciones introducidas por el usuario
        public void DeterminarPromedioClase()
        {
            int total; //suma de las calificaciones introducidas por el usuario
            int contadorCalif; //número de la siguiente calificación a introducir
            int calificacion; //valor de la calificación introducida por el usuario
            double promedio; //promedio de las calificaciones

            //fase de inicializacion
            total = 0; //inicializa el total
            contadorCalif = 0; //inicializa el contador del ciclo

            //fase de procesamiento
            //mensaje para recibir como entrada la calificacion del usuario
            Console.Write("Escriba  calficacion o -1 para salir: ");
            calificacion = Convert.ToInt32(Console.ReadLine());

            //itera hasta que se lee el valor centinela del usuario
            while (calificacion != -1)
            {
                total = total + calificacion; //suma calificacion a total
                contadorCalif = contadorCalif + 1; //incremeta el contador

                //mensaje para recibir como entrada la siguiente calificacion del usuario
                Console.Write("Escriba calificacion o -1 para salir: ");
                calificacion = Convert.ToInt32(Console.ReadLine());
            } //fin de while

            
            //fase de terminacion
            //si el usuario introdujo cuando menos una calificacion...
            if(contadorCalif != 0)
            {
                //calcula el promedio de todas las calificaciones introducidas
                promedio = (double)total / contadorCalif;

                //muestra el total y el promedio (con dos digitos de precision)
                Console.WriteLine("\nEl total de las {0} calificaciones introducidas es {1}",
                    contadorCalif, total);
                Console.WriteLine("El promedio de las clases es {0:F2}", promedio);
            }// fin del if

            else //no se introdujeron califcaciones, entonces mostar mensaje de error
            {
                Console.WriteLine("No se introdujeron calificaciones");
            } 
            
        } //fin del metodo DeterminarPromedioClase
    } //fin de la clase LibroCalifcaciones1
}