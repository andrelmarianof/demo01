using demo01.Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace demo01.Domain.Produtos
{
    public class Produto
    {
        #region Construtores
        public string CdProduto { get; set; }
        public string Descricao { get; set; }
        public decimal Estoque { get; set; }
        public decimal Valor { get; set; }
        #endregion


        #region Validacao
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
            if (Estoque < 0)
            {
                messages.Add("A quantidade do estoque do produto está em branco, verifique!");
            }
            if (Valor < 0)
            {
                messages.Add("O valor do produto não pode ser negativo, verifique!");
            }
            if (Estoque > 99999)
            {
                messages.Add("O estoque do produto excede a capacidade de digitos, verifique!");
            }
            if (Valor > 99900000)
            {
                messages.Add("O valor do produto excede a capacidade de digitos, verifique!");
            }
            if (Descricao.Length > 32)
            {
                messages.Add("A descrição do produto está irregular, verifique!");
            }
            if (CdProduto.Length > 7)
            {
                messages.Add("O códig do produto pode conter somente 7 digitos, verifique!");
            }
            return new Result(messages.Count == 0, messages);
        }
        #endregion

    }
}
