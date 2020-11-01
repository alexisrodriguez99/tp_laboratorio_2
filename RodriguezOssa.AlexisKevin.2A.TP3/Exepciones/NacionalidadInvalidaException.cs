using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exepciones
{
    public class NacionalidadInvalidaException : Exception
    {
        /// <summary>
        /// contructor por defecto de la excepcion de nacionalidad invalida
        /// </summary>
        public NacionalidadInvalidaException():this("La nacionalidad no se condice con el número de DNI")
        {

        }
        /// <summary>
        /// sobrecarga del contructor de la excepcion de nacionalidad invalida
        /// </summary>
        /// <param name="message"></param>
        public NacionalidadInvalidaException(string message) : base(message)
        {

        }
    }
}
