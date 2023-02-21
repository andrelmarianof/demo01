using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using demo01.Data.RepositoriesCliente;
using demo01.Views.Clientes;
using demo01.Views.Helpers;

namespace demo01.Views.Cliente
{
    public partial class ClienteView : MetroFramework.Forms.MetroForm
    {
        #region Declaração
        public BindingSource _bsListaCliente;
        #endregion

        #region Construtores
        public ClienteView()
        {
            InitializeComponent();
            DesabilitarCampo();

        }
        #endregion

        #region MetodosInternos
        private void InserirCliente()
        {
            if ((txtCodigoClientezz.Text != "") & (txtNomeCliente.Text != "") & (mskCPF.Text != " ") & (txtEmail.Text != ""))
            {
                if (mskCPF.Text.Length == 11)
                {
                    try
                    {
                        var cliente = new Domain.Clientes.Cliente();
                        cliente.CdCliente = txtCodigoClientezz.Text.Trim().ToLower();
                        cliente.NomeCliente = txtNomeCliente.Text.Trim();
                        cliente.Cpf = mskCPF.Text.Trim();
                        cliente.Email = txtEmail.Text.Trim();
                        var result = new ClienteAppService().Inserir(cliente);
                        if (result.Success)
                        {
                            MessageBox.Show(string.Format("Cliente {0} inserido com sucesso!", txtNomeCliente.Text));
                            limparCampos();
                            ListarGrid();
                            DesabilitarCampo();
                        }
                        else
                        {
                            MessageBox.Show($"Ocorreu um erro no cadastro:\n\r{string.Join("\n\r", result.Messages)}");

                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ocorreu um erro ao salvar! Verifique os dados!" + ex.Message);

                    }
                }
                else
                {
                    MessageBox.Show("O CPF inserido está incorreto, verifique!!");
                }
            }
            else
            {
                MessageBox.Show("insira todos os campos corretamente para cadastrar um cliente!");

            }
        }

        public void ListarGrid(string sortColumn = "CdCliente")
        {

            try
            {


                List<Domain.Clientes.Cliente> lista1 = new List<Domain.Clientes.Cliente>();
                lista1 = new ClienteRepository().ListarClientes(sortColumn);


                _bsListaCliente = new BindingSource(lista1, "");
                listacliente.AutoGenerateColumns = false;
                listacliente.DataSource = _bsListaCliente;

            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao Listar dados!");
            }
            return;
        }
        private void EditarCliente()
        {
            if ((txtNomeCliente.Text != "") & (mskCPF.Text != ""))
            {


                {
                    var cliente = new Domain.Clientes.Cliente();
                    cliente.CdCliente = txtCodigoClientezz.Text.Trim().ToLower();
                    cliente.NomeCliente = txtNomeCliente.Text.Trim();
                    //cliente.Cpf = txtCpf.Text.Trim();
                    cliente.Cpf = mskCPF.Text.Trim();
                    cliente.Email = txtEmail.Text.Trim();
                    var result = new ClienteAppService().Editar(cliente);
                    if (result.Success)
                    {
                        MessageBox.Show(string.Format("O cadastro do cliente {0} foi alterado com sucesso!", txtNomeCliente.Text));
                        ListarGrid();
                        DesabilitarCampo();
                    }
                    else
                        MessageBox.Show($"Ocorreu um erro no cadastro:\n\r{string.Join("\n\r", result.Messages)}");
                }
            }
            else
                MessageBox.Show("Selecione um cliente para editar!");

        }
        private Domain.Clientes.Cliente GetCurrentCliente()
        {

            if (_bsListaCliente == null || _bsListaCliente.Current == null)
                return null;

            if (_bsListaCliente.Current is Domain.Clientes.Cliente currentCliente)
                return currentCliente;

            return null;
        }
        private void LerCliente()
        {

            var currentCliente = GetCurrentCliente();
            if (currentCliente != null)
            {
                txtCodigoClientezz.Text = currentCliente.CdCliente;
                txtNomeCliente.Text = currentCliente.NomeCliente;
                mskCPF.Text = currentCliente.Cpf;
                txtEmail.Text = currentCliente.Email;

            }
        }
        private void limparCampos()
        {
            txtCodigoClientezz.Text = "";
            txtNomeCliente.Text = "";
            mskCPF.Text = "";
            txtEmail.Text = "";

        }

        private void HabilitarCampo()
        {
            txtCodigoClientezz.Enabled = true;
            txtNomeCliente.Enabled = true;
            mskCPF.Enabled = true;
            txtEmail.Enabled = true;

        }

        private void DesabilitarCampo()
        {
            txtCodigoClientezz.Enabled = false;
            txtNomeCliente.Enabled = false;
            mskCPF.Enabled = false;
            txtEmail.Enabled = false;

        }
        private void Editar()
        {
            HabilitarCampo();
            txtCodigoClientezz.Enabled = false;
            txtEmail.Enabled = true;
        }

        #endregion

        #region Eventos

        private void btnExcluirCliente_Click(object sender, EventArgs e)
        {
            var resposta = DialogResult;
            var currentCliente = GetCurrentCliente();
            if (currentCliente == null)
                return;
            resposta = MessageBox.Show("Deseje realmente excluir este Cliente?", "Excluir Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resposta != DialogResult.No)
            {
                var result = new ClienteRepository().DeleteCliente(currentCliente);
                MessageBox.Show(string.Format("Cliente {0} Excluido com sucesso!", currentCliente.NomeCliente));
                limparCampos();

                ListarGrid();
                LerCliente();

            }
            else
                MessageBox.Show(string.Format("Processo cancelado! "));
        }
        private void listacliente_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                decimal cpf;
                if (!decimal.TryParse(e.Value?.ToString().Trim(), out cpf))
                    return;

                e.Value = Math.Round(cpf, 0).ToString(@"000\.000\.000\-00");
            }
        }

        private void Listacliente_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                ListarGrid(nameof(Domain.Clientes.Cliente.CdCliente));
            }
            else
                if (e.ColumnIndex == 1)
            {
                ListarGrid(nameof(Domain.Clientes.Cliente.NomeCliente));
            }
            else
                if (e.ColumnIndex == 2)
            {
                ListarGrid(nameof(Domain.Clientes.Cliente.Cpf));
            }
            else
                ListarGrid(nameof(Domain.Clientes.Cliente.Email));
        }
        private void txtCodigoCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBoxEventHelpers.KeyPressNumericHandler(sender as TextBox, e);
        }
        private void txtCpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBoxEventHelpers.KeyPressNumericHandler(sender as TextBox, e);
        }
        private void btnNovoCliente_Click(object sender, EventArgs e)
        {
            limparCampos();
            HabilitarCampo();

            if (txtCodigoClientezz.Enabled)
                txtCodigoClientezz.Focus();
        }
        private void listacliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LerCliente();
            DesabilitarCampo();
        }
        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (txtCodigoClientezz.Enabled != true)
            {
                EditarCliente();
            }
            else
                InserirCliente();
        }
        private void c1ToolBar2_Click(object sender, EventArgs e)
        {

        }
      
       


        public void Cliente_Load(object sender, EventArgs e)
        {

            ListarGrid();
            _bsListaCliente.CurrentChanged += OnCurrentItemChangeHandler;

        }
        public void listacliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LerCliente();
        }
        private void listacliente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Editar();
        }
        private void OnCurrentItemChangeHandler(object sender, EventArgs e)
        {
            LerCliente();
        }

        #endregion

        private void txtCodigoClientezz_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNomeCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void mskCPF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
