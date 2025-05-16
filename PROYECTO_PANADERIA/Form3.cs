using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_PANADERIA
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void INGRESAR_PRODUCTOS_Click(object sender, EventArgs e)
        {
            Form4 mostrar = new Form4();
            mostrar.StartPosition = FormStartPosition.CenterScreen; // Mejor CenterScreen para formularios iniciales
            this.Hide(); // Oculta el formulario actual mientras Form2 está activo
            mostrar.ShowDialog(); // Modal
            this.Show();
        }

        private void MODIFICAR_INVENTARIO_Click(object sender, EventArgs e)
        {
            Form6 mostrar = new Form6();
            mostrar.StartPosition = FormStartPosition.CenterScreen; // Mejor CenterScreen para formularios iniciales
            this.Hide(); // Oculta el formulario actual mientras Form2 está activo
            mostrar.ShowDialog(); // Modal
            this.Show();
        }

        private void ELIMINAR_PRODUCTO_Click(object sender, EventArgs e)
        {
            Form5 mostrar = new Form5();
            mostrar.StartPosition = FormStartPosition.CenterScreen; // Mejor CenterScreen para formularios iniciales
            this.Hide(); // Oculta el formulario actual mientras Form2 está activo
            mostrar.ShowDialog(); // Modal
            this.Show();
        }

        private void INVENTARIO_Click(object sender, EventArgs e)
        {
            Form7 mostrar = new Form7();
            mostrar.StartPosition = FormStartPosition.CenterScreen; // Mejor CenterScreen para formularios iniciales
            this.Hide(); // Oculta el formulario actual mientras Form2 está activo
            mostrar.ShowDialog(); // Modal
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 mostrar = new Form1();
            mostrar.StartPosition = FormStartPosition.CenterScreen;
            mostrar.Show();  // Mostrar de forma normal
            this.Close();    // Cierra el formulario actual
        }
    }
}
