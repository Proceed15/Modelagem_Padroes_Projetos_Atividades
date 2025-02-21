/*
public interface IInstrumento Pagamento { 

void Validacao(); 
//
void ColetarPagamento(); 
} 
abstract public class NubankCard IInstrumento Pagamento{ 
//
public void ColetarPagamento() { 
Console.WriteLine("Pagamento Realizado"); } 
//
public virtual void Validacao() { 
//validação básica do cartão 
} 
} 
public class CreditCard: NubankCard { 
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