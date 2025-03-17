// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
// Abstract Product Interface
public interface IBotao {
    void Render();
}
// Concrete Products
public class BotaoWindows : IBotao {
    public void Render() => Console.WriteLine("Renderizando um botão no Windows");
}

public class BotaoMac : IBotao {
    public void Render() => Console.WriteLine("Renderizando um botão no macOS");
}
// Abstract Factories 
public interface IFactory {
    IBotao CriarBotao();
}
// Concrete Factories
public class Windowsfactory : IFactory {
    public IBotao CriarBotao() => new BotaoWindows();
}
public class MacFactory : IFactory {
    public IBotao CriarBotao() => new BotaoMac();
}
//Cliente
class Program {
    static void Main() {
        IFactory factory = new Windowsfactory(); //Pode-se trocar para MacFactory
        IBotao botao = factory.CriarBotao();
        botao.Render();
    }
}