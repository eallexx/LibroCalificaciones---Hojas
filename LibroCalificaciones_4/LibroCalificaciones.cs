using System;
using System.Collections.Generic;
using System.Text;

namespace LibroCalificaciones_4
{
    public class LibroCalificaciones
    {
        private string nombreCurso; //nombre del curso que representa este LibroCalificaciones

        //el constructor inicializa nombreCurso
        public LibroCalificaciones(string nombre)
        {
            nombreCurso = nombre; //inicializa nombreCurso usando la ropiedad
        }//fin del constructor

        //propiedad para obtener (get) y establecer set) el nombre del curso

        public string NombreCurso
        {
            get { return nombreCurso; }// fin de get
            set { nombreCurso = value; //set deberia validar
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
            int promedio; //promedio de las calificaciones

            //fase de inicializacion
            total = 0; //inicializa el total
            contadorCalif = 1; //inicializa el contador del ciclo

            //fase de procesamiento
            while (contadorCalif <= 10) //se repite 10 veces
            {
                Console.Write("Escriba calificacion: "); //mensaje para el usuario
                calificacion = Convert.ToInt32(Console.ReadLine()); //lee la calificacion
                total = total + calificacion; //Sima la calificacion al total
                contadorCalif = contadorCalif + 1; //incrementa el contador en 1
            } //fin de while

            //fase de terminacion
            promedio = total / 10; //division entera produce resultado entero

            //muestra el total y el promedio de las calificaciones
            Console.WriteLine("\nEl total de las califcaciones es {0}", total);
            Console.WriteLine(" El promedio de la clase es {0}", promedio);

        } //fin del metodo DeterminarPromedioClase
    } //fin de la clase LibroCalifcaciones
} 
