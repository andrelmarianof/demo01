using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace demo01.Views.Produtos
{
    class produtodb
    {
        public int Inserir(produtoent objTabela)
        {
            using (SqlConnection con = new SqlConnection())
            {

                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;

                con.Open();

                cn.CommandText = "INSERT INTO produtos ([idproduto],  [cdproduto], [estoque], [valor]) VALUES (@cdproduto, @idproduto, @estoque, @valor)";
                cn.Parameters.Add("idproduto", SqlDbType.VarChar).Value = objTabela.Id;
                cn.Parameters.Add("cdproduto", SqlDbType.VarChar).Value = objTabela.Descricao;
                cn.Parameters.Add("estoque", SqlDbType.Float).Value = objTabela.Quantidade;
                cn.Parameters.Add("valor", SqlDbType.Decimal).Value = objTabela.Valor;
                cn.Connection = con;

                int qtd = cn.ExecuteNonQuery();

                con.Close();

                return qtd;

            }
        }
        public int Editar(produtoent objTabela)
        {
            using (SqlConnection con = new SqlConnection())
            {

                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();

                cn.CommandText = " UPDATE produtos SET idproduto = @cdproduto , estoque = @estoque, valor = @valor where cdproduto = @idproduto";
                cn.Parameters.Add("idproduto", SqlDbType.VarChar).Value = objTabela.Id;
                cn.Parameters.Add("cdproduto", SqlDbType.VarChar).Value = objTabela.Descricao;
                cn.Parameters.Add("estoque", SqlDbType.Float).Value = objTabela.Quantidade;
                cn.Parameters.Add("valor", SqlDbType.Decimal).Value = objTabela.Valor;
                cn.Connection = con;

                int qtd = cn.ExecuteNonQuery();
                return qtd;

            }
        }

        public List<produtoent> Lista(produtoent objTabela)
        {
            using (SqlConnection con = new SqlConnection())
            {

                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "SELECT * FROM produtos ORDER BY cdproduto DESC";
                cn.Connection = con;


                SqlDataReader dr;
                List<produtoent> lista = new List<produtoent>();

                dr = cn.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {

                        produtoent dado = new produtoent();
                        dado.Id = Convert.ToDecimal(dr["cdproduto"]);
                        dado.Descricao = Convert.ToString(dr["idproduto"]);
                        dado.Quantidade = Convert.ToDecimal(dr["estoque"]);
                        dado.Valor = Convert.ToDecimal(dr["valor"]);
                        lista.Add(dado);

                    }
                }

                return lista;

            }
        }
    }
}
