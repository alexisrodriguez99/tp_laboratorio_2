using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace Entidades
{
    public class Sedan : Vehiculo
    {
        public enum ETipo 
        { 
            CuatroPuertas, 
            CincoPuertas 
        }
        ETipo tipo;

        /// <summary>
        /// Por defecto, TIPO será Monovolumen
        /// Inicializa el Sedan con el constructor del vehiculo
        /// </summary>
        /// <param name="marca">La marca de Sedan</param>
        /// <param name="chasis">El chasis del Sedan</param>
        /// <param name="color">El color del Sedan</param>
        public Sedan(EMarca marca, string chasis, ConsoleColor color)
            : base(chasis, marca, color)
        {
            this.tipo = ETipo.CuatroPuertas;
        }
        /// <summary>
        /// Sobrecarga del constructor del Sedan, inicializa el tipo
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="chasis"></param>
        /// <param name="color"></param>
        /// <param name="tipo"></param>
        public Sedan(EMarca marca, string chasis, ConsoleColor color, ETipo tipo)
            :this(marca,chasis,color)
        {
            this.tipo = tipo;
        }

        /// <summary>
        /// Los automoviles son medianos
        /// </summary>
        protected override ETamanio Tamanio
        {
            get
            {
                return ETamanio.Mediano;
            }
        }
        /// <summary>
        /// Metodo que se encargar de mostrar todas las caracteristicas del Sedan
        /// </summary>
        /// <returns>Retorna un string con los datos del Sedan</returns>
        public override sealed string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("SEDAN");
            sb.AppendLine(base.Mostrar());
            sb.AppendLine("TAMAÑO : "+ this.Tamanio);
            sb.AppendLine("TIPO : " + this.tipo);
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }

    }
}
