namespace PROYECTO_PANADERIA
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.INGRESAR = new System.Windows.Forms.Button();
            this.USURARIO = new System.Windows.Forms.TextBox();
            this.CONTRASEÑA = new System.Windows.Forms.TextBox();
            this.REGISTRAR = new System.Windows.Forms.Button();
            this.mySqlConnection1 = new MySql.Data.MySqlClient.MySqlConnection();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.checkMostrar = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(476, 321);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "USUARIO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(450, 386);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "CONTRASEÑA";
            // 
            // INGRESAR
            // 
            this.INGRESAR.Location = new System.Drawing.Point(472, 484);
            this.INGRESAR.Name = "INGRESAR";
            this.INGRESAR.Size = new System.Drawing.Size(140, 38);
            this.INGRESAR.TabIndex = 3;
            this.INGRESAR.Text = "INGRESAR";
            this.INGRESAR.UseVisualStyleBackColor = true;
            this.INGRESAR.Click += new System.EventHandler(this.INGRESAR_Click);
            // 
            // USURARIO
            // 
            this.USURARIO.Location = new System.Drawing.Point(399, 349);
            this.USURARIO.Name = "USURARIO";
            this.USURARIO.Size = new System.Drawing.Size(256, 22);
            this.USURARIO.TabIndex = 5;
            this.USURARIO.TextChanged += new System.EventHandler(this.USURARIO_TextChanged);
            // 
            // CONTRASEÑA
            // 
            this.CONTRASEÑA.Location = new System.Drawing.Point(399, 414);
            this.CONTRASEÑA.Name = "CONTRASEÑA";
            this.CONTRASEÑA.Size = new System.Drawing.Size(256, 22);
            this.CONTRASEÑA.TabIndex = 6;
            this.CONTRASEÑA.TextChanged += new System.EventHandler(this.CONTRASEÑA_TextChanged);
            // 
            // REGISTRAR
            // 
            this.REGISTRAR.Location = new System.Drawing.Point(472, 536);
            this.REGISTRAR.Name = "REGISTRAR";
            this.REGISTRAR.Size = new System.Drawing.Size(140, 38);
            this.REGISTRAR.TabIndex = 7;
            this.REGISTRAR.Text = "REGISTRAR";
            this.REGISTRAR.UseVisualStyleBackColor = true;
            this.REGISTRAR.Click += new System.EventHandler(this.REGISTRAR_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(455, 188);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 123);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(234, -178);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(580, 363);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.UseWaitCursor = true;
            // 
            // checkMostrar
            // 
            this.checkMostrar.AutoSize = true;
            this.checkMostrar.Location = new System.Drawing.Point(399, 442);
            this.checkMostrar.Name = "checkMostrar";
            this.checkMostrar.Size = new System.Drawing.Size(159, 36);
            this.checkMostrar.TabIndex = 10;
            this.checkMostrar.Text = "     Mostrar contraseña\n\n";
            this.checkMostrar.UseVisualStyleBackColor = true;
            this.checkMostrar.CheckedChanged += new System.EventHandler(this.checkMostrar_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(1070, 626);
            this.Controls.Add(this.checkMostrar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.REGISTRAR);
            this.Controls.Add(this.CONTRASEÑA);
            this.Controls.Add(this.USURARIO);
            this.Controls.Add(this.INGRESAR);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox USURARIO;
        private System.Windows.Forms.TextBox CONTRASEÑA;
        private System.Windows.Forms.Button REGISTRAR;
        private System.Windows.Forms.Button INGRESAR;
        private MySql.Data.MySqlClient.MySqlConnection mySqlConnection1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.CheckBox checkMostrar;
    }
}

