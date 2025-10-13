// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;

public class Program
{
    public static void Main(string[] args)
    {
        // 1. Cria o Subject (o gerador)
        GeradorDeNotaFiscal gerador = new GeradorDeNotaFiscal();

        // 2. Cria os Observers (as ações)
        IAcaoAposGerarNota email = new EnviadorDeEmail();
        IAcaoAposGerarNota dao = new NotaFiscalDao();
        IAcaoAposGerarNota api = new ApiGoverno();

        // 3. Registra os observers no subject
        gerador.AdicionaAcao(email);
        gerador.AdicionaAcao(dao);
        gerador.AdicionaAcao(api);

        // 4. Cria os dados
        NotaFiscal nf = new NotaFiscal("Empresa XYZ", 2500.0);

        // 5. Executa a ação principal, que vai notificar todos os observers
        Console.WriteLine("\n--- Padrão Observer ---");
        gerador.Gera(nf);
    }
}

