public class Door
{
    private bool Open = false;
    private static Random rnd = new Random();

    public bool open()
    {
        if (rnd.NextDouble() < 0.1)
        {
            Console.WriteLine("🚪 Falha ao abrir a Porta!");
            return false;
        }
        Open = true;
        Console.WriteLine("🚪 Porta Aberta.");
        return true;
    }

    public bool CloseDoor()
    {
        if (rnd.NextDouble() < 0.1)
        {
            Console.WriteLine("🚪 Falha ao fechar a Porta!");
            return false;
        }
        Open = false;
        Console.WriteLine("🚪 Porta fechada.");
        return true;
    }

    public void Status()
    {
        Console.WriteLine($"🚪 Porta está {(Open ? "Open" : "fechada")}.");
    }
}





