// Comando Concreto: encapsula a ação de pagar um pedido.
public class PagaPedido : IComando
{
    private Pedido _pedido;

    public PagaPedido(Pedido pedido)
    {
        _pedido = pedido;
    }

    public void Executa()
    {
        _pedido.Paga();
    }
}

