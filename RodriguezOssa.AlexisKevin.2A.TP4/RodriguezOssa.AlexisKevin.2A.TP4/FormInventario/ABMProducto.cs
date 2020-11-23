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
namespace FormInventario
{

    public partial class ABMProducto : Form
    {
        Pantalon pantalon;
        int id;

        PantalonHombre ph;
        PantalonNiño pñ;

        /// <summary>
        /// Propiedad de lectura de un pantalon
        /// </summary>
        public Pantalon ProductoDelFormulario
        {
            get { return pantalon; }
        }
        /// <summary>
        /// Propiedad de lectura de un pantalon de hombre
        /// </summary>
        public PantalonHombre pantalonHombre
        {
            get { return ph; }
        }
        /// <summary>
        /// Propiedad de lectura de un pantalon de niño
        /// </summary>
        public PantalonNiño PantalonNiño
        {
            get { return pñ; }
        }
        /// <summary>
        /// Inicializa todos los elementos de mi form y configuro el form
        /// </summary>
        public ABMProducto()
        {
            InitializeComponent();
            ConfigurarComboBox_producto();
            comboBox_talle.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_cordon.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_tachas.DropDownStyle = ComboBoxStyle.DropDownList;

        }
        /// <summary>
        /// Constructor parametrizado del ABMProducto
        /// </summary>
        /// <param name="id">el id pasado como parametro</param>
        public ABMProducto(int id) : this()
        {
            this.id = id;
        }
        /// <summary>
        /// Configura el form dependiendo del producto que elija
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox_producto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_producto.SelectedItem.ToString() != null)
            {
                comboBox_talle.Items.Clear();
                comboBox_talle.DropDownStyle = ComboBoxStyle.DropDown;
                comboBox_cordon.DropDownStyle = ComboBoxStyle.DropDownList;
                comboBox_tachas.DropDownStyle = ComboBoxStyle.DropDownList;
                switch (comboBox_producto.SelectedItem.ToString())
                {
                    case "Pantalon(hombre)":
                        {
                            comboBox_cordon.DropDownStyle = ComboBoxStyle.DropDown;

                            comboBox_talle.Items.Add("36");
                            comboBox_talle.Items.Add("38");
                            comboBox_talle.Items.Add("40");
                            comboBox_talle.Items.Add("42");
                            comboBox_talle.Items.Add("44");
                            comboBox_talle.Items.Add("46");
                            comboBox_talle.Items.Add("48");

                            comboBox_cordon.Items.Add("true");
                            comboBox_cordon.Items.Add("false");
                            break;
                        }
                    case "Pantalon(niño)":
                        {
                            comboBox_tachas.DropDownStyle = ComboBoxStyle.DropDown;

                            comboBox_talle.Items.Add("4");
                            comboBox_talle.Items.Add("6");
                            comboBox_talle.Items.Add("8");
                            comboBox_talle.Items.Add("10");
                            comboBox_talle.Items.Add("12");
                            comboBox_talle.Items.Add("14");
                            comboBox_talle.Items.Add("16");

                            comboBox_tachas.Items.Add("true");
                            comboBox_tachas.Items.Add("false");
                            break;
                        }
                }
            }
            else
            {
                comboBox_talle.DropDownStyle = ComboBoxStyle.DropDownList;
            }
        }
        /// <summary>
        /// Configura el ComboBox_producto
        /// </summary>
        public void ConfigurarComboBox_producto()
        {
            comboBox_producto.Items.Add("Pantalon(hombre)");
            comboBox_producto.Items.Add("Pantalon(niño)");
        }
        /// <summary>
        /// Pregunta si se desea guardar los cambios a la hora de tocar el boton "aceptar"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_aceptar_Click(object sender, EventArgs e)
        {
            if (this.comboBox_producto.Text != null && this.textBox_modelo.Text != null && this.comboBox_talle.Text != null && this.textBox_precio.Text != null && (this.comboBox_tachas.Text != null || this.comboBox_cordon.Text != null))
            {
                MessageBoxButtons botones = MessageBoxButtons.YesNo;
                DialogResult respuesta = MessageBox.Show("Los cambios relizasdos se guardaran de forma permanente\n ¿Desea guardar?", "Advertencia", botones, MessageBoxIcon.Exclamation);
                if (respuesta == DialogResult.Yes)
                {
                    try
                    {
                        switch (this.comboBox_producto.SelectedItem.ToString())
                        {
                            case "Pantalon(niño)":
                                {
                                    this.pñ = new PantalonNiño(this.id + 1, this.comboBox_producto.Text, this.textBox_modelo.Text, int.Parse(this.comboBox_talle.Text), float.Parse(this.textBox_precio.Text), bool.Parse(comboBox_tachas.Text));
                                    this.pantalon = new PantalonNiño(0, this.comboBox_producto.Text, this.textBox_modelo.Text, int.Parse(this.comboBox_talle.Text), float.Parse(this.textBox_precio.Text), bool.Parse(comboBox_tachas.Text));

                                    break;
                                }
                            case "Pantalon(hombre)":
                                {
                                    this.ph = new PantalonHombre(this.id + 1, this.comboBox_producto.Text, this.textBox_modelo.Text, int.Parse(this.comboBox_talle.Text), float.Parse(this.textBox_precio.Text), bool.Parse(comboBox_cordon.Text));
                                    this.pantalon = new PantalonHombre(0, this.comboBox_producto.Text, this.textBox_modelo.Text, int.Parse(this.comboBox_talle.Text), float.Parse(this.textBox_precio.Text), bool.Parse(comboBox_cordon.Text));

                                    break;
                                }
                        }
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("Solo se permiten velores numericos en el 'precio'");
                    }


                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    this.DialogResult = DialogResult.Cancel;
                }

            }
            else
            {
                MessageBox.Show("Error, tiene que llenar todos los campo.");
            }

        }
        /// <summary>
        /// Cancela la creacion de un producto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }


    }
}
