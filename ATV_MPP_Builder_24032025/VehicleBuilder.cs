/*class VehicleBuilder : IBuilder
{
    private Vehicle vehicle = new Vehicle();
    private Engine engine;
    private Transmission transmission;
    private int seats;
    private VehicleType vehicleType;
    bool airbag;
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
    public void SetAirbag(bool airbag)
    {
        this.airbag = airbag;
    }
}*/
class CarBuilder : IBuilder
{
    private Vehicle _vehicle;

    public CarBuilder()
    {
        Reset();
    }

    public void Reset()
    {
        _vehicle = new Vehicle();
    }

    public void SetSeats(int seats)
    {
        _vehicle.Seats = seats;
    }

    public void SetEngine(Engine engine)
    {
        _vehicle.Engine = engine;
    }

    public void SetTransmission(Transmission transmission)
    {
        _vehicle.Transmission = transmission;
    }

    public void SetVehicleType(VehicleType vehicleType)
    {
        _vehicle.VehicleType = vehicleType;
    }

    public void SetAirbag(bool airbag)
    {
        _vehicle.Airbag = airbag;
    }

    public Vehicle GetVehicle()
    {
        return _vehicle;
    }
}
