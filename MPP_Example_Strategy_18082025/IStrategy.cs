// 1. A Interface da Estratégia (Strategy Interface)
// Declara uma operação comum a todas as estratégias suportadas.
public interface IStrategy
{
    int Execute(int a, int b);
}