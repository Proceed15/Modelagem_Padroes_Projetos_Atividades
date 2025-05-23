﻿// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
class Program
{

    static void Main()
    {
        Console.WriteLine("=== ATIVIDADE DE PROXY ===");
        IFileDownloader downloader = new FileDownloaderProxy();
        
        // Primeiro download
        Console.WriteLine("\nPrimeiro Download:");
        downloader.DownloadFile("http://exemplo.com/arquivo1.zip");
        
        // Novo Arquivo
        Console.WriteLine("\nNovo Download:");
        downloader.DownloadFile("http://exemplo.com/arquivo2.zip");

        // Tentativa repetida (deve usar cache)
        Console.WriteLine("\nBaixando Novamente:");
        downloader.DownloadFile("http://exemplo.com/arquivo1.zip");
    }

}
