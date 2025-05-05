using System;

namespace SOLID_MPP_ATVS
{
    internal class SOLID_DIP_A {
    public static void Retorna_DIP(){
    //Tipo do Cálculo Aqui
    ICalculadoraSalario calculadora = new CalculadoraCLT(3355m, 5533m);
    ICalculadoraSalario calculadora1 = new CalculadoraFreelancer(55m, 161);

    var FolhaPagamento1 = new FolhaPagamento(calculadora);
    FolhaPagamento1.Processar();
    var FolhaPagamento3 = new FolhaPagamento(calculadora1);
    FolhaPagamento3.Processar();
    }

public interface ICalculadoraSalario
{
    decimal CalcularSalario();
}
public class CalculadoraCLT : ICalculadoraSalario {
   private decimal Salario;
   private decimal Bonus;
   public CalculadoraCLT(decimal salario, decimal bonus){
      Salario = salario;
      Bonus = bonus;
   }

   public decimal CalcularSalario(){
      return Salario + Bonus;
   }
}
public class CalculadoraFreelancer : ICalculadoraSalario{
    private decimal VHora;
    private int horas;

    public CalculadoraFreelancer(decimal VHora, int horas)
    {
        this.VHora = VHora;
        this.horas = horas;
    }

    public decimal CalcularSalario()
    {
        return VHora * horas;
    }
}

public class FolhaPagamento
{
    private readonly ICalculadoraSalario calculadora;

    public FolhaPagamento(ICalculadoraSalario calculadora){
        this.calculadora = calculadora;
    }

    public void Processar(){
        var Salario = calculadora.CalcularSalario();
        Console.WriteLine($"Salário Processado: R$ {Salario}");
    }
}
    }
}