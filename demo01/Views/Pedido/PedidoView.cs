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
using demo01.Views.Cliente;
using demo01.Data.RepositoriesCliente;
using demo01.Application.Pedidos;
using demo01.Domain.Produtos;

namespace demo01.Views.Pedido
{
    public partial class PedidoView : MetroFramework.Forms.MetroForm
    {
        private object sortColumn;
        private BindingSource _bsListaCliente;

        public PedidoView()
        {
            InitializeComponent();

            
        }
        private void InserirCliente()
        {
            
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

        private void btnPesquisarCliente_Click(object sender, EventArgs e)
        {
           
        }
    }
}
