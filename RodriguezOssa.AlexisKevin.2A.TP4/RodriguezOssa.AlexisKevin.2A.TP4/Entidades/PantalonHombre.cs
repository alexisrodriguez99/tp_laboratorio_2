using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   public class PantalonHombre:Pantalon
    {
        public bool tieneCordon;
        /// <summary>
        /// sobrecarga del contructor de PantalonHombre, que instancia todos los datos pasados por parametro
        /// </summary>
        /// <param name="id">El id del pantalon de hombre</param>
        /// <param name="producto">El modelo del patalon de hombre</param>
        /// <param name="modelo">El modelo del pantalon de hombre</param>
        /// <param name="talle">El talle del pantalon de hombre</param>
        /// <param name="precio">El precio del pantalon de hombre</param>
        /// <param name="tieneCordon">El cordon que puede tener o no</param>
        public PantalonHombre(int id,string producto,string modelo,int talle, float precio,bool tieneCordon):base(id,producto,modelo,talle,precio)
        {
            this.tieneCordon = tieneCordon;
        }
        /// <summary>
        /// Sobre carga del ToString, que le formato al la informacion de un patalon de hombre
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.DatosPantalon());
            sb.AppendLine($"Tiene cordon: {this.tieneCordon}");
            return sb.ToString();
        }
    }
}
