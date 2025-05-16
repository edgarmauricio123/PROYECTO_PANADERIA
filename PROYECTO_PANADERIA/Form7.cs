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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        static string conexion = "SERVER=127.0.0.1;PORT=3306; DATABASE=pnaderiaedgar; UID=root;PASSWORD=panaderia123;";
        string connectionString = "server=127.0.0.1;port=3306;user=root;password=panaderia123;database=pnaderiaedgar";
        MySqlConnection cn = new MySqlConnection(conexion);
        public DataTable llenar_grid()
        {
            cn.Open();
            DataTable dt = new DataTable();
            String llenar = "select * from productos";
            MySqlCommand cmd = new MySqlCommand(llenar, cn);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            cn.Close();

            return dt;
        }
        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            dataGridView1.DataSource = llenar_grid();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 mostrar = new Form3();
            mostrar.StartPosition = FormStartPosition.CenterScreen; // Mejor CenterScreen para formularios iniciales
            this.Hide(); // Oculta el formulario actual mientras Form2 está activo
            mostrar.ShowDialog(); // Modal
            this.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
