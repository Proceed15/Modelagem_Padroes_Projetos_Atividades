public class FinalizaPedido : IComando
{
    private PagaPedido Pago;

    public FinalizaPedido(PagaPedido True) => Pago = True;


    public bool Pedir()
    {
        Pago.Pagar();
        Console.WriteLine("Pedido Finalizado");
        return true;
    }
    public bool Desfazer()
    {
        Pago.DesfazerPago();
        Console.WriteLine("Finalização do Pedido Cancelada.");
        return true;
    }
}
