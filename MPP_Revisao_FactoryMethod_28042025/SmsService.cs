public class SmsService : IServicoMensagem
{
    public void Envia(ServicoMensagem msg)
    {
        Console.WriteLine($"Enviando SMS para {msg.Destinatario}");
        Console.WriteLine($"Título: {msg.Titulo}");
        Console.WriteLine($"Mensagem: {msg.Corpo}");
    }
}