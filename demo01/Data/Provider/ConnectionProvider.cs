using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo01.Data.Provider
{
    public static class ConnectionProvider
    {
        public static SqlConnection ObterConexao()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Properties.Settings.Default.banco;
            return con;
        }
    }


    //public class Teste
    //{

    //    public Teste()
    //    {
    //        //var connectionProvider = new ConnectionProvider();
    //        //connectionProvider.Metodo();

    //        ConnectionProvider.Metodo();
    //    }
    //}


}
