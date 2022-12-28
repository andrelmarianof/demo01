
using System;

namespace demo01.Views.Produtos
{
    partial class fProduto
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cadastrarProdudo = new System.Windows.Forms.Button();
            this.cdProduto = new System.Windows.Forms.TextBox();
            this.descricaoProduto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.qtd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.valor = new System.Windows.Forms.TextBox();
            this.listaprodutos = new System.Windows.Forms.DataGridView();
            this.código = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descrição = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preçoUn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estoque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salvar = new System.Windows.Forms.Button();
            this.novo = new System.Windows.Forms.Button();
            this.editar = new System.Windows.Forms.Button();
            this.cancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.listaprodutos)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(170, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "&Código do produto";
            // 
            // cadastrarProdudo
            // 
            this.cadastrarProdudo.Enabled = false;
            this.cadastrarProdudo.Location = new System.Drawing.Point(694, 8);
            this.cadastrarProdudo.Name = "cadastrarProdudo";
            this.cadastrarProdudo.Size = new System.Drawing.Size(75, 23);
            this.cadastrarProdudo.TabIndex = 8;
            this.cadastrarProdudo.Text = "&Cadastrar";
            this.cadastrarProdudo.UseVisualStyleBackColor = true;
            this.cadastrarProdudo.Click += new System.EventHandler(this.cadastrarProdudo_Click);
            // 
            // cdProduto
            // 
            this.cdProduto.Enabled = false;
            this.cdProduto.Location = new System.Drawing.Point(25, 40);
            this.cdProduto.Name = "cdProduto";
            this.cdProduto.Size = new System.Drawing.Size(63, 20);
            this.cdProduto.TabIndex = 7;
            this.cdProduto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cdProduto_KeyPress);
            // 
            // descricaoProduto
            // 
            this.descricaoProduto.Enabled = false;
            this.descricaoProduto.Location = new System.Drawing.Point(121, 41);
            this.descricaoProduto.Name = "descricaoProduto";
            this.descricaoProduto.Size = new System.Drawing.Size(211, 20);
            this.descricaoProduto.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(176, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "&Descrição do produto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(348, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "&Quantidade em estoque";
            // 
            // qtd
            // 
            this.qtd.Enabled = false;
            this.qtd.Location = new System.Drawing.Point(380, 40);
            this.qtd.Name = "qtd";
            this.qtd.Size = new System.Drawing.Size(63, 20);
            this.qtd.TabIndex = 12;
            this.qtd.TextChanged += new System.EventHandler(this.qtd_TextChanged);
            this.qtd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.qtd_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(493, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "&Valor do produto";
            // 
            // valor
            // 
            this.valor.Enabled = false;
            this.valor.Location = new System.Drawing.Point(506, 40);
            this.valor.MaxLength = 1000000;
            this.valor.Name = "valor";
            this.valor.Size = new System.Drawing.Size(63, 20);
            this.valor.TabIndex = 14;
            this.valor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.valor_KeyPress);
            // 
            // listaprodutos
            // 
            this.listaprodutos.AllowUserToAddRows = false;
            this.listaprodutos.AllowUserToDeleteRows = false;
            this.listaprodutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaprodutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.código,
            this.descrição,
            this.preçoUn,
            this.estoque});
            this.listaprodutos.Location = new System.Drawing.Point(25, 87);
            this.listaprodutos.Name = "listaprodutos";
            this.listaprodutos.ReadOnly = true;
            this.listaprodutos.Size = new System.Drawing.Size(443, 311);
            this.listaprodutos.TabIndex = 16;
            this.listaprodutos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listaprodutos_CellClick);
            this.listaprodutos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listaprodutos_CellContentClick);
            // 
            // código
            // 
            this.código.DataPropertyName = "Id";
            this.código.HeaderText = "codigo";
            this.código.Name = "código";
            this.código.ReadOnly = true;
            // 
            // descrição
            // 
            this.descrição.DataPropertyName = "Descricao";
            this.descrição.HeaderText = "descrição";
            this.descrição.Name = "descrição";
            this.descrição.ReadOnly = true;
            // 
            // preçoUn
            // 
            this.preçoUn.DataPropertyName = "valor";
            this.preçoUn.HeaderText = "valor";
            this.preçoUn.Name = "preçoUn";
            this.preçoUn.ReadOnly = true;
            // 
            // estoque
            // 
            this.estoque.DataPropertyName = "Quantidade";
            this.estoque.HeaderText = "estoque";
            this.estoque.Name = "estoque";
            this.estoque.ReadOnly = true;
            // 
            // salvar
            // 
            this.salvar.Enabled = false;
            this.salvar.Location = new System.Drawing.Point(694, 41);
            this.salvar.Name = "salvar";
            this.salvar.Size = new System.Drawing.Size(75, 23);
            this.salvar.TabIndex = 17;
            this.salvar.Text = "&Salvar";
            this.salvar.UseVisualStyleBackColor = true;
            this.salvar.Click += new System.EventHandler(this.salvar_Click_1);
            // 
            // novo
            // 
            this.novo.Location = new System.Drawing.Point(595, 8);
            this.novo.Name = "novo";
            this.novo.Size = new System.Drawing.Size(75, 23);
            this.novo.TabIndex = 18;
            this.novo.Text = "&Novo";
            this.novo.UseVisualStyleBackColor = true;
            this.novo.Click += new System.EventHandler(this.novo_Click);
            // 
            // editar
            // 
            this.editar.Location = new System.Drawing.Point(595, 39);
            this.editar.Name = "editar";
            this.editar.Size = new System.Drawing.Size(75, 23);
            this.editar.TabIndex = 19;
            this.editar.Text = "&Editar";
            this.editar.UseVisualStyleBackColor = true;
            this.editar.Click += new System.EventHandler(this.editar_Click);
            // 
            // cancelar
            // 
            this.cancelar.Enabled = false;
            this.cancelar.Location = new System.Drawing.Point(595, 77);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(75, 23);
            this.cancelar.TabIndex = 20;
            this.cancelar.Text = "&Cancelar";
            this.cancelar.UseVisualStyleBackColor = true;
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // fProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.editar);
            this.Controls.Add(this.novo);
            this.Controls.Add(this.salvar);
            this.Controls.Add(this.listaprodutos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.valor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.qtd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cadastrarProdudo);
            this.Controls.Add(this.cdProduto);
            this.Controls.Add(this.descricaoProduto);
            this.Name = "fProduto";
            this.Tag = "";
            this.Text = "Cadastro de produto";
            this.Load += new System.EventHandler(this.fProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listaprodutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
  #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cadastrarProdudo;
        private System.Windows.Forms.TextBox cdProduto;
        private System.Windows.Forms.TextBox descricaoProduto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox qtd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox valor;
        private System.Windows.Forms.DataGridView listaprodutos;
        private System.Windows.Forms.DataGridViewTextBoxColumn código;
        private System.Windows.Forms.DataGridViewTextBoxColumn descrição;
        private System.Windows.Forms.DataGridViewTextBoxColumn preçoUn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estoque;
        private System.Windows.Forms.Button salvar;
        private System.Windows.Forms.Button novo;
        private System.Windows.Forms.Button editar;
        private System.Windows.Forms.Button cancelar;
    }
}