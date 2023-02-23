
using System.Drawing;

namespace demo01.Views.Pedido
{
    partial class ConsultaGridPadrao
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
            this.GridDeConsultasGenerico = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.GridDeConsultasGenerico)).BeginInit();
            this.SuspendLayout();
            // 
            // GridDeConsultasGenerico
            // 
            this.GridDeConsultasGenerico.AllowUserToAddRows = false;
            this.GridDeConsultasGenerico.AllowUserToDeleteRows = false;
            this.GridDeConsultasGenerico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridDeConsultasGenerico.Location = new System.Drawing.Point(8, 94);
            this.GridDeConsultasGenerico.Name = "GridDeConsultasGenerico";
            this.GridDeConsultasGenerico.ReadOnly = true;
            this.GridDeConsultasGenerico.Size = new System.Drawing.Size(747, 319);
            this.GridDeConsultasGenerico.TabIndex = 0;
            this.GridDeConsultasGenerico.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridDeConsultasGenerico_CellClick);
            this.GridDeConsultasGenerico.DoubleClick += new System.EventHandler(this.GridDeConsultasGenerico_DoubleClick);
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.LightYellow;
            this.txtSearch.Font = new System.Drawing.Font("Arial", 12F);
            this.txtSearch.ForeColor = System.Drawing.Color.Black;
            this.txtSearch.Location = new System.Drawing.Point(8, 63);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(747, 25);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.Tag = "Digite para pesquisar!";
            this.txtSearch.Text = "";
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged_1);
            // 
            // ConsultaGridPadrao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 416);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.GridDeConsultasGenerico);
            this.Name = "ConsultaGridPadrao";
            this.Text = "Consulta De Dados";
            ((System.ComponentModel.ISupportInitialize)(this.GridDeConsultasGenerico)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GridDeConsultasGenerico;
        private System.Windows.Forms.RichTextBox txtSearch;
    }
}