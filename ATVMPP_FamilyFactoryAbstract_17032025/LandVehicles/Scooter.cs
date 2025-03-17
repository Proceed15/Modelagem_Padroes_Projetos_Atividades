class Scooter : ILandVehicle
{
    public void CheckTransit() {
        Console.WriteLine("Veículos a 33km, veículos ok!");
    }
    public void GetCargo() {
        Console.WriteLine("Passageiros a bordo, trajeto autorizado.");
    }
    public void StartRoute() {
        GetCargo();
        CheckTransit();
        Console.WriteLine("Iniciando o Trajeto.");
    }
}