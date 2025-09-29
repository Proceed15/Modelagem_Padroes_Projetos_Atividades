using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadraoState
{
    public class EntregueState : IOrderState
    {
        public void ProcessarPagamento(Pedido pedido) => Console.WriteLine("ERRO: O pedido já foi entregue.");
        public void DespacharPedido(Pedido pedido) => Console.WriteLine("ERRO: O pedido já foi entregue.");
        public void EntregarPedido(Pedido pedido) => Console.WriteLine("ERRO: O pedido já foi entregue.");
        public void CancelarPedido(Pedido pedido) => Console.WriteLine("ERRO: O pedido já foi entregue.");
    }
}