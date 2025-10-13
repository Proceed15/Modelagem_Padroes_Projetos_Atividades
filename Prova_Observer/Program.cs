// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
class Program
{
    static void Main(string[] args)
    {
        IAcaoAposGerarNota gerador = new GeradordeNotaFiscal();
        IAcaoAposGerarNota dao = new NotaFiscalDao();
        Console.WriteLine("Gerando nota fiscal e notificando observadores...\n");
        gerador.RegistrarAcao(dao);
        gerador.CriarNotaFiscal("Nota fiscal gerada com sucesso!");
        gerador.EmitirNotaFiscal();
        gerador.Remover(dao);
        Console.WriteLine("Gerando Nota Fiscal pela API do Governo e notificando observadores...\n");
        IAcaoAposGerarNota apiGoverno = new ApiGoverno();
        //Adicionando o observador
        gerador.RegistrarAcao(apiGoverno);
        gerador.CriarNotaFiscal("Nota fiscal gerada com sucesso!");
        gerador.EmitirNotaFiscal();
        //Removendo o observador
        gerador.Remover(apiGoverno);


    }
}
