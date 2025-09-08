using exemploCommand.Receiver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemploCommand.Commands
{
    public class Pedido : IPedido
    {
        private Cozinha _cozinha;
        private string _prato;

        public Pedido(Cozinha cozinha, string prato)
        {
            _cozinha = cozinha;
            _prato = prato;
        }

        public void Executar()
        {
            _cozinha.Preparar(_prato);
        }
    }
}

