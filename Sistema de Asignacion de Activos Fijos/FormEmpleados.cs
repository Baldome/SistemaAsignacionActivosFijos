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
    public partial class FormEmpleados : Form
    {

        private ConexionDB conexionDB;
        private SqlConnection connection;
        private SqlDataAdapter adapter;
        private DataTable dataTable;

        public FormEmpleados()
        {
            InitializeComponent();
            conexionDB = new ConexionDB();
            connection = conexionDB.getConexion();
        }

        private void FormEmpleados_Load(object sender, EventArgs e)
        {
            cargarDatos();
        }

        private void cargarDatos()
        {
            string query = "SELECT * FROM Empleados";
            adapter = new SqlDataAdapter(query, connection);
            dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridViewEmpleados.DataSource = dataTable;
        }

        private void btnNuevoEmp_Click(object sender, EventArgs e)
        {
            //this.Hide();
            FormAgregarEmpleado formAgregarEmpleado = new FormAgregarEmpleado();
            formAgregarEmpleado.Show();
        }
    }
}
