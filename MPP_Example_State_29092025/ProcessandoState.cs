using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadraoState
{
    public class ProcessandoState : IOrderState
    {
        public void ProcessarPagamento(Pedido pedido) => Console.WriteLine("ERRO: O pagamento deste pedido já foi processado.");
        public void DespacharPedido(Pedido pedido)
        {
            Console.WriteLine("Pedido despachado para o cliente!");
            pedido.MudarEstado(new EnviadoState());
            Console.WriteLine("Pedido mudou para o estado: Enviado");
        }
        public void EntregarPedido(Pedido pedido) => Console.WriteLine("ERRO: O pedido precisa ser despachado antes de ser entregue.");
        public void CancelarPedido(Pedido pedido)
        {
            Console.WriteLine("Pedido cancelado com sucesso.");
            pedido.MudarEstado(new CanceladoState());
            Console.WriteLine("Pedido mudou para o estado: Cancelado");
        }
    }
}