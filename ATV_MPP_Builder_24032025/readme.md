class Engine {
 private int power;
 public int Power {
 get => power;
 set => power = value;
 }
 public Engine(int power)
 {
 this.Power = power;
 }
}
enum Transmission {
 MANUAL,
 AUTOMATIC,
 AUTOMATIC_SEQUENTIAL
}
enum VehicleType {
 SEDAN,
 SPORTCAR,
 PICKUPTRUCK,
 TRUCK
}
Modelagem de Padrões de Projeto
 interface IBuilder
 {
 void Reset();
 Vehicle GetVehicle();
 void SetSeats(int seats);
 void SetEngine(Engine engine);
 void SetTransmission(Transmission transmission);
 void SetVehicleType(VehicleType vehicleType);
 
 }
}
