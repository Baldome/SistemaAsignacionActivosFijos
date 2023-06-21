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
    public partial class FormEquiposAsignados : Form
    {
        private ConexionDB conexionDB;
        private SqlConnection connection;
        private FormDevolucion formDevolucion;

        public FormEquiposAsignados()
        {
            InitializeComponent();
            conexionDB = new ConexionDB();
            connection = conexionDB.getConexion();
            formDevolucion = new FormDevolucion();
        }

        private void FormEquiposAsignados_Load(object sender, EventArgs e)
        {
            cargarDatos();
        }

        public void cargarDatos()
        {
            using (connection)
            {
                connection.Open();

                string query = @"select ASIG_NO, Inventario.INV_NO, RUBRO, AUXILIAR, OFICINA_NO, ESTADO, RESPONSABLE, Inventario.CARGO, 
	                                Empleados.EMP_NO, NOMBRE, Empleados.CARGO, OFICINA, UNIDAD, AREA_TRAB, PROFESION 
                                FROM Asignacion
                                INNER JOIN Inventario ON Asignacion.INV_NO = Inventario.INV_NO
                                INNER JOIN Empleados ON Asignacion.EMP_NO = Empleados.EMP_NO";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Asigna el DataTable como origen de datos del DataGridView
                    dataGridViewListadoAsignacion.DataSource = dataTable;
                }
                connection.Close();
            }

        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (dataGridViewListadoAsignacion.SelectedRows.Count == 1)
            {
                using (connection)
                {
                    connection.Open();
                    string asig_no = dataGridViewListadoAsignacion.CurrentRow.Cells["ASIG_NO"].Value.ToString();
                    string query = "DELETE FROM Asignacion WHERE ASIG_NO = @AsigNo";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@AsigNo", asig_no);

                    command.ExecuteNonQuery();
                    MessageBox.Show("La devolucion fue realizada correctamente");

                    this.Close();

                    formDevolucion.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Por favor seleccione una fila.");
            }
        }
    }
}
