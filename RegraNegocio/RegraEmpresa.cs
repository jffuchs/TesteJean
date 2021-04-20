using System;
using System.Data;
using System.Text;

namespace RegraNegocio
{
    public class RegraEmpresa : RegraNegocioBase
    {
        AcessoDados.Empresa acessoEmpresa = new AcessoDados.Empresa();

        public RegraEmpresa()
        {
            NomeCampoID = new AcessoDados.DTO.EmpresaDTO().NomeCampoID;
        }

        public void IncluirAlterar(AcessoDados.DTO.EmpresaDTO dados)
        {
            try
            {
                acessoEmpresa.IncluirAlterar(dados);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public override void Excluir(int idEmpresa)
        {
            try
            {
                acessoEmpresa.ExcluirRegistro(idEmpresa);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public override DataTable CarregarRegistros(string filtros = "")
        {
            StringBuilder str = new StringBuilder();
            str.AppendLine("SELECT ID_EMPRESA, UF_SIGLA, EMP_CNPJ, EMP_NOME FROM EMPRESA");
            str.AppendLine("LEFT JOIN UF ON ID_UF = IDF_UF");
            if (filtros.Trim() != "")
            {
                str.AppendLine("WHERE " + filtros);
            }
            str.AppendLine("ORDER BY EMP_NOME");
            return acessoEmpresa.RetornarDataTable(str.ToString());
        }

        public AcessoDados.DTO.EmpresaDTO Dados(int iDF_EMPRESA)
        {
            return acessoEmpresa.Dados(iDF_EMPRESA);
        }
    }
}
