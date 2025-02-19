// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//Como refatorar os programas abaixo, seguindo os princípios SOLID:

//Atv1 1) Single Responsability Principle
class program
{ 
//
static void Main(string[] args) { } 
//
static void CreateClient(){ } 
//
static void ReadClient() { } 
//
static void UpdateClient(){ } 
//
static void DeleteClient() { } 
//
static void NotifyClient() { 
// Envia e-mail / SMS 
} 
}

//Atv2 2) Aplicar Open Closed Principle
/*
public class Veiculo 
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
*/

//Atv3 3) Aplicar Liskov Substitucion Principle
//Precisa de mais uma classe: Nubank Rewards, que fará a atualização da pontuação do cliente.
/*
public interface IInstrumento Pagamento 
{ 
//
void Validacao(); 
//
void ColetarPagamento(); 
} 
abstract public class NubankCard IInstrumentoPagamento 
{ 
//
public void ColetarPagamento() { 
Console.WriteLine("Pagamento Realizado"); } 
//
public virtual void Validacao() { 
//validação básica do cartão 
} 
} 
public class CreditCard: Nubank Card { 
//
public override void Validacao() { 
Console.WriteLine("Validando limite..."); 
Console.WriteLine("Limite OK"); } 
} 
public class DebitCard: NubankCard { 
//
public override void Validacao() { 
Console.WriteLine("Verificando Saldo..."); 
Console.WriteLine("Saldo disponível"); 
} 
}
*/
//Atv4 4) Aplicar Interface Segregation Principle
/*
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
*/