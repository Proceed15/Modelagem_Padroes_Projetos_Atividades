class Level2Support : Handler
{
    public override void Handle(string request)
    {
        if (request == "internet")
        {
           Console.WriteLine($"Requisição {request} Resolvida por Handler 2");
        }
        else if (next != null)
        {
            next.Handle(request);
        }
        else
        {
            Console.WriteLine($"A Requisição \"{request}\": Chegou ao fim da cadeia sem solução.");
        }
    }
}