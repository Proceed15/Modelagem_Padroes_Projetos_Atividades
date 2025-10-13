public class PagaPedido
{
    public bool Pago = false;
    private int valor = 100;

    public void Pagar()
    {
        Pago = true;
        Console.WriteLine("Pedido Pago");
    }
    public void DesfazerPago()
    {
        Pago = false;
        Console.WriteLine("Pagamento do Pedido Cancelado.");
    }
    public void Status()
    {
        Console.WriteLine($"Pedido {(Pago ? "Pago" : "Não Pago")} no valor de R$" + valor);
    }
}