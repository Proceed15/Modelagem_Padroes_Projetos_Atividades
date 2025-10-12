using System;
using Prova_MVC.Model;
using Prova_MVC.View;

namespace Prova_MVC.Controller
{
    public class AgendaController
    {
        private readonly Agenda _model;
        private readonly ContatoView _view;

        public AgendaController(Agenda model, ContatoView view)
        {
            _model = model;
            _view = view;
        }

        public void Iniciar()
        {
            string opcao;
            do
            {
                _view.MostrarMenu();
                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        AdicionarContato();
                        break;
                    case "2":
                        ListarContatos();
                        break;
                    case "0":
                        _view.MostrarMensagem("Saindo da agenda...");
                        break;
                    default:
                        _view.MostrarMensagem("Opção inválida. Por favor, tente novamente.");
                        break;
                }

            } while (opcao != "0");
        }

        private void AdicionarContato()
        {
            string nome = _view.SolicitarNome();
            string email = _view.SolicitarEmail();

            Contato novoContato = new Contato(nome, email);
            _model.AdicionarContato(novoContato);

            _view.MostrarMensagem("Contato adicionado com sucesso!");
        }

        private void ListarContatos()
        {
            var contatos = _model.GetContatos();
            _view.MostrarListaDeContatos(contatos);
        }
    }
}
