using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Archivos;
namespace Clases_Instanciables
{
    public class Jornada
    {
        List<Alumno> alumnos;
        Universidad.EClases clase;
        Profesor instructor;
        /// <summary>
        /// Propiedad de lectura y escritura de la lista de alumnos
        /// </summary>
        public List<Alumno> Alumnos
        {
            get { return this.alumnos; }
            set { this.alumnos = value; }
        }
        /// <summary>
        /// Propiedad de lectura y escritura de clase
        /// </summary>
        public Universidad.EClases Clase
        {
            get { return this.clase; }
            set { this.clase = value; }
        }
        /// <summary>
        /// Propiedad de lectura y escritura del profesor
        /// </summary>
        public Profesor Instructor
        {
            get { return this.instructor; }
            set { this.instructor = value; }
        }
        /// <summary>
        /// Contrutor privado por defecto de una jornada, donce instancio la lista de alumnos
        /// </summary>
        private Jornada()
        {
            this.alumnos = new List<Alumno>();
        }
        /// <summary>
        /// sobrecarga del contructor de jornada, que instancia todos los datos pasados por parametro
        /// </summary>
        /// <param name="clase">La clase de una jornada</param>
        /// <param name="instructor">El profesor de una jornada</param>
        public Jornada(Universidad.EClases clase, Profesor instructor) : this()
        {
            this.clase = clase;
            this.instructor = instructor;
        }
        /// <summary>
        /// Guarda los datos de una jornada en un archivo txt
        /// </summary>
        /// <param name="jornada">La datos de la jornada a guardar</param>
        /// <returns>Retorna 'true' si lo logro o 'false' en el caso contrario</returns>
        public static bool Guardar(Jornada jornada)
        {
            Texto archivoGuardar = new Texto();
            return archivoGuardar.Guardar("Jornada.txt", jornada.ToString());
        }
        /// <summary>
        /// Lee un archivo txt, donde se encuentran los datos de una jornada guardada
        /// </summary>
        /// <returns>Retorna un string con los datos leidos</returns>
        public static string Leer()
        {
            Texto archivoLerr = new Texto();
            string datosDelArchico;

            archivoLerr.Leer("Jornada.txt", out datosDelArchico);

            return datosDelArchico;
        }
        /// <summary>
        /// Sobrecarga del metodo ==,verifica si un alumno esta en la jornada
        /// </summary>
        /// <param name="j">Una jornada</param>
        /// <param name="a">Un alumno</param>
        /// <returns>Retorna 'true' si el alumno pertenece a esa jornada o 'false' caso contrario</returns>
        public static bool operator ==(Jornada j, Alumno a)
        {
            bool verifica = false;
            foreach (Alumno aux in j.alumnos)
            {
                if (aux == a)
                {
                    verifica = true;
                }
            }

            return verifica;

        }
        /// <summary>
        /// Sobrecarga del metodo !=,verifica si un alumno no esta en la jornada
        /// </summary>
        /// <param name="j">Una jornada</param>
        /// <param name="a">Un alumno</param>
        /// <returns>Retorna 'true' si no el alumno no pertene a es jornada o 'false' caso contrario</returns>
        public static bool operator !=(Jornada j, Alumno a)
        {
            return !(j == a);
        }
        /// <summary>
        /// sobrecarga del +, que agrega un alumno a la jornada.Solo lo agrega si el alumno no esta en la jornada
        /// </summary>
        /// <param name="j">Una jornada</param>
        /// <param name="a">Un alumno</param>
        /// <returns>Retoruna 'true' si lo agrego o 'false' caso contraio</returns>
        public static Jornada operator +(Jornada j, Alumno a)
        {
            if (j != a)
            {
                j.Alumnos.Add(a);
            }
            return j;
        }

        /// <summary>
        /// sobrecarga del ToString, que le da formato a los datos de una jornada
        /// </summary>
        /// <returns>Retorna los datos una jornada</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat($"CLASE DE {this.Clase} POR {this.Instructor.ToString()}");
            sb.AppendLine("ALUMNOS:");
            foreach (Alumno a in this.Alumnos)
            {
                sb.AppendLine(a.ToString());
            }
            return sb.ToString();
        }

    }
}
