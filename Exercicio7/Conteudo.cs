﻿namespace Exercicio7;
public class Conteudo
{
    public string Titulo { get; set; }
    public Conteudo(string titulo)
    {
        Titulo = titulo;
    }
    public virtual void ExibirInfo()
    {
        Console.WriteLine($"Título do conteudo: {Titulo}");
    }
}
