// ----------------- RECEIVERS -----------------
//Light
public class Light
{
    public bool TurnedON = false;
    private int Intensity = 100;

    public void TurnON()
    {
        TurnedON = true;
        Console.WriteLine("💡 Luz Ligada.");
    }

    public void DesTurnON()
    {
        TurnedON = false;
        Console.WriteLine("💡 Luz desligada.");
    }

    public void AdjustIntensity(int valor)
    {
        Intensity = Math.Clamp(valor, 0, 100);
        Console.WriteLine($"💡 Intensidade ajustada para {Intensity}%.");
    }

    public void Status()
    {
        Console.WriteLine($"💡 Luz está {(TurnedON ? "Ligada" : "desligada")} configurada com a intensidade {Intensity}%.");
    }
}
