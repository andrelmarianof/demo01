using System;
using System.Windows.Forms;
using demo01.Application.Pedidos;
using demo01.Domain.Pedidos;
using demo01.Data.RepositoriesPedido;
using demo01.Domain.Produtos;
using demo01.Views.Pedido;
using System.Collections.Generic;
using demo01.Data.RepositoriesCliente;

namespace demo01.Views.Pedido
{
   
    public partial class PedidoView : MetroFramework.Forms.MetroForm
    {
        private object sortColumn;
        private BindingSource _bsListaCliente;
        private BindingSource _bsListaProduto;
        private object listaprodutos;

        public string CdProduto { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }


        public PedidoView()
        {
            InitializeComponent();
            NovoPedido();
            

        }
        private void Inserir()
        {
            if ((txtCdCliente.Text != "") & (txtDescricaoCliente.Text != "") & (txtCdProduto.Text != "") & (txtDescricaoProduto.Text != ""))
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
            txtDescricaoProduto.Enabled = false;
            txtValor.Enabled = false;
            txtQtd.Enabled = false;
        }
        private void LimparCampos()
        {
            txtCdCliente.Text = " ";
            txtDescricaoCliente.Text = " ";
            txtCdProduto.Text = " ";
            txtDescricaoProduto.Text = " ";
            txtValor.Text = " ";
            txtQtd.Text = " ";
        }
        private void InserirProdutos()
        {
            txtCdCliente.Enabled = false;
            txtDescricaoCliente.Enabled = false;
            txtCdProduto.Enabled = true;
            txtDescricaoProduto.Enabled = true;
            txtValor.Enabled = true;
            txtQtd.Enabled = true;
            btnNovoPedido.Enabled = false;
            btnPesquisarCliente.Enabled = false;
            txtCdProduto.Text = " ";
            txtDescricaoProduto.Text = " ";
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

        public void btnNovoPedido_Click(object sender, EventArgs e)
        {
         
            if ((txtCdCliente.Text != "")&(txtDescricaoCliente.Text != ""))
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
                    var result = new PedidoAppService().ValidarCliente(pedido);
                    if (result.Success)
                    {
                        MessageBox.Show(string.Format("Pedido criado com sucesso, realize a inserção dos produto"));
                        InserirProdutos();
                    }
                    else
                    {
                        MessageBox.Show("O cliente não existe na base de dados");

                    }

                }
                catch
                {
                    MessageBox.Show(string.Format("Selecione um cliente para que possa gerar um pedido!"));
                }
            }
            else
            {
                MessageBox.Show(string.Format("Selecione um cliente para que possa gerar um pedido!"));
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

            public void PedidoView_Load(object sender, EventArgs e)
        {
            //txtCdCliente.Text = BuscarProduto.
            //txtCdProduto.Text = CdProduto;
            //txtCescricaoProduto.Text = Descricao;
            //txtValor.Text = Valor.ToString();
        }

        private void btnAddProduto_Click(object sender, EventArgs e)
        {
            if ((txtCdProduto.Text != " ") & (txtDescricaoProduto.Text != " ")&(txtQtd.Text != " ")&(txtValor.Text != " "))
            {
                try
                {
                    var pedido = new Domain.Pedidos.Pedido();
                    pedido.CdProduto = txtCdProduto.Text.Trim();
                    pedido.NumeroPedido = TxtNumero.Text.Trim();
                    decimal valorProduto;
                    if (!decimal.TryParse(txtValor.Text.Trim(), out valorProduto))
                    {
                        MessageBox.Show(string.Format("Valor informado não é válido!"));
                        return;
                    }
                    decimal quantidade;
                    if (!decimal.TryParse(txtQtd.Text.Trim(), out quantidade))
                    {
                        MessageBox.Show(string.Format("Valor informado para quantidade não é válido!"));
                        return;
                    }
                    var result = new PedidoAppService().ValidarProduto(pedido);

                    if (result.Success)
                    {
                        MessageBox.Show(string.Format("Produto Inserido com sucesso!"));
                        InserirProdutos();
                        ListarProdutos(nameof(Domain.Pedidos.Pedido.NumeroPedido));
                    }
                    else
                    {
                        MessageBox.Show("Produto não cadastrado!");

                    }

                }
                catch
                {
                    MessageBox.Show(string.Format("Selecione um produto para que possa inserir no pedido!"));
                }
            }
            else
            {
                MessageBox.Show(string.Format("Selecione um produto para que possa inserir no pedido!"));
            }
        }
        private void ListarProdutos(string sortColumn = "CdCliente")
        {
            //try
            //{
            //    List<Produto> lista = new List<Produto>();
            //    lista = new PedidoRepository().ObterTodosProdutosPorNumeroPedido(pedido);
            //    _bsListaProduto = new BindingSource(lista, "");
            //    ListaProdutosDoPedido.AutoGenerateColumns = false;
            //    ListaProdutosDoPedido.DataSource = _bsListaProduto;
            //}
            //catch (Exception)
            //{
            //    MessageBox.Show("Erro ao listar produtos!");
            //}
            
                try
                {


                    List<Domain.Pedidos.Pedido> lista1 = new List<Domain.Pedidos.Pedido>();
                    lista1 = new PedidoRepository().ObterTodosProdutosPorNumeroPedido(sortColumn);


                    _bsListaCliente = new BindingSource(lista1, "");
                     ListaProdutosDoPedido.AutoGenerateColumns = false;
                      ListaProdutosDoPedido.DataSource = _bsListaCliente;

                }
                catch (Exception)
                {
                    MessageBox.Show("Erro ao Listar dados!");
                }
                return;
            }
        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSalvarPedido_Click(object sender, EventArgs e)
        {
            LimparCampos();
            MessageBox.Show(string.Format("Pedido salvo com sucesso!!"));
            TxtNumero.Text= "";
        }
    }
}
