using System;

// Observador Concreto 1: Envia a nota por e-mail
public class EnviadorDeEmail : IAcaoAposGerarNota
{
    public void Executa(NotaFiscal nf)
    {
        Console.WriteLine($"EMAIL: Nota fiscal para {nf.RazaoSocial} enviada por e-mail.");
    }
}



