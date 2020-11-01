using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exepciones;

namespace Clases_Abstractas
{
    public abstract class Persona
    {
        string apellido;
        int dni;
        ENacionalidad nacionalidad;
        string nombre;

        public enum ENacionalidad
        {
            Argentino,
            Extranjero
        }
        /// <summary>
        /// Propidad de escritura y lectura del apellido
        /// </summary>
        public string Apellido
        {
            get { return this.apellido; }
            set { this.apellido = this.ValidarNombreApellido(value); }
        }
        /// <summary>
        /// Propidad de escritura y lectura del dni(int)
        /// </summary>
        public int DNI
        {
            get { return this.dni; }
            set { this.dni = this.ValidarDni(this.Nacionalidad, value); }
        }
        /// <summary>
        /// Propidad de escritura y lectura de la naionalidad
        /// </summary>
        public ENacionalidad Nacionalidad
        {
            get { return this.nacionalidad; }
            set { this.nacionalidad = value; }
        }
        /// <summary>
        /// Propidad de escritura y lectura del nombre
        /// </summary>
        public string Nombre
        {
            get { return nombre; }
            set { nombre = this.ValidarNombreApellido(value); }
        }
        /// <summary>
        /// Propidad de escritura del dni(string)
        /// </summary>
        public string StringToDNI
        {
            set { this.dni = this.ValidarDni(this.Nacionalidad, value); }
        }
        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public Persona()
        {

        }
        /// <summary>
        /// Sobrecarga del contructor de clase que instancia los datos recibidos como parametro
        /// </summary>
        /// <param name="nombre">El nombre de la persona</param>
        /// <param name="apellido">El apellido de la persona</param>
        /// <param name="nacionalidad">La nacionalidad de la persona</param>
        public Persona(string nombre, string apellido, ENacionalidad nacionalidad) : this()
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Nacionalidad = nacionalidad;
        }
        /// <summary>
        /// Sobrecarga del contructor de clase que instancia los datos recibidos como parametro
        /// </summary>
        /// <param name="nombre">El nombre de la persna</param>
        /// <param name="apellido">El apellido de la persona</param>
        /// <param name="dni">El dni de la persona</param>
        /// <param name="nacionalidad">La nacionalidad de la persona</param>
        public Persona(string nombre, string apellido, string dni, ENacionalidad nacionalidad)
            : this(nombre, apellido, nacionalidad)
        {
            this.StringToDNI = dni;
        }
        /// <summary>
        /// Sobrecarga del contructor de clase que instancia los datos recibidos como parametro
        /// </summary>
        /// <param name="nombre">El nombre de la persona</param>
        /// <param name="apellido">El apellido de la persona</param>
        /// <param name="dni">El dni de la persona</param>
        /// <param name="nacionalidad">La nacionalidad de la persona</param>
        public Persona(string nombre, string apellido, int dni, ENacionalidad nacionalidad)
           : this(nombre, apellido, dni.ToString(), nacionalidad)
        {

        }
        /// <summary>
        /// Sobreescribo el metodo ToString, para mostrar todos los datos de persona
        /// </summary>
        /// <returns>Retorna una cadena con todos los datos de persona</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"NOMBRE COMPLETO: {this.apellido}, {this.nombre}");
            sb.AppendLine($"NACIONALIDAD: {this.nacionalidad}");
            return sb.ToString();

        }
        /// <summary>
        /// Valida el dni(int) segun su nacionalidad
        /// </summary>
        /// <param name="nacionalidad">La nacionalidad de la persona</param>
        /// <param name="dato">El dni de la persona a validar</param>
        /// <returns>Retorna el dni validado o '-1' en caso de haber un error</returns>
        private int ValidarDni(ENacionalidad nacionalidad, int dato)
        {
            int dniValidado = -1;
            if (nacionalidad == ENacionalidad.Argentino && dato >= 1 && dato <= 89999999)
            {
                dniValidado = dato;
            }
            else if (nacionalidad == ENacionalidad.Extranjero && dato >= 90000000 && dato <= 99999999)
            {
                dniValidado = dato;
            }
            return dniValidado;
        }
        /// <summary>
        /// Valido el dni(string)
        /// </summary>
        /// <param name="nacionalidad">La nacionalidad de la persona</param>
        /// <param name="dato">El dni de la persona a validar</param>
        /// <returns>Retorna el dni validado</returns>
        private int ValidarDni(ENacionalidad nacionalidad, string dato)
        {
            int dniValidado = -1;
            try
            {
                if (dato.Length > 8 || dato.Length < 8)
                {
                    throw new DniInvalidoException();
                }
                if (!(int.TryParse(dato, out dniValidado)))
                {
                    throw new DniInvalidoException();
                }
                if (ValidarDni(nacionalidad, dniValidado) == -1)
                {
                    throw new NacionalidadInvalidaException();
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            return dniValidado;
        }
        /// <summary>
        /// Valida que una cadena solo contenga letras
        /// </summary>
        /// <param name="dato">El dato a validar</param>
        /// <returns>Retorna el dato validado si la cadena solo tenia letras o "" en caso contrario</returns>
        private string ValidarNombreApellido(string dato)
        {
            foreach (char aux in dato)
            {
                if (!char.IsLetter(aux))
                {
                    dato = "";
                    break;
                }

            }
            return dato;
        }
    }
}
