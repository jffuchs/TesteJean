using RegraNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Interface
{
    public partial class frmFornecedor : Interface.frmBase
    {
        RegraNegocio.RegraFornecedor fornecedor;
        RegraNegocio.RegraEmpresa empresa;
        AcessoDados.DTO.FornecedorDTO DTO = new AcessoDados.DTO.FornecedorDTO();

        public frmFornecedor()
        {
            InitializeComponent();
            fornecedor = new RegraNegocio.RegraFornecedor();
            empresa = new RegraNegocio.RegraEmpresa();
            regraNegocio = new RegraNegocio.RegraFornecedor();
            cbEmpresa.DataSource = empresa.CarregarRegistros();
        }

        protected override void Inicializar()
        {
            GridView.Columns[0].HeaderText = "ID";
            GridView.Columns[1].HeaderText = "Nome";
            GridView.Columns[2].HeaderText = "CPF/CNPJ";
            GridView.Columns[3].HeaderText = "Telefone";
            GridView.Columns[4].HeaderText = "Cadastro";

            GridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        
        /*protected override int CarregarTodosRegistros()
        {
            fornecedor = new RegraNegocio.RegraFornecedor();
            GridView.DataSource = fornecedor.CarregarRegistros();
            return GridView.RowCount;
        }*/

        private void txbCNPJ_Enter(object sender, EventArgs e)
        {
            txbCNPJ.Text = Util.RetornarApenasNumeros(txbCNPJ.Text);
        }

        private void txbCNPJ_Leave(object sender, EventArgs e)
        {            
            DTO.CPFCNPJ = Util.RetornarApenasNumeros(txbCNPJ.Text);
            txbCNPJ.Text = Util.FormatarCPFCNPJ(txbCNPJ.Text);
            pnPesFis.Visible = fornecedor.EhPessoaFisica(DTO);
        }

        private void txbTelefone_Leave(object sender, EventArgs e)
        {
            txbTelefone.Text = Util.FormatarTelefone(txbTelefone.Text);
        }

        private void txbTelefone_Enter(object sender, EventArgs e)
        {
            txbTelefone.Text = Util.RetornarApenasNumeros(txbTelefone.Text);
        }

        protected override void CarregarRegistro()
        {
            DTO = new RegraNegocio.RegraFornecedor().Dados(idAtual);

            txbNome.Text = DTO.Nome;
            txbCNPJ.Text = DTO.CPFCNPJ;
            txbTelefone.Text = DTO.Telefone;
            txbRG.Text = DTO.RG;
            dtpNasc.Value = DTO.DataNascimento.Date;
            cbEmpresa.Text = empresa.Dados(DTO.IDF_EMPRESA).Nome;

            txbCNPJ_Leave(this, null);
        }

        protected override void SalvarRegistro()
        {
            DTO.ID = idAtual;
            DTO.Nome = txbNome.Text;
            DTO.CPFCNPJ = txbCNPJ.Text;
            DTO.Telefone = txbTelefone.Text;
            DTO.RG = txbRG.Text;
            DTO.DataNascimento = dtpNasc.Value;
            DTO.IDF_EMPRESA = Convert.ToInt32(cbEmpresa.SelectedValue.ToString());
            DTO.DataHoraCadastro = DateTime.Now;            

            fornecedor.IncluirAlterar(DTO);
        }

        protected override void ExcluirRegistro()
        {
            fornecedor.Excluir(idAtual);
        }

        private void cbEmpresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbEmpresa.SelectedValue == null)
            {
                return;
            }

            int idEmpresa = Convert.ToInt32(cbEmpresa.SelectedValue.ToString());
            if (idEmpresa >= 0)
            {
                AcessoDados.DTO.EmpresaDTO EmpDTO = new AcessoDados.DTO.EmpresaDTO();
                EmpDTO = new RegraNegocio.RegraEmpresa().Dados(idEmpresa);
                txbEmpCNPJ.Text = Util.FormatarCPFCNPJ(EmpDTO.CNPJ);

                AcessoDados.DTO.UFDTO ufDTO = new AcessoDados.DTO.UFDTO();
                ufDTO = new RegraNegocio.RegraUF().Dados(EmpDTO.IDF_UF);
                txbEmpUF.Text = ufDTO.Sigla;
            }
        }        
    }
}
