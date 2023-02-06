using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo01.Domain.Pedido
{
    class PedidoItem
    {
        public int NumeroPedido { get; set; }
        public int CdProduto { get; set; }
        public string Descricao { get; set; }
        public decimal QtdVenda { get; set; }
        public decimal VlVenda { get; set; }
    }
}
