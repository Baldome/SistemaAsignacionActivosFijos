using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Asignacion_de_Activos_Fijos
{
    public partial class FormDevolucion : Form
    {
        ConexionDB conexionDB;
        FormEquiposAsignados formEquiposAsignados;
        public FormDevolucion()
        {
            InitializeComponent();
            conexionDB = new ConexionDB();
        }

        private void btnBuscarAsignacion_Click(object sender, EventArgs e)
        {
            formEquiposAsignados = new FormEquiposAsignados();
            formEquiposAsignados.btnMaximizar.Visible = true;
            formEquiposAsignados.btnSeleccionar.Visible = true;
            formEquiposAsignados.btnGenerarQR.Visible = false;
            
            formEquiposAsignados.ShowDialog();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
