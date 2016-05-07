using System.Data.SqlClient;
namespace viñedos.Lote
{
    public class lote
    {
        #region Propiedades
        public string _Idlote { get; set; }
        public string _Descripcion { get; set; }
        public string _Fraccionamiento { get; set; }
        public string _Zector { get; set; }
        public string _Viña { get; set; }
        public string _Numerolote { get; set; }
        public string _Cnorte { get; set; }
        public string _Csur { get; set; }
        public string _Coriente { get; set; }
        public string _Cponiente { get; set; }
        public string _Mnorte { get; set; }
        public string _Msur { get; set; }
        public string _Moriente { get; set; }
        public string _Mponiente { get; set; }
        public string _Estatus { get; set; }
        public string _Direccion { get; set; }
        public string _Titular { get; set; }
        public string _Superficie { get; set; }
        public string _Plandepago { get; set; }
        public  string _Precio { get; set; }
        #endregion
        public lote()
        {
            Inicializar();
        }
        public lote(string idlote)
        {
            Inicializar();
            _Idlote = idlote;
            Cargarloteid();
        }
        public lote(string nlote ,int i)
        {
            Inicializar();
            _Numerolote = nlote;
            Cargarlotenlote();
        }
        private void Inicializar()
        {
            _Idlote ="";
            _Descripcion ="";
            _Fraccionamiento ="";
            _Zector ="";
            _Viña ="";
            _Numerolote ="";
            _Cnorte ="";
            _Csur ="";
            _Coriente ="";
            _Cponiente ="";
            _Mnorte ="";
            _Msur ="";
            _Moriente ="";
            _Mponiente ="";
            _Estatus ="";
            _Direccion ="";
            _Titular ="";
            _Superficie ="";
            _Plandepago ="";
            _Precio = "";
        }
        private void Cargarloteid()
        {
            SqlConnection cn = new SqlConnection(@"Integrated Security=SSPI;Initial Catalog=viñedos;Data Source=localhost; MultipleActiveResultSets=true; MultipleActiveResultSets=true; max pool size=1000");
            cn.Open();

            try
            {
                var conDd = cn;
                string idlote = "";
                string queryDatosClien = "select *,v.descripcion as viña,f.descripcion as fraccionamiento,s.descripcion as sector,pr.precio as precio from poligono E left join lote d on e.idlote = d.idlote left join viña v on v.idviña=d.idviña left join fraccionamiento f on d.idfraccionamiento=f.idfraccionamiento left join sector s on d.idzector=s.idzector left join preciolote pr on d.idprecio=pr.idprecio  where d.idlote='" + _Idlote + "'";
                

                var cmdDd = new SqlCommand(queryDatosClien, conDd);
                var readerDd = cmdDd.ExecuteReader();
                if (readerDd.HasRows)
                {
                    if (readerDd.Read())
                    {
                        _Descripcion = readerDd["descripcion"].ToString();
                        _Numerolote = readerDd["numerolote"].ToString();
                        _Fraccionamiento = readerDd["fraccionamiento"].ToString();
                        _Zector = readerDd["sector"].ToString();
                        _Viña = readerDd["Viña"].ToString();

                        _Cnorte= readerDd["cnorte"].ToString();
                        _Csur = readerDd["csur"].ToString();
                        _Coriente = readerDd["coriente"].ToString();
                        _Cponiente = readerDd["cponiente"].ToString();
                        //--
                        _Mnorte= readerDd["mnorte"].ToString();
                        _Msur = readerDd["msur"].ToString();
                        _Moriente = readerDd["moriente"].ToString();
                        _Mponiente = readerDd["mponiente"].ToString();
                        //--
                        _Superficie = readerDd["superficie"].ToString();
                        _Estatus = readerDd["estatus"].ToString();
                        _Precio = readerDd["precio"].ToString();
                    }
                    conDd.Close();
                   
                }
            }
            catch
            {
                //ignored
            }
        }
        private void Cargarlotenlote()
        {
            SqlConnection cn = new SqlConnection(@"Integrated Security=SSPI;Initial Catalog=viñedos;Data Source=localhost; MultipleActiveResultSets=true; MultipleActiveResultSets=true; max pool size=1000");
            cn.Open();

            try
            {
                var conDd = cn;
                string idlote = "";
                string queryDatosClien = "select *,v.descripcion as viña,f.descripcion as fraccionamiento,s.descripcion as sector,pr.precio as precio from poligono E left join lote d on e.idlote = d.idlote left join viña v on v.idviña=d.idviña left join fraccionamiento f on d.idfraccionamiento=f.idfraccionamiento left join sector s on d.idzector=s.idzector left join preciolote pr on d.idprecio=pr.idprecio  where d.numerolote='" + _Numerolote + "'";


                var cmdDd = new SqlCommand(queryDatosClien, conDd);
                var readerDd = cmdDd.ExecuteReader();
                if (readerDd.HasRows)
                {
                    if (readerDd.Read())
                    {
                        _Descripcion = readerDd["descripcion"].ToString();
                        _Numerolote = readerDd["numerolote"].ToString();
                        _Fraccionamiento = readerDd["fraccionamiento"].ToString();
                        _Zector = readerDd["sector"].ToString();
                        _Viña = readerDd["Viña"].ToString();

                        _Cnorte = readerDd["cnorte"].ToString();
                        _Csur = readerDd["csur"].ToString();
                        _Coriente = readerDd["coriente"].ToString();
                        _Cponiente = readerDd["cponiente"].ToString();
                        //--
                        _Mnorte = readerDd["mnorte"].ToString();
                        _Msur = readerDd["msur"].ToString();
                        _Moriente = readerDd["moriente"].ToString();
                        _Mponiente = readerDd["mponiente"].ToString();
                        //--
                        _Superficie = readerDd["superficie"].ToString();
                        _Estatus = readerDd["estatus"].ToString();
                        _Precio = readerDd["precio"].ToString();
                        _Idlote = readerDd["idlote"].ToString();
                    }
                    conDd.Close();

                }
            }
            catch
            {
                //ignored
            }
        }
    }
}