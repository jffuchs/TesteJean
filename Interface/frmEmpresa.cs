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

            regraNegocio = new RegraNegocio.RegraEmpresa();
            cbUF.DataSource = UF.CarregarRegistros();
        }

        protected override void Inicializar()
        {
            GridView.Columns[0].HeaderText = "ID";
            GridView.Columns[1].HeaderText = "UF";
            GridView.Columns[2].HeaderText = "CNPJ";
            GridView.Columns[3].HeaderText = "Razão Social";
            GridView.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        protected override void CarregarRegistro()
        {
            DTO = new RegraNegocio.RegraEmpresa().Dados(idAtual);

            txbNome.Text = DTO.Nome;            
            txbCNPJ.Text = DTO.CNPJ;
            cbUF.Text = UF.Dados(DTO.IDF_UF).Nome;
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

        private void txbCNPJ_Enter(object sender, EventArgs e)
        {
            txbCNPJ.Text = Util.RetornarApenasNumeros(txbCNPJ.Text);
        }

        private void txbCNPJ_Leave(object sender, EventArgs e)
        {
            txbCNPJ.Text = Util.FormatarCPFCNPJ(txbCNPJ.Text);
        }
    }
}
