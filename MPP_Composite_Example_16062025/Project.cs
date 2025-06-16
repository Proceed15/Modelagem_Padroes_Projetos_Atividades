public class Project : IProjectComponent
{
    public string Nome { get; set; }
    private List<IProjectComponent> componentes = new List<IProjectComponent>();
    public Project(string nome)
    {
        Nome = nome;
    }
    public void Adicionar(IProjectComponent componente)
    {
        componentes.Add(componente);
    }
    public void Exibir(int nivel = 0)
    {
        Console.WriteLine(new string(' ', nivel * 2) + "+ Projeto: " + Nome);
        foreach (var componente in componentes)
        {
            componente.Exibir(nivel + 1);
        }
    }
}