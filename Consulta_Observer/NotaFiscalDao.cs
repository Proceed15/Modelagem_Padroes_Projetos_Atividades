// Observador Concreto 2: Salva a nota no banco de dados
public class NotaFiscalDao : IAcaoAposGerarNota
{
    public void Executa(NotaFiscal nf)
    {
        Console.WriteLine($"BANCO: Nota fiscal de {nf.ValorBruto:C} salva no banco de dados.");
    }
}

