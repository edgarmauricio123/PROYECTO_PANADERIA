namespace PROYECTO_PANADERIA
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.USURARIO_REGISTRO = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NOMBRE_REGISTRO = new System.Windows.Forms.TextBox();
            this.USUARIOREGISTRO = new System.Windows.Forms.TextBox();
            this.CONTRASEÑA_REGISTRO = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.CORREO = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ROL = new System.Windows.Forms.ComboBox();
            this.DESCRIPCIONROL = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(327, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "NOMBRE";
            // 
            // USURARIO_REGISTRO
            // 
            this.USURARIO_REGISTRO.AutoSize = true;
            this.USURARIO_REGISTRO.Location = new System.Drawing.Point(327, 151);
            this.USURARIO_REGISTRO.Name = "USURARIO_REGISTRO";
            this.USURARIO_REGISTRO.Size = new System.Drawing.Size(68, 16);
            this.USURARIO_REGISTRO.TabIndex = 1;
            this.USURARIO_REGISTRO.Text = "USUARIO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(327, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "CONTRASEÑA";
            // 
            // NOMBRE_REGISTRO
            // 
            this.NOMBRE_REGISTRO.Location = new System.Drawing.Point(330, 98);
            this.NOMBRE_REGISTRO.Name = "NOMBRE_REGISTRO";
            this.NOMBRE_REGISTRO.Size = new System.Drawing.Size(394, 22);
            this.NOMBRE_REGISTRO.TabIndex = 3;
            this.NOMBRE_REGISTRO.TextChanged += new System.EventHandler(this.NOMBRE_REGISTRO_TextChanged);
            // 
            // USUARIOREGISTRO
            // 
            this.USUARIOREGISTRO.Location = new System.Drawing.Point(330, 181);
            this.USUARIOREGISTRO.Name = "USUARIOREGISTRO";
            this.USUARIOREGISTRO.Size = new System.Drawing.Size(394, 22);
            this.USUARIOREGISTRO.TabIndex = 4;
            this.USUARIOREGISTRO.TextChanged += new System.EventHandler(this.USUARIOREGISTRO_TextChanged);
            // 
            // CONTRASEÑA_REGISTRO
            // 
            this.CONTRASEÑA_REGISTRO.Location = new System.Drawing.Point(330, 256);
            this.CONTRASEÑA_REGISTRO.Name = "CONTRASEÑA_REGISTRO";
            this.CONTRASEÑA_REGISTRO.Size = new System.Drawing.Size(394, 22);
            this.CONTRASEÑA_REGISTRO.TabIndex = 5;
            this.CONTRASEÑA_REGISTRO.TextChanged += new System.EventHandler(this.CONTRASEÑA_REGISTRO_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(480, 465);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 38);
            this.button1.TabIndex = 6;
            this.button1.Text = "REGISTRARSE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CORREO
            // 
            this.CORREO.Location = new System.Drawing.Point(330, 319);
            this.CORREO.Name = "CORREO";
            this.CORREO.Size = new System.Drawing.Size(394, 22);
            this.CORREO.TabIndex = 7;
            this.CORREO.TextChanged += new System.EventHandler(this.CORREO_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(327, 290);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "CORREO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(328, 355);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "ROL";
            // 
            // ROL
            // 
            this.ROL.FormattingEnabled = true;
            this.ROL.Location = new System.Drawing.Point(330, 383);
            this.ROL.Name = "ROL";
            this.ROL.Size = new System.Drawing.Size(394, 24);
            this.ROL.TabIndex = 11;
            this.ROL.SelectedIndexChanged += new System.EventHandler(this.ROL_SelectedIndexChanged);
            // 
            // DESCRIPCIONROL
            // 
            this.DESCRIPCIONROL.AutoSize = true;
            this.DESCRIPCIONROL.Location = new System.Drawing.Point(327, 433);
            this.DESCRIPCIONROL.Name = "DESCRIPCIONROL";
            this.DESCRIPCIONROL.Size = new System.Drawing.Size(44, 16);
            this.DESCRIPCIONROL.TabIndex = 12;
            this.DESCRIPCIONROL.Text = "label5";
            this.DESCRIPCIONROL.Click += new System.EventHandler(this.DESCRIPCIONROL_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-6, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1079, 633);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(1070, 626);
            this.Controls.Add(this.DESCRIPCIONROL);
            this.Controls.Add(this.ROL);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CORREO);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CONTRASEÑA_REGISTRO);
            this.Controls.Add(this.USUARIOREGISTRO);
            this.Controls.Add(this.NOMBRE_REGISTRO);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.USURARIO_REGISTRO);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label USURARIO_REGISTRO;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NOMBRE_REGISTRO;
        private System.Windows.Forms.TextBox USUARIOREGISTRO;
        private System.Windows.Forms.TextBox CONTRASEÑA_REGISTRO;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox CORREO;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ROL;
        private System.Windows.Forms.Label DESCRIPCIONROL;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}