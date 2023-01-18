using System;
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
    
    public partial class Cliente : Form
    {
        private BindingSource _bsListaCliente;

        public Cliente()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InserirCliente();
        }

        private void Cliente_Load(object sender, EventArgs e)
        {

            ListarGrid();
            _bsListaCliente.CurrentChanged += OnCurrentItemChangeHandler;
            
        }
        private void OnCurrentItemChangeHandler(object sender, EventArgs e)
        {
            ListarGrid();
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

        private void btnNovoCliente_Click(object sender, EventArgs e)
        {
            limparCampos();
            HabilitarCampo();
        }
        private void InserirCliente()
        {
            if ((txtCodigoCliente.Text != "") & (txtNomeCliente.Text != ""))
            {
                try
                {
                    var cliente = new Clientes();
                    cliente.CdCliente = txtCodigoCliente.Text.Trim().ToLower();
                    cliente.NomeCliente = txtNomeCliente.Text.Trim();
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
                MessageBox.Show("insira todos os campos para cadastrar um produto!");

            }
        }
     
        private void limparCampos()
        {
            txtCodigoCliente.Text = "";
            txtNomeCliente.Text = "";
          
        }

        private void HabilitarCampo()
        {
            txtCodigoCliente.Enabled = true;
            txtNomeCliente.Enabled = true;
           
        }

        private void DesabilitarCampo()
        {
            txtCodigoCliente.Enabled = false;
            txtNomeCliente.Enabled = false;
         
        }

        private void listacliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ListarGrid();
        }
        private void ListarGrid()
        {

            try
            {

        
                List<Clientes> lista1 = new ClienteRepository().ListarClientes();
                lista1 = lista1;

                _bsListaCliente = new BindingSource(lista1, "");
                listacliente.AutoGenerateColumns = false;
                listacliente.DataSource = _bsListaCliente;

                return;
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao Listar dados!");
            }
            return;
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

        private void txtNomeCliente_KeyPress(object sender, KeyPressEventArgs e)
        {


        }
    }
}
