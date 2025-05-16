namespace PROYECTO_PANADERIA
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NOMBRE = new System.Windows.Forms.TextBox();
            this.STOCK = new System.Windows.Forms.TextBox();
            this.PRECIO = new System.Windows.Forms.TextBox();
            this.DESCRIPCIONCATEGORIA = new System.Windows.Forms.Label();
            this.comboCategoria = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(40, 435);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 38);
            this.button1.TabIndex = 52;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 16);
            this.label5.TabIndex = 49;
            this.label5.Text = "Precio";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(321, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 48;
            this.label4.Text = "Stock";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 47;
            this.label3.Text = "Nombre";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(321, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 46;
            this.label2.Text = "Categoria";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(611, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(456, 470);
            this.panel1.TabIndex = 55;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-1, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(453, 467);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // NOMBRE
            // 
            this.NOMBRE.Location = new System.Drawing.Point(25, 139);
            this.NOMBRE.Name = "NOMBRE";
            this.NOMBRE.Size = new System.Drawing.Size(280, 22);
            this.NOMBRE.TabIndex = 58;
            this.NOMBRE.TextChanged += new System.EventHandler(this.NOMBRE_TextChanged);
            // 
            // STOCK
            // 
            this.STOCK.Location = new System.Drawing.Point(325, 139);
            this.STOCK.Name = "STOCK";
            this.STOCK.Size = new System.Drawing.Size(280, 22);
            this.STOCK.TabIndex = 59;
            this.STOCK.TextChanged += new System.EventHandler(this.STOCK_TextChanged);
            // 
            // PRECIO
            // 
            this.PRECIO.Location = new System.Drawing.Point(25, 208);
            this.PRECIO.Name = "PRECIO";
            this.PRECIO.Size = new System.Drawing.Size(280, 22);
            this.PRECIO.TabIndex = 60;
            this.PRECIO.TextChanged += new System.EventHandler(this.PRECIO_TextChanged);
            // 
            // DESCRIPCIONCATEGORIA
            // 
            this.DESCRIPCIONCATEGORIA.AutoSize = true;
            this.DESCRIPCIONCATEGORIA.BackColor = System.Drawing.Color.Transparent;
            this.DESCRIPCIONCATEGORIA.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DESCRIPCIONCATEGORIA.Location = new System.Drawing.Point(322, 263);
            this.DESCRIPCIONCATEGORIA.Name = "DESCRIPCIONCATEGORIA";
            this.DESCRIPCIONCATEGORIA.Size = new System.Drawing.Size(50, 16);
            this.DESCRIPCIONCATEGORIA.TabIndex = 61;
            this.DESCRIPCIONCATEGORIA.Text = "label5";
            this.DESCRIPCIONCATEGORIA.Click += new System.EventHandler(this.DESCRIPCIONCATEGORIA_Click);
            // 
            // comboCategoria
            // 
            this.comboCategoria.FormattingEnabled = true;
            this.comboCategoria.Location = new System.Drawing.Point(325, 236);
            this.comboCategoria.Name = "comboCategoria";
            this.comboCategoria.Size = new System.Drawing.Size(280, 24);
            this.comboCategoria.TabIndex = 62;
            this.comboCategoria.SelectedIndexChanged += new System.EventHandler(this.comboCategoria_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-261, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1046, 465);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 63;
            this.pictureBox1.TabStop = false;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(1070, 626);
            this.Controls.Add(this.comboCategoria);
            this.Controls.Add(this.DESCRIPCIONCATEGORIA);
            this.Controls.Add(this.PRECIO);
            this.Controls.Add(this.STOCK);
            this.Controls.Add(this.NOMBRE);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox NOMBRE;
        private System.Windows.Forms.TextBox STOCK;
        private System.Windows.Forms.TextBox PRECIO;
        private System.Windows.Forms.Label DESCRIPCIONCATEGORIA;
        private System.Windows.Forms.ComboBox comboCategoria;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}