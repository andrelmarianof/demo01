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
        public ResultCliente Inserir(Clientes cliente)
        {
            var resultCliente = cliente.IsValid();
            if (!resultCliente.Success)
            {
                return resultCliente;
                //Gravar no repositrio
                // new ProdutoRepository().Inserir(produto);
            }
            new ClienteRepository().InsertCliente(cliente);


            return new ResultCliente(true, string.Empty);


        }
    }


}
