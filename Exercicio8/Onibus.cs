﻿namespace Exercicio8;

internal class Onibus : Transporte
{
    public override int CalcularTempo(int distancia)
    {
        return (distancia * 2) + 5;
    }
}
