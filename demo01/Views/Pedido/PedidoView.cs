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
using demo01.Domain.Pedido;
using demo01.Data.Repositories;

namespace demo01.Views.Pedido
{

    public partial class PedidoView : MetroFramework.Forms.MetroForm
    {


        #region Private 

        private enum StatusControlEnum
        {
            Loaded,
            Editing,
            Empty,
            New
        }

        private StatusControlEnum _statusPedido = StatusControlEnum.Empty;
        private StatusControlEnum _statusPedidoItem = StatusControlEnum.Empty;
        #endregion
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
            MudarStatusDeControles(StatusControlEnum.Loaded);
            TxtNumero.Leave += OnPedidoLeave;
            txtCdProduto.Leave += OnProdutoLeave;
            txtCdCliente.Leave += OnClienteLeave;




        }

        private void OnProdutoItemChanged(object sender, EventArgs e)
        {
            var currentPedidoItem = GetCurrentPedidoItem();
            if (currentPedidoItem != null)
            {
                txtCdProduto.Text = currentPedidoItem.CdProduto.ToString();
                txtDescricaoProduto.Text = currentPedidoItem.Descricao;
                txtQtd.Text = currentPedidoItem.QtdVenda.ToString();
                txtValor.Text = currentPedidoItem.VlVenda.ToString();

            }
        }

        private PedidoItem GetCurrentPedidoItem()
        {

            if (_bsListaProduto == null || _bsListaProduto.Current == null)
                return null;

            if (_bsListaProduto.Current is PedidoItem currentPedidoItem)
                return currentPedidoItem;

            return null;
        }

        private void OnClienteLeave(object sender, EventArgs e)
        {
            CarregarCliente();
        }
        private void OnPedidoLeave(object sender, EventArgs e)
        {
            CarregarPedido();
            c1Command3.Enabled = true;
        }
        private void OnProdutoLeave(object sender, EventArgs e)
        {
            CarregarProduto();
        }

        //private void OnClienteLeave(object sender, EventArgs e)
        //{

        //}

        private void NovoPedido()
        {
            txtCdCliente.Enabled = true;
            txtNomeCliente.Enabled = true;
            txtCdProduto.Enabled = false;
            txtDescricaoProduto.Enabled = false;
            txtValor.Enabled = false;
            txtQtd.Enabled = false;
        }
        private void LimparCampos()
        {
            txtCdCliente.Text = "";
            txtNomeCliente.Text = "";
            txtCdProduto.Text = "";
            txtDescricaoProduto.Text = "";
            txtValor.Text = "";
            txtQtd.Text = "";
        }
        private void InserirProdutos()
        {
            txtCdCliente.Enabled = false;
            txtNomeCliente.Enabled = false;
            txtCdProduto.Enabled = true;
            txtDescricaoProduto.Enabled = true;
            txtValor.Enabled = true;
            txtQtd.Enabled = true;
            txtCdProduto.Text = "";
            txtDescricaoProduto.Text = "";
            txtValor.Text = "";
            txtQtd.Text = "";
        }
        private void confirmarPedido()
        {
            txtCdProduto.Enabled = false;
            txtDescricaoProduto.Enabled = false;
            txtQtd.Enabled = false;
            txtValor.Enabled = false;
            txtCdCliente.Enabled = true;
            txtNomeCliente.Enabled = true;
        }
        private void MudarStatusDeControles(StatusControlEnum status)
        {

            switch (status)
            {
                case StatusControlEnum.Loaded:
                    txtCdCliente.Text = "";
                    txtCdProduto.Text = "";
                    txtDescricaoProduto.Text = "";
                    txtNomeCliente.Text = "";
                    txtQtd.Text = "";
                    txtValor.Text = "";
                    TxtNumero.Text = "";
                    c1Command1.Enabled = true;
                    c1Command6.Enabled = false;
                    c1Command4.Enabled = false;
                    c1Command2.Enabled = false;
                    c1Command5.Enabled = false;
                    c1Command3.Enabled = false;
                    c1Command7.Enabled = false;
                    c1Command8.Enabled = true;
                    c1Command11.Enabled = false;
                    c1Command10.Enabled = false;
                    txtCdProduto.Enabled = false;
                    txtDescricaoProduto.Enabled = false;
                    txtQtd.Enabled = false;
                    txtValor.Enabled = false;
                    txtCdCliente.Enabled = false;
                    txtNomeCliente.Enabled = false;
                    TxtNumero.Enabled = true;
                    ListaProdutosDoPedido.Rows.Clear();
                    break;
                case StatusControlEnum.Editing:
                    c1Command1.Enabled = true;
                    c1Command6.Enabled = true;
                    c1Command4.Enabled = true;
                    c1Command2.Enabled = true;
                    c1Command5.Enabled = false;
                    c1Command3.Enabled = true;
                    c1Command7.Enabled = true;
                    c1Command8.Enabled = false;
                    c1Command11.Enabled = false;
                    c1Command10.Enabled = true;
                    txtCdProduto.Enabled = true;
                    txtDescricaoProduto.Enabled = true;
                    txtQtd.Enabled = true;
                    txtValor.Enabled = true;
                    txtCdCliente.Enabled = false;
                    txtNomeCliente.Enabled = false;
                    TxtNumero.Enabled = false;
                    break;
                case StatusControlEnum.Empty:
                    break;
                case StatusControlEnum.New:
                    txtCdCliente.Text = "";
                    txtCdProduto.Text = "";
                    txtDescricaoProduto.Text = "";
                    txtNomeCliente.Text = "";
                    txtQtd.Text = "";
                    txtValor.Text = "";
                    TxtNumero.Text = "";
                    c1Command1.Enabled = false;
                    c1Command4.Enabled = false;
                    c1Command2.Enabled = false;
                    c1Command5.Enabled = true;
                    c1Command3.Enabled = false;
                    c1Command7.Enabled = true;
                    c1Command8.Enabled = false;
                    c1Command11.Enabled = true;
                    c1Command10.Enabled = false;
                    txtCdProduto.Enabled = false;
                    txtDescricaoProduto.Enabled = false;
                    txtQtd.Enabled = false;
                    txtValor.Enabled = false;
                    txtCdCliente.Enabled = true;
                    txtNomeCliente.Enabled = true;
                    TxtNumero.Enabled = false;
                    ListaProdutosDoPedido.Rows.Clear();
                    break;
            }


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
        public void PedidoView_Load(object sender, EventArgs e)
        {
            //txtCdCliente.Text = BuscarProduto.
            //txtCdProduto.Text = CdProduto;
            //txtCescricaoProduto.Text = Descricao;
            //txtValor.Text = Valor.ToString();
        }

        private void btnAddProduto_Click(object sender, EventArgs e)
        {
            if ((txtCdProduto.Text != "") & (txtDescricaoProduto.Text != "") & (txtQtd.Text != "") & (txtValor.Text != ""))
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

                        ListarProdutos(pedido.NumeroPedido);

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
        private void ListarProdutos(string numero)
        {
            try
            {
                List<PedidoItem> lista = new List<PedidoItem>();
                lista = new PedidoRepository().ObterProdutos(numero);
                _bsListaProduto = new BindingSource(lista, "");
                _bsListaProduto.CurrentItemChanged += OnProdutoItemChanged;
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
                if ((txtCdCliente.Text != "") & (txtNomeCliente.Text != ""))
                {
                    var pedido = new PedidoRepository().ObterPedido(delete.Text);
                    var result = new PedidoRepository().DeletePedido(pedido);
                    if (result == true)
                    {
                        MessageBox.Show(string.Format("Pedido N° {0} cancelado com sucesso!", TxtNumero.Text));
                        LimparCampos();
                        NovoPedido();
                        _bsListaProduto.Clear();
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

        #region Métodos internos
        private void CarregarCliente()
        {
            if (!string.IsNullOrWhiteSpace(txtCdCliente.Text))
            {
                var cliente = new ClienteRepository().ObterPorCodigo(txtCdCliente.Text);

                if (cliente != null)
                {
                    txtCdCliente.Text = cliente.CdCliente;
                    txtNomeCliente.Text = cliente.NomeCliente;
                }
            }
        }
        private void CarregarPedido()
        {
            if (!string.IsNullOrWhiteSpace(TxtNumero.Text))
            {
                var pedido = new PedidoRepository().ObterPedido(TxtNumero.Text);

                if (pedido != null)
                {
                    TxtNumero.Text = pedido.Numero;
                    txtCdCliente.Text = pedido.CdCliente;
                    CarregarCliente();
                    ListarProdutos(pedido.Numero);
                    MudarStatusDeControles(StatusControlEnum.Editing);

                }
            }
        }
        private void CarregarProduto()
        {
            if (!string.IsNullOrWhiteSpace(txtCdProduto.Text))
            {
                var produto = new ProdutoRepository().ObterPorCodigo(txtCdProduto.Text);

                if (produto != null)
                {
                    txtCdProduto.Text = produto.CdProduto;
                    txtDescricaoProduto.Text = produto.Descricao;
                    txtValor.Text = produto.Valor.ToString();
                }
            }
        }

        #endregion

        private void c1ToolBar2_Click(object sender, EventArgs e)
        {

        }

        private void c1Command1_Click_1(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            MudarStatusDeControles(StatusControlEnum.New);
        }

        private void c1Command2_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            if ((txtCdProduto.Text == "") & (txtDescricaoProduto.Text == "") & (txtQtd.Text == "") & (txtValor.Text == ""))
            {
                MudarStatusDeControles(StatusControlEnum.Loaded);
                MessageBox.Show(string.Format("Pedido salvo com sucesso!!"));
            }
            else
                MessageBox.Show(string.Format("Finalize a edição do produto para poder salvar o pedido!!"));
        }

        private void c1Command3_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            DialogResult resposta = DialogResult;
            var delete = TxtNumero;

            resposta = MessageBox.Show("Deseje realmente excluir este pedido?", "excluir pedido", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resposta != DialogResult.No)
            {
                if ((txtCdCliente.Text != "") & (txtNomeCliente.Text != ""))
                {
                    var pedido = new PedidoRepository().ObterPedido(delete.Text);
                    var result = new PedidoRepository().DeletePedido(pedido);
                    if (result == true)
                    {
                        MessageBox.Show(string.Format("Pedido N° {0} excluido com sucesso!", TxtNumero.Text));
                        LimparCampos();
                        NovoPedido();
                        _bsListaProduto.Clear();
                        TxtNumero.Text = "";
                    }
                    else
                    {
                        MessageBox.Show(string.Format("Não foi possivel excluir o pedido N° {0}!", TxtNumero.Text));
                    }
                }
                else

                    MessageBox.Show(string.Format("Selecione um produto para que possa realizar a exclusão!"));
            }
            else
                MessageBox.Show(string.Format("Processo cancelado! "));
        }

        private void c1Command5_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            if (txtCdCliente.Text == "")
            {
                if ((txtCdProduto.Text == "") & (txtDescricaoProduto.Text == "") & (txtQtd.Text == "") & (txtValor.Text == ""))
                {
                    MudarStatusDeControles(StatusControlEnum.Loaded);
                    MessageBox.Show(string.Format("Pedido salvo com sucesso!!"));
                }
                else
                    MessageBox.Show(string.Format("Finalize a edição do produto para poder salvar o pedido!!"));
            }
            else
            if ((txtCdCliente.Text != "") & (txtNomeCliente.Text != ""))
            {
                try
                {
                    MudarStatusDeControles(StatusControlEnum.Editing);

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
                    MessageBox.Show(string.Format("Ocorreu um erro na criação do pedido, tente novamente!"));
                }
            }
            else
            {
                MessageBox.Show(string.Format("Selecione um cliente para que possa gerar um pedido!"));
            }
        }

        private void c1Command4_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            if ((txtCdProduto.Text != "") & (txtDescricaoProduto.Text != "") & (txtQtd.Text != "") & (txtValor.Text != ""))
            {
                try
                {
                    var pedido = new Domain.Pedidos.Pedido();
                    var pedidoitem = new PedidoItem();
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
                    var IndentificadorProduto = new PedidoRepository().ObterQuantidadeDeProdutos();
                    pedidoitem.IdentificadorProduto = IndentificadorProduto ++;
                    pedido.QtdVenda = quantidade;
                    pedido.VlVenda = valorProduto;
                    pedidoitem.IdentificadorProduto = IndentificadorProduto;
                    var result = new PedidoAppService().ValidarProduto(pedido);
                    

                    if (result.Success)
                    {
                        MessageBox.Show(string.Format("Produto Inserido com sucesso!"));
                        InserirProdutos();

                        ListarProdutos(pedido.NumeroPedido);
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
                MessageBox.Show(string.Format("Preencha todos os campos para inserir o produto no pedido!!"));
            }
        }

        private void c1Command6_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {

        }

        private void btnPesquisarPedido_Click_1(object sender, EventArgs e)
        {
            {
                BuscarPedido formpedido = new BuscarPedido();
                formpedido.ShowDialog();

                if (formpedido.ReturnValue != null)
                {
                    TxtNumero.Text = formpedido.ReturnValue;
                    CarregarPedido();
                }
            }
        }

        private void btnPesquisarCliente_Click(object sender, EventArgs e)
        {
            {
                BuscarCliente formpedido = new BuscarCliente();
                formpedido.ShowDialog();

                if (formpedido.ReturnValue != null)
                {
                    txtCdCliente.Text = formpedido.ReturnValue;
                    CarregarCliente();
                }
            }
        }

        private void c1Command7_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            MudarStatusDeControles(StatusControlEnum.Loaded);
        }

        private void ListaProdutosDoPedido_DoubleClick(object sender, EventArgs e)
        {
            LerProduto();
        }
        private void LerProduto()
        {

            if (_bsListaProduto.Current != null && _bsListaProduto.Current is demo01.Domain.Pedidos.Pedido pedido)
            {
                txtCdProduto.Text = pedido.CdProduto;
            }
        }



        private void c1Command8_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {

            {
                BuscarPedido formpedido = new BuscarPedido();
                formpedido.ShowDialog();

                if (formpedido.ReturnValue != null)
                {
                    TxtNumero.Text = formpedido.ReturnValue;
                    CarregarPedido();
                    MudarStatusDeControles(StatusControlEnum.Editing);
                }
            }
        }

        private void c1Command10_Click_1(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            BuscarProduto formproduto = new BuscarProduto();
            formproduto.ShowDialog();

            if (formproduto.ReturnValue != null)
            {
                txtCdProduto.Text = formproduto.ReturnValue;
                CarregarProduto();
            }
        }

        private void c1Command11_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            {
                BuscarCliente formpedido = new BuscarCliente();
                formpedido.ShowDialog();

                if (formpedido.ReturnValue != null)
                {
                    txtCdCliente.Text = formpedido.ReturnValue;
                    CarregarCliente();
                }
            }
        }

        private void txtCdCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {

                BuscarCliente formpedido = new BuscarCliente();
                formpedido.ShowDialog();

                if (formpedido.ReturnValue != null)
                {
                    txtCdCliente.Text = formpedido.ReturnValue;
                    CarregarCliente();
                }

            }
        }

        private void TxtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                BuscarPedido formpedido = new BuscarPedido();
                formpedido.ShowDialog();

                if (formpedido.ReturnValue != null)
                {
                    TxtNumero.Text = formpedido.ReturnValue;
                    CarregarPedido();
                }
            }
        }

        private void txtCdProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                BuscarProduto formproduto = new BuscarProduto();
                formproduto.ShowDialog();

                if (formproduto.ReturnValue != null)
                {
                    txtCdProduto.Text = formproduto.ReturnValue;
                    CarregarProduto();
                }
            }
        }

        private void txtCdProduto_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


