using GerenciadorTarefas.Communication.Response.Tarefas;

namespace GerenciadorTarefas.Application.Tarefas.Get;

public class GetTarefaUseCase
{
    public ResultTarefaJson Execute(string id)
    {
        return new ResultTarefaJson
        {
            Id = id,
            Nome = "Desenvolver projeto",
            Descricao = "Desenvolver projeto de teste",
            DataLimite = new DateTime(year: 2022, month: 10, day: 5),
            Prioridade = Communication.Request.Tarefas.PrioridadeType.Média,
            Status = Communication.Request.Tarefas.StatusType.Aguardando
        };
    }
}
