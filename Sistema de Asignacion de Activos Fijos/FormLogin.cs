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

        ConexionDB conexionDB = new ConexionDB();

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

            string usuario = txtUsuario.Texts;
            string password = txtPassword.Texts;

            // Encriptar la contraseña ingresada
            //string passwordEncriptada = EncriptarPassword(password);

            //MessageBox.Show("passwordEncriptada: " + passwordEncriptada);

            // Realizar la comprobación de inicio de sesión
            if (ValidarCredenciales(usuario, password))
            {
                MessageBox.Show("Inicio de sesión exitoso");
                FormPrincipal formPrincipal = new FormPrincipal();
                this.Hide();
                formPrincipal.Show();
            }
            else
            {
                MessageBox.Show("Credenciales inválidas usuario y password no existe");
            }
        }

        private string EncriptarPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(password);
                byte[] hash = sha256.ComputeHash(bytes);
                return BitConverter.ToString(hash).Replace("-", "");
            }
        }
        private bool ValidarCredenciales(string usuario, string password)
        {
            using (SqlConnection connection = conexionDB.getConexion())
            {
                connection.Open();
                string query = "SELECT * FROM Usuarios WHERE USUARIO = @Usuario AND PASSWORD = @Password";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Usuario", usuario);
                command.Parameters.AddWithValue("@Password", password);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    return reader.Read(); // Devuelve true si hay filas coincidentes, de lo contrario, devuelve false
                }
            }
        }
    }
}
