class VehicleBuilder : IBuilder
{
    private Vehicle vehicle = new Vehicle();
    private Engine engine;
    private Transmission transmission;
    private int seats;
    private VehicleType vehicleType;
    public Vehicle GetVehicle()
    {
        Vehicle result = vehicle;
        Reset();
        return result;
    }
    public void Reset(){
        vehicle = new Vehicle();
    }
    public void SetEngine(Engine engine){
        this.engine = engine;
    }
    public void SetTransmission(Transmission transmission){
        this.transmission = transmission;
    }
    public void SetSeats(int seats){
        this.seats = seats;
    }
    public void SetVehicleType(VehicleType vehicleType){
        this.vehicleType = vehicleType;
    }
}