using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Suv:Vehiculo
    {
        /// <summary>
        /// Inicializo el Suv, con el constructor de vehiculo
        /// </summary>
        /// <param name="marca">La marca de Suv</param>
        /// <param name="chasis">El chasis del Suv</param>
        /// <param name="color">El color del Suv</param>
        public Suv(EMarca marca, string chasis, ConsoleColor color)
            : base(chasis, marca, color)
        {
        }
        /// <summary>
        /// Las camionetas son grandes
        /// </summary>
        protected override ETamanio Tamanio
        {
            get
            {
                return ETamanio.Grande;
            }
        }
        /// <summary>
        /// Metodo que se encargar de mostrar todas las caracteristicas del Suv
        /// </summary>
        /// <returns>Retorna los datos del Suv</returns>
        public override sealed string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("SUV");
            sb.AppendLine(base.Mostrar());
            sb.AppendLine("TAMAÑO : "+ this.Tamanio);
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
    }
}
