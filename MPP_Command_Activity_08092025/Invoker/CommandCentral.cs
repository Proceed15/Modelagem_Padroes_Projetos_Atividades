// ----------------- INVOKER -----------------
public class CommandCentral
{
    private Stack<ICommand> history = new Queue<ICommand>();

    public void PressingButton(ICommand command)
    {
        if (command.Run())
        {
            if (history.Count >= 5)
            {
                var temp = history.Reverse().Take(4).Reverse().ToList();
                history = new Stack<ICommand>(temp);
            }
            history.Push(command);
        }
    }

    public void ShowHistory()
    {
        Console.WriteLine("\n📜 Histórico dos últimos commands:");
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
        ShowHistory();
    }
}
