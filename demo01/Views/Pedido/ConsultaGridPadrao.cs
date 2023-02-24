using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using demo01.Data.Repositories;
using demo01.Data.RepositoriesCliente;
using demo01.Data.RepositoriesPedido;
using demo01.Domain.Produtos;

namespace demo01.Views.Pedido
{

    public class DataSourceConsulta
    {
        public bool HasData { get; set; }
        public string MessageNoData { get; set; }
        public object Data { get; set; }
    }
    public class ColunaConsulta
    {
        public ColunaConsulta(string nomeColuna, string descricaoColuna)
        {
            NomeColuna = nomeColuna;
            DescricaoColuna = descricaoColuna;
        }

        public string NomeColuna { get; set; }
        public string DescricaoColuna { get; set; }
    }
    public class ConfiguracaoConsulta
    {
        public List<ColunaConsulta> Colunas { get; set; }
        public Func<DataSourceConsulta> ObterDataSource { get; set; }
        public Action<object> DevolverRetorno { get; set; }
    }

    public partial class ConsultaGridPadrao : MetroFramework.Forms.MetroForm
    {

        public string ReturnValue;
        public ConfiguracaoConsulta _configuracao;
        public ConsultaGridPadrao()
        {
            InitializeComponent();
        }

        public ConsultaGridPadrao(ConfiguracaoConsulta configuracao)
        {
            InitializeComponent();
            _configuracao = configuracao;
            PopularGrid();
            ConfigurarColunas();
        }

        private BindingSource _bsListaProduto;

        #region Métodos de configuração de grid
        private void ConfigurarColunas()
        {
            GridDeConsultasGenerico.Columns.Clear();
            foreach (var coluna in
                _configuracao.Colunas)
            {
                GridDeConsultasGenerico.Columns.Add(coluna.NomeColuna, coluna.DescricaoColuna);
                GridDeConsultasGenerico.Columns[coluna.NomeColuna].DataPropertyName = coluna.NomeColuna;

            }
            GridDeConsultasGenerico.AutoGenerateColumns = false;
        }

        private void PopularGrid()
        {

            var dataSource = _configuracao.ObterDataSource();
            if (dataSource.HasData)
                GridDeConsultasGenerico.DataSource = dataSource.Data;
            else
                MessageBox.Show(dataSource.MessageNoData);

        }
        #endregion

        private void txtSearch_TextChanged_1(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text;

            if (!string.IsNullOrEmpty(searchText))
            {
                GridDeConsultasGenerico.CurrentCell = null;
                foreach (DataGridViewRow row in GridDeConsultasGenerico.Rows)
                {
                    bool match = false;
                    for (int i = 0; i < row.Cells.Count; i++)
                    {
                        if (row.Cells[i].Value != null && row.Cells[i].Value.ToString().Contains(searchText))
                        {
                            match = true;
                            break;
                        }
                    }
                    row.Visible = match;
                }
            }
            else
            {
                foreach (DataGridViewRow row in GridDeConsultasGenerico.Rows)
                {
                    row.Visible = true;
                }
            }
        }

        private void GridDeConsultasGenerico_DoubleClick(object sender, EventArgs e)
        {
            if (GridDeConsultasGenerico.CurrentRow != null)
            {
                _configuracao.DevolverRetorno(GridDeConsultasGenerico.CurrentRow.DataBoundItem);
                this.Close();
            }
        }

        private void GridDeConsultasGenerico_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                var linhaClicada = GridDeConsultasGenerico.Rows[e.RowIndex];

            }
        }

        private void GridDeConsultasGenerico_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                GridDeConsultasGenerico.Focus();
            }
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
            }
        }
    }
}
