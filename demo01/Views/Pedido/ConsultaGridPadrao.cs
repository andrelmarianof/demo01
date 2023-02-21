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
using demo01.Data.RepositoriesCliente;
using demo01.Data.RepositoriesPedido;
using demo01.Domain.Produtos;

namespace demo01.Views.Pedido
{
    public partial class ConsultaGridPadrao : MetroFramework.Forms.MetroForm
    {

        public string ReturnValue;

        public ConsultaGridPadrao()
        {
            InitializeComponent();
        }
        private BindingSource _bsListaProduto;

        public void ConfigurarColunasProduto()
        {
            GridDeConsultasGenerico.Columns.Add("CdProduto", "Código");
            GridDeConsultasGenerico.Columns["CdProduto"].DataPropertyName = "CdProduto";
            GridDeConsultasGenerico.Columns.Add("Descricao", "Descrição");
            GridDeConsultasGenerico.Columns["Descricao"].DataPropertyName = "Descricao";
            GridDeConsultasGenerico.Columns.Add("Estoque", "Estoque Disponivel");
            GridDeConsultasGenerico.Columns["Estoque"].DataPropertyName = "Estoque";
            GridDeConsultasGenerico.Columns.Add("Valor", "Preço");
            GridDeConsultasGenerico.Columns["Valor"].DataPropertyName = "Valor";
            GridDeConsultasGenerico.AutoGenerateColumns = false;
        }

        public void ConfigurarColunasPedido()
        {
            GridDeConsultasGenerico.Columns.Add("Numero", "Numero do Pedido");
            GridDeConsultasGenerico.Columns["Numero"].DataPropertyName = "Numero";
            GridDeConsultasGenerico.Columns.Add("cdCliente", "Nome do cliente");
            GridDeConsultasGenerico.Columns["cdCliente"].DataPropertyName = "cdCliente";
            GridDeConsultasGenerico.AutoGenerateColumns = false;
        }

        public void ConfigurarColunasClientes()
        {
            GridDeConsultasGenerico.Columns.Add("CdCliente", "Código");
            GridDeConsultasGenerico.Columns["CdCliente"].DataPropertyName = "CdCliente";
            GridDeConsultasGenerico.Columns.Add("NomeCliente", "Nome do Cliente");
            GridDeConsultasGenerico.Columns["NomeCliente"].DataPropertyName = "NomeCliente";
            GridDeConsultasGenerico.AutoGenerateColumns = false;
        }

        private List<Domain.Pedidos.Pedido> GetPedidos()
        {
            var Pedido = new List<Domain.Pedidos.Pedido>();
            Pedido.Add(new Domain.Pedidos.Pedido() { Numero = 01, CdCliente = "01" });
            Pedido.Add(new Domain.Pedidos.Pedido() { Numero = 02, CdCliente = "02" });
            return Pedido;
        }

        private List<Domain.Produtos.Produto> GetProdutos()
        {
            var produtos = new List<Produto>();
            produtos.Add(new Produto() { CdProduto = "01", Descricao = "DEscr 01" });
            produtos.Add(new Produto() { CdProduto = "02", Descricao = "DEscr 02" });
            return produtos;
        }
        private List<Domain.Clientes.Cliente> GetClientes()
        {
            var clientes = new List<Domain.Clientes.Cliente>();
            clientes.Add(new Domain.Clientes.Cliente() { CdCliente = "01", NomeCliente = "Nome 01" });
            clientes.Add(new Domain.Clientes.Cliente() { CdCliente = "02", NomeCliente = "Nome 02" });
            return clientes;
        }

        public void PopularGridProdutos()
        {
            ConfigurarColunasProduto();

            var produtoRepository = new ProdutoRepository();
            var produtos = produtoRepository.ObterTodos("1");
            if (produtos != null && produtos.Any())
            {
                GridDeConsultasGenerico.DataSource = produtos;
            }
            else
            {
                MessageBox.Show("Nenhum produto encontrado.");
            }

        }

        public void PopularGridDePedidos()
        {
            ConfigurarColunasPedido();
            var pedidoRepository = new PedidoRepository();
            var pedidos = pedidoRepository.ListarPedido("1");
            if (pedidos != null && pedidos.Any())
            {
                GridDeConsultasGenerico.DataSource = pedidos;
            }
            else
            {
                MessageBox.Show("Nenhum produto encontrado.");
            }
        }

        public void PopularGridDeClientes()
        {
            ConfigurarColunasClientes();
            var clienteRepository = new ClienteRepository();
            var clientes = clienteRepository.ListarClientes("1");
            if (clientes != null && clientes.Any())
            {
                GridDeConsultasGenerico.DataSource = clientes;
            }
            else
            {
                MessageBox.Show("Nenhum produto encontrado.");
            }
        }
    }
}
