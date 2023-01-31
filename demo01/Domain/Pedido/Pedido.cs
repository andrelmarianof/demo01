using demo01.Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace demo01.Domain.Pedido
{
    class Pedido
    {
        public string CdCPedido { get; set; }
        public string clientePedido { get; set; }
        public string produtoItem { get; set; }
        public decimal QuantidadeItem { get; set; }
        public decimal Valor { get; set; }

        public ResultPedido IsValid()
        {
            var messages = new List<string>();
            if (string.IsNullOrWhiteSpace(CdCPedido))
            {
                messages.Add("O código do cliente está em branco, verifique!");
            }

            if (string.IsNullOrWhiteSpace(clientePedido))
            {
                messages.Add("O nome do cliente está em branco, verifique!");
            }
            if (string.IsNullOrWhiteSpace(produtoItem))
            {
                messages.Add("O Cpf do cliente está em branco, verifique!");
            }
            if (QuantidadeItem > 10000)
            {
                messages.Add("O código do cliente está irregular, verifique!");
            }
            if (clientePedido.Length > 50)
            {
                messages.Add("O nome do cliente está irregular, verifique!");
            }
            return new ResultPedido(messages.Count == 0, messages);
        }
    }
}
