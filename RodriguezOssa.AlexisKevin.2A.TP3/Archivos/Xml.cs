using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using Exepciones;
using System.IO;

namespace Archivos
{
    public class Xml<T> : IArchivo<T>
    {
        /// <summary>
        /// Metodo que serializa cualquier tipo de dato en un archimo xml
        /// </summary>
        /// <param name="archivo">La direccion del archivo</param>
        /// <param name="datos">Los datos que se serializan</param>
        /// <returns>Retorna 'true' si lo logro o 'false' en el caso contrario</returns>
        public bool Guardar(string archivo, T datos)
        {
            bool verificar = false;
            Encoding codificacion = Encoding.UTF8;
            try
            {
                using (XmlTextWriter xw = new XmlTextWriter(archivo, codificacion))
                {
                    XmlSerializer serializar = new XmlSerializer(typeof(T));
                    serializar.Serialize(xw, datos);
                    verificar = true;

                }
            }
            catch (Exception excepcion)
            {
                throw new ArchivosException(new Exception(excepcion.Message));

            }
            return verificar;
        }

        /// <summary>
        /// Metodo que deserializa los datod del archivo xml
        /// </summary>
        /// <param name="archivo">La direccion del archivo</param>
        /// <param name="datos">En donde se guarda los datos</param>
        /// <returns>Retorna 'true' si lo logro o 'false' en el caso contrario</returns>
        public bool Leer(string archivo, out T datos)
        {
            bool verificar = false;
            try
            {
                if (archivo != null)
                {
                    using (XmlTextReader xr = new XmlTextReader(archivo))
                    {
                        XmlSerializer serializar = new XmlSerializer(typeof(T));
                        datos = (T)serializar.Deserialize(xr);
                        verificar = true;
                    }
                }
                else
                {
                    throw new ArchivosException(new Exception("No se pudo leer el archivo de xml (el archino no existe))"));
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            return verificar;
        }

    }



}

