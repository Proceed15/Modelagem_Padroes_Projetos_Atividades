class YouTube : IPlatform
{
    public YouTube()
    {
        ConfigureRTMP();
        Console.WriteLine("YouTube: Transmissão Iniciada!");
    }
    public void AuthToken()
    {
        Console.WriteLine("\nYouTube: Autorizando aplicação.");
    }
    public void ConfigureRTMP()
    {
        AuthToken();
        Console.WriteLine("YouTube: Configurando Servidor RMTP.");
    }
    public void BroadCasting()
    {
        Console.WriteLine("YouTube: Transmissão Iniciada!");
    }
    public void Subtitles()
    {
        Console.WriteLine("YouTube: Adicionando Legendas à Transmissão!");
    }
    public void Comments()
    {
        Console.WriteLine("YouTube: Permitindo Comentários na Transmissão!\n");
    }
}