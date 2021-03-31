
namespace Interface
{
    partial class frmEmpresa
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.txbCNPJ = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbUF = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tcAbas.SuspendLayout();
            this.tpLista.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).BeginInit();
            this.pnEdicao.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcAbas
            // 
            this.tcAbas.Size = new System.Drawing.Size(788, 325);
            // 
            // tpLista
            // 
            this.tpLista.Size = new System.Drawing.Size(780, 299);
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(691, 293);
            // 
            // GridView
            // 
            this.GridView.Size = new System.Drawing.Size(689, 291);
            // 
            // pnEdicao
            // 
            this.pnEdicao.Controls.Add(this.cbUF);
            this.pnEdicao.Controls.Add(this.txbCNPJ);
            this.pnEdicao.Controls.Add(this.label5);
            this.pnEdicao.Controls.Add(this.label3);
            this.pnEdicao.Controls.Add(this.txbNome);
            this.pnEdicao.Controls.Add(this.label2);
            this.pnEdicao.Size = new System.Drawing.Size(774, 259);
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(3, 262);
            this.panel3.Size = new System.Drawing.Size(774, 34);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nome";
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(44, 7);
            this.txbNome.MaxLength = 80;
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(494, 20);
            this.txbNome.TabIndex = 0;
            // 
            // txbCNPJ
            // 
            this.txbCNPJ.Location = new System.Drawing.Point(44, 33);
            this.txbCNPJ.MaxLength = 14;
            this.txbCNPJ.Name = "txbCNPJ";
            this.txbCNPJ.Size = new System.Drawing.Size(138, 20);
            this.txbCNPJ.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "CNPJ";
            // 
            // cbUF
            // 
            this.cbUF.DisplayMember = "UF_NOME";
            this.cbUF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUF.FormattingEnabled = true;
            this.cbUF.Location = new System.Drawing.Point(44, 59);
            this.cbUF.Name = "cbUF";
            this.cbUF.Size = new System.Drawing.Size(174, 21);
            this.cbUF.TabIndex = 3;
            this.cbUF.ValueMember = "ID_UF";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "UF";
            // 
            // frmEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(788, 325);
            this.Name = "frmEmpresa";
            this.Text = "Empresa";
            this.tcAbas.ResumeLayout(false);
            this.tpLista.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).EndInit();
            this.pnEdicao.ResumeLayout(false);
            this.pnEdicao.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbCNPJ;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbUF;
        private System.Windows.Forms.Label label5;
    }
}
