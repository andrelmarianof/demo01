using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace demo01.Views.Produtos
{
    public class produtomodel
    {
       
        public static int Inserir(produtoent objTabela)
        {
            return new produtodb().Inserir(objTabela);
        }
        public List<produtoent> Lista(produtoent objTabela)
        {
            return new produtodb().Lista(objTabela);
        }
        public static int Editar(produtoent objtabela)
        {
            return new produtodb().Editar(objtabela);
        }

    }
}

