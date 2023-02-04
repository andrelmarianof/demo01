using System;
using System.Windows.Forms;
using demo01.Application.Pedidos;
using demo01.Domain.Pedidos;
using demo01.Data.RepositoriesPedido;
using demo01.Domain.Produtos;

namespace demo01.Views.Pedido
{
   
    public partial class PedidoView : MetroFramework.Forms.MetroForm
    {
        private object sortColumn;
        private BindingSource _bsListaCliente;
        private BindingSource _bsListaProduto;



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
        private void LimparCampos()
        {
            txtCdCliente.Text = " ";
            txtDescricaoCliente.Text = " ";
            txtCdProduto.Text = " ";
            txtCescricaoProduto.Text = " ";
            txtValor.Text = " ";
            txtQtd.Text = " ";
        }
        private void InserirProdutos()
        {
            txtCdCliente.Enabled = false;
            txtDescricaoCliente.Enabled = false;
            txtCdProduto.Enabled = true;
            txtCescricaoProduto.Enabled = true;
            txtValor.Enabled = true;
            txtQtd.Enabled = true;
            btnNovoPedido.Enabled = false;
            btnPesquisarCliente.Enabled = false;
            txtCdProduto.Text = " ";
            txtCescricaoProduto.Text = " ";
            txtValor.Text = " ";
            txtQtd.Text = " ";
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
                    string numero = new PedidoAppService().BuscarNumero();
                    int txtnumero = int.Parse(numero);
                    txtnumero++;
                    TxtNumero.Text = txtnumero.ToString();
                    var pedido = new Domain.Pedidos.Pedido();
                    pedido.Numero = txtnumero.ToString();
                    pedido.CdCliente = txtCdCliente.Text.Trim();
                    var result = new PedidoAppService().Inserir(pedido);
                    
                    if (result.Success)
                    {
                        MessageBox.Show(string.Format("Pedido criado com sucesso, realize a inserção dos produto"));
                        InserirProdutos();
                    }
                    else
                    {
                        MessageBox.Show("Ocorreu um erro verifique");

                    }

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
            DialogResult dialogResult = formproduto.ShowDialog();
            txtCdCliente.Text = formproduto.Text;
        }
        public void CarregaForm(string cdcliente)
        {
           
        }

            private void PedidoView_Load(object sender, EventArgs e)
        {

        }

        private void btnAddProduto_Click(object sender, EventArgs e)
        {
            if ((txtCdProduto.Text != " ") & (txtCescricaoProduto.Text != " ")&(txtQtd.Text != " ")&(txtValor.Text != " "))
            {
                try
                {
                    var pedido = new Domain.Pedidos.Pedido();
                    pedido.CdProduto = txtCdProduto.Text.Trim();
                    pedido.NumeroPedido = TxtNumero.Text.Trim();
                    decimal valorProduto;
                    if (!decimal.TryParse(txtValor.Text.Trim(), out valorProduto))
                    {
                        MessageBox.Show(string.Format("Valor informado para valor não é válido!"));
                        return;
                    }
                    decimal quantidade;
                    if (!decimal.TryParse(txtQtd.Text.Trim(), out quantidade))
                    {
                        MessageBox.Show(string.Format("Valor informado para quantidade não é válido!"));
                        return;
                    }
                    var result = new PedidoAppService().InserirProduto(pedido);

                    if (result.Success)
                    {
                        MessageBox.Show(string.Format("Produto Inserido com sucesso!"));
                        InserirProdutos();
                    }
                    else
                    {
                        MessageBox.Show("Ocorreu um erro verifique");

                    }

                }
                catch
                {
                    MessageBox.Show(string.Format("Selecione um cliente para que possa gerar um pedido!"));
                }
            }
        }
    }
}
