public interface IAcaoAposGerarNota
{
    void RegistrarAcao(IAcaoAposGerarNota acao);
    void CriarNotaFiscal(string mensagem);
    void Remover(IAcaoAposGerarNota acao);
    void EmitirNotaFiscal();
}