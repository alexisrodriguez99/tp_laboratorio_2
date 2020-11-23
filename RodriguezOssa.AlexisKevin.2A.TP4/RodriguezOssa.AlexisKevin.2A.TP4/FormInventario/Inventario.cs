using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Entidades;
using Archivo;
using System.IO;
using Excepciones;
using System.Threading;
namespace FormInventario
{
    public delegate void DelegadoThreadConParam(object param);
    public partial class formInventario : Form
    {
        SqlDataAdapter da;
        DataTable dt;
        SqlConnection cn;
        PantalonHombre ph;
        PantalonNiño pñ;
        Stock miStock = 6;
        Thread hilo;
        /// <summary>
        /// Inicializa todos los elementos de mi form
        /// </summary>
        public formInventario()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;
            this.ConfigurarDt();
            DelegadoThreadConParam delegado = new DelegadoThreadConParam(MostrarPantalon);

            
        }
        /// <summary>
        /// Instancio los elementos para que se cargue mi dataTable con los datos de la base de datos.Creo un hilo Clase(23)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void formInventario_Load(object sender, EventArgs e)
        {
            this.hilo = new Thread(this.MostrarPantalon);
        

         this.cn = new SqlConnection(Properties.Settings.Default.Tabla);
            this.da = new SqlDataAdapter();
            this.ComandoSelect();
            this.da.Fill(this.dt);
            this.dataGridView1.DataSource = this.dt;
            this.AgregarBaseDeDatosALista();

        }
        /// <summary>
        /// configura el comando select
        /// </summary>
        public void ComandoSelect()
        {         
            this.da.SelectCommand = new SqlCommand("SELECT * FROM producto", cn);       

        }
        /// <summary>
        /// Configura mi dataTable
        /// </summary>
        public void ConfigurarDt()
        {
            this.dt = new DataTable("producto");
            this.dt.Columns.Add("ID", typeof(int));
            this.dt.Columns.Add("Producto", typeof(string));
            this.dt.Columns.Add("Modelo", typeof(string));
            this.dt.Columns.Add("Talle", typeof(int));
            this.dt.Columns.Add("Precio", typeof(float));

            this.dt.PrimaryKey = new DataColumn[] { this.dt.Columns[0] };
            this.dt.Columns["id"].AutoIncrement = true;
            this.dt.Columns["id"].AutoIncrementSeed = 1;
            this.dt.Columns["id"].AutoIncrementStep = 1;
        }
        /// <summary>
        /// Agrega un producto en la dataTable y la agrega a mi lista pantalones. Implemento SQLCommand Clase 21 y 22 (SQL y base de datos)
        /// Llama al otro form "ABMProducto", para que le carguen los datos y los guarde donde corresponda
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_agregar_Click(object sender, EventArgs e)
        {

            string ultimoId;
            int id;
            try
            {
                ultimoId = dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[0].Value.ToString();
            }
            catch (Exception)
            {

                ultimoId = "0";
            }
            id = int.Parse(ultimoId);
            ABMProducto formulario = new ABMProducto(id);
            try
            {
                if (formulario.ShowDialog() == DialogResult.OK)
                {

                    if (formulario.ProductoDelFormulario.Producto == "Pantalon(hombre)")
                    {
                        this.ph = new PantalonHombre(formulario.pantalonHombre.Id, formulario.pantalonHombre.Producto, formulario.pantalonHombre.Modelo, formulario.pantalonHombre.Talle, formulario.pantalonHombre.Precio, formulario.pantalonHombre.tieneCordon);
                        this.miStock += ph;
                    }
                    else if (formulario.ProductoDelFormulario.Producto == "Pantalon(niño)")
                    {
                        this.pñ = new PantalonNiño(formulario.PantalonNiño.Id, formulario.PantalonNiño.Producto, formulario.PantalonNiño.Modelo, formulario.PantalonNiño.Talle, formulario.PantalonNiño.Precio, formulario.PantalonNiño.TieneTachas);
                        this.miStock += pñ;
                    }
                    this.da.InsertCommand = new SqlCommand("INSERT INTO producto (producto,modelo,talle,precio) VALUE (@producto,@modelo,@talle,@precio)", cn);
                    this.da.InsertCommand.Parameters.Add("@producto", SqlDbType.VarChar, 50, "producto");
                    this.da.InsertCommand.Parameters.Add("@modelo", SqlDbType.VarChar, 50, "modelo");
                    this.da.InsertCommand.Parameters.Add("@talle", SqlDbType.Int, 10, "talle");
                    this.da.InsertCommand.Parameters.Add("@precio", SqlDbType.Float, 10, "precio");

                    DataRow fila = this.dt.NewRow();
                    fila[1] = formulario.ProductoDelFormulario.Producto;
                    fila[2] = formulario.ProductoDelFormulario.Modelo;
                    fila[3] = formulario.ProductoDelFormulario.Talle;
                    fila[4] = formulario.ProductoDelFormulario.Precio;
                    this.dt.Rows.Add(fila);
                }

            }
            catch (Exception ecx)
            {

                MessageBox.Show("Error" + ecx.Message);
            }
        }
        
        /// <summary>
        /// Elimina un producto de la dataTable y de mi lista de pantalones. Implemento SQLCommand, Clase 21 y 22 (SQL y base de datos)
        /// Tambien le agrego un manejador de evento, a mi evento "EventoTxt". Clase 24(Eventos)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_vender_Click(object sender, EventArgs e)
        {
            int i = this.dataGridView1.CurrentRow.Index;
            try
            {
                MessageBoxButtons botones = MessageBoxButtons.YesNo;
                DialogResult respuesta = MessageBox.Show("¿Seguro que desea realizar esta compra?", "Advertencia", botones, MessageBoxIcon.Question);
                if (respuesta == DialogResult.Yes)
                {
                    this.miStock.EventoTxt += new ImprimirTicketDelegado(ImprimirTicket);
                    this.miStock -= int.Parse(this.dt.Rows[i][0].ToString());

                    this.da.DeleteCommand = new SqlCommand("DELETE FROM producto WHERE id=@id");
                    this.da.DeleteCommand.Parameters.Add("@id", SqlDbType.Int, 10, "id");
                    DataRow fila = this.dt.Rows[i];


                    fila.Delete();
                }
                else
                {
                    MessageBox.Show("Se cancelo la venta");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al vender el producto:",ex.Message);
            }
        }
        /// <summary>
        /// Genera un un archivo con una ruta especifica y un objeto pasado por pametro. Es en manejor del evento "EventoTxt"
        /// </summary>
        /// <param name="sender">El objeto que voy a guardar en el txt</param>
        /// <param name="e"></param>
        private void ImprimirTicket(object sender, EventArgs e)
        {
            //bool verificar ;
            Texto texto = new Texto();
            try
            {
                if (texto.Guardar(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\tickets.txt", sender.ToString()))
                {
                    MessageBox.Show("Se imprimio el ticket correctamente");
                }
            }
            catch (ArchivoExcepcion excepcion)
            {
                MessageBox.Show(excepcion.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al imprimir el ticket: " + ex.Message);

            }
        }
        /// <summary>
        /// Lee el archivo de una ruta en especifico y lo imprime en texbox_ticket
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_leerTxt_Click(object sender, EventArgs e)
        {
            string datosArchivo;
            Texto texto = new Texto();
            try
            {
                texto.Leer(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\tickets.txt", out datosArchivo);

                this.textBox_ticket.Text = datosArchivo;

            }
            catch (ArchivoExcepcion excepcion)
            {
                MessageBox.Show(excepcion.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer el ticket" + ex.Message);

            }

        }
        /// <summary>
        /// Muestras imagenes del producto por medio de pictureBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_mostrar_Click(object sender, EventArgs e)
        {
           // this.hilo = new Thread(this.MostrarPantalon);
            if (this.hilo.IsAlive)
            {
                MessageBox.Show("Ya se estan mostrando los productos");
            }
            else
            {
                this.hilo = new Thread(this.MostrarPantalon);
                this.hilo.Start();
            }
        }
        /// <summary>
        /// Es el metodo que permite que se vean las imagenes mediante el pictureBox
        /// </summary>
        /// <param name="param"></param>
        private void MostrarPantalon(object param)
        {
            
            if (this.pictureBox1.InvokeRequired)
            {
               
                int pantalon = 0;

                DelegadoThreadConParam delegado = new DelegadoThreadConParam(this.MostrarPantalon);

                object[] imagen = new object[3];

                imagen[0] = "pantalon1.png";
                imagen[1] = "pantalon2.jpg";
                imagen[2] = "pantalon3.jpg";


                do
                {
                    object[] parametro = new object[] { imagen[pantalon] };
                    switch (pantalon)
                    {
                        case 0:
                            {
                                pantalon++;
                                break;
                            }
                        case 1:
                            {
                                pantalon++;                             
                                break;
                            }
                        case 2:
                            {
                                pantalon = 0;                             
                                break;
                            }
                    }
                    this.Invoke(delegado, (object)parametro);

                    Thread.Sleep(3000);
                } while (true);


            }
            else
            {
                this.pictureBox1.ImageLocation = ((object[])param)[0].ToString();        
            }

        }
        /// <summary>
        /// Pone en blanco el pictureBox, frena el hilo que se encargaba de mostrar los productos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_parar_Click(object sender, EventArgs e)
        {
            if (this.hilo.IsAlive)
            {
                this.hilo.Abort();
                this.pictureBox1.Image.Dispose();

                this.pictureBox1.Image = null;
            }
            else
            {
                MessageBox.Show("Ya paro de mostrar");
            }
        }
        /// <summary>
        /// Al cerrar el proyecto cierra el hilo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void formInventario_FormClosed(object sender, FormClosedEventArgs e)
        {
           
            this.hilo.Abort();
        }
        /// <summary>
        /// Paso los datos de la base de datos a una lista de pantalones
        /// </summary>
        public void AgregarBaseDeDatosALista()
        {
            int talle;
            foreach(DataGridViewRow aux in dataGridView1.Rows)
            {
                talle = int.Parse(aux.Cells[3].Value.ToString());
                if(talle<18)
                {
                    PantalonNiño pñ = new PantalonNiño(int.Parse(aux.Cells[0].Value.ToString()), aux.Cells[1].Value.ToString(), aux.Cells[2].Value.ToString(), talle,float.Parse(aux.Cells[4].Value.ToString()), default);
                    this.miStock += pñ;
                }
                else
                {
                    PantalonHombre ph = new PantalonHombre(int.Parse(aux.Cells[0].Value.ToString()), aux.Cells[1].Value.ToString(), aux.Cells[2].Value.ToString(), talle, float.Parse(aux.Cells[4].Value.ToString()), default);
                    this.miStock += ph;
                }
            }
        }
    }
}
