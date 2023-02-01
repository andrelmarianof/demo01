using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using demo01.Data.Repositories;
using demo01.Domain.Core;
using demo01.Domain.Produtos;
using demo01.Domain.Pedido;

namespace demo01.Application.Pedidos
{
    class PedidoAppService
    {
        public ResultPedido InserirPedido(Pedido pedido)
        {
            var validation = pedido.IsValid();
            if (!validation.Success) return validation;
           
                return new ResultPedido(false, "O Cliente não pode ser cadastrado pois o Cpf já está em uso por aseCPF.NomeCliente.Trim()");
           

        }
        public ResultCliente Editar(Domain.Cliente.Cliente cliente)
        {
            var validation = cliente.IsValid();
            if (!validation.Success) return validation;

            var clienteBaseCPF = new ClienteRepository().ObterPorCpf(cliente.Cpf);
            if (clienteBaseCPF != null && (clienteBaseCPF.CdCliente ?? "").Trim()
                                            .Equals((cliente.CdCliente ?? "").Trim(), StringComparison.InvariantCultureIgnoreCase))
            {
                return new ResultCliente(false, $"O Cliente não pode ser cadastrado pois o Cpf já está em uso por {clienteBaseCPF.CdCliente.Trim()} - {clienteBaseCPF.NomeCliente.Trim()}");
            }

            new ClienteRepository().EditarCliente(cliente);
            return new ResultCliente(true, string.Empty);
        }
    }

