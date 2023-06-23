using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Asignacion_de_Activos_Fijos
{
    public partial class FormAgregarEmpleado : Form
    {

        private ConexionDB conexionDB;
        private SqlConnection connection;
        private FormEmpleados formEmpleados;

        public FormAgregarEmpleado()
        {
            InitializeComponent();
            conexionDB = new ConexionDB();
        }

        //este codigo tendra la funcionalidad de arrastrar el formulario
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                string emp_no = txtEmpleadoNumero.Text;
                string ci = txtCi.Text;
                string exp = txtExpedido.Text;
                string nombre = txtNombre.Text;
                string cargo = txtCargo.Text;
                string oficina = txtOficina.Text;
                string dir_ofi = txtDireccionOficina.Text;
                string unidad = txtUnidad.Text;
                string area_trab = txtAreaTrabajo.Text;
                string celular = txtCelular.Text;
                string profesion = txtProfesion.Text;
                string dpto = txtDepartamento.Text;
                string usuario = txtUsuario.Text;

                string query = "INSERT INTO Empleados (EMP_NO, CI, EXP, NOMBRE, CARGO, OFICINA, DIR_OFI, UNIDAD, " +
                    "AREA_TRAB, CELULAR, PROFESION, DPTO, USUARIO) VALUES (@EmpNo, @Ci, @Exp, @Nombre, @Cargo, " +
                    "@Oficina, @DirOfi, @Unidad, @AreaTrab, @Celular, @Profesion, @Dpto, @Usuario)";

                using (connection = conexionDB.getConexion())
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@EmpNo", emp_no);
                    command.Parameters.AddWithValue("@Ci", ci);
                    command.Parameters.AddWithValue("@Exp", exp);
                    command.Parameters.AddWithValue("@Nombre", nombre);
                    command.Parameters.AddWithValue("@Cargo", cargo);
                    command.Parameters.AddWithValue("@Oficina", oficina);
                    command.Parameters.AddWithValue("@DirOfi", dir_ofi);
                    command.Parameters.AddWithValue("@Unidad", unidad);
                    command.Parameters.AddWithValue("@AreaTrab", area_trab);
                    command.Parameters.AddWithValue("@Celular", celular);
                    command.Parameters.AddWithValue("@Profesion", profesion);
                    command.Parameters.AddWithValue("@Dpto", dpto);
                    command.Parameters.AddWithValue("@Usuario", usuario);

                    command.ExecuteNonQuery();
                }

                MessageBox.Show("El registro de empleado se realizó correctamente");

                limpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar empleado: " + ex.Message);
            }
        }

        private void limpiarCampos()
        {
            txtEmpleadoNumero.Text = "";
            txtCi.Text = "";
            txtExpedido.Text = "";
            txtNombre.Text = "";
            txtCargo.Text = "";
            txtOficina.Text = "";
            txtDireccionOficina.Text = "";
            txtUnidad.Text = "";
            txtAreaTrabajo.Text = "";
            txtCelular.Text = "";
            txtProfesion.Text = "";
            txtDepartamento.Text = "";
            txtUsuario.Text = "";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            formEmpleados = new FormEmpleados();
            formEmpleados.cargarDatos();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
