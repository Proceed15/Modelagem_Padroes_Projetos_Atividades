// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;

class Program
{
    static void Main()
    {
        //Criação dos Aprovadores
        var DescontoPorValorAlto = new DescontoPorValorAlto();
        var DescontoPorValorMedio = new DescontoPorValorMedio();
        var SemDesconto = new SemDesconto();

        //Configuração da cadeia de responsabilidades
        DescontoPorValorAlto.DefineProximo(DescontoPorValorMedio);
        DescontoPorValorMedio.DefineProximo(SemDesconto);

        //Exemplos de solicitações
        var solicitações = new[]
        {
            new SolicitaDesconto(800, "Desconto"),    // Deve ser negado
            new SolicitaDesconto(1500, "Desconto por Valor Médio"),   // Deve ser aprovado por valor médio
            new SolicitaDesconto(6000, "Desconto por Valor Alto"),   // Deve ser aprovado por valor alto
            new SolicitaDesconto(30000, "Desconto por Valor Alto")   // Deve ser aprovado por valor alto
        };

        //Processar todas as solicitações
        foreach (var s in solicitações)
        {
            Console.WriteLine($"\nSolicitação: {s.TipoDesconto} - Valor: R${s.Valor:F2}");
            DescontoPorValorAlto.AprovaDesconto(s);
        }

        Console.WriteLine("\nProcessamento concluído. Pressione qualquer tecla para sair...");
        Console.ReadKey();
    }
}
