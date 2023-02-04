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

namespace demo01.Views.Pedido
{
    public partial class BuscarCliente : MetroFramework.Forms.MetroForm
    {
        public BindingSource _bsListaCliente;
        public BuscarCliente()
        {
            InitializeComponent();
            ListarGrid();
        }

        private void listacliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void ListarGrid(string sortColumn = "CdCliente")
        {

            try
            {


                List<Domain.Clientes.Cliente> lista1 = new List<Domain.Clientes.Cliente>();
                lista1 = new ClienteRepository().ListarClientes(sortColumn);


                _bsListaCliente = new BindingSource(lista1, "");
                buscarClienteGrid.AutoGenerateColumns = false;
                buscarClienteGrid.DataSource = _bsListaCliente;

            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao Listar dados!");
            }
            return;
        }

        private void buscarClienteGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //using (var PedidoView = new PedidoView())
            //{
            //    PedidoView.CdProduto = txt.Text;
            //    form1.Sobrenome = txtSobrenome.Text;
            //    form1.ShowDialog();
            //}
        }
    }
       
}

