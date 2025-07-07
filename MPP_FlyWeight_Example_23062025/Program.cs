// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        EmojiFactory fabrica = new EmojiFactory();

        EmojiType riso = fabrica.GetEmojiType("Riso", "Amarelo", "Feliz");
        EmojiType triste = fabrica.GetEmojiType("Triste", "Cinza", "Chorando");

        Emoji e1 = new Emoji(10, 20, riso);
        Emoji e2 = new Emoji(15, 25, riso);
        Emoji e3 = new Emoji(30, 40, triste);
        Emoji e4 = new Emoji(50, 60, riso);
        Emoji e5 = new Emoji(70, 80, triste);
        Emoji e6 = new Emoji(80, 90, riso);
        Emoji e7 = new Emoji(75, 85, riso);
        Emoji e8 = new Emoji(85, 95, riso);

        Console.WriteLine("Exibindo: ");
        e1.Mostrar();
        e2.Mostrar();
        e3.Mostrar();
        e4.Mostrar();
        e5.Mostrar();
        e6.Mostrar();
        e7.Mostrar();
        e8.Mostrar();


    }
}
