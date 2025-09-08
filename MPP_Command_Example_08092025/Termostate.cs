//Termostate
public class Termostate
{
    private double Temperature = 22.0;

    public void AdjustTemperature(double t)
    {
        Temperature = t;
        Console.WriteLine($"🌡️ Temperatura ajustada para {Temperature}°C.");
    }

    public void Status()
    {
        Console.WriteLine($"🌡️ Temperatura atual: {Temperature}°C.");
    }
}

