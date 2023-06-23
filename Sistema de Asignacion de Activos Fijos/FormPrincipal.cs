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
    public partial class FormPrincipal : Form
    {
        private ConexionDB conexionDB;
        private SqlConnection connection;
        private FormEmpleados formEmpleados;
        private FormEquiposAsignados formEquiposAsignados;

        public FormPrincipal()
        {
            InitializeComponent();
            personalizarDiseño();
            conexionDB = new ConexionDB();
            connection = conexionDB.getConexion();
            formEmpleados = new FormEmpleados();
            formEquiposAsignados = new FormEquiposAsignados();
        }

        //este codigo tendra la funcionalidad de arrastrar el formulario
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void panelSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            //permite arrastrar el formulario
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //Este método oculta los submenus
        private void personalizarDiseño()
        {
            panelEquiposSubMenu.Visible = false;
            panelEmpleadosSubMenu.Visible = false;
            panelOficinasSubMenu.Visible = false;
        }

        //Oculta un submenu cuando esta desplegado
        private void ocultarSubMenu()
        {
            if (panelEquiposSubMenu.Visible)
            {
                panelEquiposSubMenu.Visible = false;
            }
            if (panelEmpleadosSubMenu.Visible)
            {
                panelEmpleadosSubMenu.Visible = false;
            }
            if (panelOficinasSubMenu.Visible)
            {
                panelOficinasSubMenu.Visible = false;
            }
        }

        //Este método mostrará los submenus 
        private void mostrarSubMenu(Panel subMenu)
        {
            if (!subMenu.Visible)
            {
                ocultarSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        //declaramos esta variable para los formularios que se abren
        private Form formularioActivo = null;

        public void abrirFormulariosEnPanelPrinicipal(Form formularioHijo)
        {
            if (formularioActivo != null)
            {
                //si existe un formulario abierto lo cerramos
                formularioActivo.Close();
            }
            formularioActivo = formularioHijo;
            //este se comportará como un control, no es de nivel superior
            formularioHijo.TopLevel = false;
            //se quita los bordes del formulario
            formularioHijo.FormBorderStyle = FormBorderStyle.None;
            //para llenar todo el campo
            formularioHijo.Dock = DockStyle.Fill;
            //agregamos el formulario a la lista de controles al panel
            panelContenedor.Controls.Add(formularioHijo);
            //asociamos el formulario con el panel contenedor
            panelContenedor.Tag = formularioHijo;
            //para traer el formulario al frente
            formularioHijo.BringToFront();
            //mostramos el formulario
            formularioHijo.Show();
        }

        private void btnMenuEquipos_Click(object sender, EventArgs e)
        {
            mostrarSubMenu(panelEquiposSubMenu);
        }

        private void btnAsignarEquipos_Click(object sender, EventArgs e)
        {
            abrirFormulariosEnPanelPrinicipal(new FormAsignacion());
        }

        private void btnDevolucionEquipos_Click(object sender, EventArgs e)
        {
            abrirFormulariosEnPanelPrinicipal(new FormDevolucion());
        }

        private void btnEquipos_Click(object sender, EventArgs e)
        {
            abrirFormulariosEnPanelPrinicipal(new FormEquiposAsignados());
            formEquiposAsignados.cargarDatos();
        }

        private void btnMenuEmpleados_Click(object sender, EventArgs e)
        {
            mostrarSubMenu(panelEmpleadosSubMenu);
            formEmpleados.cargarDatos();
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            abrirFormulariosEnPanelPrinicipal(new FormEmpleados());
            formEmpleados.cargarDatos();
        }

        private void btnCargos_Click(object sender, EventArgs e)
        {
            abrirFormulariosEnPanelPrinicipal(new FormCargosEmpleados());
        }

        private void btnMenuOficinas_Click(object sender, EventArgs e)
        {
            mostrarSubMenu(panelOficinasSubMenu);
        }

        private void btnOficinas_Click(object sender, EventArgs e)
        {
            abrirFormulariosEnPanelPrinicipal(new FormOficinas());
        }

        private void btnEncargados_Click(object sender, EventArgs e)
        {
            abrirFormulariosEnPanelPrinicipal(new FormResponsableOficina());
        }

        private void btnPartidaMenu_Click(object sender, EventArgs e)
        {
            ocultarSubMenu();
            abrirFormulariosEnPanelPrinicipal(new FormPartida());
        }

        private void pictureBoxInicio_Click(object sender, EventArgs e)
        {
            ocultarSubMenu();
            if (formularioActivo != null)
            {
                formularioActivo.Close();
            }
            panelContenedor.BringToFront();
            cargarDatos();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            cargarDatos();
        }

        private void cargarDatos()
        {
            connection.Open();

            string queryEmp = "SELECT COUNT(*) FROM Empleados";

            using (SqlCommand command = new SqlCommand(queryEmp, connection))
            {
                int cantidadEmpleados = (int)command.ExecuteScalar();

                labelTotalEmpleados.Text = cantidadEmpleados.ToString();
            }

            string queryInv = "SELECT COUNT(*) FROM Inventario";

            using (SqlCommand command = new SqlCommand(queryInv, connection))
            {
                int cantidadInventarios = (int)command.ExecuteScalar();

                labelTotalInventario.Text = cantidadInventarios.ToString();
            }

            string queryAsig = "SELECT COUNT(*) FROM Asignacion";

            using (SqlCommand command = new SqlCommand(queryAsig, connection))
            {
                int cantidadAsignados = (int)command.ExecuteScalar();

                labelAsignados.Text = cantidadAsignados.ToString();
            }
            connection.Close();
        }

        private void btnGenerarQR_Click(object sender, EventArgs e)
        {
            abrirFormulariosEnPanelPrinicipal(new FormEquiposAsignados());
        }
    }
}
