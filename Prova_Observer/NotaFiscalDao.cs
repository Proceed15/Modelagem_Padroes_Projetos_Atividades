public class NotaFiscalDao : IAcaoAposGerarNota
{
    public void CriarNotaFiscal(string mensagem)
    {
        Console.WriteLine("NotaFiscalDao: Criando nota fiscal com a mensagem: " + mensagem);
    }

    public void EmitirNotaFiscal()
    {
        Console.WriteLine("NotaFiscalDao: Emitindo nota fiscal...");
    }

    public void RegistrarAcao(IAcaoAposGerarNota acao)
    {
        // Implementação vazia, pois não faz sentido registrar ações em um DAO
    }

    public void Remover(IAcaoAposGerarNota acao)
    {
        // Implementação vazia, pois não faz sentido remover ações em um DAO
    }
}