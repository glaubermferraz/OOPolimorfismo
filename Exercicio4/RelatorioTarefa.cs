﻿namespace Exercicio4;

public class RelatorioTarefa : TarefaAgendada
{
    public override void Executar()
    {
        Console.WriteLine("Gerando e enviando relatório diário...");
    }
}
