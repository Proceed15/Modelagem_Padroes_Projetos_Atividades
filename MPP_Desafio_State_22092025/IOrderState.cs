using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public interface IOrderState
{
    void ProcessarPagamento(Pedido pedido);
    void DespacharPedido(Pedido pedido);
    void EntregarPedido(Pedido pedido);
    void CancelarPedido(Pedido pedido);
    void SolicitarDevolucao(Pedido pedido);
}
    



