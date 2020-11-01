using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exepciones
{
   public class ArchivosException:Exception
    {
        /// <summary>
        /// contructor por defecto de la excepcion de archivos
        /// </summary>
        /// <param name="innerException"></param>
       public ArchivosException(Exception innerException):base("Error: ",innerException)
        {

        }
    }
}
