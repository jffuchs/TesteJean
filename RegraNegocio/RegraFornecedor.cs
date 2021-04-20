using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegraNegocio
{
    public class RegraFornecedor : RegraNegocioBase
    {
        AcessoDados.Fornecedor acessoFornecedor = new AcessoDados.Fornecedor();        

        public RegraFornecedor()
        {
            NomeCampoID = new AcessoDados.DTO.FornecedorDTO().NomeCampoID;
        }

        public bool EhPessoaFisica(AcessoDados.DTO.FornecedorDTO dados)
        {
            return dados.Pessoa == AcessoDados.DTO.FornecedorDTO.TipoPessoa.Fisica;
        }

        public void IncluirAlterar(AcessoDados.DTO.FornecedorDTO dados)
        {
            RegraEmpresa empresa = new RegraEmpresa();
            RegraUF UF = new RegraUF();

            if (dados.Pessoa == AcessoDados.DTO.FornecedorDTO.TipoPessoa.Fisica)
            {
                if (UF.Dados(empresa.Dados(dados.IDF_EMPRESA).IDF_UF).Sigla == "PR")
                {
                    if (Util.CalcularIdade(dados.DataHoraCadastro) < 18)
                    {
                        throw new Exception("Fornecedor Pessoa Física deve ser maior de idade!");
                    }                     
                }
            }            

            try
            {
                acessoFornecedor.IncluirAlterar(dados);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public override void Excluir(int idFornecedor)
        {
            try
            {
                acessoFornecedor.ExcluirRegistro(idFornecedor);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public override DataTable CarregarRegistros(string filtros = "")
        {
            StringBuilder str = new StringBuilder();
            str.AppendLine("SELECT ID_FORNECEDOR, FOR_NOME, FOR_CPFCNPJ, FOR_TELEFONE, FOR_DTHRCAD FROM FORNECEDOR");
            if (filtros.Trim() != "")
            {
                str.AppendLine("WHERE "+filtros);
            }
            return acessoFornecedor.RetornarDataTable(str.ToString());
        }

        public AcessoDados.DTO.FornecedorDTO Dados(int idFornecedor)
        {
            return acessoFornecedor.Dados(idFornecedor);
        }
    }
}
