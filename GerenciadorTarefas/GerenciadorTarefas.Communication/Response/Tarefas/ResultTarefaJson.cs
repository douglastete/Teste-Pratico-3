using GerenciadorTarefas.Communication.Request.Tarefas;

namespace GerenciadorTarefas.Communication.Response.Tarefas;

public class ResultTarefaJson
{
    public string Id { get; set; } = string.Empty;
    public string Nome { get; set; } = string.Empty;
    public string Descricao { get; set; } = string.Empty;
    public PrioridadeType Prioridade { get; set; }
    public DateTime DataLimite { get; set; }
    public StatusType Status { get; set; }
}
