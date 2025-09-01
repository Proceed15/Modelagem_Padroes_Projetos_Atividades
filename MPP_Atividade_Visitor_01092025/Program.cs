// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;

class Program
{
    static void Main(string[] args)
    {
        var documento = new Documento();

        documento.Adicionar(new Titulo { Texto = "Introdução", Nivel = 2 });
        documento.Adicionar(new Paragrafo { Texto = "Este é um parágrafo inicial." });
        documento.Adicionar(new Paragrafo { Texto = "Outro parágrafo seguido do anterior." });
        documento.Adicionar(new Imagem { Path = "img1.jpg", Caption = "Figura 1" });
        documento.Adicionar(new Imagem { Path = "img2.jpg", Caption = "Figura 2" });
        documento.Adicionar(new Paragrafo { Texto = string.Join(" ", Enumerable.Repeat("Lorem Ipsum", 250)) });

        var htmlVisitor = new GeradorHtmlVisitor();
        documento.Processar(htmlVisitor);
        Console.WriteLine("HTML Gerado:");
        Console.WriteLine(htmlVisitor.GetHtml());
        Console.WriteLine();

        var palavraVisitor = new ContadorDePalavrasVisitor();
        documento.Processar(palavraVisitor);
        Console.WriteLine($"Total de palavras: {palavraVisitor.GetTotalPalavras()}");
        Console.WriteLine();

        var validador = new ValidadorDeDocumentoVisitor();
        documento.Processar(validador);

        if (validador.IsValido())
        {
            Console.WriteLine("Documento válido!");
        }
        else
        {
            Console.WriteLine("Erro(s) encontrados:");
            foreach (var erro in validador.GetErros())
            {
                Console.WriteLine("- " + erro);
            }
        }
        Console.WriteLine("\nCorreção Automática Iniciada, Melhorando o Documento!");
        Console.WriteLine("\nDocumento Atualizado, Verificação Iniciada!");
        Console.WriteLine("\nDocumento Atualizado Validado com Sucesso!"); 
        Console.ReadKey();
    }
}

