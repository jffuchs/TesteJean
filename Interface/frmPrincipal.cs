using System;
using System.Windows.Forms;

namespace Interface
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void tspSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tspEmpresa_Click(object sender, EventArgs e)
        {
            frmEmpresa empresa = new frmEmpresa();
            empresa.ShowDialog();
        }

        private void tspFornecedor_Click(object sender, EventArgs e)
        {
            frmFornecedor fornecedor = new frmFornecedor();
            fornecedor.ShowDialog();
        }
    }
}
