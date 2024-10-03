using INVESTIMENTO.RENDAFIXA.APPLICATION.ConsultaInvestimentoDaPessoa;
using INVESTIMENTO.RENDAFIXA.DOMAIN.Financeiro;
using INVESTIMENTO.RENDAFIXA.DOMAIN.Financeiro.BancoDados.Consulta;
using Microsoft.AspNetCore.Mvc;

namespace INVESTIMENTO.RENDAFIXA.WEBAPI.Controllers;

[ApiController]
[Route("[controller]/[action]")]
public class ConsultaInvestimentoController(IServicoQueConsultaInvestimentoDaPessoa servicoQueConsultaInvestimentoDaPessoa) : ControllerBase
{
    private readonly IServicoQueConsultaInvestimentoDaPessoa _servicoQueConsultaInvestimentoDaPessoa = servicoQueConsultaInvestimentoDaPessoa;

    [HttpPost(nameof(ConsultaInvestimentoDaPessoa))]
    public async Task<IActionResult> ConsultaInvestimentoDaPessoa(ConsultaInvestimentoDaPessoaSignature signature)
    {
        var taskListaInvestimentoQueNaoEstaLiquidadoOuBloqueado = _servicoQueConsultaInvestimentoDaPessoa
            .ListaInvestimentoQueNaoEstaLiquidadoOuBloqueado(new Investimento(signature.Investimento, signature.Investidor, signature.DocumentoFederal));

        return Ok(await taskListaInvestimentoQueNaoEstaLiquidadoOuBloqueado);
    }
}