class LimeTransport : ITransportFactory {
    public IAircraft CreateTransportAircraft() {
        return new Airplane();
    }
    public ILandVehicle CreateTransportVehicle() {
        return new Car();
    }
}