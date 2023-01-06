using demo01.Data.Provider;
using demo01.Domain.Produtos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo01.Data.Repositories
{


    public class ProdutoRepository
    {
        public int Inserir(Produto objTabela)
        {
            using (SqlConnection con = ConnectionProvider.ObterConexao())
            {

                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;

                con.Open();

                cn.CommandText = "INSERT INTO produtos ([cdproduto], [descricao], [estoque], [valor]) VALUES (@cdproduto, @descricao, @estoque, @valor)";
                cn.Parameters.Add("cdproduto", SqlDbType.VarChar).Value = objTabela.CdProduto;
                cn.Parameters.Add("descricao", SqlDbType.VarChar).Value = objTabela.Descricao;
                cn.Parameters.Add("estoque", SqlDbType.Float).Value = objTabela.Estoque;
                cn.Parameters.Add("valor", SqlDbType.Decimal).Value = objTabela.Valor;
                cn.Connection = con;

                int qtd = cn.ExecuteNonQuery();

                con.Close();

                return qtd;

            }
        }
        public int Atualizar(Produto objTabela)
        {
            using (SqlConnection con = ConnectionProvider.ObterConexao())
            {
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();

                cn.CommandText = " UPDATE produtos SET descricao = @descricao , estoque = @estoque, valor = @valor where cdproduto = @cdproduto";
                cn.Parameters.Add("descricao", SqlDbType.VarChar).Value = objTabela.Descricao;
                cn.Parameters.Add("estoque", SqlDbType.Float).Value = objTabela.Estoque;
                cn.Parameters.Add("valor", SqlDbType.Decimal).Value = objTabela.Valor;
                cn.Parameters.Add("cdproduto", SqlDbType.VarChar).Value = objTabela.CdProduto;
                cn.Connection = con;

                int qtd = cn.ExecuteNonQuery();
                return qtd;

            }
        }
        public int Excluir(Produto objTabela)
        {
            using (SqlConnection con = ConnectionProvider.ObterConexao())
            {
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();

                cn.CommandText = "DELETE FROM produtos WHERE cdproduto = @cdproduto";
                cn.Parameters.Add("cdproduto", SqlDbType.VarChar).Value = objTabela.CdProduto;
                cn.Connection = con;
                int qtd = cn.ExecuteNonQuery();
                return qtd;
            }


        }
        public List<Produto> ObterTodos()
        {
            using (SqlConnection con = ConnectionProvider.ObterConexao())
            {
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "SELECT * FROM produtos ORDER BY cdproduto DESC";
                cn.Connection = con;


                SqlDataReader dr;
                List<Produto> lista = new List<Produto>();

                dr = cn.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {

                        Produto dado = new Produto();
                        dado.CdProduto = dr["cdproduto"].ToString();
                        dado.Descricao = dr["Descricao"].ToString();
                        dado.Estoque = Convert.ToDecimal(dr["estoque"]);
                        dado.Valor = Convert.ToDecimal(dr["valor"]);
                        lista.Add(dado);

                    }
                }

                return lista;

            }
        }
        public Produto ObterPorCodigo(string cdProduto)
        {
            using (SqlConnection con = ConnectionProvider.ObterConexao())
            {
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "SELECT * FROM produtos WHERE cdproduto = @cdproduto";
                cn.Parameters.Add("cdproduto", SqlDbType.VarChar).Value = cdProduto;
                cn.Connection = con;


                SqlDataReader dr;

                dr = cn.ExecuteReader();

                if (!dr.HasRows)
                    return null;

                Produto dado = new Produto();
                if (dr.Read())
                {
                    dado.CdProduto = dr["cdproduto"].ToString();
                    dado.Descricao = dr["Descricao"].ToString();
                    dado.Estoque = Convert.ToDecimal(dr["estoque"]);
                    dado.Valor = Convert.ToDecimal(dr["valor"]);


                }
                return dado;

            }
        }
    }
}
