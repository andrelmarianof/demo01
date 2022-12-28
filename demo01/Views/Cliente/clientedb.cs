using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo01.Views.Cliente
{
    class clientedb
    {
        public int Inserir(clientent objTabela)
        {
            using (SqlConnection con = new SqlConnection())
            {

                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;

                con.Open();

                cn.CommandText = "INSERT INTO produtos ([cdcliente],  [nomecliente]) VALUES (@IdCliente, @nome)";

                //MessageBox.Show(cn.CommandText);
                //Console.WriteLine(cn.CommandText);

                //cn.Parameters.Add("idproduto", SqlDbType.VarChar).Value = objTabela.Id;
                //cn.Parameters.Add("cdproduto", SqlDbType.VarChar).Value = objTabela.Descricao;
                //cn.Parameters.Add("estoque", SqlDbType.Float).Value = objTabela.Quantidade;
                //cn.Parameters.Add("valor", SqlDbType.Decimal).Value = objTabela.Valor;



                cn.Connection = con;

                int qtd = cn.ExecuteNonQuery();

                /*Console.Write(qtd);*/

                con.Close();

                return qtd;

            }

        }

    }
}
