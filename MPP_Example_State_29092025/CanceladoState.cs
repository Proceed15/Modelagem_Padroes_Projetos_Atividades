using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadraoState
{
    public class CanceladoState : IOrderState
    {
        public void ProcessarPagamento(Pedido pedido) => Console.WriteLine("ERRO: O pedido está cancelado.");
        public void DespacharPedido(Pedido pedido) => Console.WriteLine("ERRO: O pedido está cancelado.");
        public void EntregarPedido(Pedido pedido) => Console.WriteLine("ERRO: O pedido está cancelado.");
        public void CancelarPedido(Pedido pedido) => Console.WriteLine("ERRO: O pedido já está cancelado.");
    }
}