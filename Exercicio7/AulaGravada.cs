namespace Exercicio7;

internal class AulaGravada : Conteudo
{
    public int Duracao { get; set; }
    public AulaGravada(string titulo, int duracao) : base(titulo)
    {
        Duracao = duracao;
    }
    public override void ExibirInfo()
    {
        Console.WriteLine($"Titulo: {Titulo}");
        Console.WriteLine($"Duracao: {Duracao} min");
    }
}
