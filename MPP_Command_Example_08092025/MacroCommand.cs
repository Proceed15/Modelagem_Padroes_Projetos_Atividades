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
    public bool Desfazer()
    {
        Light Light = new Light();
        Door Door = new Door();
        bool IsOpen = Door.Open;
        bool IsTurned = Light.TurnedON;
        if (IsTurned == false && IsOpen == false)
        {
            return IsTurned == true && IsOpen == true;
        }
        if (IsTurned == true && IsOpen == false)
        {
            return IsTurned == false && IsOpen == true;
        }
        if (IsTurned == false && IsOpen == true)
        {
            return IsTurned == true && IsOpen == false;
        }
        else
        {
            return IsTurned == false && IsOpen == false;
        }
    }
}
