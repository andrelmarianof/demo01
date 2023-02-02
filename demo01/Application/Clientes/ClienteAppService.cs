using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using demo01.Domain.Cliente;
using demo01.Data.RepositoriesCliente;
using demo01.Domain.Core;

namespace demo01.Views.Pedidos
{
    public class ClienteAppService
    {
        public ResultCliente Inserir(Domain.Cliente.Cliente cliente)
        {

            //cliente.IsEmpresa();
            var validation = cliente.IsValid();
            if (!validation.Success) return validation;

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
}
