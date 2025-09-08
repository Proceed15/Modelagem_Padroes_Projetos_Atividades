// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using exemploCommand.Commands;
using exemploCommand.Invoker;
using exemploCommand.Receiver;

class Program
{
    static void Main()
    {
        var cozinha = new Cozinha();
        var garcom = new Garcom();

        // Cliente pede Pizza
        var pedidoPizza = new Pedido(cozinha, "Pizza");
        garcom.EnviarPedido(pedidoPizza);

        // Cliente pede Suco
        var pedidoSuco = new Pedido(cozinha, "Suco");
        garcom.EnviarPedido(pedidoSuco);
    }
}
