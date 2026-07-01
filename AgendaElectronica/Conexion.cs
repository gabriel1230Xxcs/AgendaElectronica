using System.Data;
using System.Data.SqlClient;

namespace AgendaElectronica
{
    internal class Conexion
    {
        SqlConnection cn = new SqlConnection(
            @"Data Source=GABRIEL\SQLEXPRESS;
              Initial Catalog=AgendaElectronica;
              Integrated Security=True");

        public SqlConnection AbrirConexion()
        {
            if (cn.State == ConnectionState.Closed)
                cn.Open();

            return cn;
        }

        public SqlConnection CerrarConexion()
        {
            if (cn.State == ConnectionState.Open)
                cn.Close();

            return cn;
        }
    }
}