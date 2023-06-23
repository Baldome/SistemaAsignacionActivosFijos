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
using QRCoder;

namespace Sistema_de_Asignacion_de_Activos_Fijos
{
    public partial class FormEquiposAsignados : Form
    {
        private ConexionDB conexionDB;
        private SqlConnection connection;
        private FormDevolucion formDevolucion;
        private FormPrincipal formPrincipal;

        public FormEquiposAsignados()
        {
            InitializeComponent();
            conexionDB = new ConexionDB();
        }

        private void FormEquiposAsignados_Load(object sender, EventArgs e)
        {
            cargarDatos();
        }

        public void cargarDatos()
        {
            using (connection = conexionDB.getConexion())
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
            if (WindowState == FormWindowState.Normal)
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
            formDevolucion = new FormDevolucion();
            if (dataGridViewListadoAsignacion.SelectedRows.Count == 1)
            {
                using (connection = conexionDB.getConexion())
                {
                    connection.Open();
                    string asig_no = dataGridViewListadoAsignacion.CurrentRow.Cells["ASIG_NO"].Value.ToString();
                    string query = "DELETE FROM Asignacion WHERE ASIG_NO = @AsigNo";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@AsigNo", asig_no);

                    command.ExecuteNonQuery();
                    MessageBox.Show("La devolucion fue realizada correctamente");

                    this.Close();
                    formDevolucion.lblFrmActual.Text = "Listado de inventario devuelto";
                    formDevolucion.txtRubros.Text = dataGridViewListadoAsignacion.CurrentRow.Cells["RUBRO"].Value.ToString();
                    formDevolucion.txtAuxiliar.Text = dataGridViewListadoAsignacion.CurrentRow.Cells["AUXILIAR"].Value.ToString();
                    formDevolucion.txtOficina.Text = dataGridViewListadoAsignacion.CurrentRow.Cells["OFICINA"].Value.ToString();
                    formDevolucion.txtEstado.Text = dataGridViewListadoAsignacion.CurrentRow.Cells["ESTADO"].Value.ToString();
                    formDevolucion.txtResponsable.Text = dataGridViewListadoAsignacion.CurrentRow.Cells["RESPONSABLE"].Value.ToString();
                    formDevolucion.txtCargoResp.Text = dataGridViewListadoAsignacion.CurrentRow.Cells["CARGO"].Value.ToString();
                    formDevolucion.txtNombre.Text = dataGridViewListadoAsignacion.CurrentRow.Cells["NOMBRE"].Value.ToString();
                    formDevolucion.txtCargoEmp.Text = dataGridViewListadoAsignacion.CurrentRow.Cells["CARGO1"].Value.ToString();
                    formDevolucion.txtOficinaEmp.Text = dataGridViewListadoAsignacion.CurrentRow.Cells["OFICINA"].Value.ToString();
                    formDevolucion.txtUnidad.Text = dataGridViewListadoAsignacion.CurrentRow.Cells["UNIDAD"].Value.ToString();
                    formDevolucion.txtAreaTrabajo.Text = dataGridViewListadoAsignacion.CurrentRow.Cells["AREA_TRAB"].Value.ToString();
                    formDevolucion.txtProfesion.Text = dataGridViewListadoAsignacion.CurrentRow.Cells["PROFESION"].Value.ToString();

                    formDevolucion.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Por favor seleccione una fila.");
            }
        }

        private void btnGenerarQR_Click(object sender, EventArgs e)
        {
            formPrincipal = new FormPrincipal();
            string stringCodigo = "\tListado de Equipos Asignados\n\n";
            if (dataGridViewListadoAsignacion.SelectedRows.Count == 1)
            {
                //this.Close();
                stringCodigo += "\tDatos de Inventario";
                stringCodigo += "\nCodigo de asignacion: " + dataGridViewListadoAsignacion.CurrentRow.Cells["ASIG_NO"].Value.ToString();
                stringCodigo += "\nCodigo de inventario: " + dataGridViewListadoAsignacion.CurrentRow.Cells["INV_NO"].Value.ToString();
                stringCodigo += "\nRubro: " + dataGridViewListadoAsignacion.CurrentRow.Cells["RUBRO"].Value.ToString();
                stringCodigo += "\nAuxiliar: " + dataGridViewListadoAsignacion.CurrentRow.Cells["AUXILIAR"].Value.ToString();
                stringCodigo += "\nOficina numero: " + dataGridViewListadoAsignacion.CurrentRow.Cells["OFICINA"].Value.ToString();
                stringCodigo += "\nEstado: " + dataGridViewListadoAsignacion.CurrentRow.Cells["ESTADO"].Value.ToString();
                stringCodigo += "\nResponsable: " + dataGridViewListadoAsignacion.CurrentRow.Cells["RESPONSABLE"].Value.ToString();
                stringCodigo += "\nCargo: " + dataGridViewListadoAsignacion.CurrentRow.Cells["CARGO"].Value.ToString();
                stringCodigo += "\n\tDatos del Empleado";
                stringCodigo += "\nNombre: "+dataGridViewListadoAsignacion.CurrentRow.Cells["NOMBRE"].Value.ToString();
                stringCodigo += "\nCargo: "+dataGridViewListadoAsignacion.CurrentRow.Cells["CARGO1"].Value.ToString();
                stringCodigo += "\nOficina: " + dataGridViewListadoAsignacion.CurrentRow.Cells["OFICINA"].Value.ToString();
                stringCodigo += "\nUnidad: " + dataGridViewListadoAsignacion.CurrentRow.Cells["UNIDAD"].Value.ToString();
                stringCodigo += "\nArea trabajo: " + dataGridViewListadoAsignacion.CurrentRow.Cells["AREA_TRAB"].Value.ToString();
                stringCodigo += "\nProfesion: " + dataGridViewListadoAsignacion.CurrentRow.Cells["PROFESION"].Value.ToString();


                QRCodeGenerator qRCodeGenerator = new QRCodeGenerator();
                QRCodeData qRCodeData = qRCodeGenerator.CreateQrCode(stringCodigo, QRCodeGenerator.ECCLevel.H);
                QRCode qRCode = new QRCode(qRCodeData);
                // genera código QR con una imagen al centro
                Bitmap qRImage = qRCode.GetGraphic(8, Color.Black, Color.White, (Bitmap)Bitmap.FromFile(@"D:\\Max\\Pictures\\Saved Pictures\\ibaka_logo.png"));
                formPrincipal.pictureBoxContenidoQR.Image = qRImage;
                formPrincipal.Show();
            }
            else
            {
                MessageBox.Show("Por favor seleccione una fila.");
            }

        }
    }
}
