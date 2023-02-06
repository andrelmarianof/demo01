
namespace demo01.Views.Pedido
{
    partial class PedidoView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSalvarPedido = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCdCliente = new System.Windows.Forms.TextBox();
            this.txtDescricaoCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCdProduto = new System.Windows.Forms.TextBox();
            this.txtDescricaoProduto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtQtd = new System.Windows.Forms.TextBox();
            this.btnAddProduto = new System.Windows.Forms.Button();
            this.btnNovoPedido = new System.Windows.Forms.Button();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ListaProdutosDoPedido = new System.Windows.Forms.DataGridView();
            this.btnPesquisarCliente = new System.Windows.Forms.Button();
            this.TxtNumero = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnPesquisarProduto = new System.Windows.Forms.Button();
            this.código = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descrição = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preçoUn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estoque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCancelarPedido = new System.Windows.Forms.Button();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ListaProdutosDoPedido)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalvarPedido
            // 
            this.btnSalvarPedido.Location = new System.Drawing.Point(109, 73);
            this.btnSalvarPedido.Name = "btnSalvarPedido";
            this.btnSalvarPedido.Size = new System.Drawing.Size(98, 25);
            this.btnSalvarPedido.TabIndex = 0;
            this.btnSalvarPedido.Text = "&Confirmar Pedido ";
            this.btnSalvarPedido.UseVisualStyleBackColor = true;
            this.btnSalvarPedido.Click += new System.EventHandler(this.btnSalvarPedido_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "&Nome do cliente";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtCdCliente
            // 
            this.txtCdCliente.Location = new System.Drawing.Point(18, 159);
            this.txtCdCliente.Name = "txtCdCliente";
            this.txtCdCliente.Size = new System.Drawing.Size(86, 20);
            this.txtCdCliente.TabIndex = 7;
            this.txtCdCliente.TextChanged += new System.EventHandler(this.cdCliente_TextChanged);
            // 
            // txtDescricaoCliente
            // 
            this.txtDescricaoCliente.Location = new System.Drawing.Point(109, 159);
            this.txtDescricaoCliente.Name = "txtDescricaoCliente";
            this.txtDescricaoCliente.Size = new System.Drawing.Size(211, 20);
            this.txtDescricaoCliente.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "&Código do cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(109, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "&Descrição do produto";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "&Código do Produto";
            // 
            // txtCdProduto
            // 
            this.txtCdProduto.Location = new System.Drawing.Point(18, 202);
            this.txtCdProduto.Name = "txtCdProduto";
            this.txtCdProduto.Size = new System.Drawing.Size(86, 20);
            this.txtCdProduto.TabIndex = 12;
            // 
            // txtDescricaoProduto
            // 
            this.txtDescricaoProduto.Location = new System.Drawing.Point(109, 202);
            this.txtDescricaoProduto.Name = "txtDescricaoProduto";
            this.txtDescricaoProduto.Size = new System.Drawing.Size(211, 20);
            this.txtDescricaoProduto.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(407, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "&Quantidade";
            // 
            // txtQtd
            // 
            this.txtQtd.Location = new System.Drawing.Point(406, 202);
            this.txtQtd.Name = "txtQtd";
            this.txtQtd.Size = new System.Drawing.Size(76, 20);
            this.txtQtd.TabIndex = 16;
            // 
            // btnAddProduto
            // 
            this.btnAddProduto.Location = new System.Drawing.Point(522, 202);
            this.btnAddProduto.Name = "btnAddProduto";
            this.btnAddProduto.Size = new System.Drawing.Size(102, 20);
            this.btnAddProduto.TabIndex = 18;
            this.btnAddProduto.Text = "&Adicionar Produto";
            this.btnAddProduto.UseVisualStyleBackColor = true;
            this.btnAddProduto.Click += new System.EventHandler(this.btnAddProduto_Click);
            // 
            // btnNovoPedido
            // 
            this.btnNovoPedido.Location = new System.Drawing.Point(18, 73);
            this.btnNovoPedido.Name = "btnNovoPedido";
            this.btnNovoPedido.Size = new System.Drawing.Size(86, 25);
            this.btnNovoPedido.TabIndex = 19;
            this.btnNovoPedido.Text = "&Criar Pedido";
            this.btnNovoPedido.UseVisualStyleBackColor = true;
            this.btnNovoPedido.Click += new System.EventHandler(this.btnNovoPedido_Click);
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(325, 202);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(76, 20);
            this.txtValor.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(325, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "&Valor";
            // 
            // ListaProdutosDoPedido
            // 
            this.ListaProdutosDoPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListaProdutosDoPedido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.ListaProdutosDoPedido.Location = new System.Drawing.Point(18, 231);
            this.ListaProdutosDoPedido.Name = "ListaProdutosDoPedido";
            this.ListaProdutosDoPedido.Size = new System.Drawing.Size(544, 320);
            this.ListaProdutosDoPedido.TabIndex = 22;
            this.ListaProdutosDoPedido.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnPesquisarCliente
            // 
            this.btnPesquisarCliente.Location = new System.Drawing.Point(325, 156);
            this.btnPesquisarCliente.Name = "btnPesquisarCliente";
            this.btnPesquisarCliente.Size = new System.Drawing.Size(28, 25);
            this.btnPesquisarCliente.TabIndex = 23;
            this.btnPesquisarCliente.Text = "...";
            this.btnPesquisarCliente.UseVisualStyleBackColor = true;
            this.btnPesquisarCliente.Click += new System.EventHandler(this.btnPesquisarCliente_Click);
            // 
            // TxtNumero
            // 
            this.TxtNumero.Enabled = false;
            this.TxtNumero.Location = new System.Drawing.Point(18, 120);
            this.TxtNumero.Name = "TxtNumero";
            this.TxtNumero.Size = new System.Drawing.Size(86, 20);
            this.TxtNumero.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "&Numero do pedido";
            // 
            // btnPesquisarProduto
            // 
            this.btnPesquisarProduto.Location = new System.Drawing.Point(488, 200);
            this.btnPesquisarProduto.Name = "btnPesquisarProduto";
            this.btnPesquisarProduto.Size = new System.Drawing.Size(28, 25);
            this.btnPesquisarProduto.TabIndex = 26;
            this.btnPesquisarProduto.Text = "...";
            this.btnPesquisarProduto.UseVisualStyleBackColor = true;
            this.btnPesquisarProduto.Click += new System.EventHandler(this.btnPesquisarProduto_Click);
            // 
            // código
            // 
            this.código.DataPropertyName = "CdProduto";
            this.código.HeaderText = "Código";
            this.código.Name = "código";
            this.código.ReadOnly = true;
            // 
            // descrição
            // 
            this.descrição.DataPropertyName = "Descricao";
            this.descrição.HeaderText = "Descrição";
            this.descrição.Name = "descrição";
            this.descrição.ReadOnly = true;
            this.descrição.Width = 200;
            // 
            // preçoUn
            // 
            this.preçoUn.DataPropertyName = "valor";
            this.preçoUn.HeaderText = "Valor";
            this.preçoUn.Name = "preçoUn";
            this.preçoUn.ReadOnly = true;
            // 
            // estoque
            // 
            this.estoque.DataPropertyName = "Estoque";
            this.estoque.HeaderText = "Estoque";
            this.estoque.Name = "estoque";
            this.estoque.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CdProduto";
            this.dataGridViewTextBoxColumn1.HeaderText = "Código";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Descricao";
            this.dataGridViewTextBoxColumn2.HeaderText = "Descrição";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "valor";
            this.dataGridViewTextBoxColumn3.HeaderText = "Valor";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Estoque";
            this.dataGridViewTextBoxColumn4.HeaderText = "Estoque";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "CdProduto";
            this.dataGridViewTextBoxColumn5.HeaderText = "Código";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Descricao";
            this.dataGridViewTextBoxColumn6.HeaderText = "Descrição";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 200;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "valor";
            this.dataGridViewTextBoxColumn7.HeaderText = "Valor";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Estoque";
            this.dataGridViewTextBoxColumn8.HeaderText = "Estoque";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "CdProduto";
            this.dataGridViewTextBoxColumn9.HeaderText = "Código";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Descricao";
            this.dataGridViewTextBoxColumn10.HeaderText = "Descrição";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 200;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "valor";
            this.dataGridViewTextBoxColumn11.HeaderText = "Valor";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Estoque";
            this.dataGridViewTextBoxColumn12.HeaderText = "Estoque";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // btnCancelarPedido
            // 
            this.btnCancelarPedido.Location = new System.Drawing.Point(213, 73);
            this.btnCancelarPedido.Name = "btnCancelarPedido";
            this.btnCancelarPedido.Size = new System.Drawing.Size(98, 25);
            this.btnCancelarPedido.TabIndex = 27;
            this.btnCancelarPedido.Text = "&Cancelar Pedido ";
            this.btnCancelarPedido.UseVisualStyleBackColor = true;
            this.btnCancelarPedido.Click += new System.EventHandler(this.btnCancelarPedido_Click);
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "CdProduto";
            this.Column5.HeaderText = "Código";
            this.Column5.Name = "Column5";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Descricao";
            this.Column1.HeaderText = "Descrição";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "VlVenda";
            this.Column2.HeaderText = "Valor";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "QtdVenda";
            this.Column3.HeaderText = "Quantidade";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Total";
            this.Column4.HeaderText = "Total item";
            this.Column4.Name = "Column4";
            // 
            // PedidoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 554);
            this.Controls.Add(this.btnCancelarPedido);
            this.Controls.Add(this.btnPesquisarProduto);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TxtNumero);
            this.Controls.Add(this.btnPesquisarCliente);
            this.Controls.Add(this.ListaProdutosDoPedido);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.btnNovoPedido);
            this.Controls.Add(this.btnAddProduto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtQtd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCdProduto);
            this.Controls.Add(this.txtDescricaoProduto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCdCliente);
            this.Controls.Add(this.txtDescricaoCliente);
            this.Controls.Add(this.btnSalvarPedido);
            this.Name = "PedidoView";
            this.Text = "Pedido";
            this.Load += new System.EventHandler(this.PedidoView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ListaProdutosDoPedido)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalvarPedido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCdCliente;
        private System.Windows.Forms.TextBox txtDescricaoCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCdProduto;
        private System.Windows.Forms.TextBox txtDescricaoProduto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtQtd;
        private System.Windows.Forms.Button btnAddProduto;
        private System.Windows.Forms.Button btnNovoPedido;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView ListaProdutosDoPedido;
        private System.Windows.Forms.Button btnPesquisarCliente;
        private System.Windows.Forms.TextBox TxtNumero;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnPesquisarProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn código;
        private System.Windows.Forms.DataGridViewTextBoxColumn descrição;
        private System.Windows.Forms.DataGridViewTextBoxColumn preçoUn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estoque;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.Button btnCancelarPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}