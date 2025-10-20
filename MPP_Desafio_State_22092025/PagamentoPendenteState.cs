using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class PagamentoPendenteState : IOrderState
    {
        public void ProcessarPagamento(Pedido pedido)
        {
            Console.WriteLine("Pagamento processado com sucesso!");
            pedido.MudarEstado(new ProcessandoState());
            Console.WriteLine("Pedido mudou para o estado: Processando");
        }
        public void DespacharPedido(Pedido pedido) => Console.WriteLine("ERRO: Não é possível despachar um pedido com pagamento pendente.");
        public void EntregarPedido(Pedido pedido) => Console.WriteLine("ERRO: Não é possível entregar um pedido com pagamento pendente.");
    public void CancelarPedido(Pedido pedido)
    {
        Console.WriteLine("Pedido cancelado com sucesso.");
        pedido.MudarEstado(new CanceladoState());
        Console.WriteLine("Pedido mudou para o estado: Cancelado");
    }
    public void SolicitarDevolucao(Pedido pedido) => Console.WriteLine("ERRO: Não é possível devolver um pedido com pagamento pendente.");
}


