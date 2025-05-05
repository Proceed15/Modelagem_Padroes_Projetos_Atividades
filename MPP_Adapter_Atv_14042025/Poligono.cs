using System.Data;
public abstract class Poligono
{
    //Método que foi utilizado o Adapter para retornar o valor de CalculaArea em HexagonoEstrangeiro
    public abstract double getArea();
    //Com abstract e override substitui os nomes na vez que forem necessários
    public abstract string getName();
}
