
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
            this.txbCNPJ = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbTelefone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txbEmpUF = new System.Windows.Forms.TextBox();
            this.txbEmpCNPJ = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbEmpresa = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pnPesFis = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.txbRG = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpNasc = new System.Windows.Forms.DateTimePicker();
            this.tcAbas.SuspendLayout();
            this.tpLista.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnEdicao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).BeginInit();
            this.panel5.SuspendLayout();
            this.pnPesFis.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcAbas
            // 
            this.tcAbas.Size = new System.Drawing.Size(712, 446);
            // 
            // tpLista
            // 
            this.tpLista.Size = new System.Drawing.Size(704, 420);
            this.tpLista.Text = "Lista de Fornecedores";
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(615, 414);
            // 
            // pnEdicao
            // 
            this.pnEdicao.Controls.Add(this.pnPesFis);
            this.pnEdicao.Controls.Add(this.panel5);
            this.pnEdicao.Controls.Add(this.txbTelefone);
            this.pnEdicao.Controls.Add(this.label1);
            this.pnEdicao.Controls.Add(this.txbCNPJ);
            this.pnEdicao.Controls.Add(this.label3);
            this.pnEdicao.Controls.Add(this.txbNome);
            this.pnEdicao.Controls.Add(this.label2);
            this.pnEdicao.Size = new System.Drawing.Size(698, 380);
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(3, 383);
            // 
            // GridView
            // 
            this.GridView.Size = new System.Drawing.Size(613, 366);
            // 
            // txbCNPJ
            // 
            this.txbCNPJ.Location = new System.Drawing.Point(76, 125);
            this.txbCNPJ.MaxLength = 14;
            this.txbCNPJ.Name = "txbCNPJ";
            this.txbCNPJ.Size = new System.Drawing.Size(138, 20);
            this.txbCNPJ.TabIndex = 2;
            this.txbCNPJ.Enter += new System.EventHandler(this.txbCNPJ_Enter);
            this.txbCNPJ.Leave += new System.EventHandler(this.txbCNPJ_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "CPF/CNPJ";
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(76, 99);
            this.txbNome.MaxLength = 80;
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(503, 20);
            this.txbNome.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nome";
            // 
            // txbTelefone
            // 
            this.txbTelefone.Location = new System.Drawing.Point(76, 151);
            this.txbTelefone.MaxLength = 11;
            this.txbTelefone.Name = "txbTelefone";
            this.txbTelefone.Size = new System.Drawing.Size(111, 20);
            this.txbTelefone.TabIndex = 3;
            this.txbTelefone.Enter += new System.EventHandler(this.txbTelefone_Enter);
            this.txbTelefone.Leave += new System.EventHandler(this.txbTelefone_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Telefone";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.txbEmpUF);
            this.panel5.Controls.Add(this.txbEmpCNPJ);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.cbEmpresa);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Location = new System.Drawing.Point(10, 10);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(569, 81);
            this.panel5.TabIndex = 0;
            // 
            // txbEmpUF
            // 
            this.txbEmpUF.Enabled = false;
            this.txbEmpUF.Location = new System.Drawing.Point(65, 56);
            this.txbEmpUF.Name = "txbEmpUF";
            this.txbEmpUF.Size = new System.Drawing.Size(27, 20);
            this.txbEmpUF.TabIndex = 2;
            // 
            // txbEmpCNPJ
            // 
            this.txbEmpCNPJ.Enabled = false;
            this.txbEmpCNPJ.Location = new System.Drawing.Point(65, 30);
            this.txbEmpCNPJ.Name = "txbEmpCNPJ";
            this.txbEmpCNPJ.Size = new System.Drawing.Size(111, 20);
            this.txbEmpCNPJ.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "UF";
            // 
            // cbEmpresa
            // 
            this.cbEmpresa.DisplayMember = "EMP_NOME";
            this.cbEmpresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEmpresa.FormattingEnabled = true;
            this.cbEmpresa.Location = new System.Drawing.Point(65, 3);
            this.cbEmpresa.Name = "cbEmpresa";
            this.cbEmpresa.Size = new System.Drawing.Size(494, 21);
            this.cbEmpresa.TabIndex = 0;
            this.cbEmpresa.ValueMember = "ID_EMPRESA";
            this.cbEmpresa.SelectedIndexChanged += new System.EventHandler(this.cbEmpresa_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "CNPJ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Empresa";
            // 
            // pnPesFis
            // 
            this.pnPesFis.Controls.Add(this.dtpNasc);
            this.pnPesFis.Controls.Add(this.label7);
            this.pnPesFis.Controls.Add(this.txbRG);
            this.pnPesFis.Controls.Add(this.label8);
            this.pnPesFis.Location = new System.Drawing.Point(4, 174);
            this.pnPesFis.Name = "pnPesFis";
            this.pnPesFis.Size = new System.Drawing.Size(396, 58);
            this.pnPesFis.TabIndex = 11;
            this.pnPesFis.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Nascimento";
            // 
            // txbRG
            // 
            this.txbRG.Location = new System.Drawing.Point(72, 3);
            this.txbRG.MaxLength = 14;
            this.txbRG.Name = "txbRG";
            this.txbRG.Size = new System.Drawing.Size(138, 20);
            this.txbRG.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "R.G.";
            // 
            // dtpNasc
            // 
            this.dtpNasc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNasc.Location = new System.Drawing.Point(72, 29);
            this.dtpNasc.Name = "dtpNasc";
            this.dtpNasc.Size = new System.Drawing.Size(97, 20);
            this.dtpNasc.TabIndex = 15;
            // 
            // frmFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(712, 446);
            this.Name = "frmFornecedor";
            this.Text = "Fornecedores";
            this.tcAbas.ResumeLayout(false);
            this.tpLista.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.pnEdicao.ResumeLayout(false);
            this.pnEdicao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.pnPesFis.ResumeLayout(false);
            this.pnPesFis.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txbCNPJ;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbTelefone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ComboBox cbEmpresa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbEmpUF;
        private System.Windows.Forms.TextBox txbEmpCNPJ;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnPesFis;
        private System.Windows.Forms.DateTimePicker dtpNasc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbRG;
        private System.Windows.Forms.Label label8;
    }
}
