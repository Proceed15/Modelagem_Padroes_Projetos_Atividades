using System;
using static SOLID_MPP_ATVS.SOLID_ISP_A;

namespace SOLID_MPP_ATVS
{
    class Program
    {
        static void Main(string[] args)
        {
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
            }
        }

        private static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1) S - Princípio SRP do SOLID");
            Console.WriteLine("2) O - Princípio OCP do SOLID");
            Console.WriteLine("3) L - Princípio LSP do SOLID");
            Console.WriteLine("4) I - Princípio ISP do SOLID");
            Console.WriteLine("5) D - Princípio DIP do SOLID");
            Console.WriteLine("6) Sair");
            Console.Write("\r\nSelecione uma opção: ");

            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("\nS - SRP (Single Responsibility Principle), Princípio da Responsabilidade Única");
                    //Dividi em ClientServices para as operações com o client e NotificationService a Notificação
                    SOLID_SRP_A.RetornaSRP();
                    ReMenu();
                    return true;

                case "2":
                    Console.WriteLine("\nO - OCP (Open/Closed Principle), Princípio do Aberto/Fechado");
                    //As classes Carro e Moto herdam da classe Veículo
                    SOLID_OCP_A.RetornaOCP();
                    ReMenu();
                    return true;

                case "3":
                    Console.WriteLine("\nL - LSP (Liskov Substitution Principle), Princípio da Substituição de Liskov");
                    //As operações de Crédito e Débito podem substituir NubankCard se preciso
                    //Fiz o NuBank Rewards com um Contador para Adicionar Pontos
                    SOLID_LSP_A.RetornaLSP();
                    ReMenu();
                    return true;


                case "4":
                    Console.WriteLine("\nI - ISP (Interface Segregation Principle), Princípio da Segregação de Interfaces");
                    //Executando esse Método, retorna um Carro e uma Moto, cada um com suas configurações individuais
                    SOLID_ISP_A.RetornaISP();
                    Console.WriteLine("\n");
                    //Teste Adicionando um Carro
                    ICarro carroISP = new Carro("Amarelo", 2025, 3.6f, 9, 4);
                    //Teste Configurando um Carro
                    carroISP.ConfigureCarro("Azul", 2021, 1.8f, 5, 4);
                    Console.WriteLine("\n");
                    //Em cada Configuração e Adição já chama o Método Ligar

                    //Mesmos Testes para uma Moto
                    IMoto motoISP = new Moto("Prata", 2023, 600f);
                    motoISP.ConfigureMoto("Branca", 2022, 300f);
                    ReMenu();
                    return true;

                case "5":
                    Console.WriteLine("\nD - DIP (Dependency Inversion Principle), Princípio da Inversão de Dependência");
                    Console.WriteLine("Não houve atividade prática sobre este princípio, então adicionei essa descrição para suprir esse espaço.");
                    ReMenu();
                    return true;

                case "6":
                    Console.WriteLine("Última Chance, Deseja Mesmo Sair? (Sim/Não)");
                    string Resposta = Console.ReadLine();
                    if (Resposta == "Sim")
                    {
                        Console.WriteLine("Obrigado pela Visita!");
                        System.Threading.Thread.Sleep(2300);
                        return false;
                    }
                    Console.WriteLine("Retornando ao Menu Inicial...");
                    System.Threading.Thread.Sleep(2300);
                    return true;

                default:
                    return true;
            }
        }

        private static void ReMenu()
        {
            Console.WriteLine("\r\nPressione Enter para retornar ao Menu...");
            Console.ReadLine();
        }
    }
}
