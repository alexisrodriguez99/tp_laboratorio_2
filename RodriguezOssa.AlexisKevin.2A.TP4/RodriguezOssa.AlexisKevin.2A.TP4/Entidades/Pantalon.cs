using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Pantalon
    {
        int id;
        string producto;
        string modelo;
        int talle;
        float precio;
        /// <summary>
        /// Propiedad de lectura de id
        /// </summary>
        public int Id
        {
            get { return this.id; }
        }
        /// <summary>
        /// Propiedad de escritura y lectura de producto
        /// </summary>
        public string Producto
        {
            get { return this.producto; }
            set { this.producto = value; }
        }
        /// <summary>
        /// Propiedad de escritura y lectura de modelo
        /// </summary>
        public string Modelo
        {
            get { return this.modelo; }
            set { this.modelo = value; }
        }
        /// <summary>
        /// Propiedad de escritura y lectura de talle
        /// </summary>
        public int Talle
        {
            get { return this.talle; }
            set { this.talle = value; }
        }

        /// <summary>
        /// Propiedad de escritura y lectura de precio
        /// </summary>
        public float Precio
        {
            get { return this.precio; }
            set { this.precio = value; }
        }
        /// <summary>
        /// sobrecarga del contructor de pantalon, que instancia todos los datos pasados por parametro
        /// </summary>
        /// <param name="id">El id del pantalon</param>
        /// <param name="producto">El producto</param>
        /// <param name="modelo">El modelo del pantalon</param>
        /// <param name="talle">El talle del pantalon</param>
        /// <param name="precio">El precio del pantalon</param>
        public Pantalon(int id, string producto, string modelo, int talle, float precio)
        {
            this.id = id;
            this.Producto = producto;
            this.Modelo = modelo;
            this.Talle = talle;
            this.Precio = precio;
        }
        /// <summary>
        /// Metodo que le da formato a la informacion de un pantalon
        /// </summary>
        /// <returns></returns>
        protected virtual string DatosPantalon()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Producto: {this.Producto}");
            sb.AppendLine($"Modelo: {this.Modelo}");
            sb.AppendLine($"Talle: {this.Talle}");
            sb.AppendLine($"Precio: {this.Precio}");

            return sb.ToString();
        }
        /// <summary>
        /// Sobrecarga del metodo ToString, que hace publico el dato del pantalon
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.DatosPantalon();
        }
    }
}
