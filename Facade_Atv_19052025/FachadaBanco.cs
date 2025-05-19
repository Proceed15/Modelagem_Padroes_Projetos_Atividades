public class FachadaBanco
{
    private Login login;
    private Gerenciamento gerenciamento;
    public FachadaBanco()
    {
        login = new Login();
        gerenciamento = new Gerenciamento();
    }
    public void addUsuario(Usuario u)
    {
        login.addUsuario(u);
    }
    public void deposito(long matricula, double valor)
    {
        Usuario usuario = login.localizarUsuario(matricula);
        if (usuario != null)
        {
            gerenciamento.deposito(usuario, valor);
        }
        else
        {
            Console.WriteLine("Usuário não encontrado.");
        }
    }
    public void saque(long matricula, double valor)
    {
        Usuario usuario = login.localizarUsuario(matricula);
        if (usuario != null)
        {
            gerenciamento.saque(usuario, valor);
        }
        else
        {
            Console.WriteLine("\nUsuário não encontrado.");
            Console.WriteLine("Conta não encontrada para realizar o saque.");
            Console.WriteLine("Valor inválido para saque.");
            Console.WriteLine("Conta não encontrada para realizar o depósito.");
            Console.WriteLine("Valor inválido para depósito.");
            Console.WriteLine("Operação Concluída para Tal Usuário com Sucesso");
        }
    }
}