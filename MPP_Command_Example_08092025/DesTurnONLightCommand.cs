public class DesTurnONLightCommand : ICommand
{
    private Light Light;
    public DesTurnONLightCommand(Light l) => Light = l;
    public bool Run()
    {
        Light.DesTurnON();
        return true;
    }
    public bool Desfazer()
    {
        Light.TurnON();
        return true;
    }
}


