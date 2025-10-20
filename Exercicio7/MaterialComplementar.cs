namespace Exercicio7;

internal class MaterialComplementar : Conteudo
{
    public int Paginas { get; set; }
    public MaterialComplementar(string titulo, int paginas) : base(titulo)
    {
        Paginas = paginas;
    }
    public override void ExibirInfo()
    {
        Console.WriteLine($"Titulo: {Titulo}");
        Console.WriteLine($"Paginas: {Paginas}");
    }
}
