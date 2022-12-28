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
using demo01.Domain.Produto;
namespace demo01.Views.Produtos
{
    public partial class fProduto : Form
    {
        public fProduto()
        {
            InitializeComponent();
            var produto = new demo01.Domain.Produto.Produto();
         }

        produtoent objTabela = new produtoent();

        private string opc = "";

        private void ListarGrid(int v)
        {
            try
            {

                List<produtoent> lista = new List<produtoent>();
                lista = new produtomodel().Lista(objTabela);
                listaprodutos.AutoGenerateColumns = false;
                listaprodutos.DataSource = lista;

            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao Listar dados!", e.Message);
            }
        }

        private void iniciartOpc()
        {
            
            switch (opc)
            {

                case "Salvar":
                   if ((cdProduto.Text != "") & (qtd.Text != "") & (valor.Text != "") & (descricaoProduto.Text != ""))
                    {
                        try
                        {

                            objTabela.Descricao = descricaoProduto.Text.Trim().ToLower();
                            objTabela.Id = Convert.ToDecimal(cdProduto.Text.Trim());
                            objTabela.Quantidade = Convert.ToDecimal(qtd.Text.Trim());
                            objTabela.Valor = Convert.ToDecimal(valor.Text.Trim());

                            int x = produtomodel.Inserir(objTabela);

                            if (x > 0)
                            {
                                MessageBox.Show(string.Format("Produto {0} inserido com sucesso!", descricaoProduto.Text));
                                limparCampos();
                                ListarGrid();
                                DesabilitarCampo();
                            }
                            else
                            {
                                MessageBox.Show("Ocorreu um erro no cadastro, verifique os dados informados!");
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
                    break;

                case "Editar":
                    if ((cdProduto.Text != "") & (qtd.Text != "") & (valor.Text != "") & (descricaoProduto.Text != ""))
                    {
                        try
                        {

                            objTabela.Descricao = descricaoProduto.Text.Trim().ToLower();
                            objTabela.Id = Convert.ToDecimal(cdProduto.Text.Trim());
                            objTabela.Quantidade = Convert.ToDecimal(qtd.Text.Trim());
                            objTabela.Valor = Convert.ToDecimal(valor.Text.Trim());

                            int x = produtomodel.Editar(objTabela);

                            if (x > 0)
                            {
                                MessageBox.Show(string.Format("Produto {0} Editado com sucesso!", descricaoProduto.Text));
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

                    break;

              default:

              break;

            }
         
        }

        private void cadastrarProdudo_Click(object sender, EventArgs e)
        {
            if (descricaoProduto.Enabled == true)
            {
                opc = "Salvar";
                iniciartOpc();
                editar.Enabled = true;
                novo.Enabled = true;
                
            }
            else
                MessageBox.Show("Realize um novo cadastro para que possa salvar!");
        }
        private void salvar_Click_1(object sender, EventArgs e)
        {
            if (descricaoProduto.Enabled == true)
            {
                opc = "Editar";
                iniciartOpc();
                ListarGrid();
                limparCampos();
                novo.Enabled = true;
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

        private void listaprodutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listaprodutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cdProduto.Text = listaprodutos.CurrentRow.Cells[0].Value.ToString();
            descricaoProduto.Text = listaprodutos.CurrentRow.Cells[1].Value.ToString();
            qtd.Text = listaprodutos.CurrentRow.Cells[2].Value.ToString();
            valor.Text = listaprodutos.CurrentRow.Cells[3].Value.ToString();
            DesabilitarCampo();
            novo.Enabled = true;
            editar.Enabled = true;
            cancelar.Enabled = false;

            
        }

        private void novo_Click(object sender, EventArgs e)
        {
            HabilitarCampo();
            limparCampos();
            cadastrarProdudo.Enabled = true;
            editar.Enabled = false;
            cancelar.Enabled = true;
        }

        private void editar_Click(object sender, EventArgs e)
        {
            HabilitarCampo();
            cdProduto.Enabled = false;
            salvar.Enabled = true;
            novo.Enabled = false;
            cancelar.Enabled = true;
        }
        private void cancelar_Click(object sender, EventArgs e)
        {
            limparCampos();
            novo.Enabled = true;
            editar.Enabled = true;
            salvar.Enabled = false;
            cadastrarProdudo.Enabled = false;
            DesabilitarCampo();
        }

        private void limparCampos()
        {
            cdProduto.Text = "";
            qtd.Text = "";
            valor.Text = "";
            descricaoProduto.Text = "";
        }

        private void HabilitarCampo()
        {
            cdProduto.Enabled = true;
            qtd.Enabled = true;
            valor.Enabled = true;
            descricaoProduto.Enabled = true;
        }

        private void DesabilitarCampo()
        {
            cdProduto.Enabled = false;
            qtd.Enabled = false;
            valor.Enabled = false;
            descricaoProduto.Enabled = false;
            salvar.Enabled = false;
            cadastrarProdudo.Enabled = false;
        }

        private void ListarGrid()
        {
            try
            {

                List<produtoent> lista = new List<produtoent>();
                lista = new produtodb().Lista(objTabela);

                listaprodutos.AutoGenerateColumns = false;
                listaprodutos.DataSource = lista;

            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao Listar dados!");
            }
        }


    }
}
