// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;


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
