using GerenciadorTarefas.Application.Tarefas.Delete;
using GerenciadorTarefas.Application.Tarefas.Get;
using GerenciadorTarefas.Application.Tarefas.Register;
using GerenciadorTarefas.Application.Tarefas.Update;
using GerenciadorTarefas.Communication;
using GerenciadorTarefas.Communication.Request.Tarefas;
using GerenciadorTarefas.Communication.Response.Tarefas;
using Microsoft.AspNetCore.Mvc;

namespace GerenciadorTarefas.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class TarefaController : ControllerBase
{
    [HttpPost]
    [ProducesResponseType(typeof(ResultRegisteredTarefaJson), StatusCodes.Status201Created)]
    [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status400BadRequest)]
    public IActionResult Register([FromBody] RequestTarefaJson request)
    {
        var response = new RegisterTarefaUseCase().Execute(request);
        return Created(string.Empty, response);
    }

    [HttpPut]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status404NotFound)]
    public IActionResult Update([FromRoute] string id, [FromBody] RequestTarefaJson request)
    {
        if (new UpdateTarefaUseCase().Execute(id, request))
        {
            return NoContent();
        }
        return BadRequest(new ResponseErrorsJson());
    }

    [HttpDelete]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status404NotFound)]
    public IActionResult Delete([FromRoute] string id)
    {
        if (new DeleteTarefaUseCase().Execute(id))
        {
            return NoContent();
        }
        return BadRequest(new ResponseErrorsJson());
    }

    [HttpGet]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status404NotFound)]
    public IActionResult Get([FromRoute] string id)
    {
        var response = new GetTarefaUseCase().Execute(id);
        return Ok(response);
    }

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status400BadRequest)]
    public IActionResult Get()
    {
        var response = new GetAllTarefaUseCase().Execute();
        return Ok(response);
    }
}
