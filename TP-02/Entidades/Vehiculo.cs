using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// La clase Vehiculo no deberá permitir que se instancien elementos de este tipo.
    /// </summary>
    public abstract class Vehiculo
    {

       public enum EMarca
        {
            Chevrolet,
            Ford, 
            Renault, 
            Toyota, 
            BMW, 
            Honda, 
            HarleyDavidson
        }
       public enum ETamanio
        {
            Chico, 
            Mediano, 
            Grande
        }
        EMarca marca;
        string chasis;
        ConsoleColor color;
        /// <summary>
        /// Inicializo al vehiculo
        /// </summary>
        /// <param name="chasis">El chasis del vehiculo</param>
        /// <param name="marca">La marca del vehiculo</param>
        /// <param name="color">El color del vehiculo</param>
       public Vehiculo(string chasis, EMarca marca, ConsoleColor color)
        {
            this.chasis = chasis;
            this.marca = marca;
            this.color = color;
        }

        /// <summary>
        /// ReadOnly: Retornará el tamaño
        /// </summary>
        protected abstract ETamanio Tamanio { get; }

        /// <summary>
        /// Publica todos los datos del Vehiculo.
        /// </summary>
        /// <returns></returns>
        public virtual string  Mostrar()
        {
            return (string)this;
        }
        /// <summary>
        /// Es un casteo que devuelve un string con todos los datos del vehiculo
        /// </summary>
        /// <param name="p">El vehiculo que recibe</param>
        public static explicit operator string(Vehiculo p)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("CHASIS: {0}\r\n", p.chasis);
            sb.AppendFormat("MARCA : {0}\r\n", p.marca.ToString());
            sb.AppendFormat("COLOR : {0}\r\n", p.color.ToString());
            sb.AppendLine("---------------------");

            return sb.ToString();
        }

        /// <summary>
        /// Dos vehiculos son iguales si comparten el mismo chasis
        /// </summary>
        /// <param name="v1">El primer vehiculo</param>
        /// <param name="v2">El segundo vehiculo</param>
        /// <returns>Retorna true si el chasis de los vehiculos son iguales o false en caso contrario</returns>
        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            return (v1.chasis == v2.chasis);
        }
        /// <summary>
        /// Dos vehiculos son distintos si su chasis es distinto
        /// </summary>
        /// <param name="v1">El primer vehiculo</param>
        /// <param name="v2">El segunfo vehiculo</param>
        /// <returns>Retorna true si los chasis de los vehiculos son distintos o false en caso contrario</returns>
        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1==v2);
        }
    }
}
