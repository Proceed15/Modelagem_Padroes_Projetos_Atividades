using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

public class Soldier
{
    public required string Name;
    public required string Weapon;
    public required Accessory Accessory;

    //Com ShallowCopy altera todos os clones ao mudar um
    public Soldier ShallowCopy()
    {
        return(Soldier)MemberwiseClone();
    }
    //Com DeepCopy alterar um clone não muda os outros clones
    public Soldier DeepCopy()
    {
        Soldier other = (Soldier)MemberwiseClone();
        other.Accessory = new Accessory(Accessory.Name);
        return other;
    }
}