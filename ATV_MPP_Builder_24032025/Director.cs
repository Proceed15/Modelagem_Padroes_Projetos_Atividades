class Director
{
    public void ConstructSedanCar(IBuilder builder)
    {
        builder.Reset();
        builder.SetVehicleType(VehicleType.SEDAN);
        builder.SetSeats(5);
        builder.SetEngine(new Engine(1.6));
        builder.SetTransmission(Transmission.AUTOMATIC);
    }

    public void ConstructTruck(IBuilder builder)
    {
        builder.Reset();
        builder.SetVehicleType(VehicleType.TRUCK);
        builder.SetSeats(2);
        builder.SetEngine(new Engine(5.0));
        builder.SetTransmission(Transmission.MANUAL);
    }

    public void ConstructSUV(IBuilder builder)
    {
        builder.Reset();
        builder.SetVehicleType(VehicleType.SUV);
        builder.SetSeats(5);
        builder.SetEngine(new Engine(2.6));
        builder.SetTransmission(Transmission.AUTOMATIC_SEQUENTIAL);
        (builder as CarBuilder)?.SetAirbag(true);
    }
}
/*class Director
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
    public void TruckBuilder(){
        builder.SetTransmission(Transmission.AUTOMATIC_SEQUENTIAL);
        builder.SetEngine(new Engine(800));
        builder.SetSeats(3);
        builder.SetVehicleType(VehicleType.TRUCK);
    }
    public void SportsCarBuilder(){
        builder.SetTransmission(Transmission.AUTOMATIC);
        builder.SetEngine(new Engine(600));
        builder.SetSeats(2);
        builder.SetVehicleType(VehicleType.SPORTCAR);
    }
    public void SedanCarBuilder(){
        builder.SetTransmission(Transmission.MANUAL);
        builder.SetEngine(new Engine(600));
        builder.SetSeats(5);
        builder.SetVehicleType(VehicleType.SEDAN);
    }
    public void SUVBuilder(){
        builder.SetTransmission(Transmission.AUTOMATIC_SEQUENTIAL);
        builder.SetEngine(new Engine(600));
        builder.SetSeats(5);
        builder.SetVehicleType(VehicleType.SUV);
    }
}*/
