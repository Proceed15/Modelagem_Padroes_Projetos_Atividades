using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public interface IEstadoDeUmaConta
{
    void Positivada(Conta conta);
    void Negativada(Conta conta);

}