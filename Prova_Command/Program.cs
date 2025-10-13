// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
using System.Collections.Generic;



class Program
{
    static void Main()
    {
        Console.WriteLine("\nPedindo"); //Inicia
        PagaPedido pedido = new PagaPedido();
        FilaDeTrabalho fila = new FilaDeTrabalho();
        fila.FazerPedido(new FinalizaPedido(pedido));   
        pedido.Status();
        Console.WriteLine("\nDesfazendo");
        fila.DesfazerUltimo();
        pedido.Status();
        Console.WriteLine("\nPedindo Novamente");
        pedido.Pagar();
        pedido.Status();
        Console.WriteLine("\nAdicionando Novos Pedidos:");
        fila.FazerPedido(new FinalizaPedido(pedido));
        fila.FazerPedido(new FinalizaPedido(pedido));
        fila.FazerPedido(new FinalizaPedido(pedido));
        fila.FazerPedido(new FinalizaPedido(pedido));
        fila.FazerPedido(new FinalizaPedido(pedido));
        pedido.Status();
        Console.WriteLine("\nHistórico:");
        fila.MostrarHistorico();
        Console.WriteLine("\nDesfazendo Último Pedido:");
        fila.DesfazerUltimo();
        pedido.Status();
        Console.WriteLine("\nFazendo mais um pedido:");
        fila.FazerPedido(new FinalizaPedido(pedido));
        pedido.Status();
        fila.MostrarHistorico();
    } 
}