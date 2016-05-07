using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace viñedos.Auxiliares
{
    internal static class Conexion
    {
        public static SqlConnection GetConexionSql(string bd)
        {
            if (String.IsNullOrEmpty(bd)) throw new ArgumentException(@"Argument is null or empty", nameof(bd));
            /*string servr = Parametros.Server.Default.direccionSQL;
            string idConex = Parametros.Server.Default.usuarioSQL;
            string passwordConex = Parametros.Server.Default.contraseñaSQL;*/
            string servr = "1";
            string idConex = "1";
            if (string.IsNullOrEmpty(servr) && string.IsNullOrEmpty(idConex))
            {
                MessageBox.Show(@"Faltan parametros para establecer una conexion");
                return null;
            }
            else
            {
                try
                {
                    //cn = new SqlConnection("Data Source=" + servr + "; Initial Catalog=" + bd + "; User Id=" + idConex + "; Password=" + passwordConex + "; MultipleActiveResultSets=true; max pool size=1000");
                    //var cn = new SqlConnection(@"Integrated Security=SSPI;Initial Catalog=viñedos;Data Source=" + servr + "; MultipleActiveResultSets=true; MultipleActiveResultSets=true; max pool size=1000");
                    var cn = new SqlConnection(@"Integrated Security=SSPI;Initial Catalog=viñedos;Data Source=localhost; MultipleActiveResultSets=true; MultipleActiveResultSets=true; max pool size=1000");
                    cn.Open();
                    return cn;
                }
                catch (InvalidOperationException ex1)
                {
                    MessageBox.Show(@"ERROR DE LA CONEXION ----" + ex1);
                    return null;
                }
                catch (SqlException ex2)
                {
                    MessageBox.Show(@"ERROR DE LA CONEXION ----" + ex2);
                    return null;
                }
                catch (NullReferenceException ex3)
                {
                    MessageBox.Show(@"ERROR DE LA CONEXION ----" + ex3);
                    return null;
                }
            }
        }

        public static SqlConnection ProbarConexionSql(string usuario, string password, string direccion)
        {
            string servr = direccion;
            string idConex = usuario;
            string passwordConex = password;
            if (string.IsNullOrEmpty(servr) && string.IsNullOrEmpty(idConex))
            {
                MessageBox.Show(@"Faltan parametros para establecer una conexion");
                return null;
            }
            else
            {
                try
                {
                    //cn = new SqlConnection("Data Source=" + servr + "; Initial Catalog=master; User Id=" + idConex + "; Password=" + passwordConex + "; MultipleActiveResultSets=true; ");
                    var cn = new SqlConnection(@"Integrated Security=SSPI;Initial Catalog=master;Data Source=" + servr + "; MultipleActiveResultSets=true; MultipleActiveResultSets=true; max pool size=1000");
                    cn.Open();
                    return cn;
                }
                catch (InvalidOperationException ex1)
                {
                    MessageBox.Show(@"ERROR DE LA CONEXION ----" + ex1);
                    return null;
                }
                catch (SqlException ex2)
                {
                    MessageBox.Show(@"ERROR DE LA CONEXION ----" + ex2);
                    return null;
                }
                catch (NullReferenceException ex3)
                {
                    MessageBox.Show(@"ERROR DE LA CONEXION ----" + ex3);
                    return null;
                }
            }
        }

        /*
        public static FbConnection GetConexionFire(string bd)
        {
            if (String.IsNullOrEmpty(bd)) throw new ArgumentException(@"Argument is null or empty", nameof(bd));
            string servr = Parametros.Server.Default.direccionFire;
            string idConex = Parametros.Server.Default.usuarioFire;
            string passwordConex = Parametros.Server.Default.contraseñaFire;
            if(string.IsNullOrEmpty(servr) && string.IsNullOrEmpty(idConex))
            {
                MessageBox.Show(@"Faltan parametros para establecer una conexion");
                return null;
            }
            else
            {
                try
                {
                    var con = new FbConnection("User=SYSDBA;Password=masterkey;Database=c:\\SIA\\club.fdb;DataSource=localhost;Port = 3050; Dialect = 3; Charset = NONE; Role =; Connection lifetime = 0; Pooling = true;");
                    con.Open();
                    return con;
                }
                catch (InvalidOperationException ex1)
                {
                    MessageBox.Show(@"ERROR DE LA CONEXION ----" + ex1);
                    return null;
                }
                catch (NullReferenceException ex3)
                {
                    MessageBox.Show(@"ERROR DE LA CONEXION ----" + ex3);
                    return null;
                }
            }
        }
        public static FbConnection ProbarConexionFire(string usuario, string password, string direccion)
        {
            FbConnection cn;
            string servr = direccion;
            string idConex = usuario;
            string passwordConex = password;
            if (string.IsNullOrEmpty(servr) && string.IsNullOrEmpty(idConex))
            {
                MessageBox.Show(@"Faltan parametros para establecer una conexion");
                return null;
            }
            else
            {
                try
                {
                    cn = new FbConnection("User=SYSDBA;Password=masterkey;Database=c:\\SIA\\club.fdb;DataSource=localhost;Port = 3050; Dialect = 3; Charset = NONE; Role =; Connection lifetime = 0; Pooling = true;");
                    cn.Open();
                    return cn;
                }
                catch (InvalidOperationException ex1)
                {
                    MessageBox.Show(@"ERROR DE LA CONEXION ----" + ex1);
                    return null;
                }
                catch (NullReferenceException ex3)
                {
                    MessageBox.Show(@"ERROR DE LA CONEXION ----" + ex3);
                    return null;
                }
            }
        }*/
    }
}