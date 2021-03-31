using System;
using System.Data;
using System.Text;

namespace RegraNegocio
{
    public class RegraEmpresa
    {
        AcessoDados.Empresa acessoEmpresa = new AcessoDados.Empresa();

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

        public void Excluir(int idEmpresa)
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

        public DataTable CarregarRegistros()
        {
            StringBuilder str = new StringBuilder();
            str.AppendLine("SELECT ID_EMPRESA, UF_SIGLA , EMP_CNPJ, EMP_NOME FROM EMPRESA");
            str.AppendLine("LEFT JOIN UF ON ID_UF = IDF_UF");
            return acessoEmpresa.RetornarDataTable(str.ToString());
        }

        public object RetornarListaEmpresas()
        {
            return acessoEmpresa.RetornarDataTable("SELECT * FROM EMPRESA ORDER BY EMP_NOME");
        }

        public AcessoDados.DTO.EmpresaDTO DadosEmpresa(int idEmpresa)
        {
            return acessoEmpresa.Dados(idEmpresa);
        }

        public AcessoDados.DTO.EmpresaDTO RetornarEmpresa(int iDF_EMPRESA)
        {
            return acessoEmpresa.Dados(iDF_EMPRESA);
        }
    }
}
