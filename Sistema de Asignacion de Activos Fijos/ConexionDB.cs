using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Asignacion_de_Activos_Fijos
{
    internal class ConexionDB
    {
        private readonly string connectionString;

        public ConexionDB()
        {
            connectionString = "Data Source=MAXIMO; Initial Catalog=BDPROYECTO; Integrated Security=True";
        }

        public SqlConnection getConexion()
        {
            return new SqlConnection(connectionString);
        }
    }
}
