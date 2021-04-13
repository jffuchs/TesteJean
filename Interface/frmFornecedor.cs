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
        }

        protected override void Inicializar()
        {
            GridView.Columns[0].HeaderText = "ID";
            GridView.Columns[1].HeaderText = "Nome";
            GridView.Columns[2].HeaderText = "CPF/CNPJ";
            GridView.Columns[3].HeaderText = "Telefone";
            GridView.Columns[4].HeaderText = "Cadastro";

            cbEmpresa.DataSource = empresa.CarregarRegistros();
        }

        protected override int RetornarGridID()
        {
            return Convert.ToInt32(GridView.Rows[GridView.CurrentRow.Index].Cells[DTO.NomeCampoID].Value.ToString());
        }

        protected override int CarregarTodosRegistros()
        {
            fornecedor = new RegraNegocio.RegraFornecedor();
            GridView.DataSource = fornecedor.CarregarRegistros();
            return GridView.RowCount;
        }

        protected override int CarregarRegistrosFiltrados(string nomeCampo, string valorCampo, string tipoCampo)
        {
            fornecedor = new RegraNegocio.RegraFornecedor();
            try
            {
                if (tipoCampo == "DateTime")
                {
                    if (Util.ValidarData(valorCampo))
                    {
                        GridView.DataSource = fornecedor.CarregarRegistros(string.Format("{0} = '{1}'", nomeCampo, valorCampo));
                    }
                    else
                    {
                        GridView.DataSource = fornecedor.CarregarRegistros();
                    }
                }                
                else
                {
                    GridView.DataSource = fornecedor.CarregarRegistros(string.Format("{0} LIKE '{1}%'", nomeCampo, valorCampo));
                }
            }
            catch (Exception)
            {
                GridView.DataSource = fornecedor.CarregarRegistros();
            }
            return GridView.RowCount;
        }

        protected override void CarregarRegistro()
        {
            DTO = new RegraNegocio.RegraFornecedor().Dados(idAtual);

            txbNome.Text = DTO.Nome;
            txbCNPJ.Text = DTO.CPFCNPJ;
            txbTelefone.Text = DTO.Telefone;
            cbEmpresa.Text = empresa.Dados(DTO.IDF_EMPRESA).Nome;
        }

        protected override void SalvarRegistro()
        {
            DTO.ID = idAtual;
            DTO.Nome = txbNome.Text;
            DTO.CPFCNPJ = txbCNPJ.Text;
            DTO.Telefone = txbTelefone.Text;
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
