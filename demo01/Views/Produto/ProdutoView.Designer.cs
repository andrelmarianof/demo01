
using C1.Win.C1Command;
using System;

namespace demo01.Views.Produtos
{
    partial class ProdutoView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProdutoView));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCdProduto = new System.Windows.Forms.TextBox();
            this.txtDescricaoProduto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtQtd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.listaprodutos = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.c1CommandHolder1 = new C1.Win.C1Command.C1CommandHolder();
            this.c1Command2 = new C1.Win.C1Command.C1Command();
            this.c1Command3 = new C1.Win.C1Command.C1Command();
            this.c1Command4 = new C1.Win.C1Command.C1Command();
            this.c1Command5 = new C1.Win.C1Command.C1Command();
            this.c1Command6 = new C1.Win.C1Command.C1Command();
            this.c1Command7 = new C1.Win.C1Command.C1Command();
            this.c1Command8 = new C1.Win.C1Command.C1Command();
            this.c1Command9 = new C1.Win.C1Command.C1Command();
            this.c1Command10 = new C1.Win.C1Command.C1Command();
            this.c1Command11 = new C1.Win.C1Command.C1Command();
            this.c1Command12 = new C1.Win.C1Command.C1Command();
            this.c1Command13 = new C1.Win.C1Command.C1Command();
            this.c1CommandLink2 = new C1.Win.C1Command.C1CommandLink();
            this.c1CommandLink3 = new C1.Win.C1Command.C1CommandLink();
            this.c1CommandLink4 = new C1.Win.C1Command.C1CommandLink();
            this.c1CommandLink5 = new C1.Win.C1Command.C1CommandLink();
            this.c1ToolBar2 = new C1.Win.C1Command.C1ToolBar();
            this.c1CommandLink1 = new C1.Win.C1Command.C1CommandLink();
            this.c1CommandLink6 = new C1.Win.C1Command.C1CommandLink();
            this.c1CommandLink7 = new C1.Win.C1Command.C1CommandLink();
            this.c1CommandLink8 = new C1.Win.C1Command.C1CommandLink();
            this.código = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descrição = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preçoUn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estoque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.listaprodutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
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
            this.label1.Location = new System.Drawing.Point(1, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "&Código do produto";
            // 
            // txtCdProduto
            // 
            this.txtCdProduto.Enabled = false;
            this.txtCdProduto.Location = new System.Drawing.Point(4, 113);
            this.txtCdProduto.Name = "txtCdProduto";
            this.txtCdProduto.Size = new System.Drawing.Size(81, 20);
            this.txtCdProduto.TabIndex = 5;
            this.txtCdProduto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cdProduto_KeyPress);
            // 
            // txtDescricaoProduto
            // 
            this.txtDescricaoProduto.Enabled = false;
            this.txtDescricaoProduto.Location = new System.Drawing.Point(101, 113);
            this.txtDescricaoProduto.Name = "txtDescricaoProduto";
            this.txtDescricaoProduto.Size = new System.Drawing.Size(201, 20);
            this.txtDescricaoProduto.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(101, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "&Descrição do produto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(420, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "&Quantidade em estoque";
            // 
            // txtQtd
            // 
            this.txtQtd.Enabled = false;
            this.txtQtd.Location = new System.Drawing.Point(423, 113);
            this.txtQtd.Name = "txtQtd";
            this.txtQtd.Size = new System.Drawing.Size(117, 20);
            this.txtQtd.TabIndex = 8;
            this.txtQtd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.qtd_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(315, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "&Valor do produto";
            // 
            // txtValor
            // 
            this.txtValor.Enabled = false;
            this.txtValor.Location = new System.Drawing.Point(318, 113);
            this.txtValor.MaxLength = 1000000;
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(89, 20);
            this.txtValor.TabIndex = 7;
            this.txtValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.valor_KeyPress);
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
            this.listaprodutos.Location = new System.Drawing.Point(4, 139);
            this.listaprodutos.Name = "listaprodutos";
            this.listaprodutos.ReadOnly = true;
            this.listaprodutos.Size = new System.Drawing.Size(539, 264);
            this.listaprodutos.TabIndex = 13;
            this.listaprodutos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listaProdutos_CellClick);
            this.listaprodutos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listaprodutos_CellContentClick);
            this.listaprodutos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listaprodutos_CellDoubleClick);
            this.listaprodutos.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.listaprodutos_ColumnHeaderMouseClick);
            this.listaprodutos.Scroll += new System.Windows.Forms.ScrollEventHandler(this.listaProdutos_Scroll);
            this.listaprodutos.SelectionChanged += new System.EventHandler(this.listaprodutos_SelectionChanged);
            this.listaprodutos.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listaprodutos_MouseDoubleClick);
            this.listaprodutos.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listaprodutos_MouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(425, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(530, 18);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(495, 18);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 18;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(460, 18);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(32, 32);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 19;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // c1CommandHolder1
            // 
            this.c1CommandHolder1.Commands.Add(this.c1Command2);
            this.c1CommandHolder1.Commands.Add(this.c1Command3);
            this.c1CommandHolder1.Commands.Add(this.c1Command4);
            this.c1CommandHolder1.Commands.Add(this.c1Command5);
            this.c1CommandHolder1.Commands.Add(this.c1Command6);
            this.c1CommandHolder1.Commands.Add(this.c1Command7);
            this.c1CommandHolder1.Commands.Add(this.c1Command8);
            this.c1CommandHolder1.Commands.Add(this.c1Command9);
            this.c1CommandHolder1.Commands.Add(this.c1Command10);
            this.c1CommandHolder1.Commands.Add(this.c1Command11);
            this.c1CommandHolder1.Commands.Add(this.c1Command12);
            this.c1CommandHolder1.Commands.Add(this.c1Command13);
            this.c1CommandHolder1.Owner = this;
            // 
            // c1Command2
            // 
            this.c1Command2.Image = ((System.Drawing.Image)(resources.GetObject("c1Command2.Image")));
            this.c1Command2.Name = "c1Command2";
            this.c1Command2.ShortcutText = "";
            this.c1Command2.Text = "&Delete";
            // 
            // c1Command3
            // 
            this.c1Command3.Image = ((System.Drawing.Image)(resources.GetObject("c1Command3.Image")));
            this.c1Command3.Name = "c1Command3";
            this.c1Command3.ShortcutText = "";
            this.c1Command3.Text = "&Save";
            // 
            // c1Command4
            // 
            this.c1Command4.Image = ((System.Drawing.Image)(resources.GetObject("c1Command4.Image")));
            this.c1Command4.Name = "c1Command4";
            this.c1Command4.ShortcutText = "";
            this.c1Command4.Text = "&Undo";
            // 
            // c1Command5
            // 
            this.c1Command5.Image = ((System.Drawing.Image)(resources.GetObject("c1Command5.Image")));
            this.c1Command5.Name = "c1Command5";
            this.c1Command5.ShortcutText = "";
            this.c1Command5.Text = "&New";
            // 
            // c1Command6
            // 
            this.c1Command6.Image = ((System.Drawing.Image)(resources.GetObject("c1Command6.Image")));
            this.c1Command6.Name = "c1Command6";
            this.c1Command6.ShortcutText = "";
            this.c1Command6.Text = "&New";
            // 
            // c1Command7
            // 
            this.c1Command7.Image = ((System.Drawing.Image)(resources.GetObject("c1Command7.Image")));
            this.c1Command7.Name = "c1Command7";
            this.c1Command7.ShortcutText = "";
            this.c1Command7.Text = "&Delete";
            // 
            // c1Command8
            // 
            this.c1Command8.Image = ((System.Drawing.Image)(resources.GetObject("c1Command8.Image")));
            this.c1Command8.Name = "c1Command8";
            this.c1Command8.ShortcutText = "";
            this.c1Command8.Text = "&Save";
            // 
            // c1Command9
            // 
            this.c1Command9.Image = ((System.Drawing.Image)(resources.GetObject("c1Command9.Image")));
            this.c1Command9.Name = "c1Command9";
            this.c1Command9.ShortcutText = "";
            this.c1Command9.Text = "&Undo";
            // 
            // c1Command10
            // 
            this.c1Command10.Image = ((System.Drawing.Image)(resources.GetObject("c1Command10.Image")));
            this.c1Command10.Name = "c1Command10";
            this.c1Command10.ShortcutText = "";
            this.c1Command10.Text = "&New";
            // 
            // c1Command11
            // 
            this.c1Command11.Image = ((System.Drawing.Image)(resources.GetObject("c1Command11.Image")));
            this.c1Command11.Name = "c1Command11";
            this.c1Command11.ShortcutText = "";
            this.c1Command11.Text = "&Delete";
            this.c1Command11.Click += new C1.Win.C1Command.ClickEventHandler(this.c1Command11_Click);
            // 
            // c1Command12
            // 
            this.c1Command12.Image = ((System.Drawing.Image)(resources.GetObject("c1Command12.Image")));
            this.c1Command12.Name = "c1Command12";
            this.c1Command12.ShortcutText = "";
            this.c1Command12.Text = "Save all";
            this.c1Command12.Click += new C1.Win.C1Command.ClickEventHandler(this.c1Command12_Click);
            // 
            // c1Command13
            // 
            this.c1Command13.Image = ((System.Drawing.Image)(resources.GetObject("c1Command13.Image")));
            this.c1Command13.Name = "c1Command13";
            this.c1Command13.ShortcutText = "";
            this.c1Command13.Text = "&Undo";
            this.c1Command13.Click += new C1.Win.C1Command.ClickEventHandler(this.c1Command13_Click);
            // 
            // c1CommandLink2
            // 
            this.c1CommandLink2.Command = this.c1Command2;
            this.c1CommandLink2.SortOrder = 1;
            // 
            // c1CommandLink3
            // 
            this.c1CommandLink3.Command = this.c1Command3;
            this.c1CommandLink3.SortOrder = 2;
            // 
            // c1CommandLink4
            // 
            this.c1CommandLink4.Command = this.c1Command4;
            this.c1CommandLink4.SortOrder = 3;
            // 
            // c1CommandLink5
            // 
            this.c1CommandLink5.Command = this.c1Command5;
            // 
            // c1ToolBar2
            // 
            this.c1ToolBar2.AccessibleName = "Tool Bar";
            this.c1ToolBar2.CommandHolder = this.c1CommandHolder1;
            this.c1ToolBar2.CommandLinks.AddRange(new C1.Win.C1Command.C1CommandLink[] {
            this.c1CommandLink1,
            this.c1CommandLink6,
            this.c1CommandLink7,
            this.c1CommandLink8});
            this.c1ToolBar2.Location = new System.Drawing.Point(23, 63);
            this.c1ToolBar2.Name = "c1ToolBar2";
            this.c1ToolBar2.Size = new System.Drawing.Size(98, 26);
            this.c1ToolBar2.Text = "c1ToolBar2";
            this.c1ToolBar2.Click += new System.EventHandler(this.c1ToolBar2_Click);
            // 
            // c1CommandLink1
            // 
            this.c1CommandLink1.Command = this.c1Command10;
            // 
            // c1CommandLink6
            // 
            this.c1CommandLink6.Command = this.c1Command11;
            this.c1CommandLink6.SortOrder = 1;
            // 
            // c1CommandLink7
            // 
            this.c1CommandLink7.Command = this.c1Command12;
            this.c1CommandLink7.SortOrder = 2;
            this.c1CommandLink7.ButtonLookChanged += new System.EventHandler(this.c1CommandLink7_ButtonLookChanged);
            // 
            // c1CommandLink8
            // 
            this.c1CommandLink8.Command = this.c1Command13;
            this.c1CommandLink8.SortOrder = 3;
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
            // ProdutoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 426);
            this.Controls.Add(this.c1ToolBar2);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listaprodutos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtQtd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCdProduto);
            this.Controls.Add(this.txtDescricaoProduto);
            this.Name = "ProdutoView";
            this.Tag = "";
            this.Text = "&Cadastro de produto";
            this.Load += new System.EventHandler(this.fProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listaprodutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
  #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCdProduto;
        private System.Windows.Forms.TextBox txtDescricaoProduto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtQtd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.DataGridView listaprodutos;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private C1ToolBar c1ToolBar1;
        private C1CommandHolder c1CommandHolder1;
        private C1Command c1Command2;
        private C1Command c1Command3;
        private C1Command c1Command4;
        private C1Command c1Command5;
        private C1CommandLink c1CommandLink5;
        private C1CommandLink c1CommandLink2;
        private C1CommandLink c1CommandLink3;
        private C1CommandLink c1CommandLink4;
        private C1Command c1Command6;
        private C1Command c1Command7;
        private C1Command c1Command8;
        private C1Command c1Command9;
        private C1ToolBar c1ToolBar2;
        private C1Command c1Command10;
        private C1Command c1Command11;
        private C1Command c1Command12;
        private C1Command c1Command13;
        private C1CommandLink c1CommandLink1;
        private C1CommandLink c1CommandLink6;
        private C1CommandLink c1CommandLink7;
        private C1CommandLink c1CommandLink8;
        private System.Windows.Forms.DataGridViewTextBoxColumn código;
        private System.Windows.Forms.DataGridViewTextBoxColumn descrição;
        private System.Windows.Forms.DataGridViewTextBoxColumn preçoUn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estoque;

        public C1ToolBar C1ToolBar1 { get => c1ToolBar1; set => c1ToolBar1 = value; }
    }
}