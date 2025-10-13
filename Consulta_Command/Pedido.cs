using System;

// Classe Receiver: contém a lógica de negócio real. É o objeto que, no final,
// fará o trabalho de verdade.
public class Pedido
{
    public string Cliente { get; private set; }
    public string Status { get; private set; }

    public Pedido(string cliente)
    {
        Cliente = cliente;
        Status = "Novo";
    }

    public void Paga()
    {
        Status = "Pago";
        Console.WriteLine($"Pedido do cliente {Cliente} foi pago.");
    }

    public void Finaliza()
    {
        Status = "Finalizado";
        Console.WriteLine($"Pedido do cliente {Cliente} foi finalizado.");
    }
}
