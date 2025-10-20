public class DevolvendoState : IOrderState
{
    public void ProcessarPagamento(Pedido pedido) => Console.WriteLine("ERRO: O pedido está em processo de devolução.");

    public void DespacharPedido(Pedido pedido) => Console.WriteLine("ERRO: O pedido está em processo de devolução.");
    public void EntregarPedido(Pedido pedido) => Console.WriteLine("ERRO: O pedido está em processo de devolução.");
    public void CancelarPedido(Pedido pedido) => Console.WriteLine("ERRO: O pedido está em processo de devolução.");
    public void SolicitarDevolucao(Pedido pedido)
    {
        pedido.MudarEstado(new DevolvendoState());
        Console.WriteLine("Pedido Devolvido com Sucesso!");
    }
}