// ----------------- MACRO COMMAND -----------------
public class MacroCommand : ICommand
{
    private List<ICommand> commands;
    public MacroCommand(List<ICommand> lista) => commands = lista;

    public bool Run()
    {
        bool success = true;
        foreach (var cmd in commands)
        {
            success &= cmd.Run();
        }
        return success;
    }
}
