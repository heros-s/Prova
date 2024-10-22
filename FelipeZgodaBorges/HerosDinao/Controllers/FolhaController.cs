using Microsoft.AspNetCore.Mvc;
using HerosDinao.Data;
using HerosDinao.Models;
namespace HerosDinao.Controllers;

[Route("api/folha")]
[ApiController]
public class FolhaController : ControllerBase
{
    private readonly AppDataContext _ctx;
    public FolhaController(AppDataContext ctx)
    {
        _ctx = ctx;
    }

    // [HttpGet]
    // public IActionResult GetFolhas()
    // {
    //     var folhas = _ctx.Folhas.ToList();
    //     return Ok(folhas);
    // }

    [HttpPost]
    [Route("cadastrar")]
    public IActionResult Cadastrar([FromBody] FolhaPagamento folha)
    {
        Funcionario? funcionario = _ctx.Funcionarios.Find(folha.FuncionarioId);
        if (funcionario == null)
        {
            return NotFound("Funcionario não encontrado.");
        }
        folha.Funcionario = funcionario;
        folha.SalarioBruto = folha.Quantidade * folha.Valor;
        
        _ctx.Folhas.Add(folha);
        _ctx.SaveChanges();

        return CreatedAtAction("GetFolhas", new { id = folha.FolhaId }, folha);
    }


}