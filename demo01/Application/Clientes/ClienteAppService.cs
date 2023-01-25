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
            var resultCliente = cliente.IsValid();
            if (!resultCliente.Success)
            {
                return resultCliente;
            }

            var clienteExiste = new ClienteRepository().clienteExiste(cliente.CdCliente);
            if (!clienteExiste)
            {
                return new ResultCliente(false, "O Cliente não pode ser cadastrado pois o código já está em uso");
            }

            var cpfExiste = new ClienteRepository().ObterPorCpf(cliente.Cpf);
            if (!cpfExiste)
            {
                return new ResultCliente(false, "O Cliente não pode ser cadastrado pois o Cpf já está em uso");
            }

            new ClienteRepository().InsertCliente(cliente);


            return new ResultCliente(true, string.Empty);

        }
        public ResultCliente Editar(Domain.Cliente.Cliente cliente)
        {
            var resultCliente = cliente.IsValid();
                if (!resultCliente.Success)
            {
                return resultCliente;
            }
            var cpfExiste = new ClienteRepository().ObterPorCpf(cliente.Cpf);
            if (!cpfExiste)
            {
                return new ResultCliente(false, "O Cliente não pode ser cadastrado pois o Cpf já está em uso");
            }
            new ClienteRepository().EditarCliente(cliente);
            return new ResultCliente(true, string.Empty);
        }

    }


}
