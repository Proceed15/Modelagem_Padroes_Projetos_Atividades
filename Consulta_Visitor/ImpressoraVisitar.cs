using System;

// --- VISITOR CONCRETO ---
// Implementa uma operação específica a ser realizada na estrutura de objetos.
// Neste caso, a operação é "imprimir a expressão de forma legível".
public class ImpressoraVisitor : IVisitor
{
    // Este método é chamado quando o visitor encontra um objeto 'Soma'.
    public void VisitaSoma(Soma soma)
    {
        Console.Write("(");
        // Pede para o filho da esquerda "aceitar" a visita, continuando o processo recursivamente.
        soma.Esquerda.Aceita(this);
        Console.Write(" + ");
        // O mesmo para o filho da direita.
        soma.Direita.Aceita(this);
        Console.Write(")");
    }

    public void VisitaSubtracao(Subtracao subtracao)
    {
        Console.Write("(");
        subtracao.Esquerda.Aceita(this);
        Console.Write(" - ");
        subtracao.Direita.Aceita(this);
        Console.Write(")");
    }

    // Este método é chamado quando o visitor encontra um objeto 'Numero'.
    // Como o número é uma "folha" da árvore, ele apenas imprime seu valor.
    public void VisitaNumero(Numero numero)
    {
        Console.Write(numero.Valor);
    }
}