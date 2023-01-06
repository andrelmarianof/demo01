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
                //Gravar no repositrio
                // new ProdutoRepository().Inserir(produto);
            }
            var produtoExistente = new ProdutoRepository().ObterPorCodigo(produto.CdProduto);

            if (produtoExistente != null)
            {
                return new Result(false, "O Produto não pode ser cadastrado pois o código já está em uso");
            }
            new ProdutoRepository().Inserir(produto);

            return new Result(true, string.Empty);


        }

        public void Atualizar()
        {

        }

        public void Excluir(Produto produto)
        {

            new ProdutoRepository().Excluir(produto);

        }
        public Result ExcluirComValidacao(Produto produto)
        {

            if (ExistePedidoComEsteProduto(produto))
                return new Result(false, new List<string>() { "Você não pode excluir o produto, pois ele está em uso em pedidos!" });

            if (new ProdutoRepository().Excluir(produto) > 0)
                return new Result(true, "");

            return new Result(false, new List<string>() { "Houve um erro ao tentar excluir o produto!" });

        }

        private bool ExistePedidoComEsteProduto(Produto produto)
        {
            //bool PedidoRepository().ExistePedidoComEsteProduto(produto.Codigo)
            return true;
        }
    }
}
