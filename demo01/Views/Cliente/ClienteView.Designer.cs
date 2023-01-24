
namespace demo01.Views.Cliente
{
    partial class ClienteView
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
            this.components = new System.ComponentModel.Container();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.txtCodigoCliente = new System.Windows.Forms.TextBox();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listacliente = new System.Windows.Forms.DataGridView();
            this.btnNovoCliente = new System.Windows.Forms.Button();
            this.btnExcluirCliente = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.mskCPF = new System.Windows.Forms.MaskedTextBox();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.código = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descrição = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.listacliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Location = new System.Drawing.Point(161, 88);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(211, 20);
            this.txtNomeCliente.TabIndex = 5;
            this.txtNomeCliente.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtNomeCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomeCliente_KeyPress);
            // 
            // txtCodigoCliente
            // 
            this.txtCodigoCliente.Location = new System.Drawing.Point(40, 88);
            this.txtCodigoCliente.Name = "txtCodigoCliente";
            this.txtCodigoCliente.Size = new System.Drawing.Size(63, 20);
            this.txtCodigoCliente.TabIndex = 4;
            this.txtCodigoCliente.TextChanged += new System.EventHandler(this.codigocliente_TextChanged);
            this.txtCodigoCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigoCliente_KeyPress);
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.Location = new System.Drawing.Point(129, 12);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(75, 23);
            this.BtnSalvar.TabIndex = 2;
            this.BtnSalvar.Text = "&Salvar";
            this.BtnSalvar.UseVisualStyleBackColor = true;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "&Código do cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(242, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "&Nome";
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
            this.listacliente.Location = new System.Drawing.Point(12, 127);
            this.listacliente.Name = "listacliente";
            this.listacliente.ReadOnly = true;
            this.listacliente.Size = new System.Drawing.Size(637, 311);
            this.listacliente.TabIndex = 6;
            this.listacliente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listacliente_CellClick);
            this.listacliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listacliente_CellContentClick);
            this.listacliente.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listacliente_CellDoubleClick);
            this.listacliente.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.listacliente_CellFormatting);
            this.listacliente.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Listacliente_ColumnHeaderMouseClick);
            // 
            // btnNovoCliente
            // 
            this.btnNovoCliente.Location = new System.Drawing.Point(28, 12);
            this.btnNovoCliente.Name = "btnNovoCliente";
            this.btnNovoCliente.Size = new System.Drawing.Size(75, 23);
            this.btnNovoCliente.TabIndex = 1;
            this.btnNovoCliente.Text = "&Novo";
            this.btnNovoCliente.UseVisualStyleBackColor = true;
            this.btnNovoCliente.Click += new System.EventHandler(this.btnNovoCliente_Click);
            // 
            // btnExcluirCliente
            // 
            this.btnExcluirCliente.Location = new System.Drawing.Point(222, 12);
            this.btnExcluirCliente.Name = "btnExcluirCliente";
            this.btnExcluirCliente.Size = new System.Drawing.Size(75, 23);
            this.btnExcluirCliente.TabIndex = 3;
            this.btnExcluirCliente.Text = "&Excluir";
            this.btnExcluirCliente.UseVisualStyleBackColor = true;
            this.btnExcluirCliente.Click += new System.EventHandler(this.btnExcluirCliente_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(461, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "&C P F";
            // 
            // mskCPF
            // 
            this.mskCPF.Location = new System.Drawing.Point(420, 88);
            this.mskCPF.Mask = "000.000.000-00";
            this.mskCPF.Name = "mskCPF";
            this.mskCPF.Size = new System.Drawing.Size(100, 20);
            this.mskCPF.TabIndex = 9;
            this.mskCPF.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataSource = typeof(demo01.Views.Cliente.ClienteView);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(641, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "&E-mail";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(553, 88);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(211, 20);
            this.txtEmail.TabIndex = 11;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
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
            // 
            // ClienteView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.mskCPF);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnExcluirCliente);
            this.Controls.Add(this.btnNovoCliente);
            this.Controls.Add(this.listacliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnSalvar);
            this.Controls.Add(this.txtCodigoCliente);
            this.Controls.Add(this.txtNomeCliente);
            this.Name = "ClienteView";
            this.Text = "Cliente";
            this.Load += new System.EventHandler(this.Cliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listacliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.TextBox txtCodigoCliente;
        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView listacliente;
        private System.Windows.Forms.Button btnNovoCliente;
        private System.Windows.Forms.Button btnExcluirCliente;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mskCPF;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn código;
        private System.Windows.Forms.DataGridViewTextBoxColumn descrição;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
    }
}