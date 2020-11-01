using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exepciones
{
   public class DniInvalidoException:Exception
    {
        /// <summary>
        /// constructor por defecto de excepcion de dni invalido
        /// </summary>
        public DniInvalidoException():base("Error en el formato del DNI")
        {

        }
        /// <summary>
        /// sobrecarga del contructor de la excepcion dni invalido
        /// </summary>
        /// <param name="e"></param>
        public DniInvalidoException(Exception e):this("Error en el formato del DNI: "+e.Message)
        {

        }
        /// <summary>
        /// sobrecarga del contructor de la excepcion dni invalido
        /// </summary>
        /// <param name="message"></param>
        public DniInvalidoException(string message):base(message)
        {

        }
        /// <summary>
        /// sobrecarga del contructor de la excepcion dni invalido
        /// </summary>
        /// <param name="message"></param>
        /// <param name="e"></param>
        public DniInvalidoException(string message,Exception e):base(message,e)
        {

        }
    }
}
