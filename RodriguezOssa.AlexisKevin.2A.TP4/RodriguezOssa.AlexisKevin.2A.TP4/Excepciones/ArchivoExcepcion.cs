using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
  public  class ArchivoExcepcion:Exception
    {
        /// <summary>
        /// contructor  parametizado de la excepcion de archivos
        /// </summary>
        /// <param name="innerExcepcion"></param>
        public ArchivoExcepcion(Exception innerExcepcion) : base("Error al realizar esta accion con el archivo", innerExcepcion)
        {

        }
    }
}
