
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
            ((System.ComponentModel.ISupportInitialize)(this.GridDeConsultasGenerico)).BeginInit();
            this.SuspendLayout();
            // 
            // GridDeConsultasGenerico
            // 
            this.GridDeConsultasGenerico.AllowUserToAddRows = false;
            this.GridDeConsultasGenerico.AllowUserToDeleteRows = false;
            this.GridDeConsultasGenerico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridDeConsultasGenerico.Location = new System.Drawing.Point(8, 63);
            this.GridDeConsultasGenerico.Name = "GridDeConsultasGenerico";
            this.GridDeConsultasGenerico.ReadOnly = true;
            this.GridDeConsultasGenerico.Size = new System.Drawing.Size(747, 279);
            this.GridDeConsultasGenerico.TabIndex = 0;
            // 
            // ConsultaGridPadrao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 351);
            this.Controls.Add(this.GridDeConsultasGenerico);
            this.Name = "ConsultaGridPadrao";
            this.Text = "Consulta De Dados";
            ((System.ComponentModel.ISupportInitialize)(this.GridDeConsultasGenerico)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GridDeConsultasGenerico;
    }
}