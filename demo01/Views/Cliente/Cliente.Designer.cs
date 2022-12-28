
namespace demo01.Views.Cliente
{
    partial class Cliente
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
            this.nomecliente = new System.Windows.Forms.TextBox();
            this.codigocliente = new System.Windows.Forms.TextBox();
            this.cadastratcliente = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nomecliente
            // 
            this.nomecliente.Location = new System.Drawing.Point(130, 32);
            this.nomecliente.Name = "nomecliente";
            this.nomecliente.Size = new System.Drawing.Size(211, 20);
            this.nomecliente.TabIndex = 0;
            this.nomecliente.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // codigocliente
            // 
            this.codigocliente.Location = new System.Drawing.Point(34, 31);
            this.codigocliente.Name = "codigocliente";
            this.codigocliente.Size = new System.Drawing.Size(63, 20);
            this.codigocliente.TabIndex = 1;
            // 
            // cadastratcliente
            // 
            this.cadastratcliente.Location = new System.Drawing.Point(362, 29);
            this.cadastratcliente.Name = "cadastratcliente";
            this.cadastratcliente.Size = new System.Drawing.Size(75, 23);
            this.cadastratcliente.TabIndex = 2;
            this.cadastratcliente.Text = "&Cadastrar";
            this.cadastratcliente.UseVisualStyleBackColor = true;
            this.cadastratcliente.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "&Código do cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(179, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "&Nome do cliente";
            // 
            // Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cadastratcliente);
            this.Controls.Add(this.codigocliente);
            this.Controls.Add(this.nomecliente);
            this.Name = "Cliente";
            this.Text = "Cliente";
            this.Load += new System.EventHandler(this.Cliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nomecliente;
        private System.Windows.Forms.TextBox codigocliente;
        private System.Windows.Forms.Button cadastratcliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}