using GerenciadorTarefas.Communication.Request.Tarefas;
using GerenciadorTarefas.Communication.Response.Tarefas;

namespace GerenciadorTarefas.Application.Tarefas.Register;

public class RegisterTarefaUseCase
{
    public ResultRegisteredTarefaJson Execute(RequestTarefaJson request)
    {
        return new ResultRegisteredTarefaJson()
        {
            Id = "1",
            Nome = request.Nome,
        };
    }
}
