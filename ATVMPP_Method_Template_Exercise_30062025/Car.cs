using System;

abstract class Car
{
    public void Manufacture()
    {
        Console.WriteLine("Iniciando a fabricação do carro...");

        BuildCarBodyWork();
        PaintCar();
        MountCarParts();

        Console.WriteLine("Fabricação concluída!");
    }

    public abstract void BuildCarBodyWork();
    public abstract void PaintCar();
    public abstract void MountCarParts();
}