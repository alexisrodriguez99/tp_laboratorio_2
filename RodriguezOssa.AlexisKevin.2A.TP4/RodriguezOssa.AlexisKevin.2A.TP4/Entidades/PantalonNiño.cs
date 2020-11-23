using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   public class PantalonNiño:Pantalon
    {
        public bool tieneTachas;
  
        /// <summary>
        /// Propiedad de lectura y escritura de tieneTachas
        /// </summary>
        public bool TieneTachas
        {
            get { return this.tieneTachas; }
            set { tieneTachas = value; }
        }
        /// <summary>
        /// sobrecarga del contructor de pantalonNiño, que instancia todos los datos pasados por parametro
        /// </summary>
        /// <param name="id">Id del patalon de niño</param>
        /// <param name="producto">El producto </param>
        /// <param name="modelo">El modelo del pantalon de niño</param>
        /// <param name="talle">El talle del pantalon de niño</param>
        /// <param name="precio">El precio del pantalon de niño</param>
        /// <param name="tieneTachas">Las tachas que puede tener o no</param>
        public PantalonNiño(int id,string producto, string modelo, int talle, float precio, bool tieneTachas) : base(id,producto, modelo, talle, precio)
        {
            this.tieneTachas = tieneTachas;
        }
        /// <summary>
        /// Sobre cargar del ToString, que le da formato a un patanlon de niño
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.DatosPantalon());
            sb.AppendLine($"Tiene cordon: {this.tieneTachas}");
            return sb.ToString();
        }
    }
}
