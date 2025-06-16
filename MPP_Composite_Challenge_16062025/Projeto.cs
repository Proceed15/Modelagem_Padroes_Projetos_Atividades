public class Projeto : IProjetoComponente
{
    public string Nome { get; set; }
    private List<IProjetoComponente> componentes = new List<IProjetoComponente>();
    public Projeto(string nome)
    {
        Nome = nome;
    }
    public void Adicionar(IProjetoComponente componente)
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
    public int ContarTarefas(int tarefas = 0)
    {
        int TotalTarefas = 0;
        foreach (var componente in componentes)
        {
            TotalTarefas += componente.ContarTarefas();
            //Chamada Recursiva
        }
        return TotalTarefas;
    }
}
 
 