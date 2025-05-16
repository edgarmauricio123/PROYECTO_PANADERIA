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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        string connectionString = "server=127.0.0.1;port=3306;user=root;password=panaderia123;database=pnaderiaedgar";
        static string conexion = "SERVER=127.0.0.1;PORT=3306; DATABASE=pnaderiaedgar; UID=root;PASSWORD=panaderia123;";
        MySqlConnection cn = new MySqlConnection(conexion);

        private void CargarRoles()
        {
            string query = "SELECT RolID, Nombre, Descripcion FROM roles";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    ROL.DataSource = dt;
                    ROL.DisplayMember = "Nombre";
                    ROL.ValueMember = "RolID";

                    // Mostrar descripción del rol seleccionado
                    ROL.SelectedIndexChanged += (s, e) =>
                    {
                        if (ROL.SelectedItem is DataRowView selectedRow)
                        {
                            DESCRIPCIONROL.Text = selectedRow["Descripcion"].ToString();
                        }
                    };

                    // Mostrar descripción del primer rol al cargar
                    if (ROL.Items.Count > 0 && ROL.SelectedItem is DataRowView firstRow)
                    {
                        DESCRIPCIONROL.Text = firstRow["Descripcion"].ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar roles: " + ex.Message);
                }
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            CargarRoles();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = USUARIOREGISTRO.Text.Trim();
            string password = CONTRASEÑA_REGISTRO.Text.Trim();
            string nombre = NOMBRE_REGISTRO.Text.Trim();
            string correo = CORREO.Text.Trim();
            int RolID = Convert.ToInt32(ROL.SelectedValue);

            if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(password) ||
                string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(correo))
            {
                MessageBox.Show("Por favor completa todos los campos.");
                return;
            }

            string checkQuery = "SELECT COUNT(*) FROM usuarios WHERE Usuario = @Usuario";
            string insertQuery = "INSERT INTO usuarios (Usuario, Password, Nombre, Correo, Activo, RolID) " +
                                 "VALUES (@Usuario, @Password, @Nombre, @Correo, 1, @RolID)";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (MySqlCommand checkCmd = new MySqlCommand(checkQuery, connection))
                    {
                        checkCmd.Parameters.AddWithValue("@Usuario", usuario);
                        long count = (long)checkCmd.ExecuteScalar();
                        if (count > 0)
                        {
                            MessageBox.Show("El nombre de usuario ya existe.");
                            return;
                        }
                    }

                    using (MySqlCommand insertCmd = new MySqlCommand(insertQuery, connection))
                    {
                        insertCmd.Parameters.AddWithValue("@Usuario", usuario);
                        insertCmd.Parameters.AddWithValue("@Password", password);
                        insertCmd.Parameters.AddWithValue("@Nombre", nombre);
                        insertCmd.Parameters.AddWithValue("@Correo", correo);
                        insertCmd.Parameters.AddWithValue("@RolID", RolID);

                        insertCmd.ExecuteNonQuery();
                        MessageBox.Show("Usuario registrado correctamente.");


                        // Verificar si Form1 ya está abierto
                        Form formExistente = Application.OpenForms.OfType<PROYECTO_PANADERIA.Form1>().FirstOrDefault();

                        if (formExistente != null)
                        {
                            formExistente.WindowState = FormWindowState.Normal;
                            formExistente.BringToFront();
                            this.Hide(); // Ocultar Form2
                        }
                        else
                        {
                            Form1 mostrar = new Form1();
                            mostrar.StartPosition = FormStartPosition.CenterScreen; // Mejor CenterScreen para formularios iniciales
                            this.Hide(); // Oculta el formulario actual mientras Form2 está activo
                            mostrar.ShowDialog(); // Modal
                            this.Show();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al registrar: " + ex.Message);
                }
            }
        }

        // Otros eventos vacíos (puedes eliminarlos si no los necesitas)
        private void label2_Click(object sender, EventArgs e) { }
        private void CORREO_TextChanged(object sender, EventArgs e) { }
        private void CONTRASEÑA_REGISTRO_TextChanged(object sender, EventArgs e) { }
        private void USUARIOREGISTRO_TextChanged(object sender, EventArgs e) { }
        private void NOMBRE_REGISTRO_TextChanged(object sender, EventArgs e) { }
        private void ROL_SelectedIndexChanged(object sender, EventArgs e) { }
        private void DESCRIPCIONROL_Click(object sender, EventArgs e) { }
    }
}
