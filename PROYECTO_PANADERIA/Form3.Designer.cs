namespace PROYECTO_PANADERIA
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.INGRESAR_PRODUCTOS = new System.Windows.Forms.Button();
            this.MODIFICAR_INVENTARIO = new System.Windows.Forms.Button();
            this.ELIMINAR_PRODUCTO = new System.Windows.Forms.Button();
            this.INVENTARIO = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // INGRESAR_PRODUCTOS
            // 
            this.INGRESAR_PRODUCTOS.Location = new System.Drawing.Point(101, 55);
            this.INGRESAR_PRODUCTOS.Name = "INGRESAR_PRODUCTOS";
            this.INGRESAR_PRODUCTOS.Size = new System.Drawing.Size(148, 36);
            this.INGRESAR_PRODUCTOS.TabIndex = 1;
            this.INGRESAR_PRODUCTOS.Text = "INGRESAR";
            this.INGRESAR_PRODUCTOS.UseVisualStyleBackColor = true;
            this.INGRESAR_PRODUCTOS.Click += new System.EventHandler(this.INGRESAR_PRODUCTOS_Click);
            // 
            // MODIFICAR_INVENTARIO
            // 
            this.MODIFICAR_INVENTARIO.Location = new System.Drawing.Point(285, 55);
            this.MODIFICAR_INVENTARIO.Name = "MODIFICAR_INVENTARIO";
            this.MODIFICAR_INVENTARIO.Size = new System.Drawing.Size(148, 36);
            this.MODIFICAR_INVENTARIO.TabIndex = 21;
            this.MODIFICAR_INVENTARIO.Text = "MODIFICAR";
            this.MODIFICAR_INVENTARIO.UseVisualStyleBackColor = true;
            this.MODIFICAR_INVENTARIO.Click += new System.EventHandler(this.MODIFICAR_INVENTARIO_Click);
            // 
            // ELIMINAR_PRODUCTO
            // 
            this.ELIMINAR_PRODUCTO.Location = new System.Drawing.Point(470, 55);
            this.ELIMINAR_PRODUCTO.Name = "ELIMINAR_PRODUCTO";
            this.ELIMINAR_PRODUCTO.Size = new System.Drawing.Size(148, 36);
            this.ELIMINAR_PRODUCTO.TabIndex = 22;
            this.ELIMINAR_PRODUCTO.Text = "ELIMINAR";
            this.ELIMINAR_PRODUCTO.UseVisualStyleBackColor = true;
            this.ELIMINAR_PRODUCTO.Click += new System.EventHandler(this.ELIMINAR_PRODUCTO_Click);
            // 
            // INVENTARIO
            // 
            this.INVENTARIO.Location = new System.Drawing.Point(649, 55);
            this.INVENTARIO.Name = "INVENTARIO";
            this.INVENTARIO.Size = new System.Drawing.Size(148, 36);
            this.INVENTARIO.TabIndex = 23;
            this.INVENTARIO.Text = "INVENTARIO";
            this.INVENTARIO.UseVisualStyleBackColor = true;
            this.INVENTARIO.Click += new System.EventHandler(this.INVENTARIO_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(827, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 36);
            this.button1.TabIndex = 24;
            this.button1.Text = "SALIR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 106);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1046, 465);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(1070, 626);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.INVENTARIO);
            this.Controls.Add(this.ELIMINAR_PRODUCTO);
            this.Controls.Add(this.MODIFICAR_INVENTARIO);
            this.Controls.Add(this.INGRESAR_PRODUCTOS);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button INGRESAR_PRODUCTOS;
        private System.Windows.Forms.Button MODIFICAR_INVENTARIO;
        private System.Windows.Forms.Button ELIMINAR_PRODUCTO;
        private System.Windows.Forms.Button INVENTARIO;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}