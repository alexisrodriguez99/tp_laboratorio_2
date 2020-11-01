using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clases_Abstractas;
namespace Clases_Instanciables
{
    public sealed class Alumno : Universitario
    {
        Universidad.EClases claseQueToma;
        EEstadoCuenta estadoCuenta;

        public enum EEstadoCuenta
        {
            AlDia,
            Deudor,
            Becado
        }
        /// <summary>
        /// Constructor por defecto de alumno
        /// </summary>
        public Alumno()
        {

        }
        /// <summary>
        /// Sobrecarga del contructor de alumno que inicializa los datos pasadon por parametro
        /// </summary>
        /// <param name="id">El id del alumno</param>
        /// <param name="nombre">El nombre del alumno</param>
        /// <param name="apellido">El apellido del alumno</param>
        /// <param name="dni">El dni del alumno</param>
        /// <param name="nacionalidad">La nacionalidad del alumno</param>
        /// <param name="claseQueToma">La clase que toma el alumno</param>
        public Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad, Universidad.EClases claseQueToma)
            : base(id, nombre, apellido, dni, nacionalidad)
        {
            this.claseQueToma = claseQueToma;
        }
        /// <summary>
        /// Sobrecarga del contructor de alumno que inicializa los datos pasadon por parametro
        /// </summary>
        /// <param name="id">El id del alumno</param>
        /// <param name="nombre">El nombre del alumno</param>
        /// <param name="apellido">El apellido del alumno</param>
        /// <param name="dni">El dni del alumno</param>
        /// <param name="nacionalidad">La nacionalidad del alumno</param>
        /// <param name="claseQueToma">La clase que toma el alumno</param>
        /// <param name="estadoCuenta">El estado de cuenta del alumno</param>
        public Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad, Universidad.EClases claseQueToma, EEstadoCuenta estadoCuenta)
            : this(id, nombre, apellido, dni, nacionalidad, claseQueToma)
        {
            this.estadoCuenta = estadoCuenta;
        }
        /// <summary>
        /// Sobrecarga del metodo MostrarDatos, que le da un formato a todos los datos de un alumno 
        /// </summary>
        /// <returns>Retorna una cadena con los datos del alumno</returns>
        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.MostrarDatos());
            sb.Append("ESTADO DE CUENTA:");
            if (this.estadoCuenta == EEstadoCuenta.AlDia)
            {
                sb.AppendLine(" Cuota al día");
            }
            else if (this.estadoCuenta == EEstadoCuenta.Becado)
            {
                sb.AppendLine(" Cuota becada");
            }
            else
            {
                sb.AppendLine(" Cuota deudor");
            }

            sb.AppendFormat(this.ParticiparEnClase());
            return sb.ToString();
        }
        /// <summary>
        /// Sobrecarga del metodo PariciparEnClase, que le da un formato a la clase que toma un alumno
        /// </summary>
        /// <returns>Retorna una cadena con la clase que toma el alumno</returns>
        protected override string ParticiparEnClase()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat($"TOMA CLASE DE {this.claseQueToma}");
            return sb.ToString();
        }
        /// <summary>
        /// Sobrecarga del ==, que verifica que un alumno toma esa clase y su estado de cuenta no es deudor
        /// </summary>
        /// <param name="a">Un alumno</param>
        /// <param name="clase">Una clase</param>
        /// <returns>Retorna 'true' si el alumno toma esa calse y no es deudo o 'false' en el caso contrario</returns>
        public static bool operator ==(Alumno a, Universidad.EClases clase)
        {
            bool validar = false;
            if (a.claseQueToma == clase && a.estadoCuenta != EEstadoCuenta.Deudor)
            {
                validar = true;
            }
            return validar;
        }

        /// <summary>
        /// Sobrecarga del !=, que verifica que un alumno no toma esa clase y su estado de cuenta no es deudor
        /// </summary>
        /// <param name="a">Un alumno</param>
        /// <param name="clase">Una clase</param>
        /// <returns>Retorna 'true' si el alumno no toma esa clase o 'false' en el caso contrario</returns>
        public static bool operator !=(Alumno a, Universidad.EClases clase)
        {
            return !(a == clase);
        }
        /// <summary>
        /// Sobrecarga del ToString, que hace publico los datos del metodo MostrarDatos
        /// </summary>
        /// <returns>Retorna los datos de un alumno</returns>
        public override string ToString()
        {
            return this.MostrarDatos();
        }
    }
}
