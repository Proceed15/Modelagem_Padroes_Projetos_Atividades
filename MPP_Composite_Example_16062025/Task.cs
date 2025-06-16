public class Task : IProjectComponent
{
    public string Nome { get; set; }
    public Task(string nome)
    {
        Nome = nome;
    }
    public void Exibir(int nivel = 0)
    {
        Console.WriteLine(new string(' ', nivel * 2) + "- Tarefa: " + Nome);
    }
}