using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Clases_Abstractas
{
    public abstract class Universitario : Persona
    {
        int legajo;
        /// <summary>
        /// Constructor por defecto de universitario
        /// </summary>
        public Universitario()
            : this(1, "", "", "", ENacionalidad.Argentino)
        {

        }
        /// <summary>
        /// Sobrecarga del contructor de universidad, donde instancio los datos pasadon por parametro
        /// </summary>
        /// <param name="legajo">El legajo del universitario</param>
        /// <param name="nombre">El nombre del universitario</param>
        /// <param name="apellido">El apellido del universitario</param>
        /// <param name="dni">El dni del universitario</param>
        /// <param name="nacionalidad">La nacionalidad del universitario</param>
        public Universitario(int legajo, string nombre, string apellido, string dni, ENacionalidad nacionalidad)
            : base(nombre, apellido, dni, nacionalidad)
        {
            this.legajo = legajo;
        }
        /// <summary>
        /// Firma del metodo abstracto que muetra la clase que se toma
        /// </summary>
        /// <returns></returns>
        protected abstract string ParticiparEnClase();

        /// <summary>
        /// Muestra todos los datos de un universitario
        /// </summary>
        /// <returns>Retorna una cadena con los datos a mostrar</returns>
        protected virtual string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine($"LEGAJO NUMERO: {this.legajo}");

            return sb.ToString();
        }
        /// <summary>
        /// Sobrecarga del ==, que verifica que dos universitarios sean iguales
        /// </summary>
        /// <param name="pg1">Un universitario</param>
        /// <param name="pg2">Otro universitario</param>
        /// <returns>Retorna 'true' si son igules o 'false' en el caso contrario</returns>
        public static bool operator ==(Universitario pg1, Universitario pg2)
        {
            bool validar = false;
            if (pg1.Equals(pg2) && (pg1.legajo == pg2.legajo || pg1.DNI == pg2.DNI))
            {
                validar = true;
            }
            return validar;
        }
        /// <summary>
        /// Sobrecarga del !=, que verifica que dos universitarios sean distintos
        /// </summary>
        /// <param name="pg1">Un universitario</param>
        /// <param name="pg2">Otro universitario</param>
        /// <returns></returns>
        public static bool operator !=(Universitario pg1, Universitario pg2)
        {
            return !(pg1 == pg2);
        }
        /// <summary>
        /// Sobrescribo el metodo Equals para que compare dos objetos
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            return obj.GetType() == this.GetType();
        }
    }
}
