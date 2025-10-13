// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;

namespace StrategyPattern
{
    public interface IMetodoAprendizado
    {
        void Treinar(string dados);
    }

    public class AprendizadoSupervisionado : IMetodoAprendizado
    {
        public void Treinar(string dados)
        {
            Console.WriteLine($"Treinando modelo supervisionado com dados rotulados: {dados}");
        }
    }

    public class AprendizadoNaoSupervisionado : IMetodoAprendizado
    {
        public void Treinar(string dados)
        {
            Console.WriteLine($"Agrupando dados não rotulados usando aprendizado não supervisionado: {dados}");
        }
    }

    public class AprendizadoPorReforco : IMetodoAprendizado
    {
        public void Treinar(string dados)
        {
            Console.WriteLine($"Treinando agente por reforço com base em recompensas simuladas: {dados}");
        }
    }

    public class InteligenciaArtificial
    {
        public string Nome { get; set; }
        private IMetodoAprendizado metodo;

        public InteligenciaArtificial(string nome, IMetodoAprendizado metodo)
        {
            Nome = nome;
            this.metodo = metodo;
        }

        public void ExecutarTreinamento(string dados)
        {
            Console.WriteLine($"\nIA {Nome} iniciando treinamento...");
            metodo.Treinar(dados);
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== Padrão Strategy - Sistema de Treinamento de IA ===");
            InteligenciaArtificial ia1 = new InteligenciaArtificial("Athena", new AprendizadoSupervisionado());
            InteligenciaArtificial ia2 = new InteligenciaArtificial("Zeus", new AprendizadoNaoSupervisionado());
            InteligenciaArtificial ia3 = new InteligenciaArtificial("Ares", new AprendizadoPorReforco());

            ia1.ExecutarTreinamento("Imagens de gatos e cães");
            ia2.ExecutarTreinamento("Logs de navegação anônimos");
            ia3.ExecutarTreinamento("Ambiente de simulação de drones");
        }
    }
}

