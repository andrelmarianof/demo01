
namespace demo01.Views.Pedido
{
    partial class Pedido
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
            this.txtCescricaoProduto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtQtd = new System.Windows.Forms.TextBox();
            this.btnAddProduto = new System.Windows.Forms.Button();
            this.btnNovoPedido = new System.Windows.Forms.Button();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSalvarPedido
            // 
            this.btnSalvarPedido.Location = new System.Drawing.Point(399, 65);
            this.btnSalvarPedido.Name = "btnSalvarPedido";
            this.btnSalvarPedido.Size = new System.Drawing.Size(113, 23);
            this.btnSalvarPedido.TabIndex = 0;
            this.btnSalvarPedido.Text = "&Confirmar Pedido ";
            this.btnSalvarPedido.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(328, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "&Nome do cliente";
            // 
            // txtCdCliente
            // 
            this.txtCdCliente.Location = new System.Drawing.Point(188, 122);
            this.txtCdCliente.Name = "txtCdCliente";
            this.txtCdCliente.Size = new System.Drawing.Size(76, 20);
            this.txtCdCliente.TabIndex = 7;
            this.txtCdCliente.TextChanged += new System.EventHandler(this.cdCliente_TextChanged);
            // 
            // txtDescricaoCliente
            // 
            this.txtDescricaoCliente.Location = new System.Drawing.Point(270, 122);
            this.txtDescricaoCliente.Name = "txtDescricaoCliente";
            this.txtDescricaoCliente.Size = new System.Drawing.Size(211, 20);
            this.txtDescricaoCliente.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(185, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "&Código do cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(328, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "&Descrição do produto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(185, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "&Código do Produto";
            // 
            // txtCdProduto
            // 
            this.txtCdProduto.Location = new System.Drawing.Point(188, 165);
            this.txtCdProduto.Name = "txtCdProduto";
            this.txtCdProduto.Size = new System.Drawing.Size(76, 20);
            this.txtCdProduto.TabIndex = 12;
            // 
            // txtCescricaoProduto
            // 
            this.txtCescricaoProduto.Location = new System.Drawing.Point(270, 165);
            this.txtCescricaoProduto.Name = "txtCescricaoProduto";
            this.txtCescricaoProduto.Size = new System.Drawing.Size(211, 20);
            this.txtCescricaoProduto.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(581, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "&Quantidade";
            // 
            // txtQtd
            // 
            this.txtQtd.Location = new System.Drawing.Point(575, 165);
            this.txtQtd.Name = "txtQtd";
            this.txtQtd.Size = new System.Drawing.Size(76, 20);
            this.txtQtd.TabIndex = 16;
            // 
            // btnAddProduto
            // 
            this.btnAddProduto.Location = new System.Drawing.Point(657, 162);
            this.btnAddProduto.Name = "btnAddProduto";
            this.btnAddProduto.Size = new System.Drawing.Size(113, 23);
            this.btnAddProduto.TabIndex = 18;
            this.btnAddProduto.Text = "&Adicionar Produto";
            this.btnAddProduto.UseVisualStyleBackColor = true;
            // 
            // btnNovoPedido
            // 
            this.btnNovoPedido.Location = new System.Drawing.Point(238, 63);
            this.btnNovoPedido.Name = "btnNovoPedido";
            this.btnNovoPedido.Size = new System.Drawing.Size(86, 25);
            this.btnNovoPedido.TabIndex = 19;
            this.btnNovoPedido.Text = "&Novo Pedido";
            this.btnNovoPedido.UseVisualStyleBackColor = true;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(493, 165);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(76, 20);
            this.txtValor.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(516, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "&Valor";
            // 
            // Pedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 554);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.btnNovoPedido);
            this.Controls.Add(this.btnAddProduto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtQtd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCdProduto);
            this.Controls.Add(this.txtCescricaoProduto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCdCliente);
            this.Controls.Add(this.txtDescricaoCliente);
            this.Controls.Add(this.btnSalvarPedido);
            this.Name = "Pedido";
            this.Text = "Pedido";
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
        private System.Windows.Forms.TextBox txtCescricaoProduto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtQtd;
        private System.Windows.Forms.Button btnAddProduto;
        private System.Windows.Forms.Button btnNovoPedido;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label6;
    }
}