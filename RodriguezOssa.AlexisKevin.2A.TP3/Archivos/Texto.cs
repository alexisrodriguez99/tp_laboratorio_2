using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Exepciones;

namespace Archivos
{
    public class Texto : IArchivo<string>
    {
        /// <summary>
        /// Metodo que me guarda un archivo de tipo txt con los datos pasados como parametro
        /// </summary>
        /// <param name="archivo">Es el direccion del archivo</param>
        /// <param name="datos">Los datos que se desean guardar</param>
        /// <returns>Me retorna 'true' si lo logro o 'false' en el caso contrario</returns>
        public bool Guardar(string archivo, string datos)
        {
            bool validar = false;
            Encoding codificacion = Encoding.UTF8;
            try
            {
                using (StreamWriter sw = new StreamWriter(archivo, false, codificacion))
                {
                    sw.Write(datos);
                    validar = true;
                }
            }
            catch (Exception excepcion)
            {
                throw new ArchivosException(new Exception(excepcion.Message));

            }
            return validar;
        }
        /// <summary>
        /// Metodo que me perimete leer un archvivo
        /// </summary>
        /// <param name="archivo">La direccion del arichivo</param>
        /// <param name="datos">En donde se va a guardar los datos leidos</param>
        /// <returns>Me retorna 'true' si lo logro o 'false' en el caso contrario</returns>
        public bool Leer(string archivo, out string datos)
        {
            bool validar = false;
            datos = "";
            try
            {
                if (File.Exists(archivo))
                {
                    using (StreamReader sr = new StreamReader(archivo))
                    {
                        datos = sr.ReadToEnd();
                        validar = true;

                    }
                }
                else
                {
                    throw new ArchivosException(new Exception("No se pudo leer el archivo de texto (el archino no existe))"));
                }


            }
            catch (Exception excepcion)
            {

                throw excepcion;
            }
            return validar;
        }
    }
}
