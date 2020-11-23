using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;
namespace Entidades
{
   public static class Extension
    {
        /// <summary>
        /// Extiende el metodo CapacidadMaximaExcepcion, para informar el error (Implemento clase 25: Extension)
        /// </summary>
        /// <param name="ex">Parametro que hace referencia el objeto que quiero extender</param>
        /// <returns>Retorna un mensaje de error</returns>
        public static string InformarError(this CapacidadMaximaExcepcion ex)
        {
            return "Error, STOCK lleno.No se ingreso este ultimo producto";
        }
    }
}
