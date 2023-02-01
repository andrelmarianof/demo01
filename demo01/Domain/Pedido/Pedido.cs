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
        public string Numero { get; set; }
        public string CdCliente { get; set; }
        public string NumeroPedido { get; set; }
        public string CdProduto { get; set; }
        public decimal QtdVenda { get; set; }
        public decimal VlVenda { get; set; }

        //public ResultPedido IsValid()
        //{
        //    //var messages = new List<string>();
        //    //if (string.IsNullOrWhiteSpace())
        //    //{
        //    //    messages.Add("O código do pedido está em branco, verifique!");
        //    //}

        //    //if (string.IsNullOrWhiteSpace(clientePedido))
        //    //{
        //    //    messages.Add("O nome do cliente está em branco, verifique!");
        //    //}
        //    //if (produtoItem == " ")
        //    //{
        //    //    messages.Add("O pedido não contem produtos, verifique!");
        //    //}
        //    //if (QuantidadeItem == 0)
        //    //{
        //    //    messages.Add("O produto x não possui quantidade, verifique!");
        //    //}
        //    //return new ResultPedido(messages.Count == 0, messages);
        //}
    }
}
