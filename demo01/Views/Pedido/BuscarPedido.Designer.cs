
namespace demo01.Views.Pedido
{
    partial class BuscarPedido
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
            this.ListarTodosPedidos = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ListarTodosPedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // ListarTodosPedidos
            // 
            this.ListarTodosPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListarTodosPedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column1});
            this.ListarTodosPedidos.Location = new System.Drawing.Point(10, 63);
            this.ListarTodosPedidos.Name = "ListarTodosPedidos";
            this.ListarTodosPedidos.Size = new System.Drawing.Size(269, 386);
            this.ListarTodosPedidos.TabIndex = 23;
            this.ListarTodosPedidos.DoubleClick += new System.EventHandler(this.ListarTodosPedidos_DoubleClick_1);
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Numero";
            this.Column5.HeaderText = "Num Pedido";
            this.Column5.Name = "Column5";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "CdCliente";
            this.Column1.HeaderText = "Cliente";
            this.Column1.Name = "Column1";
            // 
            // BuscarPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 450);
            this.Controls.Add(this.ListarTodosPedidos);
            this.Name = "BuscarPedido";
            this.Text = "BuscarPedido";
            ((System.ComponentModel.ISupportInitialize)(this.ListarTodosPedidos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ListarTodosPedidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}