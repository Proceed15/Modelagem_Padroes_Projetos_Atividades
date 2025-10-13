// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
public class Program
{
    public static void Main(string[] args)
    {
        // 1. Cria os Receivers (os objetos que farão o trabalho)
        Pedido pedido1 = new Pedido("Cliente A");
        Pedido pedido2 = new Pedido("Cliente B");

        // 2. Cria o Invoker (a fila que vai processar os comandos)
        FilaDeTrabalho fila = new FilaDeTrabalho();

        // 3. Cria os Comandos, associando-os aos receivers
        IComando comandoPagar1 = new PagaPedido(pedido1);
        IComando comandoFinalizar1 = new FinalizaPedido(pedido1);
        IComando comandoPagar2 = new PagaPedido(pedido2);

        // 4. Adiciona os comandos à fila (a solicitação é enfileirada, não executada)
        fila.Adiciona(comandoPagar1);
        fila.Adiciona(comandoFinalizar1);
        fila.Adiciona(comandoPagar2);

        // 5. Processa a fila (agora sim, as ações são executadas)
        Console.WriteLine("\n--- Padrão Command ---");
        fila.Processa();
    }

}
