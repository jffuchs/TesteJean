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

            cbEmpresa.DataSource = empresa.RetornarListaEmpresas();
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

        protected override void CarregarRegistro()
        {
            DTO = new RegraNegocio.RegraFornecedor().DadosFornecedor(idAtual);

            txbNome.Text = DTO.Nome;
            txbCNPJ.Text = DTO.CPFCNPJ;
            txbTelefone.Text = DTO.Telefone;
            cbEmpresa.Text = empresa.RetornarEmpresa(DTO.IDF_EMPRESA).Nome;
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
    }
}
