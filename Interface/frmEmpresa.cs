using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Interface
{
    public partial class frmEmpresa : Interface.frmBase
    {
        RegraNegocio.RegraEmpresa empresa;
        RegraNegocio.RegraUF UF;
        AcessoDados.DTO.EmpresaDTO DTO = new AcessoDados.DTO.EmpresaDTO();

        public frmEmpresa()
        {
            InitializeComponent();
            empresa = new RegraNegocio.RegraEmpresa();
            UF = new RegraNegocio.RegraUF();
        }

        protected override void Inicializar()
        {
            GridView.Columns[0].HeaderText = "ID";
            GridView.Columns[1].HeaderText = "UF";
            GridView.Columns[2].HeaderText = "CNPJ";
            GridView.Columns[3].HeaderText = "Razão Social";            

            cbUF.DataSource = UF.RetornarListaUF();
        }

        protected override int RetornarGridID()
        {
            return Convert.ToInt32(GridView.Rows[GridView.CurrentRow.Index].Cells[DTO.NomeCampoID].Value.ToString());
        }

        protected override int CarregarTodosRegistros()
        {
            empresa = new RegraNegocio.RegraEmpresa();
            GridView.DataSource = empresa.CarregarRegistros();
            return GridView.RowCount;
        }

        protected override void CarregarRegistro()
        {
            DTO = new RegraNegocio.RegraEmpresa().DadosEmpresa(idAtual);

            txbNome.Text = DTO.Nome;            
            txbCNPJ.Text = DTO.CNPJ;
            cbUF.Text = UF.RetornarUF(DTO.IDF_UF).Nome;
        }

        protected override void SalvarRegistro()
        {
            DTO.ID = idAtual;
            DTO.Nome = txbNome.Text;
            DTO.CNPJ = txbCNPJ.Text;
            DTO.IDF_UF = Convert.ToInt32(cbUF.SelectedValue.ToString());

            empresa.IncluirAlterar(DTO);            
        }

        protected override void ExcluirRegistro()
        {
            empresa.Excluir(idAtual);
        }
    }
}
