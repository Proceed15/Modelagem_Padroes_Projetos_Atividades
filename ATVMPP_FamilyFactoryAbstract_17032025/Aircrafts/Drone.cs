class Drone : IAircraft
{
    public void CheckWind() {
        Console.WriteLine("Ventos a 25km, ventos ok!");
    }
    public void GetCargo() {
        Console.WriteLine("Dados Confidenciais a bordo, vôo autorizado.");
    }
    public void StartRoute() {
        GetCargo();
        CheckWind();
        Console.WriteLine("Iniciando a decolagem.");
    }
}