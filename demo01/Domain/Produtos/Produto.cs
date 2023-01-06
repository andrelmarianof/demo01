using demo01.Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo01.Domain.Produtos
{
    public class Produto
    {
        public string CdProduto { get; set; }
        public string Descricao { get; set; }
        public decimal Estoque { get; set; }
        public decimal Valor { get; set; }

        public Result IsValid()
        {
            var messages = new List<string>();

            if (string.IsNullOrWhiteSpace(CdProduto))
            {
                messages.Add("O código do produto está em branco, verifique!");
            }

            if (string.IsNullOrWhiteSpace(Descricao))
            {
                messages.Add("A descrição do produto está em branco, verifique!");
            }
        //    if (Estoque == null)
        //    {
        //        messages.Add("A quantidade do estoque do produto está em branco, verifique!");
        //      }
        //      if (Valor == null)
        //      {
        //           return new Result(messages.Count == 0, messages);
        //       }
       //        messages.Add("O valor do produto está em branco, verifique!");
              return new Result(messages.Count == 0, messages);
        }
    }
}
