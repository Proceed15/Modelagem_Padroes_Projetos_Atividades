// 3. O Contexto (Context)
// Mantém uma referência a um objeto de Estratégia e delega o trabalho para ele.
public class Context
{
    // O Contexto mantém uma referência a uma das estratégias.
    // Ele não conhece a classe concreta da estratégia.
    private IStrategy _strategy;

    // O construtor não precisa de uma estratégia inicial.
    // Ela será definida pelo Cliente.
    public Context()
    { }

    // O Contexto permite que o Cliente troque a estratégia em tempo de execução.
    public void SetStrategy(IStrategy strategy)
    {
        this._strategy = strategy;
    }

    // O Contexto delega o trabalho para o objeto de Estratégia.
    public int ExecuteStrategy(int a, int b)
    {
        if (_strategy == null)
        {
            throw new InvalidOperationException("Estratégia não foi definida. Use SetStrategy().");
        }
        return _strategy.Execute(a, b);
    }
}