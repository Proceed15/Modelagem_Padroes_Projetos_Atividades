public class OpenDoorCommand : ICommand
{
    private Door Door;
    public OpenDoorCommand(Door p) => Door = p;
    public bool Run() => Door.open();
    public bool Desfazer() => Door.CloseDoor();
}
