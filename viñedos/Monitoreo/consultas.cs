using System.Collections.Generic;
using System.Data.SqlClient;
using viñedos.Auxiliares;

namespace viñedos.Monitoreo
{
    public static class consultas
    {       
        private static SqlConnection Conn()
        {
            var con = Conexion.GetConexionSql("viñedos");
            return con;
        }
        public static List<string> Fraccionamientos()
        {
            string query = "select * from Fraccionamiento";
            List<string> l = new List<string>();
            SqlConnection con = Conn();
            if (con != null)
            {
                SqlCommand cmdDd = new SqlCommand(query, con);
                SqlDataReader readerDd = cmdDd.ExecuteReader();
                if (readerDd.HasRows)
                {
                    while (readerDd.Read())
                    {
                        l.Add(readerDd["descripcion"].ToString());
                    }
                }
                con.Close();
            }
            return l;
        }
        public static List<string> Sectores()
        {
            string query = "select s.descripcion from sector s ";
            List<string> l = new List<string>();
            SqlConnection con = Conn();
            if (con != null)
            {
                SqlCommand cmdDd = new SqlCommand(query, con);
                SqlDataReader readerDd = cmdDd.ExecuteReader();
                if (readerDd.HasRows)
                {
                    while (readerDd.Read())
                    {
                        l.Add(readerDd["descripcion"].ToString());
                    }
                }
                con.Close();
            }
            return l;
        }
        public static List<string> Viñas()
        {
            string query = "select v.descripcion from viña v ";
            List<string> l = new List<string>();
            SqlConnection con = Conn();
            if (con != null)
            {
                SqlCommand cmdDd = new SqlCommand(query, con);
                SqlDataReader readerDd = cmdDd.ExecuteReader();
                if (readerDd.HasRows)
                {
                    while (readerDd.Read())
                    {
                        l.Add(readerDd["descripcion"].ToString());
                    }
                }
                con.Close();
            }
            return l;
        }
    }
}