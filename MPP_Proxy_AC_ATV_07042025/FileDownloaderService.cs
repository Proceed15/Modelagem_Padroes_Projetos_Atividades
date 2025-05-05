public class FileDownloadService : IFileDownloader
{
    public void DownloadFile(string url)
    {
        Console.WriteLine($"\nBaixando arquivo de: {url}");
        Console.WriteLine("\nDownload Concluído com Sucesso!");
    }
}