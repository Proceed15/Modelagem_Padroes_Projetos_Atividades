public class Pedido : IComando
{
    private List<IComando> comandos;

    public Pedido(List<IComando> lista) => comandos = lista;


    public bool Pedir()
    {
        bool sucesso = true;
        foreach (var cmd in comandos)
        {
            sucesso &= cmd.Pedir();
        }
        return sucesso;
    }
    public bool Desfazer()
    {
        bool sucesso = true;
        for (int i = comandos.Count - 1; i >= 0; i--)
            sucesso &= comandos[i].Desfazer();
        return sucesso;    
    }
}