interface ITransportFactory
{
IAircraft CreateTransportAircraft();
ILandVehicle CreateTransportVehicle();
}
class Application {
    private IAircraft aircraft;
    private ILandVehicle vehicle;
    private string rota;
    public Application(ITransportFactory factory, string rota)
    {
        this.rota = rota;
        if (rota == "terrestre")
            vehicle = factory.CreateTransportVehicle();
        else
            aircraft = factory.CreateTransportAircraft();
    }
    public void StartRoute() {
        if (rota == "terrestre")
            vehicle.StartRoute();
        else
            aircraft.StartRoute();
    }
}