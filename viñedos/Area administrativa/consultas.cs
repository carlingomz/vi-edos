using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using viñedos.Auxiliares;

namespace viñedos.Area_administrativa
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
            string query = "select s.descripcion from sector s ";//where s.descripcion like '%"+ sector + "%'";
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
        public static void Insertalote(string nlote,string descripcion,string colindanciaN,string colindanciaS,string colindanciaO,string colindanciaP ,string medidaN,string medidaS ,string medidaO,string medidaP,string direccion,string fraccionamiento,string sector,string viña,string superficie,string titular,string estatus,string plandepago,string coordenadas,string x1,string y1,string x2,string y2,string x3,string y3,string x4,string y4,string idfraccionaiento,string idsector,string idviña)
        {
            try
            {
                string query = "insert into lote (numerolote,descripcion,Idfraccionamiento,idzector,Idviña,cnorte,csur,coriente,cponiente,mnorte,msur,moriente,mponiente,estatus,direccion,titular,superficie,plandepago) values ('"+nlote+"','"+descripcion+"','"+idfraccionaiento+"','"+idsector+"','"+idviña+"','"+colindanciaN+"','"+colindanciaS+"','"+colindanciaO+"','"+colindanciaP+"',"+medidaN+","+medidaS+","+medidaO+","+medidaP+",'"+estatus+"','"+direccion+"','"+titular+"',"+superficie+",'"+plandepago+"')";
                int inserto = 0;
                SqlConnection con = Conn();
                if (con != null)
                {
                    SqlCommand cmd = new SqlCommand(query, con);
                    inserto=cmd.ExecuteNonQuery();
                }
                if(inserto>0)
                {
                    string consulta = "select * from lote where numerolote='"+ nlote + "'";
                    if (con != null)
                    {
                        string idlote = "";
                        SqlCommand cmdDd = new SqlCommand(consulta, con);
                        SqlDataReader readerDd = cmdDd.ExecuteReader();
                        if (readerDd.HasRows)
                        {
                            if(readerDd.Read())
                            {
                                idlote = readerDd["idlote"].ToString();
                            }
                            readerDd.Close();
                        }
                        if (idlote!="")
                        {
                            string insert = "insert into poligono (idlote,poligono,coordenadas) values('"+idlote+ "',geometry::STGeomFromText('POLYGON (("+coordenadas+"))', 0),'"+coordenadas+"')";
                            SqlCommand cmd = new SqlCommand(insert, con);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show(@"Guardado");
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show(@"Algo salio mal intentelo de nuevo");
            }
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
                        val = readerDd["Idzector"].ToString();
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
        public static DataTable InfoModificarLote(string opcion)
        {
            DataTable d = new DataTable();
            string query = "select Descripcion,idfraccionamiento,idzector,idviña,numerolote as 'Numero de lote',cnorte as 'Colindancia norte',csur 'Colindancia sur',coriente 'Colindancia oriente',cponiente 'Colindancia poniente',mnorte 'Medida norte',msur 'Medida sur',moriente 'Medida oriente', mponiente 'Medida poniente',Estatus as idestatus,Direccion,Titular,Superficie,plandepago 'Plan de pago',idlote,idprecio from lote where " + opcion;
            SqlConnection con = Conn();
            if (con != null)
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, con);
                //new SqlCommandBuilder(dataAdapter);
                d.Locale = System.Globalization.CultureInfo.InvariantCulture;
                dataAdapter.Fill(d);
            }
            return d;
        }
        public static DataTable InfoBorrarLote(string opcion)
        {
            DataTable d = new DataTable();
            string query = "select idlote,numerolote,descripcion,estatus,direccion,titular from lote where " + opcion;
            SqlConnection con = Conn();
            if (con != null)
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, con);
                d.Locale = System.Globalization.CultureInfo.InvariantCulture;
                dataAdapter.Fill(d);
            }
            return d;
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
        public static string Sector(string idsector)
        {
            string query = "select * from sector where idzector='" + idsector + "'";
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
        public static string Viña(string idviña)
        {
            string query = "select * from viña where idviña='" + idviña + "'";
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
        public static void BorrarLote(string idlote)
        {
            try
            {
                string query = "delete from lote where idlote='"+idlote+"'";
                string query2 = "delete from poligono where idlote='" + idlote + "'";
                SqlConnection con = Conn();
                if (con != null)
                {
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    //-- Elimina poligono - Elimina lote
                    cmd = new SqlCommand(query2, con);
                    cmd.ExecuteNonQuery();
                }
            }
            catch
            {
                MessageBox.Show(@"Algo salio mal intentelo de nuevo");
            }
        }
        public static void ModificaLote(string nlote, string descripcion, string colindanciaN, string colindanciaS, string colindanciaO, string colindanciaP, string medidaN, string medidaS, string medidaO, string medidaP, string direccion,string superficie, string titular, string estatus, string plandepago,string idfraccionaiento, string idsector, string idviña)
        {
            try
            {
                string query = "update lote set  numerolote='" + nlote + "',descripcion='" + descripcion + "',Idfraccionamiento='" + idfraccionaiento + "',idzector='" + idsector + "',Idviña='" + idviña + "',cnorte='" + colindanciaN + "',csur='" + colindanciaS + "',coriente='" + colindanciaO + "',cponiente='" + colindanciaP + "',mnorte=" + medidaN + ",msur=" + medidaS + ",moriente=" + medidaO + ",mponiente=" + medidaP + ",estatus='" + estatus + "',direccion='" + direccion + "',titular='" + titular + "',superficie=" + superficie + ",plandepago='" + plandepago + "' where numerolote='"+ nlote+"'";
                SqlConnection con = Conn();
                if (con != null)
                {
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                }
            }
            catch
            {
                MessageBox.Show(@"Algo salio mal intentelo de nuevo");
            }
        }
    }
}