using demo01.Data.RepositoriesPedido;
using demo01.Domain.Produtos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demo01.Views.Pedido
{
    public partial class BuscarPedido : MetroFramework.Forms.MetroForm
    {
        public BuscarPedido()
        {
            InitializeComponent();
            ListarGrid();
        }
        private BindingSource _bsListaPedido;
        public string ReturnValue;
        private void ListarGrid(string sortColumn = "Numero")
        {

            try
            {

                List<demo01.Domain.Pedidos.Pedido> lista = new List<demo01.Domain.Pedidos.Pedido>();
                lista = new PedidoRepository().ListarPedido(sortColumn);

                _bsListaPedido = new BindingSource(lista, "");
                ListarTodosPedidos.AutoGenerateColumns = false;
                ListarTodosPedidos.DataSource = _bsListaPedido;


                return;
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao Listar dados!");
            }
            return;
        }

        private Produto GetCurrentProduto()
        {

            if (_bsListaPedido == null || _bsListaPedido.Current == null)
                return null;

            if (_bsListaPedido.Current is Produto currentProduto)
                return currentProduto;

            return null;
        }

        private void ListarTodosPedidos_DoubleClick(object sender, EventArgs e)
        {
            if (_bsListaPedido.Current != null && _bsListaPedido.Current is demo01.Domain.Pedidos.Pedido pedido)
            {
                ReturnValue = pedido.Numero;
                this.Close();
            }
        }

        private void ListarTodosPedidos_DoubleClick_1(object sender, EventArgs e)
        {
            if (_bsListaPedido.Current != null && _bsListaPedido.Current is demo01.Domain.Pedidos.Pedido pedido)
            {
                ReturnValue = pedido.Numero;
                this.Close();
            }
        }
    }
}
