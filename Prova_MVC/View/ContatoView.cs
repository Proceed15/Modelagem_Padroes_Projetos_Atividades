using System;
using System.Collections.Generic;
using Prova_MVC.Model;

namespace Prova_MVC.View
{
    public class ContatoView
    {
        public void MostrarMenu()
        {
            Console.WriteLine("\n--- AGENDA DE CONTATOS ---");
            Console.WriteLine("1. Adicionar Contato");
            Console.WriteLine("2. Listar Contatos");
            Console.WriteLine("0. Sair");
            Console.Write("Escolha uma opção: ");
        }

        public string SolicitarNome()
        {
            Console.Write("Digite o nome do contato: ");
            return Console.ReadLine();
        }

        public string SolicitarEmail()
        {
            Console.Write("Digite o email do contato: ");
            return Console.ReadLine();
        }

        public void MostrarListaDeContatos(List<Contato> contatos)
        {
            Console.WriteLine("\n--- LISTA DE CONTATOS ---");
            if (contatos.Count == 0)
            {
                Console.WriteLine("Nenhum contato na agenda.");
            }
            else
            {
                foreach (var contato in contatos)
                {
                    Console.WriteLine(contato.ToString());
                }
            }
        }

        public void MostrarMensagem(string mensagem)
        {
            Console.WriteLine(mensagem);
        }
    }
}
