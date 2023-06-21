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
    public partial class FormLIstadoInventario : Form
    {
        private FormPrincipal formPrincipal;
        private FormAsignacion formAsignacion;
        private ConexionDB conexionDB;
        private SqlConnection connection;
        private SqlDataAdapter adapter;
        private DataTable dataTable;

        public FormLIstadoInventario()
        {
            InitializeComponent();
            conexionDB = new ConexionDB();
            connection = conexionDB.getConexion();
            formAsignacion = new FormAsignacion();
            formPrincipal = new FormPrincipal();
        }

        //este codigo tendra la funcionalidad de arrastrar el formulario
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
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

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            //permite arrastrar el formulario
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void FormLIstadoInventario_Load(object sender, EventArgs e)
        {
            cargarDatos();
        }

        private void cargarDatos()
        {
            string queryInv = "SELECT * FROM Inventario";
            string queryEmp = "SELECT * FROM Empleados";
            adapter = new SqlDataAdapter(queryInv, connection);
            dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridViewInventario.DataSource = dataTable;

            adapter = new SqlDataAdapter(queryEmp, connection);
            dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridViewListadoEmpleados.DataSource = dataTable;
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (dataGridViewInventario.SelectedRows.Count == 1 & dataGridViewListadoEmpleados.SelectedRows.Count == 1)
            {
                formAsignacion.label13.Visible = true;
                formAsignacion.lblNumeroInventario.Visible = true;
                formAsignacion.btnMaximizar.Visible = true;
                formAsignacion.btnCancelar.Visible = true;
                formAsignacion.lblNumeroInventario.Text = dataGridViewInventario.CurrentRow.Cells["INV_NO"].Value.ToString();
                formAsignacion.txtRubros.Text = dataGridViewInventario.CurrentRow.Cells["RUBRO"].Value.ToString();
                formAsignacion.txtAuxiliar.Text = dataGridViewInventario.CurrentRow.Cells["AUXILIAR"].Value.ToString();
                formAsignacion.txtOficina.Text = dataGridViewInventario.CurrentRow.Cells["OFICINA_NO"].Value.ToString();
                formAsignacion.txtEstado.Text = dataGridViewInventario.CurrentRow.Cells["ESTADO"].Value.ToString();
                formAsignacion.txtResponsable.Text = dataGridViewInventario.CurrentRow.Cells["RESPONSABLE"].Value.ToString();
                formAsignacion.txtCargoResp.Text = dataGridViewInventario.CurrentRow.Cells["CARGO"].Value.ToString();

                formAsignacion.label15.Visible = true;
                formAsignacion.lblNumeroEmpleado.Visible = true;
                formAsignacion.lblNumeroEmpleado.Text = dataGridViewListadoEmpleados.CurrentRow.Cells["EMP_NO"].Value.ToString();
                formAsignacion.txtNombre.Text = dataGridViewListadoEmpleados.CurrentRow.Cells["NOMBRE"].Value.ToString();
                formAsignacion.txtCargoEmp.Text = dataGridViewListadoEmpleados.CurrentRow.Cells["CARGO"].Value.ToString();
                formAsignacion.txtOficinaEmp.Text = dataGridViewListadoEmpleados.CurrentRow.Cells["OFICINA"].Value.ToString();
                formAsignacion.txtUnidad.Text = dataGridViewListadoEmpleados.CurrentRow.Cells["UNIDAD"].Value.ToString();
                formAsignacion.txtAreaTrabajo.Text = dataGridViewListadoEmpleados.CurrentRow.Cells["AREA_TRAB"].Value.ToString();
                formAsignacion.txtProfesion.Text = dataGridViewListadoEmpleados.CurrentRow.Cells["PROFESION"].Value.ToString();

                this.Close();
                formAsignacion.ShowDialog();
            }
            else
            {
                MessageBox.Show("Por favor seleccione una fila de cada registro.");
            }

        }
    }
}
