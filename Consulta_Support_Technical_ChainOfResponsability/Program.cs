// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;

namespace ChainPattern
{
    public abstract class Suporte
    {
        protected Suporte Proximo;
        public void DefinirProximo(Suporte proximo) => Proximo = proximo;
        public abstract void TratarChamado(int nivel);
    }

    public class SuporteBasico : Suporte
    {
        public override void TratarChamado(int nivel)
        {
            if (nivel == 1)
                Console.WriteLine("Suporte Básico resolveu o problema.");
            else
                Proximo?.TratarChamado(nivel);
        }
    }

    public class SuporteIntermediario : Suporte
    {
        public override void TratarChamado(int nivel)
        {
            if (nivel == 2)
                Console.WriteLine("Suporte Intermediário resolveu o problema.");
            else
                Proximo?.TratarChamado(nivel);
        }
    }

    public class SuporteAvancado : Suporte
    {
        public override void TratarChamado(int nivel)
        {
            Console.WriteLine("Suporte Avançado analisou e resolveu o problema crítico com Sucesso.");
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== Padrão Chain of Responsibility - Sistema de Suporte Técnico ===");
            Console.WriteLine("Atendimento de Suporte Técnico Níveis 1, 2 e 3: ");
            Suporte basico = new SuporteBasico();
            Suporte medio = new SuporteIntermediario();
            Suporte avancado = new SuporteAvancado();

            basico.DefinirProximo(medio);
            medio.DefinirProximo(avancado);

            basico.TratarChamado(1);
            basico.TratarChamado(2);
            basico.TratarChamado(3);
        }
    }
}


