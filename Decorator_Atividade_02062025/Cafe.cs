public class Cafe : IBebida
{
    public string GetDescricao()
    {
        return "Café";
    }

    public double GetCusto()
    {
        return 2.00;
    }
}