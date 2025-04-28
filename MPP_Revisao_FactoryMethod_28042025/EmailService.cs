public class EmailService : IServicoMensagem
{
    public void Envia(ServicoMensagem msg)
    {
        Console.WriteLine($"Enviando Email para {msg.Destinatario}");
        Console.WriteLine($"Assunto: {msg.Titulo}");
        Console.WriteLine($"Corpo: {msg.Corpo}");
    }
}