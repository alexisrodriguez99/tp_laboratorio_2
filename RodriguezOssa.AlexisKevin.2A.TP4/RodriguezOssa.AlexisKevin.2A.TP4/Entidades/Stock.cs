using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;
namespace Entidades
{

    /// <summary>
    /// Delegado que almacena metodos que quiero que ejecute mi evento(Implemento la clase 24: Eventos)
    /// </summary>
    /// <param name="sender">Un objeto</param>
    /// <param name="e"></param>
    public delegate void ImprimirTicketDelegado(object sender, EventArgs e);
    public class Stock
    {
        /// <summary>
        /// Evento que voy a manejar  (Implemento la clase 24: Eventos)
        /// </summary>
        public event ImprimirTicketDelegado EventoTxt;
        List<Pantalon> patalon;
        int cantidad;
        /// <summary>
        /// Contructor de instancia 
        /// </summary>
        public Stock()
        {
            this.patalon = new List<Pantalon>();
        }
        /// <summary>
        /// Consturctor parametrisado 
        /// </summary>
        /// <param name="cantidad">La cantidad maxima</param>
        public Stock(int cantidad) : this()
        {
            this.cantidad = cantidad;
        }
        /// <summary>
        /// Me instancia un Stock con la capacidad ingresada por parametro 
        /// </summary>
        /// <param name="capacidad">la pacidad que va a tener el stock</param>
        public static implicit operator Stock(int capacidad)
        {
            return new Stock(capacidad);
        }
        /// <summary>
        /// Agregar un tipo pantalon al la lista de pantalones
        /// </summary>
        /// <param name="s">El Stock que contiene la lista a la que se desea agrgar</param>
        /// <param name="p">El pantalon que se quiere agregar</param>
        /// <returns>Retorna el Stock pasamo como parametro</returns>
        public static Stock operator +(Stock s, Pantalon p)
        {
            if (s.cantidad > s.patalon.Count)
            {
                s.patalon.Add(p);
            }
            else
            {
                throw new CapacidadMaximaExcepcion();
            }
            return s;
        }
        /// <summary>
        /// Elimina un tipo de pantalon de la lista de pantalones. Es donde se utiliza el evento "EventoTxt"(clase 24: eventos) donde llama al manejador del evento.
        /// </summary>
        /// <param name="s">El Stock que contiene la lista de pantalones a la cual se desea eliminar</param>
        /// <param name="id">El id del pantalon que se desea eliminar</param>
        /// <returns>Retorna el Stock</returns>
        public static Stock operator -(Stock s, int id)
        {
            try
            {
                foreach (Pantalon aux in s.patalon)
                {
                    if (aux.Id == id)
                    {
                        s.EventoTxt(aux, new EventArgs());
                        s.patalon.Remove(aux);
                        break;
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("error al eliminar");
            }
            return s;
        }
    }
}
