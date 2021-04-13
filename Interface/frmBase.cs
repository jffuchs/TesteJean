using System;
using System.Windows.Forms;

namespace Interface
{
    public partial class frmBase : Form
    {
        protected int idAtual = 0;
        private int totalRegistros = 0;
        private string nomeColunaSelecionada;
        private string tipoColunaSelecionada;

        public frmBase()
        {
            InitializeComponent();
        }

        private void AjustarComponentes(bool ehEdicao)
        {
            if (!this.DesignMode)
            {
                if (ehEdicao == true)
                {
                    tpEdicao.Parent = tcAbas;
                    tpLista.Parent = null;

                    btnLimpar.Text = this.idAtual == 0 ? "Limpar" : "Restaurar";

                    tpEdicao.Text = idAtual == 0 ? "Incluíndo" : "Alterando";

                    LimparControles(pnEdicao);
                }
                else
                {
                    tpLista.Parent = tcAbas;
                    tpEdicao.Parent = null;
                    GridView.Focus();
                }
            }
        }

        private void AjustarBotoes()
        {
            btnAlterar.Enabled = totalRegistros > 0;
            btnExcluir.Enabled = btnAlterar.Enabled;
        }

        private void LimparControles(Control controle)
        {
            foreach (Control ctl in controle.Controls)
            {
                if (ctl is TextBox)
                    (ctl as TextBox).Text = "";
                if (ctl is ComboBox)
                    (ctl as ComboBox).SelectedIndex = -1;
                if (ctl is ListBox)
                    (ctl as ListBox).SelectedIndex = -1;
                if (ctl is Panel)
                    LimparControles(ctl);
            }
            PosicionarPrimeiroControle(pnEdicao);
        }

        private void PosicionarPrimeiroControle(Control controle)
        {
            foreach (Control ctr in controle.Controls)
            {
                if (ctr.TabIndex == 0)
                {
                    if (ctr is Panel)
                    {
                        PosicionarPrimeiroControle(ctr);
                    }
                    else
                    {
                        ctr.Focus();
                        break;
                    }                    
                }
            }
        }

        private void frmBase_KeyDown(object sender, KeyEventArgs e)
        {
            //Quer dizer que está na aba "Lista"...
            if (tpLista.Parent != null)
            {
                if (e.KeyCode == Keys.Insert)
                {
                    btnIncluir_Click(sender, e);
                }
                else if (e.KeyCode == Keys.Delete && !txbPesquisa.Focused)
                {
                    btnExcluir_Click(sender, e);
                }
                else if (e.KeyCode == Keys.Return)
                {
                    btnAlterar_Click(sender, e);
                }
                else if (e.KeyCode == Keys.Escape)
                {
                    this.Close();
                }
            }
            else
            {
                if (e.KeyCode == Keys.Escape)
                {
                    btnCancelar_Click(sender, e);
                }
            }
        }

        protected virtual void Inicializar()
        {
        }

        protected virtual int RetornarGridID()
        {
            return 0;
        }

        protected virtual int CarregarTodosRegistros()
        {
            return 0;
        }

        protected virtual void CarregarRegistro()
        {
        }

        protected virtual void SalvarRegistro()
        {
        }

        protected virtual void ExcluirRegistro()
        {        
        }

        protected virtual int CarregarRegistrosFiltrados(string nomeCampo, string valorCampo, string tipoCampo)
        {
            return 0;
        }

        private void FrmBase_Load(object sender, EventArgs e)
        {
            AjustarComponentes(false);
            totalRegistros = CarregarTodosRegistros();
            AjustarBotoes();
            Inicializar();
        }

        private void frmBase_Shown(object sender, EventArgs e)
        {
            GridView.Focus();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GridView_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            AjustarBotoes();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            idAtual = 0;
            AjustarComponentes(true);
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            idAtual = RetornarGridID();
            AjustarComponentes(true);
            CarregarRegistro();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirma excluir o registro?", "Confirma", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    idAtual = RetornarGridID();
                    ExcluirRegistro();
                    totalRegistros = CarregarTodosRegistros();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                }
            }
        }

        private void GridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (btnAlterar.Enabled)
            {
                btnAlterar_Click(sender, e);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            AjustarComponentes(false);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirma " + (sender as Button).Text + " a edição do registro?", "Confirmação",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (this.idAtual == 0)
                {
                    LimparControles(pnEdicao);
                }
                else
                {
                    CarregarRegistro();
                    PosicionarPrimeiroControle(pnEdicao);
                }
            }
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            try
            {
                SalvarRegistro();
                AjustarComponentes(false);
                totalRegistros = CarregarTodosRegistros();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
        }

        private void txbPesquisa_TextChanged(object sender, EventArgs e)
        {
            CarregarRegistrosFiltrados(nomeColunaSelecionada, txbPesquisa.Text, tipoColunaSelecionada);
        }

        private void GridView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            lbPesquisa.Text = "Filtrar " + GridView.Columns[e.ColumnIndex].HeaderText;

            nomeColunaSelecionada = GridView.Columns[e.ColumnIndex].Name.ToString();
            tipoColunaSelecionada = GridView.Columns[e.ColumnIndex].ValueType.Name;

            txbPesquisa.Clear();
            txbPesquisa.Focus();
        }

        private void GridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (btnAlterar.Enabled)
            {
                btnAlterar_Click(sender, e);
            }
        }
    }
}
