public class Spreedsheet {
    public void Enviar(Funcionario f, decimal salario){
        Console.WriteLine("=============================================");
        Console.WriteLine($"Nome: {f.Nome}");
        Console.WriteLine($"Tipo: {f.Cargo}");
        Console.WriteLine($"Salário calculado:  R$ {salario}");
        Console.WriteLine("==============================================");
    }                                                                                                                                                                                                                                                                                 
}
