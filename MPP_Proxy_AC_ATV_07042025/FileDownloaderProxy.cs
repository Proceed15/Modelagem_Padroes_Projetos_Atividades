using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Dynamic;

public interface IFileDownloader
{
    void DownloadFile(string url);
}

public class FileDownloaderProxy : IFileDownloader
{
    private FileDownloadService _realService;
    private Dictionary<string, bool> _cache = new();

    public void DownloadFile(string url)
    {
        if (_cache.ContainsKey(url))
        {
            Console.WriteLine($"\n[CACHE] Arquivo {url} já baixado");
            return;
        }

        Console.WriteLine($"\nTem Certeza que deseja baixar {url}? (S/N)");
        if (Console.ReadLine()?.ToUpper() == "S")
        {
            _realService ??= new FileDownloadService();
            _realService.DownloadFile(url);
            _cache[url] = true;
        }
        else
        {
            Console.WriteLine("\nDownload cancelado");
        }
    }
}
