using demo01.Domain.Core;
using System.Collections.Generic;

namespace demo01.Domain.Pedidos
{
    class Pedido
    {
        #region Construtores
        public string Numero { get; set; }
        public string CdCliente { get; set; }
        public string NumeroPedido { get; set; }
        public string CdProduto { get; set; }
        public decimal QtdVenda { get; set; }
        public decimal VlVenda { get; set; }
        #endregion

        #region Validaçoes
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
        public ResultPedido IsValidInserirProduto()
        {
            var messages = new List<string>();
            if (string.IsNullOrWhiteSpace(CdProduto))
            {
                messages.Add("O código do produto está em branco, verifique!");
            }
            if (QtdVenda == 0)
            {
                messages.Add("Insira quantidade ao produto para adiciona-lo ao pedido");
            }
            if (QtdVenda < 0)
            {
                messages.Add("Insira quantidade ao produto para adiciona-lo ao pedido");
            }
            if (VlVenda < 0)
            {
                messages.Add("O valor do produto não pode ser negativo, verifique!");
            }
            if (VlVenda == 0)
            {
                messages.Add("O valor do produto não pode ser zero, verifique!");
            }
            return new ResultPedido(messages.Count == 0, messages);
        }
        #endregion

    }
}
