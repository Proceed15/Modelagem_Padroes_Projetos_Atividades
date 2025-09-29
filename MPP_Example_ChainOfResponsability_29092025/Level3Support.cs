class Level3Support : Handler
{
    public override void Handle(string request)
    {
        if (request == "servidor")
        {
              Console.WriteLine($"Requisição {request} Resolvida por Handler 3");
        }
        else if (next != null)
        {
            next.Handle(request);
        }
        else
        {
            Console.WriteLine($"A Requisição \"{request}\" chegou ao fim da cadeia sem solução.");
        }
    }
}