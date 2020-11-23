namespace FormInventario
{
    partial class ABMProducto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_producto = new System.Windows.Forms.Label();
            this.label_modelo = new System.Windows.Forms.Label();
            this.textBox_modelo = new System.Windows.Forms.TextBox();
            this.label_talle = new System.Windows.Forms.Label();
            this.label_precio = new System.Windows.Forms.Label();
            this.textBox_precio = new System.Windows.Forms.TextBox();
            this.comboBox_producto = new System.Windows.Forms.ComboBox();
            this.comboBox_talle = new System.Windows.Forms.ComboBox();
            this.button_aceptar = new System.Windows.Forms.Button();
            this.button_cancelar = new System.Windows.Forms.Button();
            this.comboBox_cordon = new System.Windows.Forms.ComboBox();
            this.comboBox_tachas = new System.Windows.Forms.ComboBox();
            this.label_cordon = new System.Windows.Forms.Label();
            this.label_tachas = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_producto
            // 
            this.label_producto.AutoSize = true;
            this.label_producto.Location = new System.Drawing.Point(55, 20);
            this.label_producto.Name = "label_producto";
            this.label_producto.Size = new System.Drawing.Size(65, 17);
            this.label_producto.TabIndex = 1;
            this.label_producto.Text = "Producto";
            // 
            // label_modelo
            // 
            this.label_modelo.AutoSize = true;
            this.label_modelo.Location = new System.Drawing.Point(55, 166);
            this.label_modelo.Name = "label_modelo";
            this.label_modelo.Size = new System.Drawing.Size(54, 17);
            this.label_modelo.TabIndex = 3;
            this.label_modelo.Text = "Modelo";
            // 
            // textBox_modelo
            // 
            this.textBox_modelo.Location = new System.Drawing.Point(58, 186);
            this.textBox_modelo.Name = "textBox_modelo";
            this.textBox_modelo.Size = new System.Drawing.Size(186, 22);
            this.textBox_modelo.TabIndex = 2;
            // 
            // label_talle
            // 
            this.label_talle.AutoSize = true;
            this.label_talle.Location = new System.Drawing.Point(55, 229);
            this.label_talle.Name = "label_talle";
            this.label_talle.Size = new System.Drawing.Size(39, 17);
            this.label_talle.TabIndex = 5;
            this.label_talle.Text = "Talle";
            // 
            // label_precio
            // 
            this.label_precio.AutoSize = true;
            this.label_precio.Location = new System.Drawing.Point(55, 296);
            this.label_precio.Name = "label_precio";
            this.label_precio.Size = new System.Drawing.Size(48, 17);
            this.label_precio.TabIndex = 7;
            this.label_precio.Text = "Precio";
            // 
            // textBox_precio
            // 
            this.textBox_precio.Location = new System.Drawing.Point(58, 316);
            this.textBox_precio.Name = "textBox_precio";
            this.textBox_precio.Size = new System.Drawing.Size(186, 22);
            this.textBox_precio.TabIndex = 6;
            // 
            // comboBox_producto
            // 
            this.comboBox_producto.FormattingEnabled = true;
            this.comboBox_producto.Location = new System.Drawing.Point(58, 40);
            this.comboBox_producto.Name = "comboBox_producto";
            this.comboBox_producto.Size = new System.Drawing.Size(186, 24);
            this.comboBox_producto.TabIndex = 8;
            this.comboBox_producto.SelectedIndexChanged += new System.EventHandler(this.comboBox_producto_SelectedIndexChanged);
            // 
            // comboBox_talle
            // 
            this.comboBox_talle.FormattingEnabled = true;
            this.comboBox_talle.Location = new System.Drawing.Point(58, 249);
            this.comboBox_talle.Name = "comboBox_talle";
            this.comboBox_talle.Size = new System.Drawing.Size(186, 24);
            this.comboBox_talle.TabIndex = 9;
            // 
            // button_aceptar
            // 
            this.button_aceptar.Location = new System.Drawing.Point(14, 385);
            this.button_aceptar.Name = "button_aceptar";
            this.button_aceptar.Size = new System.Drawing.Size(119, 37);
            this.button_aceptar.TabIndex = 10;
            this.button_aceptar.Text = "Aceptar";
            this.button_aceptar.UseVisualStyleBackColor = true;
            this.button_aceptar.Click += new System.EventHandler(this.button_aceptar_Click);
            // 
            // button_cancelar
            // 
            this.button_cancelar.Location = new System.Drawing.Point(174, 385);
            this.button_cancelar.Name = "button_cancelar";
            this.button_cancelar.Size = new System.Drawing.Size(122, 37);
            this.button_cancelar.TabIndex = 11;
            this.button_cancelar.Text = "Cancelar";
            this.button_cancelar.UseVisualStyleBackColor = true;
            this.button_cancelar.Click += new System.EventHandler(this.button_cancelar_Click);
            // 
            // comboBox_cordon
            // 
            this.comboBox_cordon.FormattingEnabled = true;
            this.comboBox_cordon.Location = new System.Drawing.Point(180, 100);
            this.comboBox_cordon.Name = "comboBox_cordon";
            this.comboBox_cordon.Size = new System.Drawing.Size(64, 24);
            this.comboBox_cordon.TabIndex = 12;
            // 
            // comboBox_tachas
            // 
            this.comboBox_tachas.FormattingEnabled = true;
            this.comboBox_tachas.Location = new System.Drawing.Point(180, 70);
            this.comboBox_tachas.Name = "comboBox_tachas";
            this.comboBox_tachas.Size = new System.Drawing.Size(64, 24);
            this.comboBox_tachas.TabIndex = 13;
            // 
            // label_cordon
            // 
            this.label_cordon.AutoSize = true;
            this.label_cordon.Location = new System.Drawing.Point(55, 73);
            this.label_cordon.Name = "label_cordon";
            this.label_cordon.Size = new System.Drawing.Size(79, 17);
            this.label_cordon.TabIndex = 14;
            this.label_cordon.Text = "Con tachas";
            // 
            // label_tachas
            // 
            this.label_tachas.AutoSize = true;
            this.label_tachas.Location = new System.Drawing.Point(55, 107);
            this.label_tachas.Name = "label_tachas";
            this.label_tachas.Size = new System.Drawing.Size(81, 17);
            this.label_tachas.TabIndex = 15;
            this.label_tachas.Text = "Con cordon";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(250, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Solo para pantalon de niño";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(250, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 34);
            this.label2.TabIndex = 17;
            this.label2.Text = "Solo para pantalon \r\nde hombre";
            // 
            // ABMProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_tachas);
            this.Controls.Add(this.label_cordon);
            this.Controls.Add(this.comboBox_tachas);
            this.Controls.Add(this.comboBox_cordon);
            this.Controls.Add(this.button_cancelar);
            this.Controls.Add(this.button_aceptar);
            this.Controls.Add(this.comboBox_talle);
            this.Controls.Add(this.comboBox_producto);
            this.Controls.Add(this.label_precio);
            this.Controls.Add(this.textBox_precio);
            this.Controls.Add(this.label_talle);
            this.Controls.Add(this.label_modelo);
            this.Controls.Add(this.textBox_modelo);
            this.Controls.Add(this.label_producto);
            this.Name = "ABMProducto";
            this.Text = "ABMProducto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_producto;
        private System.Windows.Forms.Label label_modelo;
        private System.Windows.Forms.TextBox textBox_modelo;
        private System.Windows.Forms.Label label_talle;
        private System.Windows.Forms.Label label_precio;
        private System.Windows.Forms.TextBox textBox_precio;
        private System.Windows.Forms.ComboBox comboBox_producto;
        private System.Windows.Forms.ComboBox comboBox_talle;
        private System.Windows.Forms.Button button_aceptar;
        private System.Windows.Forms.Button button_cancelar;
        private System.Windows.Forms.ComboBox comboBox_cordon;
        private System.Windows.Forms.ComboBox comboBox_tachas;
        private System.Windows.Forms.Label label_cordon;
        private System.Windows.Forms.Label label_tachas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}