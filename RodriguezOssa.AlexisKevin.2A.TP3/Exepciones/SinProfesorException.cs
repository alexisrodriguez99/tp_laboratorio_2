using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exepciones
{
   public class SinProfesorException:Exception
    {
        /// <summary>
        /// constructor por defecto de la excepcion sin profesor
        /// </summary>
        public SinProfesorException():base("No hay profesor para la clase.")
        {

        }
    }
}
