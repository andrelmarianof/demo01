using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using demo01.Application.Pedidos;
using System.Data.SqlClient;
using demo01.Data.Provider;
using Dapper;
using demo01.Domain.Pedidos;

namespace demo01.Data.RepositoriesPedido
{
    class PedidoRepository
    {
        public bool InsertPedido(Pedido pedido)
        {
            using (SqlConnection con = ConnectionProvider.ObterConexao())
            {

                var sql1 = @"
 INSERT INTO pedido
    (Numero,
    CdCliente)
 OUTPUT INSERTED.Numero
 VALUES
    ( @numero,
     @cdcliente)";

                var resp1 = con.ExecuteScalar(sql1, new
                {
                    numero = pedido.Numero,
                    cdcliente = pedido.CdCliente
                });

                if (resp1 == null)
                {
                    return false;
                }
                return true;
            }
        }
        public bool InsertProduto(Pedido pedido)
        {
            using (SqlConnection con = ConnectionProvider.ObterConexao())
            {

                var sql2 = @"
 INSERT INTO pedidoItem
    (NumeroPedido,
    CdProduto,
    QtdVenda,
    VlVenda)
 OUTPUT INSERTED.NumeroPedido
 VALUES
    ( @numeropedido,
     @cdproduto,
     @qtdvenda,
     @vlvenda)";
                var resp2 = con.ExecuteScalar(sql2, new
                {
                    numeropedido = pedido.NumeroPedido,
                    cdproduto = pedido.CdProduto,
                    qtdvenda = pedido.QtdVenda,
                    vlvenda = pedido.VlVenda
                });

                if ((resp2 == null) & (resp2 == null))
                {
                    return false;
                }
                return true;

            }
        }
        public List<Pedido> ObterTodosProdutosPorNumeroPedido(string columnSort)
        {
            //using (SqlConnection con = ConnectionProvider.ObterConexao())
            //{
            //    var sql = @"SELECT * FROM Pedido WHERE Numero = @numeroPedido";
            //    return con.Query<Pedido>(sql, new { numeroPedido }).ToList();
            //}
                using (SqlConnection con = ConnectionProvider.ObterConexao())
                {
                    var query = new StringBuilder();
                    query.AppendLine("SELECT * FROM pedido");
                    query.AppendLine("/**WHERE**/");

                    var queryBuilder = new SqlBuilder();
                    var template = queryBuilder.AddTemplate(query.ToString());
                    queryBuilder.OrderBy(columnSort);

                    return con.Query<Pedido>(template.RawSql, template.Parameters).ToList();
                }

        }
        
        public string ConsultarUltimoPedido()
        {
            using (SqlConnection con = ConnectionProvider.ObterConexao())
            {
                var result = con.QueryFirstOrDefault<string>(@"SELECT top 1 Numero FROM Pedido ORDER BY Numero DESC");
                return result;
                
            }
        }

    } 
  
}
