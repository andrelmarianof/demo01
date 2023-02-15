using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using demo01.Data.Repositories;
using demo01.Domain.Core;
using demo01.Domain.Produtos;
using demo01.Data.RepositoriesPedido;
using demo01.Domain.Pedidos;
using demo01.Data.RepositoriesCliente;
using demo01.Domain.Clientes;
using demo01.Domain.Pedido;

namespace demo01.Application.Pedidos
{
    class PedidoAppService
    {
        public ResultPedido Inserir(Pedido pedido)
        {
            var validation = pedido.IsValidCriar();
            if (!validation.Success) return validation;


            new PedidoRepository().InsertPedido(pedido);

            return new ResultPedido(true, string.Empty);
        }
        public ResultPedido ValidarCliente(Pedido pedido)
        {
            var clienteExiste = new ClienteRepository().ObterPorCodigo(pedido.CdCliente);
            if (clienteExiste != null)

            {
                var pedido1 = new Domain.Pedidos.Pedido();
                var result1 = new PedidoAppService().Inserir(pedido);
                return new ResultPedido(true, "");
            }
            return new ResultPedido(false, string.Empty);
        }
        public ResultPedido InserirProduto(PedidoItem pedido)
        {
            var validation = pedido.IsValidInserirProduto();
            if (!validation.Success) return validation;

            new PedidoRepository().InsertProduto(pedido);

            return new ResultPedido(true, string.Empty);
        }
        public ResultPedido ValidarProduto(PedidoItem pedido)
        {
            var produtoExiste = new ProdutoRepository().ObterProdutoPorCodigo(pedido.CdProduto);
            if (produtoExiste != null)
            {
                //var pedido1 = new Domain.Pedidos.Pedido();
                var result1 = new PedidoAppService().InserirProduto(pedido);
                return new ResultPedido(true, "");
            }
            return new ResultPedido(false, string.Empty);
        }

        public string BuscarNumero()
        {
            var numero = new PedidoRepository().ConsultarUltimoPedido();
            return numero;

        }
    }
}


