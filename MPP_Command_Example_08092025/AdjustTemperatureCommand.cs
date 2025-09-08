public class AdjustTemperatureCommand : ICommand
{
    private Termostate Termostate;
    private double temp;
    public AdjustTemperatureCommand(Termostate t, double temp) { Termostate = t; this.temp = temp; }
    public bool Run() { Termostate.AdjustTemperature(temp); return true; }
}
