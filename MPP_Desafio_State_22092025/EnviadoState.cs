using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Classe EnviadoState implementando a interface IOrderState Funcionando!

public class EnviadoState : IOrderState
{
    public void ProcessarPagamento(Pedido pedido) => Console.WriteLine("ERRO: O pagamento deste pedido já foi processado.");
    public void DespacharPedido(Pedido pedido) => Console.WriteLine("ERRO: O pedido já foi despachado.");
    public void EntregarPedido(Pedido pedido)
    {
        Console.WriteLine("Pedido entregue ao cliente com sucesso!");
        pedido.MudarEstado(new EntregueState());
        Console.WriteLine("Pedido mudou para o estado: Entregue (Finalizado)");
    }
    public void CancelarPedido(Pedido pedido) => Console.WriteLine("ERRO: Não é possível cancelar um pedido que já foi enviado.");
    public void SolicitarDevolucao(Pedido pedido) => Console.WriteLine("ERRO: Não é possível devolver um pedido que ainda não foi entregue.");

}