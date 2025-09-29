// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;

        
    class Program
    {
        static void Main()
        {
            // Cria os aprovadores
            var gerente = new Manager();
            var diretor = new Director();
            var cfo = new CFO();

            // Configura a cadeia
            gerente.SetNext(diretor);
            diretor.SetNext(cfo);

            // Exemplos de pedidos
            var pedidos = new[]
            {
                new PurchaseRequest("Compra de material de escritório", 500),
                new PurchaseRequest("Novos computadores", 5_000),
                new PurchaseRequest("Servidores para Data Center", 25_000),
                new PurchaseRequest("Aquisição de empresa", 120_000)
            };

            // Processa todos os pedidos
            foreach (var p in pedidos)
            {
                Console.WriteLine($"\nSolicitação: {p.Description} - Valor: R${p.Amount:F2}");
                gerente.Approve(p);
            }

            Console.WriteLine("\nProcessamento concluído. Pressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
