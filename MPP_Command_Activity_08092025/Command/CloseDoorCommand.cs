public class CloseDoorCommand : ICommand
{
    private Door Door;
    public CloseDoorCommand(Door p) => Door = p;
    public bool Run() => Door.CloseDoor();
}
