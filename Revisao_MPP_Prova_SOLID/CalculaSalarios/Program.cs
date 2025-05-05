// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;

namespace CalculaSalarios {
    public class Program
    {
        static void Main(string[] args){
            var Funcionario = new Funcionario{
                Nome = "Valéria",
                Cargo = "CLT",
                Remuneracao = 4555,
                Bonus = 555,
            };

            var calculadora = new CalculadoraSalario();
            var relatorio = new Spreedsheet();

            decimal salario = calculadora.Calcular(funcionario);
            relatorio.SpreedSheet(Funcionario, salario);
        }    
    }
}
