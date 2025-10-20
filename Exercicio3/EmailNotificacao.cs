namespace Exercicio3;

internal class EmailNotificacao : INotificacao
{
    public void EnviarMensagem(string mensagem)
    {
        Console.WriteLine($"Enviando E-mail: {mensagem}");
    }
}
