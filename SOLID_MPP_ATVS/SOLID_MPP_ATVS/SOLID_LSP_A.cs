using System;

namespace SOLID_MPP_ATVS
{
    internal class SOLID_LSP_A
    {
        public interface IInstrumentoPagamento
        {
            void Validacao();
            void ColetarPagamento();
        }

        public abstract class NubankCard : IInstrumentoPagamento
        {
            public void ColetarPagamento()
            {
                Console.WriteLine("Pagamento Realizado");
            }

            public abstract void Validacao();
        }

        public class CreditCard : NubankCard
        {
            public override void Validacao()
            {
                Console.WriteLine("Validando limite...");
                Console.WriteLine("Limite OK");
            }
        }

        public class DebitCard : NubankCard
        {
            public override void Validacao()
            {
                Console.WriteLine("Verificando Saldo...");
                Console.WriteLine("Saldo Disponível");
            }
        }

        public class NubankRewards : NubankCard
        {
            private int NBR_pontos;

            public NubankRewards()
            {
                //
                NBR_pontos = 0;
            }

            public override void Validacao()
            {
                Console.WriteLine("Seu Cartão Nubank Rewards foi Validado com Sucesso!");
            }

            public void MaisPontos()
            {
                NBR_pontos++;
                //Adiciona 1 Ponto
                Console.WriteLine($"Pontos Acumulados: {NBR_pontos}");
            }
        }

        public static void RetornaLSP()
        {
            Console.WriteLine("\nOperação para o Cartão de Crédito:");
            NubankCard cartaoCredito = new CreditCard();
            cartaoCredito.Validacao();
            cartaoCredito.ColetarPagamento();

            Console.WriteLine("\nOperação para o Cartão de Débito:");
            NubankCard cartaoDebito = new DebitCard();
            cartaoDebito.Validacao();
            cartaoDebito.ColetarPagamento();

            Console.WriteLine("\nAdicionando Pontos para o NuBank Rewards!");

            NubankRewards rewardsCard = new NubankRewards();
            rewardsCard.Validacao();
            rewardsCard.ColetarPagamento();

            Console.WriteLine("\nAdicionando Pontos:");
            for (int i = 0; i < 6; i++) // O Contador vai até 6 Pontos como se fossem 6 Transferências
            {
                rewardsCard.MaisPontos();
            }
        }
    }
}

