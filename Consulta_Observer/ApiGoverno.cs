// Observador Concreto 3: Envia para uma API externa
public class ApiGoverno : IAcaoAposGerarNota
{
    public void Executa(NotaFiscal nf)
    {
        Console.WriteLine($"API: Nota fiscal enviada para a API do governo.");
    }
}

