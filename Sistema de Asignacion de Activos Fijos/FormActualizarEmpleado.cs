using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Asignacion_de_Activos_Fijos
{
    public partial class FormActualizarEmpleado : Form
    {

        private ConexionDB conexionDB;
        private SqlConnection connection;

        public FormActualizarEmpleado()
        {
            InitializeComponent();
            conexionDB = new ConexionDB();
        }

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

                string query = "UPDATE Empleados SET CI=@Ci, EXP=@Exp, NOMBRE=@Nombre, CARGO=@Cargo, OFICINA=@Oficina, DIR_OFI=@DirOfi, UNIDAD=@Unidad, " +
                    "AREA_TRAB=@AreaTrab, CELULAR=@Celular, PROFESION=@Profesion, DPTO=@Dpto, USUARIO=@Usuario " +
                    "WHERE EMP_NO=@EmpNo";

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

                MessageBox.Show("La actualizacion de empleado se realizó correctamente");
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar empleado empleado: " + ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
