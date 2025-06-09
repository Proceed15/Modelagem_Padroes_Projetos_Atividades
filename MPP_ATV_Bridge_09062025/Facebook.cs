class Facebook : IPlatform
{
    public Facebook()
    {
        ConfigureRTMP();
        Console.WriteLine("Facebook: Transmissão Iniciada!");
    }
    public void AuthToken()
    {
        Console.WriteLine("\nFacebook: Autorizando aplicação.");
    }
    public void ConfigureRTMP()
    {
        AuthToken();
        Console.WriteLine("Facebook: Configurando Servidor RMTP.");
    }
    public void BroadCasting()
    {
        Console.WriteLine("Facebook: Transmissão Iniciada!");
    }
    public void Subtitles()
    {
        Console.WriteLine("Facebook: Adicionando Legendas à Transmissão!");
    }
    public void Comments()
    {
        Console.WriteLine("Facebook: Permitindo Comentários na Transmissão!\n");
    }
}