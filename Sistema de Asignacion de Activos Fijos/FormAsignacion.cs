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
    public partial class FormAsignacion : Form
    {
        private ConexionDB conexionDB;
        private SqlConnection connection;

        public FormAsignacion()
        {
            InitializeComponent();
            conexionDB = new ConexionDB();
            connection = conexionDB.getConexion();
        }

        private void btnBuscarEquipo_Click(object sender, EventArgs e)
        {
            FormLIstadoInventario formLIstadoInventario = new FormLIstadoInventario();
            formLIstadoInventario.ShowDialog();
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string prefijo;
            using (connection = new ConexionDB().getConexion())
            {
                connection.Open();
                string queryCod = "SELECT TOP 1 ASIG_NO FROM Asignacion ORDER BY ASIG_NO DESC";
                using (SqlCommand command = new SqlCommand(queryCod, connection))
                {
                    // Ejecutar la consulta y obtener el resultado
                    object resultado = command.ExecuteScalar();

                    // Verificar si se obtuvo un resultado
                    if (resultado != null)
                    {
                        // Convertir el resultado al tipo de dato correspondiente
                        string valorCampo = resultado.ToString();

                        char ultimoDigito = valorCampo[valorCampo.Length - 1];
                        int ultimoDigitoEntero = int.Parse(ultimoDigito.ToString());

                        if (ultimoDigitoEntero > 9)
                        {
                            prefijo = "ASIG-";
                        }
                        else
                        {
                            prefijo = "ASIG-0";
                        }

                        ultimoDigitoEntero++;
                        string asig_no = prefijo + ultimoDigitoEntero.ToString();
                        string inv_no = lblNumeroInventario.Text;
                        string emp_no = lblNumeroEmpleado.Text;
                        if(asig_no == "" || lblNumeroInventario.Text == "" || lblNumeroEmpleado.Text == "")
                        {
                            string query = "INSERT INTO Asignacion VALUES (@AsigNo, @InvNo, @EmpNo)";
                            SqlCommand comando = new SqlCommand(query, connection);
                            comando.Parameters.AddWithValue("@AsigNo", asig_no);
                            comando.Parameters.AddWithValue("@InvNo", inv_no);
                            comando.Parameters.AddWithValue("@EmpNo", emp_no);

                            comando.ExecuteNonQuery();

                            MessageBox.Show("La asignación se realizó con exito");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Los campos no pueden ser vacios seleccione inventario y empleado.");
                        }
                        
                    }
                    else
                    {
                        // No se encontró ningún resultado
                        MessageBox.Show("No se encontró ningún resultado");
                    }
                }
            }
        }
    }
}
