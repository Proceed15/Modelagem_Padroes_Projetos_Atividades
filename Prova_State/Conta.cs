using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Conta
{
    public IEstadoDeUmaConta EstadoAtual { get; private set; }

    public Conta()
    {
        EstadoAtual = new Positivo();
        Console.WriteLine("Nova conta criada... Estado inicial: Positivo");
    }
    public void MudarEstado(IEstadoDeUmaConta novoEstado)
    {
        EstadoAtual = novoEstado;
    }
    public void Positivada() => EstadoAtual.Positivada(this);
    public void Negativada() => EstadoAtual.Negativada(this);
}
