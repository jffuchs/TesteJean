
namespace Interface
{
    partial class frmFornecedor
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbEmpresa = new System.Windows.Forms.ComboBox();
            this.txbCNPJ = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbTelefone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tcAbas.SuspendLayout();
            this.tpLista.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).BeginInit();
            this.pnEdicao.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnEdicao
            // 
            this.pnEdicao.Controls.Add(this.txbTelefone);
            this.pnEdicao.Controls.Add(this.label1);
            this.pnEdicao.Controls.Add(this.cbEmpresa);
            this.pnEdicao.Controls.Add(this.txbCNPJ);
            this.pnEdicao.Controls.Add(this.label5);
            this.pnEdicao.Controls.Add(this.label3);
            this.pnEdicao.Controls.Add(this.txbNome);
            this.pnEdicao.Controls.Add(this.label2);
            // 
            // cbEmpresa
            // 
            this.cbEmpresa.DisplayMember = "EMP_NOME";
            this.cbEmpresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEmpresa.FormattingEnabled = true;
            this.cbEmpresa.Location = new System.Drawing.Point(70, 7);
            this.cbEmpresa.Name = "cbEmpresa";
            this.cbEmpresa.Size = new System.Drawing.Size(494, 21);
            this.cbEmpresa.TabIndex = 0;
            this.cbEmpresa.ValueMember = "ID_EMPRESA";
            // 
            // txbCNPJ
            // 
            this.txbCNPJ.Location = new System.Drawing.Point(70, 60);
            this.txbCNPJ.MaxLength = 14;
            this.txbCNPJ.Name = "txbCNPJ";
            this.txbCNPJ.Size = new System.Drawing.Size(138, 20);
            this.txbCNPJ.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Empresa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "CPF/CNPJ";
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(70, 34);
            this.txbNome.MaxLength = 80;
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(494, 20);
            this.txbNome.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nome";
            // 
            // txbTelefone
            // 
            this.txbTelefone.Location = new System.Drawing.Point(70, 86);
            this.txbTelefone.MaxLength = 14;
            this.txbTelefone.Name = "txbTelefone";
            this.txbTelefone.Size = new System.Drawing.Size(138, 20);
            this.txbTelefone.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Telefone";
            // 
            // frmFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(712, 446);
            this.Name = "frmFornecedor";
            this.tcAbas.ResumeLayout(false);
            this.tpLista.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).EndInit();
            this.pnEdicao.ResumeLayout(false);
            this.pnEdicao.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbEmpresa;
        private System.Windows.Forms.TextBox txbCNPJ;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbTelefone;
        private System.Windows.Forms.Label label1;
    }
}
