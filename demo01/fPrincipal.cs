using demo01.Views.Produtos;
using demo01.Views.Pedido;
using demo01.Views.Cliente;
using System;
using System.Windows.Forms;
using demo01.Views.Relatorios.relatorioProduto;
using demo01.Views.Relatorios.relatorioCliente;
using demo01.Views.Relatorios.relatoriopedido;

namespace demo01
{
    public partial class fPrincipal : Form
    {

        public fPrincipal()
        {
            InitializeComponent();

            this.produtoToolStripMenuItem.Click += mnufProdutos_Click;
            this.pedidoToolStripMenuItem.Click += mnuPedido_Click;
            this.clienteToolStripMenuItem.Click += mnuCliente_click;
            this.clientesToolStripMenuItem.Click += mnurelatoriocliente_click;
            this.produtosToolStripMenuItem.Click += mnurelatorioproduto_click;
            this.pedidosToolStripMenuItem.Click += mnurelatoriopedido_click;

        }
        private void mnufProdutos_Click(object arg1, EventArgs arg2)
        {
            try
            {
                this.Text = "";

                var formfProduto = new ProdutoView();
                formfProduto.MdiParent = this;

                formfProduto.Show();// Apenas chama
                //formProduto.ShowDialog();// Mostra e aguarda
            }
            catch (Exception exe)
            {
                MessageBox.Show("Ocorreu um erro");
            }
        }
        private void mnuPedido_Click(object arg1, EventArgs arg2)
        {
            try
            {
                this.Text = "";

                var formPedido = new PedidoView();
                formPedido.MdiParent = this;

                formPedido.Show();// Apenas chama
                //formProduto.ShowDialog();// Mostra e aguarda
            }
            catch (Exception exe)
            {
                MessageBox.Show("Ocorreu um erro");
            }
        }
        private void mnurelatoriopedido_click(object arg1, EventArgs arg2)
        {
            try
            {
                this.Text = "";

                var formPedido = new RelatorioPedidoView();
                formPedido.MdiParent = this;

                formPedido.Show();// Apenas chama
                //formProduto.ShowDialog();// Mostra e aguarda
            }
            catch (Exception exe)
            {
                MessageBox.Show("Ocorreu um erro");
            }
        }
        private void mnuCliente_click(object arg1, EventArgs arg2)
        {
            try
            {
                this.Text = "";

                var formfCliente = new ClienteView();
                formfCliente.MdiParent = this;

                formfCliente.Show();// Apenas chama
                //formProduto.ShowDialog();// Mostra e aguarda
            }
            catch (Exception exe)
            {
                MessageBox.Show("Ocorreu um erro");
            }
        }
        private void mnurelatoriocliente_click(object arg1, EventArgs arg2)
        {
            try
            {
                this.Text = "";

                var formfCliente = new RelatorioClienteView();
                formfCliente.MdiParent = this;

                formfCliente.Show();// Apenas chama
                //formProduto.ShowDialog();// Mostra e aguarda
            }
            catch (Exception exe)
            {
                MessageBox.Show("Ocorreu um erro");
            }
        }
        private void mnurelatorioproduto_click(object arg1, EventArgs arg2)
        {
            try
            {
                this.Text = "";

                var formfCliente = new RelatorioProdutosView();
                formfCliente.MdiParent = this;

                formfCliente.Show();// Apenas chama
                //formfCliente.ShowDialog(relatorioProdutos.ActiveForm);// Mostra e aguarda
            }
            catch (Exception exe)
            {

               MessageBox.Show("Ocorreu um erro");
            }
        }
       
        private void fPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void pedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fprodutoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mnuPrincipal_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
