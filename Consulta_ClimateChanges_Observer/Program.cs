// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
using System.Collections.Generic;

namespace ObserverPattern
{
    public interface IObservador
    {
        void Atualizar(double temperatura, double umidade);
    }

    public interface IEstacao
    {
        void Registrar(IObservador observador);
        void Remover(IObservador observador);
        void Notificar();
    }

    public class EstacaoMeteorologica : IEstacao
    {
        private List<IObservador> paineis = new List<IObservador>();
        private double temperatura;
        private double umidade;

        public void DefinirMedidas(double temperatura, double umidade)
        {
            this.temperatura = temperatura;
            this.umidade = umidade;
            Notificar();
        }

        public void Registrar(IObservador obs) => paineis.Add(obs);
        public void Remover(IObservador obs) => paineis.Remove(obs);

        public void Notificar()
        {
            foreach (var p in paineis)
                p.Atualizar(temperatura, umidade);
        }
    }

    public class PainelDisplay : IObservador
    {
        public string Nome { get; }
        public PainelDisplay(string nome) => Nome = nome;

        public void Atualizar(double temperatura, double umidade)
        {
            Console.WriteLine($"{Nome} mostra: Temperatura = {temperatura}°C | Umidade = {umidade}%");
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== Padrão Observer - Monitoramento de Clima ===");
            EstacaoMeteorologica estacao = new EstacaoMeteorologica();
            PainelDisplay painel1 = new PainelDisplay("Painel Principal");
            PainelDisplay painel2 = new PainelDisplay("Painel Secundário");

            estacao.Registrar(painel1);
            estacao.Registrar(painel2);

            estacao.DefinirMedidas(27.5, 65);
            estacao.DefinirMedidas(30.0, 55);

            estacao.Remover(painel2);
            estacao.DefinirMedidas(25.0, 70);
            estacao.DefinirMedidas(35.0, 75);
        }
    }
}
