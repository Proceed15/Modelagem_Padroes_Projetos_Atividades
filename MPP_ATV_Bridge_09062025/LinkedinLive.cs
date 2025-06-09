class LinkedinLive : IPlatform
{
    public LinkedinLive()
    {
        ConfigureRTMP();
        Console.WriteLine("LinkedinLive: Transmissão Iniciada!");
    }
    public void AuthToken()
    {
        Console.WriteLine("\nLinkedinLive: Autorizando aplicação.");
    }
    public void ConfigureRTMP()
    {
        AuthToken();
        Console.WriteLine("LinkedinLive: Configurando Servidor RMTP.");
    }
    public void BroadCasting()
    {
        Console.WriteLine("LinkedinLive: Transmissão Iniciada!");
    }
    public void Subtitles()
    {
        Console.WriteLine("LinkedinLive: Adicionando Legendas à Transmissão!");
    }
    public void Comments()
    {
        Console.WriteLine("LinkedinLive: Permitindo Comentários na Transmissão!\n");
    }
}