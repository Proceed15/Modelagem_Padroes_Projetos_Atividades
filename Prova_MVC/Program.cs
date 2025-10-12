// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using Prova_MVC.Controller;
using Prova_MVC.Model; 
using Prova_MVC.View;


namespace Prova_MVC {
    class Program
    {
        static void Main(string[] args)
        {
            //1 Instancia as Camadas Model e View
            Agenda model = new Agenda();
            ContatoView view = new ContatoView();

            //2 Instancia o Controller, injetando as dependências Model e View
            AgendaController controller = new AgendaController(model, view);

            //3 Inicia o Sistema
            controller.Iniciar();
        }
    }
}