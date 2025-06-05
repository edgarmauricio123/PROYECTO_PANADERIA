using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;
using System.Text;
using Org.BouncyCastle.Tls.Crypto;



namespace PROYECTO_PANADERIA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string connectionString = "server=127.0.0.1;port=3306;user=root;password=panaderia123;database=pnaderiaedgar";
        private string EncriptarSHA256(string texto)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(texto);
                byte[] hash = sha256.ComputeHash(bytes);
                StringBuilder sb = new StringBuilder();
                foreach (byte b in hash)
                {
                    sb.Append(b.ToString("x2")); // formato hexadecimal
                }
                return sb.ToString();
            }
        }
        public static class SesionUsuario
        {
            public static string NombreUsuario { get; set; }
        }

        public void Login()
        {
            string query = "SELECT * FROM usuarios WHERE Usuario = @Usuario AND Password = @Password AND Activo = 1";

            using (MySqlConnection databaseConnection = new MySqlConnection(connectionString))
            using (MySqlCommand command = new MySqlCommand(query, databaseConnection))
            {
                command.Parameters.AddWithValue("@Usuario", USURARIO.Text);
                command.Parameters.AddWithValue("@Password", CONTRASEÑA.Text);

                try
                {
                    databaseConnection.Open();

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            reader.Read();

                            // Guardar nombre de usuario en sesión
                            SesionUsuario.NombreUsuario = reader["Usuario"].ToString();

                            MessageBox.Show("Inicio de sesión exitoso.");
                            this.DialogResult = DialogResult.OK;
                            this.Close(); // Cierra el formulario actual (login)
                        }
                        else
                        {
                            MessageBox.Show("Usuario, contraseña incorrectos o cuenta inactiva.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error de conexión: " + ex.Message);
                }
            }
        }


        private void INGRESAR_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void REGISTRAR_Click(object sender, EventArgs e)
        {
            Form2 mostrar = new Form2();
            mostrar.StartPosition = FormStartPosition.CenterScreen; // Mejor CenterScreen para formularios iniciales
            this.Hide(); // Oculta el formulario actual mientras Form2 está activo
            mostrar.ShowDialog(); // Modal
            this.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void USURARIO_TextChanged(object sender, EventArgs e)
        {
        }

        private void CONTRASEÑA_TextChanged(object sender, EventArgs e)
        {
            CONTRASEÑA.UseSystemPasswordChar = true;


        }

        private void checkMostrar_CheckedChanged(object sender, EventArgs e)
        {

            if (checkMostrar.Checked)
            {
                // Mostrar texto en claro
                CONTRASEÑA.UseSystemPasswordChar = false;
            }
            else
            {
                // Ocultar con puntos/asteriscos
                CONTRASEÑA.UseSystemPasswordChar = true;
            }
        }
    }
}