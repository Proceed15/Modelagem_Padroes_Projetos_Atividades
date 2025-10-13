// Comando Concreto: encapsula a ação de finalizar um pedido.
public class FinalizaPedido : IComando
{
    private Pedido _pedido;

    public FinalizaPedido(Pedido pedido)
    {
        _pedido = pedido;
    }

    public void Executa()
    {
        _pedido.Finaliza();
    }
}
