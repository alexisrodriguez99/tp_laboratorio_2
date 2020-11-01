using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exepciones
{
    public class AlumnoRepetidoException:Exception
    {
        /// <summary>
        /// constructor de la excepcion de alumnos repetidos
        /// </summary>
        public AlumnoRepetidoException():base("Alumno repetido.")
        {

        }
    }
}
