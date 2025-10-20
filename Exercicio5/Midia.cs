namespace Exercicio5;

public class Midia
{
    public string Nome { get; }
    public Midia(string nome)
    {
        Nome = nome;
    }
    public virtual void ExibirDetalhes()
    {
        Console.WriteLine($"Mídia: {Nome}");
    }
}
