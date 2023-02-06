using System;
using System.Windows.Forms;
using demo01.Application.Pedidos;
using demo01.Domain.Pedidos;
using demo01.Data.RepositoriesPedido;
using demo01.Domain.Produtos;
using demo01.Views.Pedido;
using System.Collections.Generic;
using demo01.Data.RepositoriesCliente;
using demo01.Domain.Pedidos;
using System.Diagnostics;

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
            btnSalvarPedido.Enabled = false;
            btnAddProduto.Enabled = false;
            btnPesquisarProduto.Enabled = false;


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
        private void confirmarPedido()
        {
            txtCdProduto.Enabled = false;
            txtDescricaoProduto.Enabled = false;
            txtQtd.Enabled = false;
            txtValor.Enabled = false;
            btnAddProduto.Enabled = false;
            btnAddProduto.Enabled = false;
            btnNovoPedido.Enabled = true;
            btnPesquisarCliente.Enabled = true;
            txtCdCliente.Enabled = true;
            txtDescricaoCliente.Enabled = true;
            btnSalvarPedido.Enabled = false;
            btnPesquisarProduto.Enabled = false;
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

            if ((txtCdCliente.Text != "") & (txtDescricaoCliente.Text != ""))
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
                        btnPesquisarProduto.Enabled = true;
                        btnAddProduto.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("O cliente não existe na base de dados");
                    }

                }
                catch
                {
                    MessageBox.Show(string.Format("Ocorreu um erro na criação do pedido, tente novamente!"));
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
            var grid = new PedidoRepository().ObterPedido(TxtNumero.Text);
            Debug.WriteLine(grid);
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
            if ((txtCdProduto.Text != " ") & (txtDescricaoProduto.Text != " ") & (txtQtd.Text != " ") & (txtValor.Text != " "))
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
                        var grid = new PedidoRepository().ObterProdutos(TxtNumero.Text);
                        ListarProdutos(TxtNumero.Text);
                        btnSalvarPedido.Enabled = true;
                        //ListarProdutos(nameof(Domain.Pedidos.Pedido.CdProduto));
                    }
                    else
                    {
                        MessageBox.Show("Produto não cadastrado!");

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(string.Format("Selecione um produto para que possa inserir no pedido!"), ex.Message);
                }
            }
            else
            {
                MessageBox.Show(string.Format("Selecione um produto para que possa inserir no pedido!"));
            }
        }
        private void ListarProdutos(string numero = "")
        {
            try
            {
                List<Produto> lista = new PedidoRepository().ObterProdutos(numero);
                _bsListaProduto = new BindingSource(lista, "");
                ListaProdutosDoPedido.AutoGenerateColumns = false;
                ListaProdutosDoPedido.DataSource = _bsListaProduto;
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao listar produtos!");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSalvarPedido_Click(object sender, EventArgs e)
        {
            LimparCampos();
            MessageBox.Show(string.Format("Pedido salvo com sucesso!!"));
            TxtNumero.Text = "";
            confirmarPedido();
        }

        private void btnCancelarPedido_Click(object sender, EventArgs e)
        {
            DialogResult resposta = DialogResult;
            var delete = TxtNumero;

            resposta = MessageBox.Show("Deseje realmente cancelar este pedido?", "Cancelar pedido", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resposta != DialogResult.No)
            {
                if ((txtCdCliente.Text != "") & (txtDescricaoCliente.Text != ""))
                {
                    var pedido = new PedidoRepository().ObterPedido("29");
                    var result = new PedidoRepository().DeletePedido(pedido);
                    if (result == true)
                    {
                        MessageBox.Show(string.Format("Pedido N° {0} cancelado com sucesso!", TxtNumero.Text));
                        LimparCampos();
                        TxtNumero.Text = "";
                    }
                    else
                    {
                        MessageBox.Show(string.Format("Não foi possivel cancelar o pedido N° {0}!", TxtNumero.Text));
                    }
                }
                else

                    MessageBox.Show(string.Format("Selecione um produto para que possa realizar a exclusão!"));
            }
            else
                MessageBox.Show(string.Format("Processo cancelado! "));
        }
    }
}
