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

    [HttpPost]
    public async Task<IActionResult> ConsultaInvestimentoDaPessoaQueNaoEstaBloqueado(ListaInvestimentoQueNaoEstaLiquidadoNemBloqueadoSignature signature)
    {
        var taskConsultaInvestimentoQueNaoEstaBloqueado = _servicoQueConsultaInvestimentoDaPessoa
            .ConsultaInvestimentoQueNaoEstaBloqueado(new Investimento(signature.Investimento, signature.Investidor, signature.DocumentoFederal));

        return Ok(await taskConsultaInvestimentoQueNaoEstaBloqueado);
    }

    [HttpPost]
    public async Task<IActionResult> ListaInvestimentoDaPessoaQueNaoEstaLiquidadoNemBloqueado(ListaInvestimentoQueNaoEstaLiquidadoNemBloqueadoSignature signature)
    {
        var taskListaInvestimentoQueNaoEstaLiquidadoOuBloqueado = _servicoQueConsultaInvestimentoDaPessoa
            .ListaInvestimentoQueNaoEstaLiquidadoNemBloqueado(new Investimento(signature.Investimento, signature.Investidor, signature.DocumentoFederal));

        return Ok(await taskListaInvestimentoQueNaoEstaLiquidadoOuBloqueado);
    }
}