using Clases_Abstractas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_Instanciables
{
    public sealed class Profesor : Universitario
    {
        Queue<Universidad.EClases> clasesDelDia;
        static Random random;
        /// <summary>
        /// Constructor de clase por defecto de profesor, intancio el atributo random
        /// </summary>
        static Profesor()
        {
            Profesor.random = new Random();
        }
        /// <summary>
        /// Constructor por defecto de profesor
        /// </summary>
        public Profesor() : this(1, "", "", "1", ENacionalidad.Argentino)
        {

        }
        /// <summary>
        /// Sobrecarga del contructor de profesor, que instancia todos los datos pasados por paramtros
        /// </summary>
        /// <param name="id">El id del profesor</param>
        /// <param name="nombre">El nombre del profesor</param>
        /// <param name="apellido">El apellido del profesor</param>
        /// <param name="dni">El dni del profesor</param>
        /// <param name="nacionalidad">La nacionalidad del profesor</param>
        public Profesor(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad)
            : base(id, nombre, apellido, dni, nacionalidad)
        {
            this.clasesDelDia = new Queue<Universidad.EClases>();
            this._randomClases();

        }
        /// <summary>
        /// Asigna las clases de un profesor
        /// </summary>
        private void _randomClases()
        {
            for (int i = 0; i < 2; i++)
            {
                this.clasesDelDia.Enqueue((Universidad.EClases)random.Next(0, 4));

            }
        }
        /// <summary>
        /// sobrecarga del metodo ParticiparEnClase, que le formato a las clases de del profesor
        /// </summary>
        /// <returns>Retorna las clases que da el profesor</returns>
        protected override string ParticiparEnClase()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("CLASES DEL DÍA:");
            foreach (Universidad.EClases clase in this.clasesDelDia)
            {
                sb.AppendLine(clase.ToString());
            }
            return sb.ToString();
        }
        /// <summary>
        /// sobrecarga del ==, verifica que un profesor de ese clase
        /// </summary>
        /// <param name="i">Un profesor</param>
        /// <param name="clase">Una clase</param>
        /// <returns>Retorna 'true' si el profesor da esa clase o 'false' caso contrario</returns>
        public static bool operator ==(Profesor i, Universidad.EClases clase)
        {
            bool verificar = false;
            foreach (Universidad.EClases claseAux in i.clasesDelDia)
            {
                if (claseAux == clase)
                {
                    verificar = true;
                    break;
                }

            }
            return verificar;
        }
        /// <summary>
        /// sobrecarga del !=, verifica que un profesor no de ese clase
        /// </summary>
        /// <param name="i">Un profesor</param>
        /// <param name="clase">Una clase</param>
        /// <returns>Retorna 'true' si el profesor no da esa clase o 'false' caso contrario</returns>
        public static bool operator !=(Profesor i, Universidad.EClases clase)
        {
            return !(i == clase);
        }
        /// <summary>
        /// sobrecarga del MostrarDatos, que le da formato a los datos de un profesor
        /// </summary>
        /// <returns>Retorna un string con los datos del profesor</returns>
        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat(base.MostrarDatos());
            sb.AppendLine(this.ParticiparEnClase());
            return sb.ToString();
        }

        /// <summary>
        /// sobrecarga del ToString, que hace publico los datod del metodo MostrarDatos 
        /// </summary>
        /// <returns>Retorna un string con los datos de un profesor</returns>
        public override string ToString()
        {
            return this.MostrarDatos();
        }
    }
}
