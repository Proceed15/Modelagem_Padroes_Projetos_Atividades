using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
namespace PadraoState
{
    // A classe de contexto que mantém a referência para o estado atual
    public class Pedido
    {
        public IOrderState EstadoAtual { get; private set; }

        public Pedido()
        {
            EstadoAtual = new PagamentoPendenteState();
            Console.WriteLine("Novo pedido criado. Estado inicial: Pagamento Pendente");
        }

        public void MudarEstado(IOrderState novoEstado)
        {
            EstadoAtual = novoEstado;
        }

        public void ProcessarPagamento() => EstadoAtual.ProcessarPagamento(this);
        public void DespacharPedido() => EstadoAtual.DespacharPedido(this);
        public void EntregarPedido() => EstadoAtual.EntregarPedido(this);
        public void CancelarPedido() => EstadoAtual.CancelarPedido(this);
    }
}
