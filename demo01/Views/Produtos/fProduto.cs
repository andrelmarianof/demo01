using demo01.App.Produtos;
using demo01.Data.Repositories;
using demo01.Domain.Produtos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace demo01.Views.Produtos
{
    public partial class fProduto : MetroFramework.Forms.MetroForm
    {

        #region "Declarações"
        private BindingSource _bsListaProduto;
        #endregion

        #region "Construtores"
        public fProduto()
        {
            InitializeComponent();
        }
        #endregion

        #region "Métodos internos"
        private void InserirProduto()
        {
            if ((txtCdProduto.Text != "") & (txtQtd.Text != "") & (txtValor.Text != "") & (txtDescricaoProduto.Text != ""))
            {

                try
                {

                    var produto = new Produto();
                    produto.Descricao = txtDescricaoProduto.Text.Trim().ToLower();
                    produto.CdProduto = txtCdProduto.Text.Trim();

                    decimal quantidade;
                    if (!decimal.TryParse(txtQtd.Text.Trim(), out quantidade))
                    {
                        MessageBox.Show(string.Format("Valor informado para quantidade não é válido!"));
                        return;
                    }

                    produto.Estoque = quantidade;

                    decimal valorProduto;
                    if (!decimal.TryParse(txtValor.Text.Trim(), out valorProduto))
                    {
                        MessageBox.Show(string.Format("Valor informado para valor não é válido!"));
                        return;
                    }

                    produto.Valor = valorProduto;

                    var result = new ProdutoAppService().Inserir(produto);
                    //int x = new ProdutoRepository().Inserir(objTabela);

                    if (result.Success)
                    {
                        MessageBox.Show(string.Format("Produto {0} inserido com sucesso!", txtDescricaoProduto.Text));
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
                MessageBox.Show("insira todos os campos para cadastrar um produto!");

            }

        }

        private void AtualizarProduto()
        {
            var produto = new Produto();
            produto.CdProduto = txtCdProduto.Text;
            produto.Descricao = txtDescricaoProduto.Text;
            produto.Estoque = Decimal.Parse(txtQtd.Text);
            produto.Valor = Decimal.Parse(txtValor.Text);

            var result = new ProdutoAppService().Atualizar(produto);
            if (result.Success)
            {
                MessageBox.Show(string.Format("Produto {0} alterado com sucesso!", txtDescricaoProduto.Text));
                limparCampos();
                ListarGrid();
                DesabilitarCampo();
            }
            else
            {
                MessageBox.Show($"Ocorreu um erro no cadastro:\n\r{string.Join("\n\r", result.Messages)}");

            }
        }
        private Produto GetCurrentProduto()
        {

            if (_bsListaProduto == null || _bsListaProduto.Current == null)
                return null;

            if (_bsListaProduto.Current is Produto currentProduto)
                return currentProduto;

            return null;
        }
        private void ExcluirProduto_Click(object sender, EventArgs e)
        {
            var resposta = DialogResult;
            var currentProduto = GetCurrentProduto();
            if (currentProduto == null)
                return;

            resposta = MessageBox.Show("Deseje realmente excluir este produto?", "Excluir produto", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resposta != DialogResult.No)
            {
                if ((txtCdProduto.Text != "") & (txtQtd.Text != "") & (txtValor.Text != "") & (txtDescricaoProduto.Text != ""))
                {
                    //objTabela.CdProduto = txtCdProduto.Text.Trim();
                    var result = new ProdutoRepository().DeleteProduto(currentProduto);
                    MessageBox.Show(string.Format("Produto {0} Excluido com sucesso!", txtDescricaoProduto.Text));
                    limparCampos();
                    ListarGrid();
                    DesabilitarCampo();
                }
                else

                    MessageBox.Show(string.Format("Selecione um produto para que possa realizar a exclusão!"));
            }
            else
                MessageBox.Show(string.Format("Processo cancelado! "));

        }
        private void Editar()
        {
            HabilitarCampo();
            txtCdProduto.Enabled = false;
            btnSalvar.Enabled = true;
            btnNovo.Enabled = false;
            btnCancelar.Enabled = true;
            btnExcluirProduto.Enabled = false;
        }


        private void limparCampos()
        {
            txtCdProduto.Text = "";
            txtQtd.Text = "";
            txtValor.Text = "";
            txtDescricaoProduto.Text = "";
        }

        private void HabilitarCampo()
        {
            txtCdProduto.Enabled = true;
            txtQtd.Enabled = true;
            txtValor.Enabled = true;
            txtDescricaoProduto.Enabled = true;
        }

        private void DesabilitarCampo()
        {
            txtCdProduto.Enabled = false;
            txtQtd.Enabled = false;
            txtValor.Enabled = false;
            txtDescricaoProduto.Enabled = false;
            btnSalvar.Enabled = false;
        }


        private void ListarGrid(string sortColumn = "CdProduto")
        {

            try
            {

                List<Produto> lista = new List<Produto>();
                lista = new ProdutoRepository().ObterTodos(sortColumn);

                _bsListaProduto = new BindingSource(lista, "");
                listaprodutos.AutoGenerateColumns = false;
                listaprodutos.DataSource = _bsListaProduto;

                return;
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao Listar dados!");
            }
            return;
        }


        private void listaProdutos_Scroll(object sender, ScrollEventArgs e)
        {
            {
                txtCdProduto.Text = listaprodutos.CurrentRow.Cells[0].Value.ToString();
                txtDescricaoProduto.Text = listaprodutos.CurrentRow.Cells[1].Value.ToString();
                txtQtd.Text = listaprodutos.CurrentRow.Cells[2].Value.ToString();
                txtValor.Text = listaprodutos.CurrentRow.Cells[3].Value.ToString();
            }
        }
        private void LerProduto()
        {

            var currentProduto = GetCurrentProduto();
            if (currentProduto != null)
            {
                txtCdProduto.Text = currentProduto.CdProduto;
                txtDescricaoProduto.Text = currentProduto.Descricao;
                txtQtd.Text = currentProduto.Estoque.ToString();
                txtValor.Text = currentProduto.Valor.ToString();
            }
        }
        #endregion

        #region "Eventos"
        private void listaProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LerProduto();
            DesabilitarCampo();
            btnNovo.Enabled = true;
            btnExcluirProduto.Enabled = true;
            btnCancelar.Enabled = false;

        }
        private void listaprodutos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Editar();

        }

        private void listaprodutos_MouseDown(object sender, MouseEventArgs e)
        {
            Editar();
        }

        private void listaprodutos_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Editar();
        }

        private void listaprodutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LerProduto();
        }

        private void listaprodutos_SelectionChanged(object sender, EventArgs e)
        {
            LerProduto();
        }
        private void salvar_Click_1(object sender, EventArgs e)
        {
            if (txtCdProduto.Enabled == false)
            {
                AtualizarProduto();
                btnNovo.Enabled = true;
            }
            else
            {
                InserirProduto();
            }
        }
        private void cancelar_Click(object sender, EventArgs e)
        {
            limparCampos();
            btnNovo.Enabled = true;
            btnExcluirProduto.Enabled = true;
            btnSalvar.Enabled = false;
            DesabilitarCampo();
            btnCancelar.Enabled = false;
        }
        private void novo_Click(object sender, EventArgs e)
        {
            HabilitarCampo();
            limparCampos();
            btnSalvar.Enabled = true;
            btnExcluirProduto.Enabled = false;
            btnCancelar.Enabled = true;
        }
        private void valor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }
        private void fProduto_Load(object sender, EventArgs e)
        {
            ListarGrid();
            _bsListaProduto.CurrentChanged += OnCurrentItemChangeHandler;
        }
        private void OnCurrentItemChangeHandler(object sender, EventArgs e)
        {
            LerProduto();
        }
        private void cdProduto_KeyPress(object sender, KeyPressEventArgs e)
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
        private void qtd_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
               (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        #endregion

        private void listaprodutos_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                ListarGrid(nameof(Domain.Produtos.Produto.CdProduto));
            }
            else
                if(e.ColumnIndex == 1)
                //ListarGrid("Cpf");<- Evitar
                ListarGrid(nameof(Domain.Produtos.Produto.Descricao));
            else
                if(e.ColumnIndex == 2)
            {
                ListarGrid(nameof(Domain.Produtos.Produto.Valor));
            }
            else
                ListarGrid(nameof(Domain.Produtos.Produto.Estoque));
        }
    }
}
