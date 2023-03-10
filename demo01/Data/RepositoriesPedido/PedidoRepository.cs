/**refatorado*/
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using Dapper;
using demo01.Application.Pedidos;
using demo01.Data.Provider;
using demo01.Domain.Pedido;
using demo01.Domain.Pedidos;

namespace demo01.Data.RepositoriesPedido
{
    class PedidoRepository
    {
        private readonly SqlConnection _connection;

        public PedidoRepository()
        {
            _connection = ConnectionProvider.ObterConexao();
        }

        public bool InsertPedido(Pedido pedido)
        {
            var sql = @"
                INSERT INTO pedido (Numero, CdCliente)
                OUTPUT INSERTED.Numero
                VALUES (@numero, @cdcliente)";

            var resp = _connection.ExecuteScalar(sql, new
            {
                numero = pedido.Numero,
                cdcliente = pedido.CdCliente
            });

            if (resp == null)
            {
                return false;
            }

            return true;
        }
        
        public bool InsertProduto(PedidoItem pedido)
        {
            var sql = @"
                INSERT INTO pedidoItem (NumeroPedido, CdProduto, QtdVenda, VlVenda, Descricao)
                OUTPUT INSERTED.NumeroPedido
                VALUES (@numeropedido, @cdproduto, @qtdvenda, @vlvenda, @descricao)";

            var resp = _connection.ExecuteScalar(sql, new
            {
                numeropedido = pedido.NumeroPedido,
                cdproduto = pedido.CdProduto,
                qtdvenda = pedido.QtdVenda,
                vlvenda = pedido.VlVenda,
                descricao = pedido.Descricao
            });

            if (resp == null)
            {
                return false;
            }

            return true;
        }

        public bool DeletePedido(Pedido pedido)
        {
            var sql = @"
                DELETE FROM pedido 
                OUTPUT DELETED.numero
                WHERE Numero = @numero";

            var resp = _connection.ExecuteScalar(sql, new
            {
                numero = pedido.Numero
            });

            if (resp == null)
            {
                return false;
            }

            return true;
        }
        public bool DeleteItemDoPedido(PedidoItem pedidoitem)
        {
            var sql = @"
                DELETE FROM pedidoItem
                OUTPUT DELETED.NumeroPedido
                WHERE NumeroPedido = @numeropedido
                AND Id = @id
                AND CdProduto = @cdproduto";

            var resp = _connection.ExecuteScalar(sql, new
            {
                cdproduto = pedidoitem.CdProduto,
                id = pedidoitem.Id,
                numeropedido = pedidoitem.NumeroPedido
            });

            if (resp == null)
            {
                return false;
            }

            return true;
        }

        public string ConsultarUltimoPedido()
        {
            return _connection.QueryFirstOrDefault<string>(@"
                SELECT top 1 Numero FROM Pedido ORDER BY Numero DESC");
        }

        public Pedido ObterPedido(string numero = "")
        {
            var query = "SELECT * FROM pedido WHERE numero = @numero";
            return _connection.QueryFirstOrDefault<Pedido>(query, new { numero });
        }

        //public List<PedidoItem> ObterListaDeItens(int numero)
        //{
        //    var queryBuilder = new SqlBuilder();
        //    var template = queryBuilder.AddTemplate(@"SELECT pedidoItem.NumeroPedido AS NumeroPedido, pedidoItem.CdProduto AS CdProduto, produto.Descricao AS Descricao, pedidoItem.QtdVenda AS QtdVenda, pedidoItem.VlVenda AS VlVenda, (pedidoItem.VlVenda * pedidoItem.QtdVenda) AS Total FROM pedido INNER JOIN pedidoItem ON pedido.Numero = pedidoItem.NumeroPedido INNER JOIN produto ON pedidoItem.CdProduto = produto.CdProduto /**where**/");
        //    queryBuilder.Where("pedido.Numero = @numero", new { numero });

        //    return _connection.Query<PedidoItem>(template.RawSql, template.Parameters).ToList();
        //}
        public List<PedidoItem> ObterListaDeItens(int numero)
        {
            var queryBuilder = new SqlBuilder();
            var template = queryBuilder.AddTemplate(@"SELECT pedidoItem.Id AS Id, pedidoItem.NumeroPedido AS NumeroPedido, pedidoItem.CdProduto AS CdProduto, produto.Descricao AS Descricao, pedidoItem.QtdVenda AS QtdVenda, pedidoItem.VlVenda AS VlVenda, (pedidoItem.VlVenda * pedidoItem.QtdVenda) AS Total FROM pedido INNER JOIN pedidoItem ON pedido.Numero = pedidoItem.NumeroPedido INNER JOIN produto ON pedidoItem.CdProduto = produto.CdProduto /**where**/");
            queryBuilder.Where("pedido.Numero = @numero", new { numero });

            return _connection.Query<PedidoItem>(template.RawSql, template.Parameters).ToList();
        }

        public List<demo01.Domain.Pedidos.Pedido> ListarPedido(string columnSort)
        {
            using (SqlConnection con = ConnectionProvider.ObterConexao())
            {
                var query = new StringBuilder();
                query.AppendLine("SELECT * FROM pedido");
                query.AppendLine("/**orderby**/");

                var queryBuilder = new SqlBuilder();
                var template = queryBuilder.AddTemplate(query.ToString());
                queryBuilder.OrderBy(columnSort);

                return con.Query<Pedido>(template.RawSql, template.Parameters).ToList();
            }
        }

    }
}
