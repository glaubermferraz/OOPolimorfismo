namespace Exercicio8;

internal class Bicicleta : Transporte
{
    public override int CalcularTempo(int distancia)
    {
        return distancia * 4;
    }
}
