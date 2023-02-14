using demo01.Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo01.Domain.Pedido
{
    #region Construtores
    public class PedidoItem
    {
        public int NumeroPedido { get; set; }
        public string CdProduto { get; set; }
        public string Descricao { get; set; }
        public decimal QtdVenda { get; set; }
        public decimal VlVenda { get; set; }
        public decimal Total { get; set; }
        public Guid Id { get; set; }

        #endregion

        #region Validações
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
