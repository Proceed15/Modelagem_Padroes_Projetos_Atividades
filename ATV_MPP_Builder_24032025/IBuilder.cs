interface IBuilder {
    
    void Reset();
    Vehicle GetVehicle();
    void SetSeats(int seats);
    void SetEngine(Engine engine);
    void SetTransmission(Transmission transmission);
    void SetVehicleType(VehicleType vehicleType);
 
 }