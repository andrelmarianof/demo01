using demo01.Domain.Core;
using System.Collections.Generic;

namespace demo01.Domain.Pedidos
{
    class Pedido
    {
        #region Construtores
        public int Numero { get; set; }
        public string CdCliente { get; set; }
        #endregion

        #region Validaçoes
        public ResultPedido IsValid()
        {
            var messages = new List<string>();
            if (Numero < 0)
            {
                messages.Add("O código do pedido está em branco, verifique!");
            }

            if (string.IsNullOrWhiteSpace(CdCliente))
            {
                messages.Add("Selecione um cliente para que possa realizar um pedido, verifique!");
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
            if (Numero == 0)
            {
                messages.Add("Ocorreu um problema na criação do pedido, verifique!");
            }
            return new ResultPedido(messages.Count == 0, messages);
        }
        #endregion

    }
}
