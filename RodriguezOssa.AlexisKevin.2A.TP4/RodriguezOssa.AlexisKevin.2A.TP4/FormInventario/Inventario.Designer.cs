namespace FormInventario
{
    partial class formInventario
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_agregar = new System.Windows.Forms.Button();
            this.button_vender = new System.Windows.Forms.Button();
            this.textBox_ticket = new System.Windows.Forms.TextBox();
            this.button_leerTxt = new System.Windows.Forms.Button();
            this.button_mostrar = new System.Windows.Forms.Button();
            this.button_parar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(12, 22);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(731, 136);
            this.dataGridView1.TabIndex = 0;
            // 
            // button_agregar
            // 
            this.button_agregar.Location = new System.Drawing.Point(12, 164);
            this.button_agregar.Name = "button_agregar";
            this.button_agregar.Size = new System.Drawing.Size(144, 45);
            this.button_agregar.TabIndex = 1;
            this.button_agregar.Text = "Agregar producto";
            this.button_agregar.UseVisualStyleBackColor = true;
            this.button_agregar.Click += new System.EventHandler(this.button_agregar_Click);
            // 
            // button_vender
            // 
            this.button_vender.Location = new System.Drawing.Point(174, 164);
            this.button_vender.Name = "button_vender";
            this.button_vender.Size = new System.Drawing.Size(151, 45);
            this.button_vender.TabIndex = 2;
            this.button_vender.Text = "Vender producto";
            this.button_vender.UseVisualStyleBackColor = true;
            this.button_vender.Click += new System.EventHandler(this.button_vender_Click);
            // 
            // textBox_ticket
            // 
            this.textBox_ticket.Location = new System.Drawing.Point(12, 235);
            this.textBox_ticket.Multiline = true;
            this.textBox_ticket.Name = "textBox_ticket";
            this.textBox_ticket.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_ticket.Size = new System.Drawing.Size(436, 147);
            this.textBox_ticket.TabIndex = 4;
            // 
            // button_leerTxt
            // 
            this.button_leerTxt.Location = new System.Drawing.Point(151, 388);
            this.button_leerTxt.Name = "button_leerTxt";
            this.button_leerTxt.Size = new System.Drawing.Size(114, 50);
            this.button_leerTxt.TabIndex = 6;
            this.button_leerTxt.Text = "Ver ticket";
            this.button_leerTxt.UseVisualStyleBackColor = true;
            this.button_leerTxt.Click += new System.EventHandler(this.button_leerTxt_Click);
            // 
            // button_mostrar
            // 
            this.button_mostrar.Location = new System.Drawing.Point(527, 208);
            this.button_mostrar.Name = "button_mostrar";
            this.button_mostrar.Size = new System.Drawing.Size(116, 42);
            this.button_mostrar.TabIndex = 7;
            this.button_mostrar.Text = "Mostrar productos(.jpg)";
            this.button_mostrar.UseVisualStyleBackColor = true;
            this.button_mostrar.Click += new System.EventHandler(this.button_mostrar_Click);
            // 
            // button_parar
            // 
            this.button_parar.Location = new System.Drawing.Point(675, 208);
            this.button_parar.Name = "button_parar";
            this.button_parar.Size = new System.Drawing.Size(113, 42);
            this.button_parar.TabIndex = 8;
            this.button_parar.Text = "Parar de mostrar";
            this.button_parar.UseVisualStyleBackColor = true;
            this.button_parar.Click += new System.EventHandler(this.button_parar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pictureBox1.Location = new System.Drawing.Point(489, 256);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(308, 190);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // formInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_parar);
            this.Controls.Add(this.button_mostrar);
            this.Controls.Add(this.button_leerTxt);
            this.Controls.Add(this.textBox_ticket);
            this.Controls.Add(this.button_vender);
            this.Controls.Add(this.button_agregar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "formInventario";
            this.Text = "RodriguezOssa.AlexisKevin.2A.TP4";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.formInventario_FormClosed);
            this.Load += new System.EventHandler(this.formInventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_agregar;
        private System.Windows.Forms.Button button_vender;
        private System.Windows.Forms.TextBox textBox_ticket;
        private System.Windows.Forms.Button button_leerTxt;
        private System.Windows.Forms.Button button_mostrar;
        private System.Windows.Forms.Button button_parar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

