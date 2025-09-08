using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemploCommand.Receiver
{
    public class Cozinha
    {
        public void Preparar(string prato)
        {
            Console.WriteLine($"🍽️ Cozinha: preparando {prato}...");
        }
    }
}
