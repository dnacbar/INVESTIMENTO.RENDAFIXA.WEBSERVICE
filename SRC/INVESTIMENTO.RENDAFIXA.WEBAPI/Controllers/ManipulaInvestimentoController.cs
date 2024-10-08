using INVESTIMENTO.RENDAFIXA.APPLICATION.AdicionaInvestimento;
using INVESTIMENTO.RENDAFIXA.DOMAIN.Financeiro;
using INVESTIMENTO.RENDAFIXA.DOMAIN.Financeiro.BancoDados.Manipula;
using Microsoft.AspNetCore.Mvc;

namespace INVESTIMENTO.RENDAFIXA.WEBAPI.Controllers;

[ApiController]
[Route("[controller]/[action]")]
public class ManipulaInvestimentoController(IServicoQueManipulaInvestimento servicoQueManipulaInvestimento) : ControllerBase
{
    private readonly IServicoQueManipulaInvestimento _servicoQueManipulaInvestimento = servicoQueManipulaInvestimento;

    [HttpPost(nameof(AdicionaInvestimento))]
    public async Task<IActionResult> AdicionaInvestimento(AdicionaInvestimentoSignature signature)
    {
        signature.Validate();

        var investimento = new Investimento(signature.Investidor, signature.DocumentoFederal, signature.ValorInicial, signature.TaxaRendimento, 
            signature.TaxaAdicional, signature.DataInicial, signature.DataFinal, signature.Indexador, signature.IsentoImposto, signature.Usuario);

        await _servicoQueManipulaInvestimento.Adiciona(investimento);

        return Ok(investimento.IdInvestimento);
    }
}