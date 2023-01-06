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
using System.Threading.Tasks;
using System.Windows.Forms;
namespace demo01.Views.Produtos
{
    public partial class fProduto : Form
    {
        public fProduto()
        {
            InitializeComponent();
        }

        Produto objTabela = new Produto();

        //private string opc = "";

        private void ListarGrid(int v)
        {
            try
            {

                List<Produto> lista = new List<Produto>();
                lista = new ProdutoRepository().ObterTodos();
                listaprodutos.AutoGenerateColumns = false;
                listaprodutos.DataSource = lista;

            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao Listar dados!", e.Message);
            }
        }

        private void InserirProduto()
        {
            if ((cdProduto.Text != "") & (txtQtd.Text != "") & (txtValor.Text != "") & (txtDescricaoProduto.Text != ""))
            {

                try
                {

                    objTabela.Descricao = txtDescricaoProduto.Text.Trim().ToLower();
                    objTabela.CdProduto = cdProduto.Text.Trim();

                    decimal quantidade;
                    if (!decimal.TryParse(txtQtd.Text.Trim(), out quantidade))
                    {
                        MessageBox.Show(string.Format("Valor informado para quantidade não é válido!"));
                        return;
                    }

                    objTabela.Estoque = quantidade;

                    decimal valorProduto;
                    if (!decimal.TryParse(txtValor.Text.Trim(), out valorProduto))
                    {
                        MessageBox.Show(string.Format("Valor informado para valor não é válido!"));
                        return;
                    }

                    objTabela.Valor = valorProduto;

                    var result = new ProdutoAppService().Inserir(objTabela);
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
        private void ExcluirProduto_Click(object sender, EventArgs e)
        {
            if ((cdProduto.Text != "") & (txtQtd.Text != "") & (txtValor.Text != "") & (txtDescricaoProduto.Text != ""))
            {
                objTabela.CdProduto = cdProduto.Text.Trim();
                new ProdutoRepository().Excluir(objTabela);
                MessageBox.Show(string.Format("Produto {0} Excluido com sucesso!", txtDescricaoProduto.Text));
                limparCampos();
                ListarGrid();
                DesabilitarCampo();
            }
            else

                MessageBox.Show(string.Format("Ocorreu um erro ao excluir o produto! Verifique. "));

        }

        private void AtualizarProduto()
        {
            if ((cdProduto.Text != "") & (txtQtd.Text != "") & (txtValor.Text != "") & (txtDescricaoProduto.Text != ""))
            {
                try
                {

                    objTabela.Descricao = txtDescricaoProduto.Text.Trim().ToLower();
                    objTabela.CdProduto = cdProduto.Text.Trim();
                    objTabela.Estoque = Convert.ToDecimal(txtQtd.Text.Trim());
                    objTabela.Valor = Convert.ToDecimal(txtValor.Text.Trim());

                    int x = new ProdutoRepository().Atualizar(objTabela);

                    if (x > 0)
                    {
                        MessageBox.Show(string.Format("Produto {0} Editado com sucesso!", txtDescricaoProduto.Text));
                        limparCampos();
                        ListarGrid();
                        DesabilitarCampo();
                    }
                    else

                        MessageBox.Show("Ocorreu um erro no cadastro, verifique os dados informados!");

                }
                catch
                {
                    MessageBox.Show("Ocorreu um erro ao editar! verifique os dados informados!");

                }
            }
            else
                MessageBox.Show("insira todos os campos para editar!");
        }
        private void cadastrarProdudo_Click(object sender, EventArgs e)
        {
            if (txtDescricaoProduto.Enabled == true)
            {
                InserirProduto();
                btnEditar.Enabled = true;
                btnNovo.Enabled = true;

            }
            else
                MessageBox.Show("Realize um novo cadastro para que possa salvar!");
        }
        private void salvar_Click_1(object sender, EventArgs e)
        {
            if (txtDescricaoProduto.Enabled == true)
            {
                AtualizarProduto();
                ListarGrid();
                limparCampos();
                btnNovo.Enabled = true;
            }
            else
                MessageBox.Show("Selecione um registro para salvar!");

        }

        private void qtd_TextChanged(object sender, EventArgs e)
        {

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

            bsListaProduto = new BindingSource(new ProdutoRepository().ObterTodos(), "");
            listaprodutos.DataSource = bsListaProduto;
            bsListaProduto.CurrentItemChanged += OnCurrentItemChanger;
        }

        private void OnCurrentItemChanger(object sender, EventArgs e)
        {
            lerProduto();

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

        private void listaProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lerProduto();
            DesabilitarCampo();
            btnNovo.Enabled = true;
            btnEditar.Enabled = true;
            cancelar.Enabled = false;


        }
       private void  lerProduto()
        {
            cdProduto.Text = listaprodutos.CurrentRow.Cells[0].Value.ToString();
            txtDescricaoProduto.Text = listaprodutos.CurrentRow.Cells[1].Value.ToString();
            txtQtd.Text = listaprodutos.CurrentRow.Cells[2].Value.ToString();
            txtValor.Text = listaprodutos.CurrentRow.Cells[3].Value.ToString();
            return;
        }
        private void novo_Click(object sender, EventArgs e)
        {
            HabilitarCampo();
            limparCampos();
            cadastrarProdudo.Enabled = true;
            btnEditar.Enabled = false;
            cancelar.Enabled = true;
        }

        private void Editar() 
        {
            HabilitarCampo();
            cdProduto.Enabled = false;
            salvar.Enabled = true;
            btnNovo.Enabled = false;
            cancelar.Enabled = true;
        }
        private void cancelar_Click(object sender, EventArgs e)
        {
            limparCampos();
            btnNovo.Enabled = true;
            btnEditar.Enabled = true;
            salvar.Enabled = false;
            cadastrarProdudo.Enabled = false;
            DesabilitarCampo();
        }

        private void limparCampos()
        {
            cdProduto.Text = "";
            txtQtd.Text = "";
            txtValor.Text = "";
            txtDescricaoProduto.Text = "";
        }

        private void HabilitarCampo()
        {
            cdProduto.Enabled = true;
            txtQtd.Enabled = true;
            txtValor.Enabled = true;
            txtDescricaoProduto.Enabled = true;
        }

        private void DesabilitarCampo()
        {
            cdProduto.Enabled = false;
            txtQtd.Enabled = false;
            txtValor.Enabled = false;
            txtDescricaoProduto.Enabled = false;
            salvar.Enabled = false;
            cadastrarProdudo.Enabled = false;
        }

        private BindingSource bsListaProduto;
        private void ListarGrid()
        {
            return;
            try
            {

                List<Produto> lista = new List<Produto>();
                lista = new ProdutoRepository().ObterTodos();

                listaprodutos.AutoGenerateColumns = false;
                listaprodutos.DataSource = lista;

            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao Listar dados!");
            }
        }

        private void listaProdutos_Scroll(object sender, ScrollEventArgs e)
        {
            {
                cdProduto.Text = listaprodutos.CurrentRow.Cells[0].Value.ToString();
                txtDescricaoProduto.Text = listaprodutos.CurrentRow.Cells[1].Value.ToString();
                txtQtd.Text = listaprodutos.CurrentRow.Cells[2].Value.ToString();
                txtValor.Text = listaprodutos.CurrentRow.Cells[3].Value.ToString();
            }
        }
 

        private void listaprodutos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Editar();
        }
    }
}
