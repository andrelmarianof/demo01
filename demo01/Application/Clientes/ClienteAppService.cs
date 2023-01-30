using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using demo01.Domain.Cliente;
using demo01.Data.RepositoriesCliente;
using demo01.Domain.Core;

namespace demo01.Views.Pedido
{
    public class ClienteAppService
    {
        public ResultCliente Inserir(Domain.Cliente.Cliente cliente)
        {
            if (!IsValid(cliente, out var resultCliente)) return resultCliente;

            var clienteExiste = new ClienteRepository().ObterPorCodigo(cliente.CdCliente);
            if (clienteExiste != null)
            {
                return new ResultCliente(false, "O Cliente não pode ser cadastrado pois o código já está em uso");
            }

            var clienteBaseCPF = new ClienteRepository().ObterPorCpf(cliente.Cpf);
            if (clienteBaseCPF != null)
            {
                return new ResultCliente(false, $"O Cliente não pode ser cadastrado pois o Cpf já está em uso por {clienteBaseCPF.CdCliente.Trim()} - {clienteBaseCPF.NomeCliente.Trim()}");
            }

            new ClienteRepository().InsertCliente(cliente);


            return new ResultCliente(true, string.Empty);

        }
        public ResultCliente Editar(Domain.Cliente.Cliente cliente)
        {
            if (!IsValid(cliente, out var resultCliente)) return resultCliente;

            var clienteBaseCPF = new ClienteRepository().ObterPorCpf(cliente.Cpf);
            if (clienteBaseCPF != null && (clienteBaseCPF.CdCliente ?? "").Trim()
                                            .Equals((cliente.CdCliente ?? "").Trim(), StringComparison.InvariantCultureIgnoreCase))
            {
                return new ResultCliente(false, $"O Cliente não pode ser cadastrado pois o Cpf já está em uso por {clienteBaseCPF.CdCliente.Trim()} - {clienteBaseCPF.NomeCliente.Trim()}");
            }

            new ClienteRepository().EditarCliente(cliente);
            return new ResultCliente(true, string.Empty);
        }
        private bool IsValid(Domain.Cliente.Cliente cliente, out ResultCliente resultCliente)
        {
            resultCliente = cliente.IsValid();
            return resultCliente.Success;
        }
    }
}
