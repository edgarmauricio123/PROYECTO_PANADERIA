using MySql.Data.MySqlClient;
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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        string connectionString = "server=127.0.0.1;port=3306;user=root;password=panaderia123;database=pnaderiaedgar";
        static string conexion = "SERVER=127.0.0.1;PORT=3306; DATABASE=pnaderiaedgar; UID=root;PASSWORD=panaderia123;";
        MySqlConnection cn = new MySqlConnection(conexion);
        private void Form6_Load(object sender, EventArgs e)
        {
            CargarCategorias();
            dataGridView1.DataSource = LlenarGrid();
        }

        private DataTable LlenarGrid()
        {
            DataTable dt = new DataTable();
            string query = @"
                SELECT p.ProductoID, p.Nombre, c.Nombre AS Categoria, 
                       p.Precio, p.Stock, p.FechaRegistro 
                FROM productos p 
                JOIN categorias c ON p.CategoriaID = c.CategoriaID";

            using (MySqlConnection cn = new MySqlConnection(connectionString))
            using (MySqlCommand cmd = new MySqlCommand(query, cn))
            using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
            {
                cn.Open();
                da.Fill(dt);
                cn.Close();
            }

            return dt;
        }

        private void CargarCategorias()
        {
            string query = "SELECT CategoriaID, Nombre, Descripcion FROM categorias";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    comboCategoria.DataSource = dt;
                    comboCategoria.DisplayMember = "Nombre";
                    comboCategoria.ValueMember = "CategoriaID";

                    comboCategoria.SelectedIndexChanged += (s, e) =>
                    {
                        if (comboCategoria.SelectedItem is DataRowView selectedRow)
                        {
                            DESCRIPCIONCATEGORIA.Text = selectedRow["Descripcion"].ToString();
                        }
                    };

                    if (comboCategoria.Items.Count > 0 && comboCategoria.SelectedItem is DataRowView firstRow)
                    {
                        DESCRIPCIONCATEGORIA.Text = firstRow["Descripcion"].ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar categorías: " + ex.Message);
                }
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                    txtProductoID.Text = row.Cells["ProductoID"].Value.ToString();
                    NOMBRE.Text = row.Cells["Nombre"].Value.ToString();
                    comboCategoria.Text = row.Cells["Categoria"].Value.ToString();
                    PRECIO.Text = row.Cells["Precio"].Value.ToString();
                    STOCK.Text = row.Cells["Stock"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al seleccionar producto: " + ex.Message);
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            Form3 mostrar = new Form3();
            mostrar.StartPosition = FormStartPosition.CenterScreen; // Mejor CenterScreen para formularios iniciales
            this.Hide(); // Oculta el formulario actual mientras Form2 está activo
            mostrar.ShowDialog(); // Modal
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Validación básica
            if (string.IsNullOrWhiteSpace(txtProductoID.Text) ||
                string.IsNullOrWhiteSpace(NOMBRE.Text) ||
                string.IsNullOrWhiteSpace(PRECIO.Text) ||
                string.IsNullOrWhiteSpace(STOCK.Text) ||
                comboCategoria.SelectedIndex == -1)
            {
                MessageBox.Show("Completa todos los campos antes de editar.");
                return;
            }

            using (MySqlConnection cn = new MySqlConnection(connectionString))
            {
                cn.Open();

                string actualizar = @"
            UPDATE productos 
            SET Nombre = @Nombre, Precio = @Precio, Stock = @Stock, CategoriaID = @CategoriaID 
            WHERE ProductoID = @ProductoID";

                MySqlCommand cmd = new MySqlCommand(actualizar, cn);
                cmd.Parameters.AddWithValue("@Nombre", NOMBRE.Text);
                cmd.Parameters.AddWithValue("@Precio", Convert.ToDecimal(PRECIO.Text));
                cmd.Parameters.AddWithValue("@Stock", Convert.ToInt32(STOCK.Text));
                cmd.Parameters.AddWithValue("@CategoriaID", comboCategoria.SelectedValue);
                cmd.Parameters.AddWithValue("@ProductoID", txtProductoID.Text);

                int resultado = cmd.ExecuteNonQuery();
                cn.Close();

                if (resultado > 0)
                {
                    MessageBox.Show("Producto actualizado correctamente.");

                    // Limpiar campos
                    txtProductoID.Clear();
                    NOMBRE.Clear();
                    STOCK.Clear();
                    PRECIO.Clear();
                    comboCategoria.SelectedIndex = -1;
                    //DESCRIPCIONCATEGORIA.Clear();
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar el producto.");
                }

                // Recargar grid
                dataGridView1.DataSource = LlenarGrid();
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void NOMBRE_TextChanged(object sender, EventArgs e)
        {

        }

        private void PRECIO_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtProductoID_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void STOCK_TextChanged(object sender, EventArgs e)
        {

        }

        private void DESCRIPCIONCATEGORIA_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {


            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                    // Asignar datos a los TextBox y ComboBox
                    txtProductoID.Text = row.Cells["ProductoID"].Value.ToString();
                    NOMBRE.Text = row.Cells["Nombre"].Value.ToString();
                    comboCategoria.Text = row.Cells["Categoria"].Value.ToString();
                    PRECIO.Text = row.Cells["Precio"].Value.ToString();
                    STOCK.Text = row.Cells["Stock"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al seleccionar producto: " + ex.Message);
            }
        }
    }
}
