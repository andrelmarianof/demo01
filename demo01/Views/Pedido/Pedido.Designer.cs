
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
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cdCliente = new System.Windows.Forms.TextBox();
            this.descricaoCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cdProduto = new System.Windows.Forms.TextBox();
            this.descricaoProduto = new System.Windows.Forms.TextBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.label5 = new System.Windows.Forms.Label();
            this.qtd = new System.Windows.Forms.TextBox();
            this.inserirProduto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(472, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "&Confirmar Pedido ";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(187, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "&Nome do cliente";
            // 
            // cdCliente
            // 
            this.cdCliente.Location = new System.Drawing.Point(32, 38);
            this.cdCliente.Name = "cdCliente";
            this.cdCliente.Size = new System.Drawing.Size(76, 20);
            this.cdCliente.TabIndex = 7;
            // 
            // descricaoCliente
            // 
            this.descricaoCliente.Location = new System.Drawing.Point(138, 38);
            this.descricaoCliente.Name = "descricaoCliente";
            this.descricaoCliente.Size = new System.Drawing.Size(211, 20);
            this.descricaoCliente.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "&Código do cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(187, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "&Descrição do produto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "&Código do Produto";
            // 
            // cdProduto
            // 
            this.cdProduto.Location = new System.Drawing.Point(32, 100);
            this.cdProduto.Name = "cdProduto";
            this.cdProduto.Size = new System.Drawing.Size(76, 20);
            this.cdProduto.TabIndex = 12;
            // 
            // descricaoProduto
            // 
            this.descricaoProduto.Location = new System.Drawing.Point(138, 100);
            this.descricaoProduto.Name = "descricaoProduto";
            this.descricaoProduto.Size = new System.Drawing.Size(211, 20);
            this.descricaoProduto.TabIndex = 11;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(32, 140);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(413, 298);
            this.treeView1.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(383, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "&Quantidade";
            // 
            // qtd
            // 
            this.qtd.Location = new System.Drawing.Point(369, 100);
            this.qtd.Name = "qtd";
            this.qtd.Size = new System.Drawing.Size(76, 20);
            this.qtd.TabIndex = 16;
            // 
            // inserirProduto
            // 
            this.inserirProduto.Location = new System.Drawing.Point(472, 100);
            this.inserirProduto.Name = "inserirProduto";
            this.inserirProduto.Size = new System.Drawing.Size(113, 23);
            this.inserirProduto.TabIndex = 18;
            this.inserirProduto.Text = "&Adicionar Produto";
            this.inserirProduto.UseVisualStyleBackColor = true;
            // 
            // Pedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.inserirProduto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.qtd);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cdProduto);
            this.Controls.Add(this.descricaoProduto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cdCliente);
            this.Controls.Add(this.descricaoCliente);
            this.Controls.Add(this.button1);
            this.Name = "Pedido";
            this.Text = "Pedido";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox cdCliente;
        private System.Windows.Forms.TextBox descricaoCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox cdProduto;
        private System.Windows.Forms.TextBox descricaoProduto;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox qtd;
        private System.Windows.Forms.Button inserirProduto;
    }
}