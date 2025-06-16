public class Organizacao : HoraTrabalhada
{
    public string Nome { get; set; }

    private List<HoraTrabalhada> Componentes { get; set; }
 
    public Organizacao(string nome)
    {
        Nome = nome;
        Componentes = new List<HoraTrabalhada>();
    }
 
    public override void Add(HoraTrabalhada componente)
    {
        Componentes.Add(componente);
    }
 
    public override void Remove(HoraTrabalhada componente)
    {
        Componentes.Remove(componente);
    }
 
    public override int GetHoraTrabalhada()
    {
        int totalHoras = 0;

        foreach (var componente in Componentes)
        {
            totalHoras += componente.GetHoraTrabalhada();
        }
        return totalHoras;
    }
}