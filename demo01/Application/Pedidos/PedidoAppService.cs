using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using demo01.Data.Repositories;
using demo01.Domain.Core;
using demo01.Domain.Produtos;
using demo01.Domain.Pedido;
using demo01.Data.RepositoriesPedido;
namespace demo01.Application.Pedidos
{
    class PedidoAppService
    {
        public ResultPedido Inserir (Pedido pedido)
        {
            var validation = pedido.IsValid();
            if (!validation.Success) return validation;

            new PedidoRepository().InsertPedido(pedido);

            return new ResultPedido(true, string.Empty);
        }
    }

}

