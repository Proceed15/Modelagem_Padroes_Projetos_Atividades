// ----------------- INVOKER -----------------
public class CommandCentral
{
    private Queue<ICommand> history = new Queue<ICommand>();

    public void PressingButton(ICommand command)
    {
        bool success = command.Run();
        if (success)
        {
            if (history.Count >= 5) history.Dequeue();
            history.Enqueue(command);
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
    class UndoLast()
    {
        
    }
}