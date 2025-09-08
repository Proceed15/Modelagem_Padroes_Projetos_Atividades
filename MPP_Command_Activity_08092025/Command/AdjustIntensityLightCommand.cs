public class AdjustIntensityLightCommand : ICommand
{
    private Light Light;
    private int valor;
    public AdjustIntensityLightCommand(Light l, int v) { Light = l; valor = v; }
    public bool Run()
    {
        Light.AdjustIntensity(valor);
        return true;
    }
    public bool Desfazer()
    {
        Light.AdjustIntensity(12);
        return true;
    }
}
