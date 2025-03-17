﻿// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System.Formats.Asn1;
using System.Runtime.InteropServices;

class Program {
    string Resposta;
    static Application ConfigureApplication()
    {
        //do {
        Application app;
        ITransportFactory transportFactory;

        Console.WriteLine("Digite o Nome da Empresa: Uber | 99 | Lime");
        string company = Console.ReadLine();
        Console.WriteLine("Digite qual Rota prefere: terrestre | aérea");
        string rota = Console.ReadLine();

        if (company == "Uber") {
            transportFactory = new UberTransport();
        } else if(company == "99") {
            transportFactory = new NineNineTransport();
        } else {
            transportFactory = new LimeTransport();
        }
        app = new Application(transportFactory, rota);
        //Console.WriteLine("Deseja Continuar? Sim | Não");
        //Resposta = Console.ReadLine();
        return app; 
        //}while(Resposta == "Sim" || Resposta == "S" || Resposta == "sim" || Resposta == "s");
    }
    static void Main(string[] args) {
        Application app = ConfigureApplication();
        app.StartRoute();
        Console.ReadLine();
    }
    
}