// Define o "contrato" para qualquer algoritmo de imposto.
// Qualquer classe que implemente esta interface PODE ser usada pela nossa calculadora.
public interface IImposto
{
    double Calcula(Orcamento orcamento);
}