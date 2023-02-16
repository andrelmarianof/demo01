
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClienteView));
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.txtCodigoClientezz = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listacliente = new System.Windows.Forms.DataGridView();
            this.código = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descrição = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.mskCPF = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.c1DataSet1 = new C1.Data.C1DataSet();
            this.c1ToolBar2 = new C1.Win.C1Command.C1ToolBar();
            this.c1CommandLink1 = new C1.Win.C1Command.C1CommandLink();
            this.c1Command1 = new C1.Win.C1Command.C1Command();
            this.c1CommandLink2 = new C1.Win.C1Command.C1CommandLink();
            this.c1Command2 = new C1.Win.C1Command.C1Command();
            this.c1CommandLink3 = new C1.Win.C1Command.C1CommandLink();
            this.c1Command3 = new C1.Win.C1Command.C1Command();
            this.c1CommandLink4 = new C1.Win.C1Command.C1CommandLink();
            this.c1Command5 = new C1.Win.C1Command.C1Command();
            this.c1Command4 = new C1.Win.C1Command.C1Command();
            this.c1CommandHolder1 = new C1.Win.C1Command.C1CommandHolder();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.listacliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Location = new System.Drawing.Point(135, 114);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(211, 20);
            this.txtNomeCliente.TabIndex = 4;
            this.txtNomeCliente.TextChanged += new System.EventHandler(this.txtNomeCliente_TextChanged);
            // 
            // txtCodigoClientezz
            // 
            this.txtCodigoClientezz.Location = new System.Drawing.Point(14, 114);
            this.txtCodigoClientezz.Name = "txtCodigoClientezz";
            this.txtCodigoClientezz.Size = new System.Drawing.Size(114, 20);
            this.txtCodigoClientezz.TabIndex = 3;
            this.txtCodigoClientezz.TextChanged += new System.EventHandler(this.txtCodigoClientezz_TextChanged);
            this.txtCodigoClientezz.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigoCliente_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "&Código do cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 98);
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
            this.listacliente.Location = new System.Drawing.Point(11, 140);
            this.listacliente.Name = "listacliente";
            this.listacliente.ReadOnly = true;
            this.listacliente.Size = new System.Drawing.Size(658, 266);
            this.listacliente.TabIndex = 7;
            this.listacliente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listacliente_CellClick);
            this.listacliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listacliente_CellContentClick);
            this.listacliente.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listacliente_CellDoubleClick);
            this.listacliente.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.listacliente_CellFormatting);
            this.listacliente.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Listacliente_ColumnHeaderMouseClick);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(349, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "&C P F";
            // 
            // mskCPF
            // 
            this.mskCPF.Location = new System.Drawing.Point(352, 114);
            this.mskCPF.Mask = "000.000.000-00";
            this.mskCPF.Name = "mskCPF";
            this.mskCPF.Size = new System.Drawing.Size(100, 20);
            this.mskCPF.TabIndex = 5;
            this.mskCPF.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mskCPF.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskCPF_MaskInputRejected);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(455, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "&E-mail";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(458, 114);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(211, 20);
            this.txtEmail.TabIndex = 6;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // c1DataSet1
            // 
            this.c1DataSet1.BindingContextCtrl = this;
            this.c1DataSet1.DataLibrary = "";
            this.c1DataSet1.DataLibraryUrl = "";
            this.c1DataSet1.DataSetDef = "";
            this.c1DataSet1.Locale = new System.Globalization.CultureInfo("pt-BR");
            this.c1DataSet1.Name = "c1DataSet1";
            this.c1DataSet1.SchemaClassName = "";
            this.c1DataSet1.SchemaDef = null;
            // 
            // c1ToolBar2
            // 
            this.c1ToolBar2.AccessibleName = "Tool Bar";
            this.c1ToolBar2.AutoSize = false;
            this.c1ToolBar2.CommandHolder = null;
            this.c1ToolBar2.CommandLinks.AddRange(new C1.Win.C1Command.C1CommandLink[] {
            this.c1CommandLink1,
            this.c1CommandLink2,
            this.c1CommandLink3,
            this.c1CommandLink4});
            this.c1ToolBar2.Location = new System.Drawing.Point(8, 63);
            this.c1ToolBar2.Name = "c1ToolBar2";
            this.c1ToolBar2.Size = new System.Drawing.Size(661, 26);
            this.c1ToolBar2.Text = "c1ToolBar2";
            this.c1ToolBar2.Click += new System.EventHandler(this.c1ToolBar2_Click);
            // 
            // c1CommandLink1
            // 
            this.c1CommandLink1.Command = this.c1Command1;
            // 
            // c1Command1
            // 
            this.c1Command1.Image = ((System.Drawing.Image)(resources.GetObject("c1Command1.Image")));
            this.c1Command1.Name = "c1Command1";
            this.c1Command1.ShortcutText = "";
            this.c1Command1.Text = "&Novo Cliente";
            this.c1Command1.Click += new C1.Win.C1Command.ClickEventHandler(this.btnNovoCliente_Click);
            // 
            // c1CommandLink2
            // 
            this.c1CommandLink2.Command = this.c1Command2;
            this.c1CommandLink2.SortOrder = 1;
            // 
            // c1Command2
            // 
            this.c1Command2.Image = ((System.Drawing.Image)(resources.GetObject("c1Command2.Image")));
            this.c1Command2.Name = "c1Command2";
            this.c1Command2.ShortcutText = "";
            this.c1Command2.Text = "Salvar Cliente";
            this.c1Command2.Click += new C1.Win.C1Command.ClickEventHandler(this.BtnSalvar_Click);
            // 
            // c1CommandLink3
            // 
            this.c1CommandLink3.Command = this.c1Command3;
            this.c1CommandLink3.SortOrder = 2;
            // 
            // c1Command3
            // 
            this.c1Command3.Image = ((System.Drawing.Image)(resources.GetObject("c1Command3.Image")));
            this.c1Command3.Name = "c1Command3";
            this.c1Command3.ShortcutText = "";
            this.c1Command3.Text = "Deletar Cliente";
            this.c1Command3.Click += new C1.Win.C1Command.ClickEventHandler(this.btnExcluirCliente_Click);
            // 
            // c1CommandLink4
            // 
            this.c1CommandLink4.Command = this.c1Command5;
            this.c1CommandLink4.SortOrder = 3;
            // 
            // c1Command5
            // 
            this.c1Command5.Image = ((System.Drawing.Image)(resources.GetObject("c1Command5.Image")));
            this.c1Command5.Name = "c1Command5";
            this.c1Command5.ShortcutText = "";
            this.c1Command5.Text = "Cancelar";
            // 
            // c1Command4
            // 
            this.c1Command4.Image = ((System.Drawing.Image)(resources.GetObject("c1Command4.Image")));
            this.c1Command4.Name = "c1Command4";
            this.c1Command4.ShortcutText = "";
            this.c1Command4.Text = "Save all";
            // 
            // c1CommandHolder1
            // 
            this.c1CommandHolder1.Commands.Add(this.c1Command1);
            this.c1CommandHolder1.Commands.Add(this.c1Command2);
            this.c1CommandHolder1.Commands.Add(this.c1Command3);
            this.c1CommandHolder1.Commands.Add(this.c1Command4);
            this.c1CommandHolder1.Commands.Add(this.c1Command5);
            this.c1CommandHolder1.Owner = this;
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataSource = typeof(demo01.Views.Cliente.ClienteView);
            // 
            // ClienteView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackImagePadding = new System.Windows.Forms.Padding(0, 0, 2, 2);
            this.ClientSize = new System.Drawing.Size(678, 425);
            this.Controls.Add(this.c1ToolBar2);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.mskCPF);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listacliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCodigoClientezz);
            this.Controls.Add(this.txtNomeCliente);
            this.Name = "ClienteView";
            this.Text = "&Cadastro De Cliente";
            this.Load += new System.EventHandler(this.Cliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listacliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.TextBox txtCodigoClientezz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView listacliente;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mskCPF;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmail;
        private C1.Data.C1DataSet c1DataSet1;
        private System.Windows.Forms.DataGridViewTextBoxColumn código;
        private System.Windows.Forms.DataGridViewTextBoxColumn descrição;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private C1.Win.C1Command.C1CommandLink c1CommandLink1;
        private C1.Win.C1Command.C1Command c1Command1;
        private C1.Win.C1Command.C1CommandLink c1CommandLink2;
        private C1.Win.C1Command.C1Command c1Command2;
        private C1.Win.C1Command.C1CommandLink c1CommandLink3;
        private C1.Win.C1Command.C1Command c1Command3;
        private C1.Win.C1Command.C1CommandHolder c1CommandHolder1;
        private C1.Win.C1Command.C1CommandLink c1CommandLink4;
        private C1.Win.C1Command.C1Command c1Command4;
        private C1.Win.C1Command.C1ToolBar c1ToolBar2;
        private C1.Win.C1Command.C1Command c1Command5;
    }
}