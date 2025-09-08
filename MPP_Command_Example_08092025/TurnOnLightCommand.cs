// ----------------- CONCRETE COMMANDS -----------------
// TurnONLightCommand
public class TurnONLightCommand : ICommand
{
    private Light Light;
    public TurnONLightCommand(Light l) => Light = l;
    public bool Run()
    {
        Light.TurnON();
        return true;
    }
    public bool Desfazer() { 
        Light.DesTurnON(); 
        return true; 
    }
}

