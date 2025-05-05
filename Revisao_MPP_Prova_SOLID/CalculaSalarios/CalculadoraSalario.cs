public class CalculadoraSalario
{
    public decimal Calcular(Funcionario f)
    {
        switch (f.Cargo)
        {
            case "CLT":
              return f.Remuneracao + f.Bonus;

            case "Estagiario":
              return f.Remuneracao; //Bolsa Estágio

            case "Terceirizado":
              return f.VHora * f.EfetivacaoEmHoras;

              default:
                throw new Exception("Nenhum Funcionário com esse tipo de cargo");
        }
    }
}
