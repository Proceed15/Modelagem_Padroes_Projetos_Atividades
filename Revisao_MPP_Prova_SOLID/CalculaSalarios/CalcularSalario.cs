public class CalcularSalario {
    public bigint Remuneracao { get; set; }
    public string Cargo { get; set; }
    public Funcionario Funcionario { get; set; }

    public CalcularSalario (bigint Remuneracao, string Cargo, Funcionario Funcionario){
        this.Remuneracao = Remuneracao;
        this.Cargo = Cargo;
        this.Funcionario = Funcionario;
    }
}