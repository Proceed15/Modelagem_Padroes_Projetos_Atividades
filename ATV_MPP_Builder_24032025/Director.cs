class Director
{
    IBuilder builder;
 
    public Director(IBuilder builder)
    {
        this.builder = builder;
    }
    public void CarBuilder(){
        builder.SetTransmission(Transmission.AUTOMATIC);
        builder.SetEngine(new Engine(500));
        builder.SetSeats(4);
        builder.SetVehicleType(VehicleType.SEDAN);
    }
}