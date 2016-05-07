using System.Collections.Generic;
using System.Data.SqlClient;

namespace viñedos.Auxiliares
{
    internal static class Consultas
    {
        private static SqlConnection Conn()
        {
            var con = Conexion.GetConexionSql("viñedos");
            return con;
        }

        public static bool Log_inCorrecto(string pass)
        {
            SqlConnection con = Conn();
            bool val = false;
            if (con != null)
            {
                string query = "select * from usuarios where password='" + pass + "'";
                SqlCommand cmdDd = new SqlCommand(query, con);
                SqlDataReader readerDd = cmdDd.ExecuteReader();
                if (readerDd.HasRows)
                {
                    val = true;
                }
                con.Close();
            }
            return val;
        }
    }
}