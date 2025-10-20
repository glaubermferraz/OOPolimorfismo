namespace Exercicio4;

public class LimpezaTarefa : TarefaAgendada
{
    public override void Executar()
    {
        Console.WriteLine("Limpando arquivos temporários do servidor...");
    }
}
