namespace Exercicio4;

public class BackupTarefa : TarefaAgendada
{
    public override void Executar()
    {
        Console.WriteLine("Executando tarefa de backup do sistema...");
    }
}
