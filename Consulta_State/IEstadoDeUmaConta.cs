// --- A INTERFACE STATE ---
// Define um contrato para todos os estados concretos.
// Qualquer estado de uma conta (Positivo, Negativo, etc.) deve saber como
// lidar com um saque e um depósito.
//
// Note que os métodos recebem a própria 'Conta' (o Contexto) como parâmetro.
// Isso é CRUCIAL para que um estado possa alterar o estado da conta.
// Por exemplo, um depósito em uma conta negativa pode torná-la positiva.
public interface IEstadoDeUmaConta
{
    void Saca(Conta conta, double valor);
    void Deposita(Conta conta, double valor);
}