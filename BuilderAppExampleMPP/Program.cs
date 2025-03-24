// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
//Interface Builder
using System.Security.Cryptography.X509Certificates;

class Program {
interface AbstractCake {
    void setTamanho(String tamanho);
    void setQuantidade(int quantidade);
    void setCliente(Boolean temNome);
    Cake getResult();
}
// Implementação do Builder
class ACakeBuilder:AbstractCake {
    private Cake cake = new Cake();

    public void setTamanho(String tamanho) {cake.setTamanho(tamanho);}
    public void setQuantidade(int quantidade) {cake.setQuantidade(quantidade);}
    public void setCliente(Boolean temNome) {cake.setCliente(temNome);}
    public Cake getResult() {return cake;}
}
// Produto Final
class Cake {
    private String tamanho;
    private int quantidade;
    private Boolean temNome;

    public void setTamanho(String tamanho) {this.tamanho = tamanho;}
    public void setQuantidade(int quantidade) {this.quantidade = quantidade;}
    public void setCliente(Boolean temNome) {this.temNome = temNome;}

    public void debuginfo() {
        Console.WriteLine("Tamanho: " + tamanho + ", Quantidade: " + quantidade + ", nome do Cliente: " + temNome);
    }
}

//Sequência de Construção
//Confeiteiro
class Confeiteiro {
    public void fazerBoloNapolitano(AbstractCake builder){
        builder.setTamanho("Festa de Aniversário!");
        builder.setQuantidade(1);
        builder.setCliente(false);
    }
}
//Cliente
    static void Main(string[] args){
        Confeiteiro director = new Confeiteiro();
        ACakeBuilder builder = new ACakeBuilder();

        director.fazerBoloNapolitano(builder);
        Cake cake = builder.getResult();

        cake.debuginfo();
    }
}