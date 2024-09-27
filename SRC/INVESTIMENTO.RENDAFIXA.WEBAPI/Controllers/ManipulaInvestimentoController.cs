using INVESTIMENTO.RENDAFIXA.APPLICATION.AdicionaInvestimento;
using INVESTIMENTO.RENDAFIXA.DOMAIN.Financeiro.BancoDados.Manipula;
using INVESTIMENTO.RENDAFIXA.TEST.DBRENDAFIXAMODEL;
using Microsoft.AspNetCore.Mvc;

namespace INVESTIMENTO.RENDAFIXA.WEBAPI.Controllers;

[ApiController]
[Route("[controller]/[action]")]
public class ManipulaInvestimentoController(IInvestimentoServicoDeDados investimentoServicoDeDados) : ControllerBase
{
    private readonly IInvestimentoServicoDeDados _investimentoServicoDeDados = investimentoServicoDeDados;

    [HttpPost(nameof(AdicionaInvestimento))]
    public async Task<IActionResult> AdicionaInvestimento(AdicionaInvestimentoSignature signature)
    {
        signature.Validate();

        var investimento = new Investimento(signature.Investidor, signature.DocumentoFederal, signature.ValorInicial, 
            signature.TaxaRendimento, signature.TaxaAdicional, signature.Indexador, signature.IsentoImposto);

        await _investimentoServicoDeDados.Adiciona(investimento);

        return Ok(investimento.IdInvestimento);
    }
}