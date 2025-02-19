public class SOLID_OCP_ATV_Veiculo 
{ 
private string cor; 
private int ano, assentos, porta; 
private double motor; 
//
public Veiculo (string cor, int ano, double motor, int assentos, int portas) { 
this.cor cor; 
this.ano ano; 
this.motor = motor; 
this.porta portas; 
this.assentos = assentos; 
} 
///
public void CriaCarro() { 
Console.WriteLine("Criando um carro {cor}, {ano}, {motor}, {portas} portas e {seats) assentos"); 
LigaCarro(); 
} 
///
public void CriaMoto() { 
Console.WriteLine("Criando um carro {cor}, {ano}, {motor} cilindradas"); 
LigaCarro(); 
} 
//
public void LigaCarro() { 
Console.WriteLine("Ligando os motores"); }
}