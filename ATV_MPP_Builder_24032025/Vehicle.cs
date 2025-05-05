/*class Vehicle {
   public void GetVehicle() {
      Console.WriteLine();
   }
}*/
class Vehicle
{
    public int Seats { get; set; }
    public Engine Engine { get; set; }
    public Transmission Transmission { get; set; }
    public VehicleType VehicleType { get; set; }
    public bool Airbag { get; set; } 

    public override string ToString()
    {
        return $"Tipo: {VehicleType}, Assentos: {Seats}, Motor: {Engine.Power}L, " +
               $"Transmissão: {Transmission}, Airbag: {Airbag}";
    }
}