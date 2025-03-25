Project("{FAE04EC0-301F-11D3-BF4B-00C04F79EFBC}") = "ATV_MPP_Builder_24032025", "ATV_MPP_Builder_24032025\ATV_MPP_Builder_24032025.csproj", "{F3C21FC5-AD52-4881-9FB2-2F397FCBB007}"
EndProject

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
