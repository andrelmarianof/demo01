
namespace demo01.Views.Pedido
{
    partial class BuscarProduto
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
            this.formBuscarProduto = new System.Windows.Forms.DataGridView();
            this.código = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descrição = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preçoUn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estoque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.formBuscarProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // formBuscarProduto
            // 
            this.formBuscarProduto.AllowUserToAddRows = false;
            this.formBuscarProduto.AllowUserToDeleteRows = false;
            this.formBuscarProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.formBuscarProduto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.código,
            this.descrição,
            this.preçoUn,
            this.estoque});
            this.formBuscarProduto.Location = new System.Drawing.Point(8, 63);
            this.formBuscarProduto.Name = "formBuscarProduto";
            this.formBuscarProduto.ReadOnly = true;
            this.formBuscarProduto.Size = new System.Drawing.Size(549, 219);
            this.formBuscarProduto.TabIndex = 14;
            this.formBuscarProduto.DoubleClick += new System.EventHandler(this.formBuscarProduto_DoubleClick);
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
            // BuscarProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 287);
            this.Controls.Add(this.formBuscarProduto);
            this.Name = "BuscarProduto";
            this.Text = "BuscarProduto";
            ((System.ComponentModel.ISupportInitialize)(this.formBuscarProduto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView formBuscarProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn código;
        private System.Windows.Forms.DataGridViewTextBoxColumn descrição;
        private System.Windows.Forms.DataGridViewTextBoxColumn preçoUn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estoque;
    }
}