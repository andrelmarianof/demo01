using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo01.Views.Produtos
{
  public  class produtoent
    {
        private decimal idproduto;
        private string cdproduto;
        private decimal valor;
        private decimal estoque;

        public decimal Id { get => idproduto; set => idproduto = value; }
        public string Descricao { get => cdproduto; set => cdproduto = value; }
        public decimal Quantidade { get => estoque; set => estoque = value; }
        public decimal Valor { get => valor; set => valor = value; }
    }
}
