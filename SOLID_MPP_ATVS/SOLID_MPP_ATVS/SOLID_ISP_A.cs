using System;

namespace SOLID_MPP_ATVS
{
    internal class SOLID_ISP_A
    {
        public interface IVeiculo
        {
            void LigaVeiculo();
        }

        public interface ICarro : IVeiculo
        {
            void ConfigureCarro(string cor, int ano, float motor, int assentos, int portas);
        }

        public interface IMoto : IVeiculo
        {
            void ConfigureMoto(string cor, int ano, float motor);
        }

        public class Carro : ICarro
        {
            private string cor;
            private int ano, assentos, portas;
            private float motor;

            public Carro(string cor, int ano, float motor, int assentos, int portas)
            {
                ConfigureCarro(cor, ano, motor, assentos, portas);
            }

            public void ConfigureCarro(string cor, int ano, float motor, int assentos, int portas)
            {
                this.cor = cor;
                this.ano = ano;
                this.motor = motor;
                this.assentos = assentos;
                this.portas = portas;

                Console.WriteLine($"Criando carro: ano {ano}, cor {cor}, Motor {motor}");
                LigaVeiculo();
            }

            public void LigaVeiculo()
            {
                Console.WriteLine("Ligando o Carro");
            }
        }

        public class Moto : IMoto
        {
            private string cor;
            private int ano;
            private float motor;

            public Moto(string cor, int ano, float motor)
            {
                ConfigureMoto(cor, ano, motor);
            }

            public void ConfigureMoto(string cor, int ano, float motor)
            {
                this.cor = cor;
                this.ano = ano;
                this.motor = motor;

                Console.WriteLine($"Criando moto: ano {ano}, cor {cor}, {motor} cilindradas");
                LigaVeiculo();
            }

            public void LigaVeiculo()
            {
                Console.WriteLine("Ligando a Moto");
            }
        }

        public static void RetornaISP()
        {
            ICarro carro = new Carro("Vermelho", 2022, 2.0f, 5, 4);
            IMoto moto = new Moto("Preta", 2023, 1.2f);
        }
    }
}

