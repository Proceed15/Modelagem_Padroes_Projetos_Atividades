// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
class Program
{
    static void Main(string[] args)
    {
        IPlatform Facebook = new Facebook();
        IPlatform TwitchTV = new TwitchTV();
        IPlatform YouTube = new YouTube();
        IPlatform LinkedinLive = new LinkedinLive();

        Live LiveOnFacebook = new Live(Facebook);
        Live LiveOnTwitchTV = new Live(TwitchTV);
        Live LiveOnYouTube = new Live(YouTube);
        Live LiveOnLinkedin = new Live(LinkedinLive);

        Console.WriteLine("\nIniciando Transmissão ao Vivo no Facebook: ");
        LiveOnFacebook.StartLive();
        LiveOnFacebook.AddSubtitles();
        LiveOnFacebook.EnableComments();
        Console.WriteLine();

        Console.WriteLine("Iniciando Transmissão ao Vivo na TwitchTV: ");
        LiveOnTwitchTV.StartLive();
        LiveOnTwitchTV.AddSubtitles();
        LiveOnTwitchTV.EnableComments();
        Console.WriteLine();

        Console.WriteLine("Iniciando Transmissão ao Vivo no YouTube: ");
        LiveOnYouTube.StartLive();
        LiveOnYouTube.AddSubtitles();
        LiveOnYouTube.EnableComments();
        Console.WriteLine();

        Console.WriteLine("Iniciando Transmissão no LinkedinLive: ");
        LiveOnLinkedin.StartLive();
        LiveOnLinkedin.AddSubtitles();
        LiveOnLinkedin.EnableComments();
        Console.WriteLine();
    }
}