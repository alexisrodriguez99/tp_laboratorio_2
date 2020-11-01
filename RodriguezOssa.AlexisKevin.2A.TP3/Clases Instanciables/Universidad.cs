using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using Archivos;
using Exepciones;
namespace Clases_Instanciables
{
    public class Universidad
    {
        List<Alumno> alumnos;
        List<Jornada> jornada;
        List<Profesor> profesor;

        public enum EClases
        {
            Programacion,
            Laboratorio,
            Legislacion,
            SPD
        }
        /// <summary>
        /// Propiedad de lectura y escritura de la lista de alumnos
        /// </summary>
        public List<Alumno> Alumnos
        {
            get { return this.alumnos; }
            set { this.alumnos = value; }
        }
        /// <summary>
        /// Propiedad de lectura y escritura de la lista de jornadas
        /// </summary>
        public List<Jornada> Jornadas
        {
            get { return this.jornada; }
            set { this.jornada = value; }
        }
        /// <summary>
        /// Propidedad de lectura y escritura de la lista de profesores
        /// </summary>
        public List<Profesor> Instructores
        {
            get { return this.profesor; }
            set { this.profesor = value; }
        }
        /// <summary>
        /// Propiedad, de indexador, de lectura y escritura de la lista de jornadas
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public Jornada this[int i]
        {
            get { return this.jornada[i]; }
            set { this.jornada[i] = value; }
        }
        /// <summary>
        /// Constructor por defecto de universidad, donde se instancian las listas alumno, profesor y jornada
        /// </summary>
        public Universidad()
        {
            alumnos = new List<Alumno>();
            jornada = new List<Jornada>();
            profesor = new List<Profesor>();
        }
        /// <summary>
        /// Metodo que le da formato a los datos de una universidad
        /// </summary>
        /// <param name="uni">Una universidad</param>
        /// <returns>Retorna un string con los datos de la universidad</returns>
        private static string MostrarDatos(Universidad uni)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("JORNADA:");
            foreach (Jornada auxJornada in uni.jornada)
            {
                sb.AppendFormat(auxJornada.ToString());
                sb.AppendLine("<-------------------------------------->\n");
            }
            return sb.ToString();
        }
        /// <summary>
        /// Metodo que serializa los datos de una universidad en un archivo xml
        /// </summary>
        /// <param name="uni">Los datos a guardar</param>
        /// <returns>Retorna 'treu' si lo logro o 'false' caso contrario</returns>
        public static bool Guardar(Universidad uni)
        {
            Xml<Universidad> archiboGuardar = new Xml<Universidad>();
            return archiboGuardar.Guardar("Universidad.xml", uni);
        }
        /// <summary>
        /// Metodo que deserializa los datos de un archivo xml
        /// </summary>
        /// <returns>Retorna los datos que deserializo</returns>
        public static Universidad Leer()
        {
            Xml<Universidad> archivoLeer = new Xml<Universidad>();
            Universidad guardarDatos = null;
            archivoLeer.Leer("Universidad.xml", out guardarDatos);
            return guardarDatos;

        }
        /// <summary>
        /// sobrecarga del ==, verifica que un alumno este en la universidad
        /// </summary>
        /// <param name="g">Una universidad</param>
        /// <param name="a">Un alumno</param>
        /// <returns>Retorna 'true' si el alumno esta en la universidad o 'false' caso contrario</returns>
        public static bool operator ==(Universidad g, Alumno a)
        {
            bool verificar = false;
            foreach (Alumno auxAlumno in g.Alumnos)
            {
                if (auxAlumno == a)
                {
                    verificar = true;
                    break;
                }
            }
            return verificar;
        }
        /// <summary>
        /// sobrecarga del !=, verifica que un alumno no este en la universidad
        /// </summary>
        /// <param name="g"></param>
        /// <param name="a"></param>
        /// <returns>Retorna 'true' si el alumno no esta en la universidad o 'false' caso contrario</returns>
        public static bool operator !=(Universidad g, Alumno a)
        {
            return !(g == a);
        }
        /// <summary>
        /// sobrecarga del ==, verifica que un profesor este en la universidad
        /// </summary>
        /// <param name="g">Una universidad</param>
        /// <param name="i">Un profesor</param>
        /// <returns>Retorno 'true' si el profesor esta en la universidad o 'false' caso contrario</returns>
        public static bool operator ==(Universidad g, Profesor i)
        {
            bool verificar = false;
            foreach (Profesor auxProfesor in g.Instructores)
            {
                if (auxProfesor == i)
                {
                    verificar = true;
                    break;
                }
            }
            return verificar;
        }
        /// <summary>
        /// sobrecarga del !=, verifica que un profesor no este en la universidad
        /// </summary>
        /// <param name="g">Una univesidad</param>
        /// <param name="i">Un profesor</param>
        /// <returns>Retorno 'true' si el profesor no esta en la universidad o 'false' caso contrario</returns>
        public static bool operator !=(Universidad g, Profesor i)
        {
            return !(g == i);
        }
        /// <summary>
        /// sobrecarga del ==, busca al primer profesor que de esa clase en la universidad
        /// </summary>
        /// <param name="g">Una universidad</param>
        /// <param name="i">Una clase</param>
        /// <returns>Retorna 'true' si lo encontro o 'false' caso contrario</returns>
        public static Profesor operator ==(Universidad g, EClases i)
        {
            bool verificar = false;
            Profesor profesorDeLaClase = null;
            foreach (Profesor auxProfesor in g.Instructores)
            {
                if (auxProfesor == i)
                {
                    profesorDeLaClase = auxProfesor;
                    verificar = true;
                    break;
                }
            }
            if (!verificar)
            {
                throw new SinProfesorException();
            }
            return profesorDeLaClase;
        }
        /// <summary>
        /// sobrecarga del !=, busca al primer profesor que no de esa clase en la universidad
        /// </summary>
        /// <param name="g">Una universidad</param>
        /// <param name="i">Una clase</param>
        /// <returns>Retorna 'true' si lo encontro o 'false' caso contrario</returns>
        public static Profesor operator !=(Universidad g, EClases i)
        {

            Profesor profesorDeLaClase = null;
            foreach (Profesor auxProfesor in g.Instructores)
            {
                if (auxProfesor != i)
                {
                    profesorDeLaClase = auxProfesor;

                    break;
                }

            }

            return profesorDeLaClase;
        }
        /// <summary>
        /// sobrecarga del +, que agrega un alumno a la universidad.Solo si no esta previamente cargado
        /// </summary>
        /// <param name="u">Una universidad</param>
        /// <param name="a">Un alumno</param>
        /// <returns>Retorna la universidad pasada como parametro</returns>
        public static Universidad operator +(Universidad u, Alumno a)
        {

            if (u != a)
            {
                u.Alumnos.Add(a);
            }
            else
            {
                throw new AlumnoRepetidoException();
            }
            return u;
        }
        /// <summary>
        /// sobrecarga del +, que agrega un profesor a la universidad.Solo si no esta previamente cargado
        /// </summary>
        /// <param name="u">Una universidad</param>
        /// <param name="i">Un profesor</param>
        /// <returns>Retorna la universidad pasada como parametro</returns>
        public static Universidad operator +(Universidad u, Profesor i)
        {
            if (u != i)
            {
                u.Instructores.Add(i);
            }
            return u;
        }
        /// <summary>
        /// sobrecarga del +, que genera una nueva jornada y le pasa como parametros, la clase , el primer profesor que pueda
        /// dar esa clase y la lista de alumnos que la toman
        /// </summary>
        /// <param name="g">Una universidad</param>
        /// <param name="clase">Una clase</param>
        /// <returns>Retorna la universidad pasada como parametro</returns>
        public static Universidad operator +(Universidad g, EClases clase)
        {
            Jornada nuevaJornada = new Jornada(clase, g == clase);
            foreach (Alumno alumos in g.alumnos)
            {
                if (alumos == clase)
                {
                    nuevaJornada.Alumnos.Add(alumos);
                }

            }
            g.Jornadas.Add(nuevaJornada);

            return g;
        }
        /// <summary>
        /// sobrecargo el ToString, que hace publicos los datos del metodo MostrarDatos
        /// </summary>
        /// <returns>Retorna un string con los datos de la universidad</returns>
        public override string ToString()
        {
            return Universidad.MostrarDatos(this);
        }
    }
}
