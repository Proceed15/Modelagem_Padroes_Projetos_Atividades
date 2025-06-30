class SedanCar : Car
{
    public override void BuildCarBodyWork()
    {
        Console.WriteLine("Produzindo a carroceria do Sedan em três volumes.");
    }

    public override void PaintCar()
    {
        Console.WriteLine("Pintando o Sedan com cor uniforme.");
    }

    public override void MountCarParts()
    {
        Console.WriteLine("Montando as peças do Sedan.");
    }
}