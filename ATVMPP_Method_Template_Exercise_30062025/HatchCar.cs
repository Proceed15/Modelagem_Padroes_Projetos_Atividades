class HatchCar : Car
{
    public override void BuildCarBodyWork()
    {
        Console.WriteLine("Produzindo a carroceria do Hatch em dois volumes.");
    }

    public override void PaintCar()
    {
        Console.WriteLine("Pintando o Hatch com cor uniforme.");
    }

    public override void MountCarParts()
    {
        Console.WriteLine("Montando as peças do Hatch.");
    }
}