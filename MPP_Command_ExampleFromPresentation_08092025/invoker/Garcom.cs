using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exemploCommand.Commands;


namespace exemploCommand.Invoker
{
    public class Garcom
    {
        public void EnviarPedido(IPedido pedido)
        {
            Console.WriteLine("📝 Garçom: enviando pedido para a cozinha...");
            pedido.Executar();
        }
    }
}
