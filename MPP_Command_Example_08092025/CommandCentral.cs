// ----------------- INVOKER -----------------
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

public class CommandCentral
{
    private Queue<ICommand> history = new Queue<ICommand>();
    public bool Revert;
    public void PressingButton(ICommand command)
    {
        bool success = command.Run();

        if (success)
        {
            if (history.Count >= 5) history.Dequeue();
            history.Enqueue(command);          
        }
        var recentCommand = command;
        if (history.Count == 5)
        {
            recentCommand = command;
        }
        Revert = recentCommand.Desfazer();
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
        Console.WriteLine($"Luz e Porta: " + Revert + "Porta: " + Revert);
    }
}