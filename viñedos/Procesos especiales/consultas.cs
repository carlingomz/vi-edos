using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using viñedos.Auxiliares;

namespace viñedos.Procesos_especiales
{
    public static class Consultas
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
        public static List<string> Sectores(string fraccionamientos)
        {
            string query = "select s.descripcion from sector s inner join Fraccionamiento f on s.Idfraccionamiento=f.Idfraccionamiento where f.descripcion like '%"+fraccionamientos+"%'";
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
        public static List<string> Viñas(string fraccionamiento,string sector)
        {
            string query = "select v.descripcion from viña v inner join Fraccionamiento f on v.Idfraccionamiento=f.Idfraccionamiento inner join sector s on v.idzector=s.idzector where f.descripcion like '%"+fraccionamiento+"%' and s.descripcion like '%"+sector+"%'";
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
        public static string Idfraccionamiento(string fraccionamiento)
        {
            string query = "select * from Fraccionamiento where descripcion='"+fraccionamiento+"'";
            string val = "";
            SqlConnection con = Conn();
            if (con != null)
            {
                SqlCommand cmdDd = new SqlCommand(query, con);
                SqlDataReader readerDd = cmdDd.ExecuteReader();
                if (readerDd.HasRows)
                {
                    if(readerDd.Read())
                    {
                        val = readerDd["Idfraccionamiento"].ToString();
                    }
                }
                con.Close();
            }
            return val;
        }
        public static string Idsector(string sector)
        {
            string query = "select * from sector where descripcion='" + sector + "'";
            string val = "";
            SqlConnection con = Conn();
            if (con != null)
            {
                SqlCommand cmdDd = new SqlCommand(query, con);
                SqlDataReader readerDd = cmdDd.ExecuteReader();
                if (readerDd.HasRows)
                {
                    if (readerDd.Read())
                    {
                        val = readerDd["Idsector"].ToString();
                    }
                }
                con.Close();
            }
            return val;
        }
        public static string Idviña(string viña)
        {
            string query = "select * from viña where descripcion='" + viña + "'";
            string val = "";
            SqlConnection con = Conn();
            if (con != null)
            {
                SqlCommand cmdDd = new SqlCommand(query, con);
                SqlDataReader readerDd = cmdDd.ExecuteReader();
                if (readerDd.HasRows)
                {
                    if (readerDd.Read())
                    {
                        val = readerDd["Idviña"].ToString();
                    }
                }
                con.Close();
            }
            return val;
        }
        public static string Fraccionamiento(string idfraccionamiento)
        {
            string query = "select * from Fraccionamiento where idfraccionamiento='" + idfraccionamiento + "'";
            string val = "";
            SqlConnection con = Conn();
            if (con != null)
            {
                SqlCommand cmdDd = new SqlCommand(query, con);
                SqlDataReader readerDd = cmdDd.ExecuteReader();
                if (readerDd.HasRows)
                {
                    if (readerDd.Read())
                    {
                        val = readerDd["descripcion"].ToString();
                    }
                }
                con.Close();
            }
            return val;
        }
        public static void InsertaEstructura(string estructura,int tipo)
        {
            string query = "";
            switch (tipo)
            {
                case 1:
                    query = "insert into fraccionamiento (descripcion) values ('"+estructura+"')";
                    break;

                case 2:
                    query = "insert into sector (descripcion) values ('" + estructura + "')";
                    break;

                case 3:
                    query = "insert into viñedos (descripcion) values ('" + estructura + "')";
                    break;
            }
            try
            {
                SqlConnection con = Conn();
                if (con != null)
                {
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show(@"Guardado");
                }
            }
            catch
            {
                MessageBox.Show(@"Algo salio mal intentelo de nuevo");
            }
        }
        public static void InsertaPrecios(string viña, string precio,int tipo)
        {
            string query = "insert into preciolote (idprecio,idviña,precio) values ("+tipo+","+viña+",'"+precio+"')";                   
            try
            {
                SqlConnection con = Conn();
                if (con != null)
                {
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(@"Guardado");
                }
            }
            catch
            {
                MessageBox.Show(@"Algo salio mal intentelo de nuevo");
            }
        }
        public static void InsertaUsuario(string usuario, string contraseña,int monitoreo,int areaadministrativa,int planesdefinanciamiento,int procesosespeciales,int administrador)
        {
            string query = "insert into usuario (usuario,contraseña) values ('"+usuario+"','"+contraseña+"')";
            try
            {
                SqlConnection con = Conn();
                if (con != null)
                {
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();


                    if (monitoreo == 1)
                    {
                        cmd = new SqlCommand("insert into permisos (programa,contraseña) values ('Monitoreo','"+contraseña+"')", con);
                        cmd.ExecuteNonQuery();
                    }
                    if (areaadministrativa == 1)
                    {
                        cmd = new SqlCommand("insert into permisos (programa,contraseña) values ('Administracion','" + contraseña + "')", con);
                        cmd.ExecuteNonQuery();
                    }
                    if (planesdefinanciamiento == 1)
                    {
                        cmd = new SqlCommand("insert into permisos (programa,contraseña) values ('Financiamiento','" + contraseña + "')", con);
                        cmd.ExecuteNonQuery();
                    }
                    if (procesosespeciales == 1)
                    {
                        cmd = new SqlCommand("insert into permisos (programa,contraseña) values ('ProcesosEspeciales','" + contraseña + "')", con);
                        cmd.ExecuteNonQuery();
                    }
                    if (administrador == 1)
                    {
                        cmd = new SqlCommand("insert into permisos (programa,contraseña) values ('Administrador','" + contraseña + "')", con);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show(@"Guardado");
                }
            }
            catch
            {
                MessageBox.Show(@"Algo salio mal intentelo de nuevo");
            }
        }
        public static DataTable Estructura(string estructura, int tipo)
        {
            DataTable d = new DataTable();
            string query = "";
            switch (tipo)
            {
                case 1:
                    query = "select idfraccionamiento as idestructura,descripcion from fraccionamiento where descripcion='" + estructura + "'";
                    break;

                case 2:
                    query = "select idzector as idestructura,descripcion from sector where descripcion='" + estructura + "'";
                    break;

                case 3:
                    query = "select idviña as idestructura,descripcion from viña where descripcion='" + estructura + "'";
                    break;
            }
            SqlConnection con = Conn();
            if (con != null)
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, con);
                d.Locale = System.Globalization.CultureInfo.InvariantCulture;
                dataAdapter.Fill(d);
            }
            return d;
        }
        public static DataTable Usuarios(string usuario)
        {
            DataTable d = new DataTable();
            string query = "select idusuario,Usuario,contraseña from usuario where usuario='"+usuario+"'";
            SqlConnection con = Conn();
            if (con != null)
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, con);
                d.Locale = System.Globalization.CultureInfo.InvariantCulture;
                dataAdapter.Fill(d);
            }
            return d;
        }
        public static void BorrarUsuario(string idusuario)
        {
            try
            {
                string query = "delete from usuario where idusuario=" + idusuario;
                SqlConnection con = Conn();
                if (con != null)
                {
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show(@"Borrado");
                }
            }
            catch
            {
                MessageBox.Show(@"Algo salio mal intentalo de nuevo");
            }
        }
        public static void BorrarEstrucutra(string idestructura,int tipo)
        {
            try
            {
                string query = "";
                switch (tipo)
                {
                    case 0:
                        query = "delete from fraccionamiento where idfraccionamiento=" + idestructura;
                        break;
                    case 1:
                        query = "delete from sector where idzector=" + idestructura;
                        break;
                    case 2:
                        query = "delete from viña where idviña=" + idestructura;
                        break;
                }
                
                SqlConnection con = Conn();
                if (con != null)
                {
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show(@"Borrado");
                }
            }
            catch
            {
                MessageBox.Show(@"Algo salio mal intentalo de nuevo");
            }
        }
    }
}