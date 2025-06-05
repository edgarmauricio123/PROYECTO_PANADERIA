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

//private void categoria_SelectedIndexChanged(object sender, EventArgs e)
//{
//}

//private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
//private void panel1_Paint(object sender, PaintEventArgs e)
//{

//}
//private void label2_Click(object sender, EventArgs e) { }
//private void label3_Click(object sender, EventArgs e) { }

using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static PROYECTO_PANADERIA.Form1;

namespace PROYECTO_PANADERIA
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        string connectionString = "server=127.0.0.1;port=3306;user=root;password=panaderia123;database=pnaderiaedgar";

        private void Form4_Load(object sender, EventArgs e)
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

        //private void CargarCategorias()
        //{

        //    string query = "SELECT CategoriaID, Nombre, Descripcion FROM categorias";

        //    using (MySqlConnection cn = new MySqlConnection(connectionString))
        //    {
        //        try
        //        {
        //            cn.Open();
        //            MySqlDataAdapter da = new MySqlDataAdapter(query, cn);
        //            DataTable dt = new DataTable();
        //            da.Fill(dt);

        //            MessageBox.Show("Categorías encontradas: " + dt.Rows.Count); // ✅ Diagnóstico

        //            if (dt.Rows.Count == 0)
        //            {
        //                MessageBox.Show("No hay categorías registradas.");
        //                comboCategoria.DataSource = null;
        //                return;
        //            }

        //            comboCategoria.DataSource = dt;
        //            comboCategoria.DisplayMember = "Nombre";
        //            comboCategoria.ValueMember = "CategoriaID";

        //            // Descripción automática al cambiar
        //            comboCategoria.SelectedIndexChanged += (s, e) =>
        //            {
        //                if (comboCategoria.SelectedItem is DataRowView row)
        //                {
        //                    DESCRIPCIONCATEGORIA.Text = row["Descripcion"].ToString();
        //                }
        //            };

        //            // Mostrar descripción inicial
        //            if (comboCategoria.SelectedItem is DataRowView firstRow)
        //            {
        //                DESCRIPCIONCATEGORIA.Text = firstRow["Descripcion"].ToString();
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show("Error al cargar categorías:\n" + ex.Message);
        //        }
        //    }

        //}
        public static class Session
        {
            public static string UsuarioActual;
        }

        private void CargarCategorias()
        {
            string query = "SELECT CategoriaID, Nombre, Descripcion FROM categorias";
            //SELECT `CategoriaID`, `Nombre`, `Descripcion` FROM `categorias`

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

                    // Mostrar descripción del rol seleccionado
                    comboCategoria.SelectedIndexChanged += (s, e) =>
                    {
                        if (comboCategoria.SelectedItem is DataRowView selectedRow)
                        {
                            DESCRIPCIONCATEGORIA.Text = selectedRow["Descripcion"].ToString();
                        }
                    };

                    // Mostrar descripción del primer rol al cargar
                    if (comboCategoria.Items.Count > 0 && comboCategoria.SelectedItem is DataRowView firstRow)
                    {
                        DESCRIPCIONCATEGORIA.Text = firstRow["Descripcion"].ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar roles: " + ex.Message);
                }
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection cn = new MySqlConnection(connectionString))
                {
                    cn.Open(); // 🔴 ABRIR la conexión antes de cualquier comando

                    // Establecer usuario de sesión
                    using (MySqlCommand setCmd = new MySqlCommand("SET @usuario_sistema = @usuario", cn))
                    {
                        setCmd.Parameters.AddWithValue("@usuario", Session.UsuarioActual);
                        setCmd.ExecuteNonQuery();
                    }

                    // INSERTAR el producto
                    string insertQuery = @"INSERT INTO productos (Nombre, CategoriaID, Precio, Stock) 
                               VALUES (@Nombre, @CategoriaID, @Precio, @Stock)";
                    using (MySqlCommand cmd = new MySqlCommand(insertQuery, cn))
                    {
                        cmd.Parameters.AddWithValue("@Nombre", NOMBRE.Text.Trim());
                        cmd.Parameters.AddWithValue("@CategoriaID", comboCategoria.SelectedValue);
                        cmd.Parameters.AddWithValue("@Precio", Convert.ToDecimal(PRECIO.Text));
                        cmd.Parameters.AddWithValue("@Stock", Convert.ToInt32(STOCK.Text));

                        cmd.ExecuteNonQuery();
                    }

                    cn.Close(); // (Opcional, el using lo hace automáticamente)
                }

                MessageBox.Show("Producto registrado correctamente.");
                dataGridView1.DataSource = LlenarGrid();

                // Limpiar campos
                NOMBRE.Clear();
                STOCK.Clear();
                PRECIO.Clear();
                comboCategoria.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar producto: " + ex.Message);
            }

        }



        private void button2_Click(object sender, EventArgs e)
        {
            Form3 mostrar = new Form3();
            mostrar.StartPosition = FormStartPosition.CenterScreen;
            mostrar.Show();  // Mostrar de forma normal
            this.Close();    // Cierra el formulario actual
        }

        // Eventos vacíos
        private void NOMBRE_TextChanged(object sender, EventArgs e) { }
        private void STOCK_TextChanged(object sender, EventArgs e) { }
        private void PRECIO_TextChanged(object sender, EventArgs e) { }
        private void DESCRIPCIONCATEGORIA_Click(object sender, EventArgs e) { }
      

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }

        private void comboCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
