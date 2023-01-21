﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using demo01.Domain.Cliente;
using demo01.Data.RepositoriesCliente;
using demo01.Views.Pedido;
namespace demo01.Views.Cliente

{

    public partial class ClienteView : Form
    {
        #region Declaração
        private BindingSource _bsListaCliente;
        #endregion

        #region Construtores
        public ClienteView()
        {
            InitializeComponent();
            DesabilitarCampo();
            BtnSalvar.Enabled = false;

        }
        #endregion

        #region MetodosInternos
        private void InserirCliente()
        {
            if ((txtCodigoCliente.Text != "") & (txtNomeCliente.Text != ""))
            {
                if (mskCPF.Text.Length == 11)
                {
                    try
                    {
                        var cliente = new Domain.Cliente.Cliente();
                        cliente.CdCliente = txtCodigoCliente.Text.Trim().ToLower();
                        cliente.NomeCliente = txtNomeCliente.Text.Trim();
                        cliente.Cpf = mskCPF.Text.Trim();
                        var result = new ClienteAppService().Inserir(cliente);
                        if (result.Success)
                        {
                            MessageBox.Show(string.Format("Cliente {0} inserido com sucesso!", txtNomeCliente.Text));
                            limparCampos();
                            ListarGrid();
                            DesabilitarCampo();
                            BtnSalvar.Enabled = false;
                            btnExcluirCliente.Enabled = true;
                        }
                        else
                        {
                            MessageBox.Show("insira todos os campos para cadastrar um produto!");

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

        private void ListarGrid(string sortColumn = "CdCliente")
        {

            try
            {


                List<Domain.Cliente.Cliente> lista1 = new List<Domain.Cliente.Cliente>();
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
                if (mskCPF.Text.Length != 14)
                {
                    {
                        var cliente = new Domain.Cliente.Cliente();
                        cliente.CdCliente = txtCodigoCliente.Text.Trim().ToLower();
                        cliente.NomeCliente = txtNomeCliente.Text.Trim();
                        //cliente.Cpf = txtCpf.Text.Trim();
                        cliente.Cpf = mskCPF.Text.Trim();
                        var result = new ClienteRepository().EditarCliente(cliente);
                        if (result != false)
                        {
                            MessageBox.Show(string.Format("O cadastro do cliente {0} foi alterado com sucesso!", txtNomeCliente.Text));
                            ListarGrid();
                            btnNovoCliente.Enabled = true;
                            BtnSalvar.Enabled = false;
                            DesabilitarCampo();
                        }
                        else
                            MessageBox.Show("Erro ao editar o cliente");
                    }
                }
                else
                    MessageBox.Show("O CPf informado está invalido!");
            }
            else
                MessageBox.Show("Selecione um cliente para editar!");

        }
        private Domain.Cliente.Cliente GetCurrentCliente()
        {

            if (_bsListaCliente == null || _bsListaCliente.Current == null)
                return null;

            if (_bsListaCliente.Current is Domain.Cliente.Cliente currentCliente)
                return currentCliente;

            return null;
        }
        private void LerCliente()
        {

            var currentCliente = GetCurrentCliente();
            if (currentCliente != null)
            {
                txtCodigoCliente.Text = currentCliente.CdCliente;
                //txtCodigoCliente.DataBindings.Add("Text", currentCliente, "CdCliente");
                txtNomeCliente.Text = currentCliente.NomeCliente;
                mskCPF.Text = currentCliente.Cpf;


            }
        }
        private void limparCampos()
        {
            txtCodigoCliente.Text = "";
            txtNomeCliente.Text = "";
            mskCPF.Text = "";

        }

        private void HabilitarCampo()
        {
            txtCodigoCliente.Enabled = true;
            txtNomeCliente.Enabled = true;
            mskCPF.Enabled = true;

        }

        private void DesabilitarCampo()
        {
            txtCodigoCliente.Enabled = false;
            txtNomeCliente.Enabled = false;
            mskCPF.Enabled = false;

        }
        private void Editar()
        {
            HabilitarCampo();
            btnExcluirCliente.Enabled = false;
            btnNovoCliente.Enabled = false;
            BtnSalvar.Enabled = true;
            txtCodigoCliente.Enabled = false;
        }

        #endregion

        #region Eventos

        private void btnExcluirCliente_Click(object sender, EventArgs e)
        {
            var resposta = DialogResult;
            var currentProduto = GetCurrentCliente();
            if (currentProduto == null)
                return;

            resposta = MessageBox.Show("Deseje realmente excluir este Cliente?", "Excluir Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resposta != DialogResult.No)
            {
                if ((txtCodigoCliente.Text != "") & (txtNomeCliente.Text != "") & (mskCPF.Text != ""))
                {
                    //objTabela.CdProduto = txtCdProduto.Text.Trim();
                    var result = new ClienteRepository().DeleteCliente(currentProduto);
                    MessageBox.Show(string.Format("Cliente {0} Excluido com sucesso!", txtNomeCliente.Text));
                    limparCampos();

                    ListarGrid();
                    LerCliente();
                    BtnSalvar.Enabled = false;

                }
                else

                    MessageBox.Show(string.Format("Selecione um produto para que possa realizar a exclusão!"));
            }
            else
                MessageBox.Show(string.Format("Processo cancelado! "));
        }
        private void txtCodigoCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        private void txtCpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        private void btnNovoCliente_Click(object sender, EventArgs e)
        {
            limparCampos();
            HabilitarCampo();
            BtnSalvar.Enabled = true;
            btnExcluirCliente.Enabled = false;
        }
        private void listacliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LerCliente();
            BtnSalvar.Enabled = false;
            btnNovoCliente.Enabled = true;
            DesabilitarCampo();
        }
        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (txtCodigoCliente.Enabled != true)
            {
                EditarCliente();
            }
            else
                InserirCliente();
        }

        private void Cliente_Load(object sender, EventArgs e)
        {

            ListarGrid();
            _bsListaCliente.CurrentChanged += OnCurrentItemChangeHandler;

        }
        private void listacliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void codigocliente_TextChanged(object sender, EventArgs e)
        {

        }


        private void txtNomeCliente_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtCpf_TextChanged(object sender, EventArgs e)
        {

        }


        #endregion

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
                ListarGrid(nameof(Domain.Cliente.Cliente.CdCliente));
            }
            else
                if(e.ColumnIndex == 1)
            {
                ListarGrid(nameof(Domain.Cliente.Cliente.NomeCliente));
            }
            else
            ListarGrid(nameof(Domain.Cliente.Cliente.Cpf));
        }
    }
}
