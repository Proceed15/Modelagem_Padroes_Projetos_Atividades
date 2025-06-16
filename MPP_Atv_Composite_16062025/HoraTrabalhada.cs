public abstract class HoraTrabalhada
{
    public abstract int GetHoraTrabalhada();
 
    public virtual void Add(HoraTrabalhada componente)
    {
        throw new NotSupportedException("Não é possível adicionar componentes a esta classe.");
    }
    public virtual void Remove(HoraTrabalhada componente)
    {
        throw new NotSupportedException("Não é possível remover componentes desta classe.");
    }
}