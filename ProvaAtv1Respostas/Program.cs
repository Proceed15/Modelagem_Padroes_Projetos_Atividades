// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//Versão Nova
using System;

class Program
{
    static void Main()
    {
        Director director = new Director();
        NotificationBuilder builder = new NotificationBuilder();

        director.NotificationNormalb(builder);
        Notification NormalFi = builder.GetNotification();
        Console.WriteLine(NormalFi);

        director.NotificationCompleteb(builder);
        Notification CompleteFi = builder.GetNotification();
        Console.WriteLine(CompleteFi);
    }
}
