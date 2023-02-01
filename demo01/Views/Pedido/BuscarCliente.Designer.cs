
namespace demo01.Views.Pedido
{
    partial class BuscarCliente
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
            this.listacliente = new System.Windows.Forms.DataGridView();
            this.código = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descrição = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.listacliente)).BeginInit();
            this.SuspendLayout();
            // 
            // listacliente
            // 
            this.listacliente.AllowUserToAddRows = false;
            this.listacliente.AllowUserToDeleteRows = false;
            this.listacliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listacliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.código,
            this.descrição,
            this.Cpf,
            this.Email});
            this.listacliente.Location = new System.Drawing.Point(58, 60);
            this.listacliente.Name = "listacliente";
            this.listacliente.ReadOnly = true;
            this.listacliente.Size = new System.Drawing.Size(650, 253);
            this.listacliente.TabIndex = 8;
            this.listacliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listacliente_CellContentClick);
            // 
            // código
            // 
            this.código.DataPropertyName = "CdCliente";
            this.código.HeaderText = "Código";
            this.código.Name = "código";
            this.código.ReadOnly = true;
            // 
            // descrição
            // 
            this.descrição.DataPropertyName = "NomeCliente";
            this.descrição.HeaderText = "Nome";
            this.descrição.Name = "descrição";
            this.descrição.ReadOnly = true;
            this.descrição.Width = 200;
            // 
            // Cpf
            // 
            this.Cpf.DataPropertyName = "Cpf";
            this.Cpf.HeaderText = "Cpf";
            this.Cpf.Name = "Cpf";
            this.Cpf.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 200;
            // 
            // BuscarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listacliente);
            this.Name = "BuscarCliente";
            this.Text = "BuscarCliente";
            ((System.ComponentModel.ISupportInitialize)(this.listacliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView listacliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn código;
        private System.Windows.Forms.DataGridViewTextBoxColumn descrição;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
    }
}