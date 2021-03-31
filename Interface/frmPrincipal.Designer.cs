
namespace Interface
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tspEmpresa = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tspFornecedor = new System.Windows.Forms.ToolStripButton();
            this.tspSair = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tspEmpresa,
            this.toolStripSeparator1,
            this.tspFornecedor,
            this.tspSair});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(800, 45);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tspEmpresa
            // 
            this.tspEmpresa.Image = ((System.Drawing.Image)(resources.GetObject("tspEmpresa.Image")));
            this.tspEmpresa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tspEmpresa.Name = "tspEmpresa";
            this.tspEmpresa.Size = new System.Drawing.Size(61, 42);
            this.tspEmpresa.Text = "Empresas";
            this.tspEmpresa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tspEmpresa.Click += new System.EventHandler(this.tspEmpresa_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 45);
            // 
            // tspFornecedor
            // 
            this.tspFornecedor.Image = ((System.Drawing.Image)(resources.GetObject("tspFornecedor.Image")));
            this.tspFornecedor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tspFornecedor.Name = "tspFornecedor";
            this.tspFornecedor.Size = new System.Drawing.Size(82, 42);
            this.tspFornecedor.Text = "Fornecedores";
            this.tspFornecedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tspFornecedor.Click += new System.EventHandler(this.tspFornecedor_Click);
            // 
            // tspSair
            // 
            this.tspSair.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tspSair.AutoSize = false;
            this.tspSair.Image = ((System.Drawing.Image)(resources.GetObject("tspSair.Image")));
            this.tspSair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tspSair.Name = "tspSair";
            this.tspSair.Size = new System.Drawing.Size(40, 42);
            this.tspSair.Text = "Sair";
            this.tspSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tspSair.Click += new System.EventHandler(this.tspSair_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel2.Text = "toolStripStatusLabel2";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teste Jean";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tspEmpresa;
        private System.Windows.Forms.ToolStripButton tspFornecedor;
        private System.Windows.Forms.ToolStripButton tspSair;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
    }
}

