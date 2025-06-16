public class Funcionario : HoraTrabalhada
{
    public int Id { get; set; }
    public string Nome { get; set; }

    public int HorasTrabalhadas { get; set; }
 
    public Funcionario(int id, string nome, int horasTrabalhadas)
    {
        Id = id;
        Nome = nome;
        HorasTrabalhadas = horasTrabalhadas;
    }
 
    public override int GetHoraTrabalhada()
    {
        return HorasTrabalhadas;
    }
}