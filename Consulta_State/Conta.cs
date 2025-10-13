// --- A CLASSE DE CONTEXTO ---
// Esta classe gerencia o estado atual e delega as ações para o objeto de estado.
// O objetivo principal do padrão State é remover a lógica de transição de estado
// (os "if/else" baseados no estado) de dentro desta classe.
public class Conta
{
    // Propriedade para armazenar o objeto de estado atual.
    // O comportamento da conta dependerá inteiramente de qual objeto está aqui.
    public IEstadoDeUmaConta Estado { get; set; }

    public double Saldo { get; set; }

    public Conta(double saldoInicial)
    {
        Saldo = saldoInicial;
        // Ao criar a conta, definimos o estado inicial com base no saldo.
        if (Saldo >= 0)
        {
            Estado = new Positivo();
        }
        else
        {
            Estado = new Negativo();
        }
    }

    // A mágica do padrão: A classe Conta não sabe COMO sacar.
    // Ela simplesmente pede ao seu estado atual para executar a operação.
    public void Saca(double valor)
    {
        Estado.Saca(this, valor);
    }

    // O mesmo para o depósito. A responsabilidade é totalmente delegada.
    public void Deposita(double valor)
    {
        Estado.Deposita(this, valor);
    }
}
