class TwitchTV : IPlatform
{
    public TwitchTV()
    {
        ConfigureRTMP();
        Console.WriteLine("TwitchTV: Transmissão Iniciada!");
    }
    public void AuthToken()
    {
        Console.WriteLine("\nTwitchTV: Autorizando aplicação.");
    }
    public void ConfigureRTMP()
    {
        AuthToken();
        Console.WriteLine("TwitchTV: Configurando Servidor RMTP.");
    }
    public void BroadCasting()
    {
        Console.WriteLine("TwitchTV: Transmissão Iniciada!");
    }
    public void Subtitles()
    {
        Console.WriteLine("TwitchTV: Adicionando Legendas à Transmissão!");
    }
    public void Comments()
    {
        Console.WriteLine("TwitchTV: Permitindo Comentários na Transmissão!\n");
    }
}