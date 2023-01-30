using demo01.Data.Repositories;
using demo01.Domain.Core;
using demo01.Domain.Produtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo01.App.Produtos
{
    public class ProdutoAppService
    {
        public Result Inserir(Produto produto)
        {
            if (!IsValid(produto, out var result)) return result;

            var produtoExistente = new ProdutoRepository().ObterPorCodigo(produto.CdProduto);

            if (produtoExistente != null )
            {
                return new Result(false, "O Produto não pode ser cadastrado pois o código já está em uso");
            }

            new ProdutoRepository().InsertProduto(produto);

            return new Result(true, string.Empty);
        }

        public Result Editar(Produto produto)
        {
            if (!IsValid(produto, out var result)) return result;

            new ProdutoRepository().UpdateProduto(produto);
            return new Result(true, string.Empty);
        }
        private bool IsValid(Domain.Produtos.Produto produto, out Result result)
        {
            result = produto.IsValid();
            return result.Success;
        }
    }
}
