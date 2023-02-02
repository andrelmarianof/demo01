using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using demo01.Domain.Pedidos;
using demo01.Application.Pedidos; 
using System.Data.SqlClient;
using demo01.Data.Provider;
using Dapper;

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

                if ((resp2 == null)&(resp2 == null))
                {
                    return false;
                }
                return true;

            }

        }
    } 
  
}
