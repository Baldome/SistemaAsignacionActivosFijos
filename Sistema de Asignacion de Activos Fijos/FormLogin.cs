using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Asignacion_de_Activos_Fijos
{
    public partial class FormLogin : Form
    {

        private string connectionString = "Data Source=MAXIMO;Initial Catalog=BDPROYECTO;Integrated Security=True";

        public FormLogin()
        {
            InitializeComponent();
        }

        //este codigo tendra la funcionalidad de arrastrar el formulario
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void panelLogin_MouseDown(object sender, MouseEventArgs e)
        {
            //permite arrastrar el formulario
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelLogo_MouseDown(object sender, MouseEventArgs e)
        {
            //permite arrastrar el formulario
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string password = txtPassword.Text;

            // Encriptar la contraseña ingresada
            string passwordEncriptada = EncriptarPassword(password);

            // Realizar la comprobación de inicio de sesión
            if (ValidarCredenciales(usuario, passwordEncriptada))
            {
                MessageBox.Show("Inicio de sesión exitoso");
            }
            else
            {
                MessageBox.Show("Credenciales inválidas");
            }
        }
        private string EncriptarPassword(string password)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // Convertir la contraseña en un arreglo de bytes
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));

                // Convertir los bytes en una cadena hexadecimal
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }

                return builder.ToString();
            }
        }
        private bool ValidarCredenciales(string usuario, string passwordEncriptada)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM Usuarios WHERE USUARIO = @Usuario AND PASSWORD = @Password";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Usuario", usuario);
                command.Parameters.AddWithValue("@Password", passwordEncriptada);

                connection.Open();
                int count = (int)command.ExecuteScalar();

                return count > 0;
            }
        }
    }
}
