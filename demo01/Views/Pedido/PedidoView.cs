using System;
using System.Windows.Forms;
using demo01.Application.Pedidos;
using demo01.Data.RepositoriesPedido;
using System.Collections.Generic;
using demo01.Data.RepositoriesCliente;
using demo01.Domain.Pedido;
using demo01.Data.Repositories;
using demo01.Views.Helpers;
using System.Linq;

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

        #region Declaraçoes
        private object sortColumn;
        private BindingSource _bsListaCliente;
        private BindingSource _bsListaProduto;
        private object listaprodutos;
        #endregion

        #region Construtores
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
        #endregion

        #region Métodos internos

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
                    NovoPedido.Enabled = true;
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
                    NovoPedido.Enabled = true;
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
                    txtCdProduto.Text = "";
                    txtDescricaoProduto.Text = "";
                    txtQtd.Text = "";
                    txtValor.Text = "";
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
                    NovoPedido.Enabled = false;
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

        private void LerProduto()
        {
            if (_bsListaProduto.Current != null && _bsListaProduto.Current is demo01.Domain.Pedido.PedidoItem pedido)
            {
                txtCdProduto.Text = pedido.CdProduto;
            }
        }
        public void OnProdutoItemChanged(object sender, EventArgs e)
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

        private void ListarItensDoPedido(int numero)
        {
            try
            {
                List<PedidoItem> lista = new List<PedidoItem>();
                lista = new PedidoRepository().ObterListaDeItens(numero);
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

        //private void CarregarListaDeCliente()
        //{
        //    if (!string.IsNullOrWhiteSpace(txtCdCliente.Text))
        //    {
        //        var teste = new Domain.Clientes.Cliente();
        //        teste.CdCliente = "0";
        //        var montargrido = new ConsultaGridPadrao().MontarGrid(cdCliente: CdcdCliente, "");

        //        var cliente = new ClienteRepository().ObterPorCodigo(txtCdCliente.Text);

        //        if (cliente != null)
        //        {
        //            txtCdCliente.Text = cliente.CdCliente.ToString();
        //            txtNomeCliente.Text = cliente.NomeCliente;
        //            if (txtCdProduto.Enabled)
        //                txtCdProduto.Focus();
        //        }
        //    }
        //}
        private void CarregarListaDeCliente()
        {
            string codigoCliente = txtCdCliente.Text.Trim();
            if (!string.IsNullOrWhiteSpace(codigoCliente))
            {
                var clienteRepository = new ClienteRepository();
                var cliente = clienteRepository.ObterPorCodigo(codigoCliente);

                if (cliente != null)
                {
                    txtCdCliente.Text = cliente.CdCliente.ToString();
                    txtNomeCliente.Text = cliente.NomeCliente;

                    if (txtCdProduto.Enabled)
                    {
                        txtCdProduto.Focus();
                    }

                    //var consultaGrid = new ConsultaGridPadrao();
                    //consultaGrid.PopularGridDeClientes();
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
                    TxtNumero.Text = pedido.Numero.ToString();
                    txtCdCliente.Text = pedido.CdCliente;
                    CarregarListaDeCliente();
                    ListarItensDoPedido(pedido.Numero);
                    MudarStatusDeControles(StatusControlEnum.Editing);
                    if (txtCdProduto.Enabled)
                        txtCdProduto.Focus();

                }
            }
        }

        private void CarregarListaDeProduto()
        {

            if (!string.IsNullOrWhiteSpace(txtCdProduto.Text))
            {
                var produto = new ProdutoRepository().ObterProdutoPorCodigo(txtCdProduto.Text);

                if (produto != null)
                {
                    txtCdProduto.Text = produto.CdProduto;
                    txtDescricaoProduto.Text = produto.Descricao;
                    txtValor.Text = produto.Valor.ToString();
                }
            }
        }

        #endregion

        #region Eventos

        private void Salvar_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            if (txtCdCliente.Text == "")
            {
                if ((txtCdProduto.Text == "") & (txtDescricaoProduto.Text == "") & (txtQtd.Text == "") & (txtValor.Text == ""))
                {
                    MudarStatusDeControles(StatusControlEnum.Loaded);
                    MessageBox.Show(string.Format("Pedido salvo com sucesso!!"));
                    if (txtCdProduto.Enabled == true)
                        txtCdProduto.Focus();
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
                    pedido.Numero = txtnumero;
                    pedido.CdCliente = txtCdCliente.Text.Trim();
                    var result = new PedidoAppService().ValidarCliente(pedido);
                    if (result.Success)
                    {
                        MessageBox.Show(string.Format("Pedido criado com sucesso, realize a inserção dos produto"));
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
        private void InserirProdutoNoPedido_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            if ((txtCdProduto.Text != "") & (txtDescricaoProduto.Text != "") & (txtQtd.Text != "") & (txtValor.Text != ""))
            {
                try
                {
                    var pedido = new Domain.Pedidos.Pedido();
                    var pedidoitem = new PedidoItem();
                    pedidoitem.CdProduto = txtCdProduto.Text.Trim();
                    pedidoitem.Descricao = txtDescricaoProduto.Text;
                    int numeroInt;
                    if (Int32.TryParse(TxtNumero.Text.Trim(), out numeroInt))
                    {
                        pedidoitem.NumeroPedido = numeroInt;
                    }
                    else
                    {
                        Console.WriteLine("A conversão falhou. Não foi possível converter a string para int.");
                    }

                    decimal valorProduto;
                    if (Decimal.TryParse(txtValor.Text.Trim(), out valorProduto))
                    {
                        pedidoitem.VlVenda = valorProduto;
                    }
                    else
                    {
                        Console.WriteLine("A conversão falhou. Não foi possível converter a string para decimal.");
                    }
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
                    pedidoitem.Id = Guid.NewGuid();
                    pedidoitem.QtdVenda = quantidade;
                    pedidoitem.VlVenda = valorProduto;
                    var result = new PedidoAppService().ValidarProduto(pedidoitem);


                    if (result.Success)
                    {
                        MessageBox.Show(string.Format("Produto Inserido com sucesso!"));
                        if (txtCdProduto.Enabled == true)
                            txtCdProduto.Focus();
                        MudarStatusDeControles(StatusControlEnum.Editing);
                        ListarItensDoPedido(pedidoitem.NumeroPedido);
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
        private void CarregarListaDePedidos_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            {
                var consultaGrid = new ConsultaGridPadrao(ObterConfiguracaoConsultaPedido());
                consultaGrid.Show();

                if (consultaGrid.ReturnValue != null)
                {
                    TxtNumero.Text = consultaGrid.ReturnValue;
                    CarregarPedido();
                    MudarStatusDeControles(StatusControlEnum.Editing);
                    if (txtCdProduto.Enabled == true)
                        txtCdProduto.Focus();
                }
            }
        }
        //private void CarregarListaDeProdutos_Click_1(object sender, C1.Win.C1Command.ClickEventArgs e)
        //{
        //    try
        //    {
        //        CdProduto = "0";
        //        ConsultaGridPadrao formproduto = new ConsultaGridPadrao().MontarColunasProduto();
        //        formproduto.ShowDialog();

        //        if (formproduto.ReturnValue != null)
        //        {
        //            txtCdProduto.Text = formproduto.ReturnValue;
        //            CarregarListaDeProduto();
        //        }

        //    }
        //    catch (Exception)
        //    {


        //    }
        //}

        private void ConsultarProduto_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            var consultaGrid = new ConsultaGridPadrao(ObterConfiguracaoConsultaProduto());
            consultaGrid.Show();
        }
        private void CarregarListaDeClientes_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            string codigoCliente = txtCdCliente.Text.Trim();
            var consultaGrid = new ConsultaGridPadrao(ObterConfiguracaoConsultaCliente());
            //consultaGrid.PopularGridDeClientes();
            consultaGrid.Show();
            if (!string.IsNullOrWhiteSpace(codigoCliente))
            {

                var clienteRepository = new ClienteRepository();
                var cliente = clienteRepository.ObterPorCodigo(codigoCliente);

                if (cliente != null)
                {
                    txtCdCliente.Text = cliente.CdCliente.ToString();
                    txtNomeCliente.Text = cliente.NomeCliente;

                    if (txtCdProduto.Enabled)
                    {
                        txtCdProduto.Focus();
                    }
                }
            }
        }

        private ConfiguracaoConsulta ObterConfiguracaoConsultaCliente()
        {

            return new ConfiguracaoConsulta
            {
                Colunas = new List<ColunaConsulta>() {
                    new ColunaConsulta("CdCliente", "Código"),
                    new ColunaConsulta("NomeCliente", "Nome do cliente")},
                ObterDataSource = ObterDataSourceCliente,
                DevolverRetorno = DevolverRetornoCliente
            };
        }
        private ConfiguracaoConsulta ObterConfiguracaoConsultaProduto()
        {

            return new ConfiguracaoConsulta
            {
                Colunas = new List<ColunaConsulta>() {
                    new ColunaConsulta("CdProduto", "Código"),
                    new ColunaConsulta("Descricao", "Produto"),
                    new ColunaConsulta("Estoque", "Estoque Disponivel"),
                    new ColunaConsulta("Valor", "Valor")},
                ObterDataSource = ObterDataSourceProduto,
                DevolverRetorno = DevolverRetornoProduto
            };
        }
        private ConfiguracaoConsulta ObterConfiguracaoConsultaPedido()
        {

            return new ConfiguracaoConsulta
            {
                Colunas = new List<ColunaConsulta>() {
                    new ColunaConsulta("Numero", "Numero Do Pedido"),
                    new ColunaConsulta("CdCliente", "Código do Cliente"),
                    new ColunaConsulta("Cpf", "Cpf do Cliente") },
                ObterDataSource = ObterDataSourcePedido,
                DevolverRetorno = DevolverRetornoPedido
            };
        }

        private void DevolverRetornoCliente(object obj)
        {
            if (obj is Domain.Clientes.Cliente cliente)
            {
                txtCdCliente.Text = cliente.CdCliente;
                txtNomeCliente.Text = cliente.NomeCliente;
                //TODO: Carregar descricao
            }
        }
        private void DevolverRetornoProduto(object obj)
        {
            if (obj is Domain.Produtos.Produto produto)
            {
                txtCdProduto.Text = produto.CdProduto;
                txtDescricaoProduto.Text = produto.Descricao;
                txtValor.Text = produto.Valor.ToString();
                //TODO: Carregar descricao
            }
        }
        private void DevolverRetornoPedido(object obj)
        {
            if (obj is Domain.Pedidos.Pedido pedido)
            {
                TxtNumero.Text = pedido.Numero.ToString();
                txtCdCliente.Text = pedido.CdCliente;
                //TODO: Carregar descricao
            }
        }

        private DataSourceConsulta ObterDataSourceCliente()
        {
            var clienteRepository = new ClienteRepository();
            var clientes = clienteRepository.ListarClientes("1");

            return new DataSourceConsulta()
            {
                HasData = clientes.Any(),
                MessageNoData = "Nenhum cliente encontrado.",
                Data = clientes
            };

        }
        private DataSourceConsulta ObterDataSourceProduto()
        {
            var produtoRepository = new ProdutoRepository();
            var produtos = produtoRepository.ObterTodos("1");

            return new DataSourceConsulta()
            {
                HasData = produtos.Any(),
                MessageNoData = "Nenhum produto encontrado.",
                Data = produtos
            };

        }
        private DataSourceConsulta ObterDataSourcePedido()
        {
            var pedidoRepository = new PedidoRepository();
            var pedidos = pedidoRepository.ListarPedido("1");


            return new DataSourceConsulta()
            {
                HasData = pedidos.Any(),
                MessageNoData = "Nenhum produto encontrado.",
                Data = pedidos
            };

        }
        private void txtCdCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
               var formpedido = new ConsultaGridPadrao(ObterConfiguracaoConsultaCliente());
                formpedido.ShowDialog();

                if (formpedido.ReturnValue != null)
                {
                    txtCdCliente.Text = formpedido.ReturnValue;
                    CarregarListaDeCliente();
                }
            }
        }
        private void TxtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                var consultaGrid = new ConsultaGridPadrao(ObterConfiguracaoConsultaPedido());
                consultaGrid.Show();

                if (consultaGrid.ReturnValue != null)
                {
                    TxtNumero.Text = consultaGrid.ReturnValue;
                    CarregarPedido();
                    MudarStatusDeControles(StatusControlEnum.Editing);
                    if (txtCdProduto.Enabled == true)
                        txtCdProduto.Focus();
                }
            }


        }
        private void txtCdProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                var consultaGrid = new ConsultaGridPadrao(ObterConfiguracaoConsultaProduto());
                consultaGrid.Show();

                if (consultaGrid.ReturnValue != null)
                {
                    txtCdProduto.Text = consultaGrid.ReturnValue;
                    CarregarPedido();
                    MudarStatusDeControles(StatusControlEnum.Editing);
                    if (txtCdProduto.Enabled == true)
                        txtCdProduto.Focus();
                }
            }



        }
        private void OnPedidoLeave(object sender, EventArgs e)
        {
            CarregarPedido();
            c1Command3.Enabled = true;
        }

        private void OnClienteLeave(object sender, EventArgs e)
        {
            CarregarListaDeCliente();
        }
        private void PrepararNovoPedido_Click_1(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            MudarStatusDeControles(StatusControlEnum.New);
            if (txtCdCliente.Enabled)
                txtCdCliente.Focus();
        }

        private void OnProdutoLeave(object sender, EventArgs e)
        {
            CarregarListaDeProduto();
        }
        private void DesfazerAlteracoes_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            MudarStatusDeControles(StatusControlEnum.Loaded);
            if (TxtNumero.Enabled == true)
                TxtNumero.Focus();
        }
        private void ListaProdutosDoPedido_DoubleClick(object sender, EventArgs e)
        {
            LerProduto();
        }
        private void ExcluirItemDoPedido_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            DialogResult resposta = DialogResult;
            var delete = TxtNumero;

            resposta = MessageBox.Show("Deseje realmente excluir este Produto?", "excluir Produto", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resposta != DialogResult.No)
            {
                if ((txtCdProduto.Text != "") & (txtDescricaoProduto.Text != "") & (txtQtd.Text != "") & (txtValor.Text != ""))
                {
                    try
                    {
                        var pedido = new Domain.Pedidos.Pedido();
                        var pedidoitem = new PedidoItem();
                        pedidoitem.CdProduto = txtCdProduto.Text.Trim();
                        int numeroInt;
                        if (Int32.TryParse(TxtNumero.Text.Trim(), out numeroInt))
                        {
                            pedidoitem.NumeroPedido = numeroInt;
                        }
                        else
                        {
                            Console.WriteLine("A conversão falhou. Não foi possível converter a string para int.");
                        }
                        var id = GetCurrentPedidoItem();
                        pedidoitem.Id = id.Id;
                        var deletarPedido = new PedidoRepository().DeleteItemDoPedido(pedidoitem);
                        if (!deletarPedido)
                            MessageBox.Show(string.Format("Ocorreu um erro ao excluir o produto! verifique!"));
                        else
                        {
                            MessageBox.Show(string.Format("produto ''{0}'' Excluido com sucesso!", id.Descricao));
                            ListarItensDoPedido(pedidoitem.NumeroPedido);
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("A conversão falhou. Não foi possível converter a string para decimal.");
                    }
                }
            }
            else
                Console.WriteLine("A conversão falhou. Não foi possível converter a string para decimal.");


        }
        private void ExcluirPedido_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            DialogResult resposta = DialogResult;
            var delete = TxtNumero;

            resposta = MessageBox.Show("Deseje realmente excluir este pedido?", "excluir pedido", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resposta != DialogResult.No)
            {
                if (TxtNumero.Text != "")
                {
                    var pedido = new PedidoRepository().ObterPedido(delete.Text);
                    var result = new PedidoRepository().DeletePedido(pedido);
                    if (result == true)
                    {
                        MessageBox.Show(string.Format("Pedido N° {0} excluido com sucesso!", TxtNumero.Text));
                        MudarStatusDeControles(StatusControlEnum.Loaded);
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

        #endregion

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBoxEventHelpers.KeyPressNumericHandler(sender as TextBox, e);
        }

        private void txtQtd_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBoxEventHelpers.KeyPressNumericHandler(sender as TextBox, e);
        }

        
    }
}


