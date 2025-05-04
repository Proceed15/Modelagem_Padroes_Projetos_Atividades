public class Funcionario
{
    public string Nome { get; set; }
    public bigint Remuneracao { get; set; }
    public string Cargo { get; set; }

    public Funcionario(string nome, bigint remuneracao, string Cargo){
        this.Nome = nome;
        this.Remuneracao = remuneracao;
        this.Cargo = cargo;
    }
}