interface IVeiculo 
{ 
// 10 estamos quebrando o principio da Singularidade: carro e moto na mesma Interface 
// 
void ConfigureCarro(string cor, int ano, float motor, int assentos, int portas); 
// 
void ConfigureMoto(string cor, int ano, float motor); 
//
void LigaVeiculo(); 
} 
public class Carro IVeiculo 
{ 
string cor;
int ano, assentos, portas; 
float motor; 
//
public Carro(string cor, int ano, float motor, int assentos, int portas) { 
ConfigureCarro(cor, ano, motor, assentos, portas); 
//
} 
public void ConfigureCarro (string cor, int ano, float motor, int assentos, int portas) 
this.cor cor; 
this.ano ano; 
this.motor motor; 
this.assentos = assentos; 
this.portas = portas; 
Console.WriteLine($"Criando carro: ano {ano} cor {cor} Motor {motor}"); 
LigaVeiculo(); 
//baixa coesão, código "sobrando" 
//
public void ConfigureMoto (string cor, int ano, float motor) { } 
//
public void LigaVeiculo() { 
Console.WriteLine("Ligando o Carro"); } 
public class Moto: IVeiculo { 
string cor; 
int ano; 
float motor; 
// 
public Moto(string cor, int ano, float motor) 
ConfigureMato(cor, ano, motor); } 
//
{ 
public void ConfigureCarro(string cor, int ano, float motor, int assentos, int portas) {} 
//
public void ConfigureMoto(string cor, int ano, float motor) { 
this.cor cor; 
this.ano ano; 
this.motor = motor; 
Console.WriteLine($"Criando moto: ano (ano) cor {cor) (motor) cilindradas"); 
LigaVeiculo(); 
//
public void LigaVeiculo() 
{ 
Console.WriteLine("Ligando a Moto"); }}