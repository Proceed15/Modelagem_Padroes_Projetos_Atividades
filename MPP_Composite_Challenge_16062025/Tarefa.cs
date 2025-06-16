using System.Security.Cryptography.X509Certificates;

public class Tarefa : IProjetoComponente
{
    public string Nome { get; set; }
    public Tarefa(string nome)
    {
        Nome = nome;
    }
    public void Exibir(int nivel = 0)
    {
        Console.WriteLine(new string(' ', nivel * 2) + "- Tarefa: " + Nome);

    }
    public int ContarTarefas(int tarefas = 0) {
        return 1;
    }
}