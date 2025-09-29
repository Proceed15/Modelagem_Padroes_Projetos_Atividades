// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;

abstract class Handler
{
    protected Handler next;

    public void SetNext(Handler nextHandler)
    {
        next = nextHandler;
    }

    public abstract void Handle(string request);
}

class Level1Support : Handler
{
    public override void Handle(string request)
    {
        if (request == "senha")
        {
              Console.WriteLine($"Requisição {request} Resolvida por Handler 1");
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

class Program
{
    static void Main()
    {
        // Monta a cadeia
        var l1 = new Level1Support();
        var l2 = new Level2Support();
        var l3 = new Level3Support();

        l1.SetNext(l2);
        l2.SetNext(l3);

        
        l1.Handle("senha");     
        l1.Handle("internet");  
        l1.Handle("servidor");  
        l1.Handle("outro");     
    }
}
