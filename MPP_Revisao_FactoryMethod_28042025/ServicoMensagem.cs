public class ServicoMensagem
{
    public string Destinatario { get; set; }
    public string Titulo { get; set; }
    public string Corpo { get; set; }

    public ServicoMensagem(string destinatario, string corpo, string titulo = null)
    {
        Destinatario = destinatario;
        Corpo = corpo;
        Titulo = titulo;
    }
}