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
            var result = produto.IsValid();
            if (!result.Success)
            {
                return result;
            }

            var produtoExistente = new ProdutoRepository().ObterPorCodigo(produto.CdProduto);
            if (!produtoExistente)
            {
                return new Result(false, "O Produto não pode ser cadastrado pois o código já está em uso");
            }

            new ProdutoRepository().InsertProduto(produto);

            return new Result(true, string.Empty);

        }

        public Result Atualizar(Produto produto)
        {
            var result = produto.IsValid();
            if (!result.Success)
            {
                return result;
            }

            new ProdutoRepository().UpdateProduto(produto);
            return new Result(true, string.Empty);
        }
    }
}
