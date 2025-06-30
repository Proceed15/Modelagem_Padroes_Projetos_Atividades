using System;

namespace TemplateMethodExemplo
{
    class ChocolateQuente : Bebida
    {
        protected override void AdicionarIngrediente()
        {
            Console.WriteLine("Adicionando o chocolate em pó.");
        }
    }
}