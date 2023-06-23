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
    public partial class FormPartida : Form
    {
        private ConexionDB conexionDB;
        private SqlConnection connection;
        private SqlDataAdapter adapter;
        private DataTable dataTable;

        public FormPartida()
        {
            InitializeComponent();
        }

        public void cargarDatos()
        {
            conexionDB = new ConexionDB();
            using (connection = conexionDB.getConexion())
            {
                connection.Open();
                string query = "select * from Partidas";
                adapter = new SqlDataAdapter(query, connection);
                dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridViewPartida.DataSource = dataTable;
                connection.Close();
            }
        }

        private void FormPartida_Load(object sender, EventArgs e)
        {
            cargarDatos();
        }
    }
}
