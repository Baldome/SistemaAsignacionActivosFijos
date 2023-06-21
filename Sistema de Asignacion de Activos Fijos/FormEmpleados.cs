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
        private FormAsignacion formAsignacion;
        private ConexionDB conexionDB;
        private SqlConnection connection;
        private SqlDataAdapter adapter;
        private DataTable dataTable;

        public FormEmpleados()
        {
            InitializeComponent();
            conexionDB = new ConexionDB();
            connection = conexionDB.getConexion();
            formAsignacion = new FormAsignacion();
        }

        private void FormEmpleados_Load(object sender, EventArgs e)
        {
            cargarDatos();
        }

        public void cargarDatos()
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

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (dataGridViewEmpleados.SelectedRows.Count > 0)
            {
                formAsignacion.label13.Visible = true;
                formAsignacion.lblNumeroInventario.Visible = true;
                formAsignacion.btnMaximizar.Visible = true;
                formAsignacion.label15.Visible = true;
                formAsignacion.lblNumeroEmpleado.Visible = true;
                formAsignacion.lblNumeroEmpleado.Text = dataGridViewEmpleados.CurrentRow.Cells["EMP_NO"].Value.ToString();
                formAsignacion.txtNombre.Text = dataGridViewEmpleados.CurrentRow.Cells["NOMBRE"].Value.ToString();
                formAsignacion.txtCargoEmp.Text = dataGridViewEmpleados.CurrentRow.Cells["CARGO"].Value.ToString();
                formAsignacion.txtOficinaEmp.Text = dataGridViewEmpleados.CurrentRow.Cells["OFICINA"].Value.ToString();
                formAsignacion.txtUnidad.Text = dataGridViewEmpleados.CurrentRow.Cells["UNIDAD"].Value.ToString();
                formAsignacion.txtAreaTrabajo.Text = dataGridViewEmpleados.CurrentRow.Cells["AREA_TRAB"].Value.ToString();
                formAsignacion.txtProfesion.Text = dataGridViewEmpleados.CurrentRow.Cells["PROFESION"].Value.ToString();

                this.Close();
                formAsignacion.ShowDialog();
            }
            else
            {
                MessageBox.Show("Por favor seleccione una fila.");
            }
        }
    }
}
