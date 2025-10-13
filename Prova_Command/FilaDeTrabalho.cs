//Invoker
using System.Windows.Input;

public class FilaDeTrabalho
{
    private Stack<IComando> history = new Stack<IComando>();
    public void FazerPedido(IComando comando)
    {
        if (comando.Pedir())
        {
            if (history.Count >= 5)
            {
                var temp = history.Reverse().Take(4).Reverse().ToList();
                history = new Stack<IComando>(temp);
            }
            history.Push(comando);
        }
    }
    public void MostrarHistorico()
    {
        Console.WriteLine("\n📜 Histórico dos últimos comandos:");
        foreach (var cmd in history)
        {
            Console.WriteLine($" - {cmd.GetType().Name}");
        }
    }
    public void DesfazerUltimo()
    {
        var ultimo = history.Pop();
        ultimo.Desfazer();
        Console.WriteLine($"Desfez: {ultimo.GetType().Name}");
        MostrarHistorico();
    }
}
