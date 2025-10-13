// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
using System.Collections.Generic;

namespace VisitorPattern
{
    public interface IVisitor
    {
        void Visitar(Pintura pintura);
        void Visitar(Escultura escultura);
    }

    public interface IObra
    {
        void Aceitar(IVisitor visitante);
    }

    public class Pintura : IObra
    {
        public string Titulo { get; set; }
        public string Artista { get; set; }

        public Pintura(string titulo, string artista)
        {
            Titulo = titulo;
            Artista = artista;
        }

        public void Aceitar(IVisitor visitante)
        {
            visitante.Visitar(this);
        }
    }

    public class Escultura : IObra
    {
        public string Nome { get; set; }
        public string Material { get; set; }

        public Escultura(string nome, string material)
        {
            Nome = nome;
            Material = material;
        }

        public void Aceitar(IVisitor visitante)
        {
            visitante.Visitar(this);
        }
    }

    public class VisitanteDescricao : IVisitor
    {
        public void Visitar(Pintura pintura)
        {
            Console.WriteLine($"Pintura: '{pintura.Titulo}' por {pintura.Artista}");
        }

        public void Visitar(Escultura escultura)
        {
            Console.WriteLine($"Escultura: '{escultura.Nome}' feita em {escultura.Material}");
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== Padrão Visitor - Museu Virtual ===");
            List<IObra> obras = new List<IObra>
            {
                new Pintura("A Noite Estrelada", "Van Gogh"),
                new Escultura("O Pensador", "Bronze")
            };

            VisitanteDescricao visitante = new VisitanteDescricao();
            foreach (var obra in obras)
                obra.Aceitar(visitante);
        }
    }
}
