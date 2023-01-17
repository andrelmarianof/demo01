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


                }
                catch
                {

                }
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

                List<Cliente> lista1 = new List<Cliente>();
              //  lista1 = new ClienteRepository().ListarClientes();
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
    }
}
