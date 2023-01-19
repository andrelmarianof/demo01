using demo01.Data.Provider;
using demo01.Domain.Produtos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Dapper;

namespace demo01.Data.Repositories
{

    #region "RepositoryAntigos"
    //public int Inserir(Produto objTabela)
    //{
    //    using (SqlConnection con = ConnectionProvider.ObterConexao())
    //    {

    //        SqlCommand cn = new SqlCommand();
    //        cn.CommandType = CommandType.Text;

    //        con.Open();

    //        cn.CommandText = "INSERT INTO produtos ([cdproduto], [descricao], [estoque], [valor]) VALUES (@cdproduto, @descricao, @estoque, @valor)";
    //        cn.Parameters.Add("cdproduto", SqlDbType.VarChar).Value = objTabela.CdProduto;
    //        cn.Parameters.Add("descricao", SqlDbType.VarChar).Value = objTabela.Descricao;
    //        cn.Parameters.Add("estoque", SqlDbType.Float).Value = objTabela.Estoque;
    //        cn.Parameters.Add("valor", SqlDbType.Decimal).Value = objTabela.Valor;
    //        cn.Connection = con;

    //        int qtd = cn.ExecuteNonQuery();

    //        con.Close();

    //        return qtd;

    //    }
    //}

    //public int Atualizar(Produto objTabela)
    //{
    //    using (SqlConnection con = ConnectionProvider.ObterConexao())
    //    {
    //        SqlCommand cn = new SqlCommand();
    //        cn.CommandType = CommandType.Text;
    //        con.Open();

    //        cn.CommandText = " UPDATE produtos SET descricao = @descricao , estoque = @estoque, valor = @valor where cdproduto = @cdproduto";
    //        cn.Parameters.Add("descricao", SqlDbType.VarChar).Value = objTabela.Descricao;
    //        cn.Parameters.Add("estoque", SqlDbType.Float).Value = objTabela.Estoque;
    //        cn.Parameters.Add("valor", SqlDbType.Decimal).Value = objTabela.Valor;
    //        cn.Parameters.Add("cdproduto", SqlDbType.VarChar).Value = objTabela.CdProduto;
    //        cn.Connection = con;

    //        int qtd = cn.ExecuteNonQuery();
    //        return qtd;


    //    }
    //}
    //public int Excluir(Produto objTabela)
    //{
    //    using (SqlConnection con = ConnectionProvider.ObterConexao())
    //    {
    //        SqlCommand cn = new SqlCommand();
    //        cn.CommandType = CommandType.Text;
    //        con.Open();

    //        cn.CommandText = "DELETE FROM produtos WHERE cdproduto = @cdproduto";
    //        cn.Parameters.Add("cdproduto", SqlDbType.VarChar).Value = objTabela.CdProduto;
    //        cn.Connection = con;
    //        int qtd = cn.ExecuteNonQuery();
    //        return qtd;
    //    }


    //}
    #endregion
    
    public class ProdutoRepository
    {

        #region RepositoryDapper
        public bool InsertProduto(Produto produto)
        {
            using (SqlConnection con = ConnectionProvider.ObterConexao())
            {

                var sql = @"
 INSERT INTO produtos
    (CdProduto,
    Descricao,
    Estoque,
    Valor)
 OUTPUT INSERTED.CdProduto
 VALUES
    ( @cdproduto,
     @descricao,
     @estoque,
     @valor)";

                var resp = con.ExecuteScalar(sql, new
                {
                    cdproduto = produto.CdProduto,
                    descricao = produto.Descricao,
                    estoque = produto.Estoque,
                    valor = produto.Valor,
                });

                if (resp == null)
                {
                    return false;
                }

                return true;

            }

        }

        public bool DeleteProduto(Produto produto)
        {
            using (SqlConnection con = ConnectionProvider.ObterConexao())
            {

                var sql = @"
 DELETE FROM produtos
 WHERE cdproduto = @cdproduto";

                var resp = con.ExecuteScalar(sql, new
                {
                    cdproduto = produto.CdProduto,
                });
                if (resp == null)
                {
                    return false;
                }
                return true;
            }
        }
        public bool UpdateProduto(Produto produto)
        {
            using (SqlConnection con = ConnectionProvider.ObterConexao())
            {
                var sql = @"
UPDATE produtos
SET descricao = @descricao,
    estoque   = @estoque,
    valor     = @valor
OUTPUT inserted.CdProduto
WHERE cdproduto = @cdproduto
";
                var resp = con.ExecuteScalar(sql, new
                {
                    descricao = produto.Descricao,
                    estoque = produto.Estoque,
                    valor = produto.Valor,
                    cdproduto = produto.CdProduto
                });

                if (resp == null)
                {
                    return false;
                }
                return true;
            }
        }
        #endregion

        #region RepositoryConsulta
        public List<Produto> ObterTodos()
        {
            using (SqlConnection con = ConnectionProvider.ObterConexao())
            {

                return con.Query<Produto>("SELECT * FROM produtos ORDER BY cdproduto DESC").ToList();

            }
        }
        
        public Produto ObterPorCodigo(string cdProduto)
        {
            using (SqlConnection con = ConnectionProvider.ObterConexao())
            {

                var query = new StringBuilder();
                query.AppendLine("SELECT * FROM produtos");
                query.AppendLine("/**where**/");

                var queryBuilder = new SqlBuilder();
                var template = queryBuilder.AddTemplate(query.ToString());
                queryBuilder.Where("cdproduto = @cdproduto", new { cdProduto });
                
                return con.QueryFirst<Produto>(template.RawSql, template.Parameters);
            }
        }
        #endregion

    }
}
