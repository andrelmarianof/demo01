using demo01.Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using demo01.Domain.Produtos;

namespace demo01.Domain.Pedidos
{
    class Pedido
    {
        public string Numero { get; set; }
        public string CdCliente { get; set; }
        public string NumeroPedido { get; set; }
        public string CdProduto { get; set; }
        public decimal QtdVenda { get; set; }
        public decimal VlVenda { get; set; }

        public ResultPedido IsValid()
        {
            var messages = new List<string>();
            if (string.IsNullOrWhiteSpace(NumeroPedido))
            {
                messages.Add("O código do pedido está em branco, verifique!");
            }

            if (string.IsNullOrWhiteSpace(CdProduto))
            {
                messages.Add("Selecione um cliente para que possa realizar um pedido, verifique!");
            }
            if (NumeroPedido == Numero)
            {
                messages.Add("Ocorreu um erro no vinculo do pedido, tente novamente!");
            }
            if (QtdVenda == 0)
            {
                messages.Add("Insira quantidade ao produto para adiciona-lo ao pedido");
            }
            if (VlVenda < 0)
            {
                messages.Add("O valor do produto não pode ser negativo, verifique!");
            }
            
            return new ResultPedido(messages.Count == 0, messages);
        }
        public ResultPedido IsValidCriar()
        {
            var messages = new List<string>();
            if (string.IsNullOrWhiteSpace(CdCliente))
            {
                messages.Add("O código do Cliente está em branco, verifique!");
            }

           
            return new ResultPedido(messages.Count == 0, messages);
        }
    }
}
