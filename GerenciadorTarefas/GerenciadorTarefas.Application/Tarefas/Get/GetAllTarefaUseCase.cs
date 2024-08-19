using GerenciadorTarefas.Communication.Response.Tarefas;

namespace GerenciadorTarefas.Application.Tarefas.Get;

public class GetAllTarefaUseCase
{
    public ResultAllTarefaJson Execute()
    {
        return new ResultAllTarefaJson()
        {
            Tarefas = new List<ResultTarefaJson>()
            {
                new ResultTarefaJson()
                {
                    Id = "7",
                    Nome = "Desenvolver projeto",
                    Descricao = "Desenvolver projeto de teste",
                    DataLimite = new DateTime(year: 2022, month: 10, day: 5),
                    Prioridade = Communication.Request.Tarefas.PrioridadeType.Média,
                    Status = Communication.Request.Tarefas.StatusType.Aguardando
                }
             }
        };
    }
}
