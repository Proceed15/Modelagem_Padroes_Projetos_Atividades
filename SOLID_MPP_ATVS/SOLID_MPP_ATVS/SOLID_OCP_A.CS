using System;
using static SOLID_MPP_ATVS.SOLID_LSP_A;

namespace SOLID_MPP_ATVS
{
    internal class SOLID_OCP_A
    {
        public abstract class Veiculo
        {
            protected string Cor { get; }
            protected int Ano { get; }
            protected double Motor { get; }

            protected Veiculo(string cor, int ano, double motor)
            {
                Cor = cor;
                Ano = ano;
                Motor = motor;
            }

            public abstract void Criar();

            public virtual void Ligar()
            {
                Console.WriteLine("Ligando os motores");
            }
        }

        public class Carro : Veiculo
        {
            private int Assentos { get; }
            private int Portas { get; }

            public Carro(string cor, int ano, double motor, int assentos, int portas)
                : base(cor, ano, motor)
            {
                Assentos = assentos;
                Portas = portas;
            }

            public override void Criar()
            {
                Console.WriteLine($"Criando um carro {Cor}, {Ano}, {Motor} cilindradas, {Portas} portas e {Assentos} assentos");
                Ligar();
            }
        }

        public class Moto : Veiculo
        {
            public Moto(string cor, int ano, double motor)
                : base(cor, ano, motor)
            {
            }

            public override void Criar()
            {
                Console.WriteLine($"Criando uma moto {Cor}, {Ano}, {Motor} cilindradas");
                Ligar();
            }
        }
        public static void RetornaOCP()
        {
            Veiculo carro = new Carro("Amarelo", 2015, 4.0, 5, 9);
            carro.Criar();

            Veiculo moto = new Moto("Rosa", 2021, 260);
            moto.Criar();
        }

    }

}
