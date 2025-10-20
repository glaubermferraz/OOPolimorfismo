namespace Exercicio8;

internal class Metro : Transporte
{
    public override int CalcularTempo(int distancia)
    {
        return distancia + 5;
    }
}
