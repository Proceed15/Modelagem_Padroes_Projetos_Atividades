public abstract class EnviadorDeEmail : IAcaoAposGerarNota
{
    protected string Email;
    public EnviadorDeEmail(string email)
    {
        Email = email;
    }
    public abstract void CriarNotaFiscal(string mensagem);
    public abstract void RegistrarAcao(IAcaoAposGerarNota acao);
    public abstract void Remover(IAcaoAposGerarNota acao);
    public abstract void EmitirNotaFiscal();
}