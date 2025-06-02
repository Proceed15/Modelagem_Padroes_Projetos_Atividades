// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
// Arquivo: Program.cs
using Decorator;
using System;

namespace DecoratorPatternExample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Notificação simples por e-mail
            INotifier emailNotifier = new EmailNotifier();
            Console.WriteLine("--- Notificação Simples por Email ---");
            Console.WriteLine(emailNotifier.Send("Olá, Mundo!"));
            Console.WriteLine();

            // Notificação por E-mail + SMS
            // Primeiro criamos o notificador base (Email)
            // Depois o "embrulhamos" com o decorator de SMS
            INotifier emailNotifierBaseForSms = new EmailNotifier();
            INotifier emailAndSmsNotifier = new SMSNotifierDecorator(emailNotifierBaseForSms);
            Console.WriteLine("--- Notificação por Email + SMS ---");
            Console.WriteLine(emailAndSmsNotifier.Send("Alerta Importante!"));
            Console.WriteLine();

            // Notificação por E-mail + SMS + Slack
            // Construímos a cadeia de decorators:
            // 1. Objeto base: EmailNotifier
            // 2. Embrulha com SMS: SMSNotifierDecorator(EmailNotifier)
            // 3. Embrulha com Slack: SlackNotifierDecorator(SMSNotifierDecorator(EmailNotifier))
            INotifier emailNotifierBaseForFull = new EmailNotifier();
            INotifier smsAndEmailNotifier = new SMSNotifierDecorator(emailNotifierBaseForFull);
            INotifier fullNotifier = new SlackNotifierDecorator(smsAndEmailNotifier);
            Console.WriteLine("--- Notificação por Email + SMS + Slack ---");
            Console.WriteLine(fullNotifier.Send("Lançamento da Nova Funcionalidade!"));
            Console.WriteLine();

            // Alternativamente, de forma mais aninhada na declaração:
            INotifier fullNotifierNested = new SlackNotifierDecorator(
                                               new SMSNotifierDecorator(
                                                   new EmailNotifier()
                                               )
                                           );
            Console.WriteLine("--- (Alternativo) Notificação por Email + SMS + Slack ---");
            Console.WriteLine(fullNotifierNested.Send("Lançamento da Nova Funcionalidade Aninhado!"));
            Console.WriteLine();


            // Apenas E-mail + Slack (sem SMS no meio)
            INotifier emailNotifierBaseForSlack = new EmailNotifier();
            INotifier emailAndSlackNotifier = new SlackNotifierDecorator(emailNotifierBaseForSlack);
            Console.WriteLine("--- Notificação por Email + Slack ---");
            Console.WriteLine(emailAndSlackNotifier.Send("Reunião de Equipe Amanhã."));
            Console.WriteLine();
        }
    }
}