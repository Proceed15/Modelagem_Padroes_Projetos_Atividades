public class ApiGoverno : IAcaoAposGerarNota
{
    private string CNPJ = "999.999.999/0001+99";

    public void CriarNotaFiscal(string mensagem)
    {
        Console.WriteLine($"Enviando nota fiscal para o governo. CNPJ: {CNPJ} - {mensagem}");
    }
    public void EmitirNotaFiscal()
    {
        Console.WriteLine("ApiGoverno: Emitindo nota fiscal para o governo...");
    }
    public void RegistrarAcao(IAcaoAposGerarNota acao)
    {
        Console.WriteLine("ApiGoverno: Registrando ação, Nota Fiscal Criada...");
    }
    public void Remover(IAcaoAposGerarNota acao)
    {
        Console.WriteLine("ApiGoverno: Removendo ação, Nota Fiscal Concluída...");
    }
}