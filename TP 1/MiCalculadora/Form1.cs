using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;


namespace MiCalculadora
{
    
    public partial class Form1 : Form
    {
        /// <summary>
        /// Inicializa todos los elementos de mi form
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Al oprimir este boton se realiza el pasaje del resultado a binario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            if(this.lblResultado.Text!= "Valor invalido")
            {
                this.lblResultado.Text = Numero.DecimalBinario(this.lblResultado.Text);
            }
            else
            {
                MessageBox.Show("Operacion Invalida. Intente cambiando el resultado.");
            }
            
            
        }
        /// <summary>
        /// Al oprimir este boton se muestra el resultado de la operacion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOperar_Click(object sender, EventArgs e)
        {

            this.lblResultado.Text=Convert.ToString( Operar(this.txtNumero1.Text,this.txtNumero2.Text,this.cmbOperador.Text));


        }
        /// <summary>
        /// Realiza la operacion entre los numero ingresados
        /// </summary>
        /// <param name="numero1"></param>
        /// <param name="numero2"></param>
        /// <param name="operador"></param>
        /// <returns>Retorna el resultado de la operacion</returns>
        static double Operar(string numero1,string numero2,string operador)
        {
          
            Numero num1 = new Numero(numero1);
            
            Numero num2 = new Numero(numero2);
            
            return Calculadora.Operar(num1, num2, operador);
        }
        /// <summary>
        /// Al oprimir este boron resetea todos los valores ingresados y el resultado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {

            limpiar();
        }
        /// <summary>
        /// Borra todo valor ingresado y el resultado del mismo
        /// </summary>
        void limpiar()
        {
            this.txtNumero1.Text = "";
            this.txtNumero2.Text = "";
            this.cmbOperador.Text = "";
            this.lblResultado.Text = "";
        }
        /// <summary>
        /// Al oprimir este boton se realiza el pasaje del resultado a binario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
           // this.lblResultado.Text = Numero.BinarioDecimal(this.lblResultado.Text);

            if (this.lblResultado.Text != "Valor invalido")
            {
                this.lblResultado.Text = Numero.BinarioDecimal(this.lblResultado.Text);
            }
            else
            {
                MessageBox.Show("Operacion Invalida. Intente cambiando el resultado.");
            }
        }
        /// <summary>
        /// Al oprimir este boron cierra el programa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
                
            this.Close();
        }
        /// <summary>
        /// Al intentar salir del form se asegura que realmente quiere salir mismo, en caso afirmativo se cierra
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult respuesta;

            respuesta = MessageBox.Show("¿Esta seguro que desea salir?", "Aviso!", MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2);

            if (respuesta == DialogResult.Yes)
            {
                e.Cancel = false;
                
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void cmbOperador_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
