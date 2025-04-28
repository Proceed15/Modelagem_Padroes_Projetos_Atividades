// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;

class Program
{
    static void Main(string[] args)
    {
        //string tipoServico = "email";
        string tipoServico = "sms";
        //string tipoServico = "push";

        IServicoMensagem servicoMensagem = MensagemFactory.CriarServico(tipoServico);

        ServicoMensagem mensagem = new ServicoMensagem(
            destinatario: "+55 (11) 32146-2323",
            corpo: "SMS da Vivo sobre Bonificações Adicionais",
            titulo: "Vivo Bonifications!"
        );

        servicoMensagem.Envia(mensagem);
    }
}