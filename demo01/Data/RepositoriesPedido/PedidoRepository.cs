using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using demo01.Domain.Pedido;
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

                var sql = @"
 INSERT INTO produto
 //   (CdProduto,
 //   Descricao,
 //   Estoque,
 //   Valor)
 //OUTPUT INSERTED.CdProduto
 //VALUES
 //   ( @cdproduto,
 //    @descricao,
 //    @estoque,
 //    @valor)";

                var resp = con.ExecuteScalar(sql, new
               {
 //                   cdproduto = produto.CdProduto,
 //                   descricao = produto.Descricao,
 //                   estoque = produto.Estoque,
 //                   valor = produto.Valor,
                });

                if (resp == null)
                {
                    return false;
                }

                return true;

            }

        }
    } 
  
}
