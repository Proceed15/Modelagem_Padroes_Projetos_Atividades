// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
using System.Collections.Generic;

namespace CommandPattern
{
    public interface ICommand
    {
        void Executar();
        void Desfazer();
    }

    public class Robo
    {
        public void Mover() => Console.WriteLine("Robô se moveu para a próxima posição.");
        public void Soldar() => Console.WriteLine("Robô executou soldagem.");
        public void Parar() => Console.WriteLine("Robô parou a operação.");
    }

    public class MoverCommand : ICommand
    {
        private Robo robo;
        public MoverCommand(Robo robo) => this.robo = robo;
        public void Executar() => robo.Mover();
        public void Desfazer() => Console.WriteLine("Desfeito: Robô retornou à posição anterior.");
    }

    public class SoldarCommand : ICommand
    {
        private Robo robo;
        public SoldarCommand(Robo robo) => this.robo = robo;
        public void Executar() => robo.Soldar();
        public void Desfazer() => Console.WriteLine("Desfeito: Soldagem anulada.");
    }

    public class PararCommand : ICommand
    {
        private Robo robo;
        public PararCommand(Robo robo) => this.robo = robo;
        public void Executar() => robo.Parar();
        public void Desfazer() => Console.WriteLine("Desfeito: Robô retomou a operação.");
    }

    public class Central
    {
        private Stack<ICommand> historico = new Stack<ICommand>();

        public void Executar(ICommand comando)
        {
            comando.Executar();
            historico.Push(comando);
        }

        public void DesfazerUltimo()
        {
            if (historico.Count > 0)
            {
                ICommand ultimo = historico.Pop();
                ultimo.Desfazer();
            }
            else Console.WriteLine("Nenhum comando a desfazer.");
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== Padrão Command - Controle de Robô Industrial ===");
            Robo robo = new Robo();
            Central central = new Central();
            central.Executar(new MoverCommand(robo));
            central.Executar(new SoldarCommand(robo));
            central.Executar(new PararCommand(robo));
            central.DesfazerUltimo();
            central.Executar(new MoverCommand(robo));
            central.Executar(new SoldarCommand(robo));
            central.Executar(new PararCommand(robo));
            central.Executar(new MoverCommand(robo));
        }
    }
}

