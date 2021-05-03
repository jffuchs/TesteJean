using System;
using System.Data;
using System.Text;

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
            return dados.Pessoa == AcessoDados.DTO.FornecedorDTO.TipoPessoaEnum.Fisica;
        }

        public AcessoDados.DTO.FornecedorDTO Dados(int idFornecedor)
        {
            return acessoFornecedor.Dados(idFornecedor);
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
            str.AppendLine("SELECT ID_FORNECEDOR, EMP_NOME, FOR_NOME, FOR_CPFCNPJ, FOR_TELEFONE, FOR_DTHRCAD FROM FORNECEDOR");
            str.AppendLine("INNER JOIN EMPRESA ON ID_EMPRESA = IDF_EMPRESA");
            if (filtros.Trim() != "")
            {
                str.AppendLine("WHERE " + filtros);
            }
            return acessoFornecedor.RetornarDataTable(str.ToString());
        }

        public void IncluirAlterar(AcessoDados.DTO.FornecedorDTO dados)
        {
            RegraEmpresa empresa = new RegraEmpresa();
            RegraUF UF = new RegraUF();

            if (dados.IDF_EMPRESA <= 0)
            {
                throw new Exception("Selecione uma empresa!");
            }

            AcessoDados.DTO.FornecedorDTO dadosAux = acessoFornecedor.Dados(dados.CPFCNPJ);
            if (dadosAux.ID > 0)
            {
                if (dadosAux.ID != dados.ID)
                {
                    throw new Exception("Já existe um Fornecedor com este CPF/CNPJ!");
                }
            }

            if (dados.Pessoa == AcessoDados.DTO.FornecedorDTO.TipoPessoaEnum.Fisica)
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
    }
}
