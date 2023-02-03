using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using demo01.Data.Repositories;
using demo01.Domain.Produtos;

namespace demo01.Views.Pedido
{
    public partial class BuscarProduto : MetroFramework.Forms.MetroForm 
    {
        public BuscarProduto()
        {
            InitializeComponent();
            ListarGrid();
        }
        private BindingSource _bsListaProduto;
        private void ListarGrid(string sortColumn = "CdProduto")
        {

            try
            {

                List<Produto> lista = new List<Produto>();
                lista = new ProdutoRepository().ObterTodos(sortColumn);

                _bsListaProduto = new BindingSource(lista, "");
                formBuscarProduto.AutoGenerateColumns = false;
                formBuscarProduto.DataSource = _bsListaProduto;


                return;
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao Listar dados!");
            }
            return;
        }
        private void LerProduto()
        {

            var currentProduto = GetCurrentProduto();
            if (currentProduto != null)
            {
                //txtCdProduto.Text = currentProduto.CdProduto;
                //txtQtd.Text = currentProduto.Estoque.ToString();
                //txtValor.Text = currentProduto.Valor.ToString();
            }
        }
        private Produto GetCurrentProduto()
        {

            if (_bsListaProduto == null || _bsListaProduto.Current == null)
                return null;

            if (_bsListaProduto.Current is Produto currentProduto)
                return currentProduto;

            return null;
        }
    }
}
