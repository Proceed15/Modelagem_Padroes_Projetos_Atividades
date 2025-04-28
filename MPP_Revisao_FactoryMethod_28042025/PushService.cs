public class PushService : IServicoMensagem
{
    public void Envia(ServicoMensagem msg)
    {
        Console.WriteLine($"Enviando Push Notification para {msg.Destinatario}");
        Console.WriteLine($"Título: {msg.Titulo}");
        Console.WriteLine($"Corpo: {msg.Corpo}");
    }
}