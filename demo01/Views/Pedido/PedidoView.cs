using System;
using System.Windows.Forms;
using demo01.Application.Pedidos;
using demo01.Domain.Pedidos;
using demo01.Domain.Pedidos;

namespace demo01.Views.Pedido
{
   
    public partial class PedidoView : MetroFramework.Forms.MetroForm
    {
        private object sortColumn;
        private BindingSource _bsListaCliente;

       
        public PedidoView()
        {
            InitializeComponent();
            NovoPedido();

        }
        private void Inserir()
        {
            if ((txtCdCliente.Text != "") & (txtDescricaoCliente.Text != "") & (txtCdProduto.Text != "") & (txtCescricaoProduto.Text != ""))
            {

                try
                {
                    var pedido = new Domain.Pedidos.Pedido();

                }
                catch
                {

                }
            }
        }
        private void NovoPedido()
        {
            txtCdCliente.Enabled = true;
            txtDescricaoCliente.Enabled = true;
            txtCdProduto.Enabled = false;
            txtCescricaoProduto.Enabled = false;
            txtValor.Enabled = false;
            txtQtd.Enabled = false;
        }

        private void cdCliente_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnPesquisarCliente_Click(object sender, EventArgs e)
        {
            BuscarCliente formcliente = new BuscarCliente();
            formcliente.ShowDialog();
        }

        private void btnNovoPedido_Click(object sender, EventArgs e)
        {
         
            if ((txtCdCliente.Text != " ")&(txtDescricaoCliente.Text != " "))
            {
                try
                {
                     var pedido = new Pe();
                   // pedido.Numero = "2";
                   // pedido.CdCliente = txtCdCliente.Text.Trim();
                   // var result = new PedidoAppService().Inserir(pedido);
                   //
                   // if (result.Success)
                   // {
                   //     MessageBox.Show(string.Format("Pedido criado com sucesso, realize a inserção dos produto"));
                   // 
                   // }
                   // else
                   // {
                   //     MessageBox.Show("Ocorreu um erro verifique");
                   //
                   // }

                }
                catch
                {
                    MessageBox.Show(string.Format("Selecione um cliente para que possa gerar um pedido!"));
                }
            }
        }

        private void btnPesquisarProduto_Click(object sender, EventArgs e)
        {
            BuscarProduto formproduto = new BuscarProduto();
            formproduto.ShowDialog();
        }

        private void PedidoView_Load(object sender, EventArgs e)
        {

        }
    }
}
