namespace Exercicio3;

internal class PushNotificacao : INotificacao
{
    public void EnviarMensagem(string mensagem)
    {
        Console.WriteLine($"Enviando Push: {mensagem}");
    }
}
