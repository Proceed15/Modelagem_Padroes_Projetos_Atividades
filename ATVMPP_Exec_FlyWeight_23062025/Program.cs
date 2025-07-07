// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        var factory = new ParticleTypeFactory();
        var particles = new List<Particle>();
        var SparkParticles = new List<Particle>();
        var WaterParticles = new List<Particle>();

        //Simulando explosão com 100 faíscas
        for (int i = 0; i < 100; i++)
        {
            IParticleType sparkType = factory.GetParticleType("Amarelo", "Faísca", 5);

            double x = RandomPosition();
            double y = RandomPosition();
            double vx = RandomVelocity();
            double vy = RandomVelocity();

            particles.Add(new Particle(sparkType, x, y, vx, vy));
            SparkParticles.Add(new Particle(sparkType, x, y, vx, vy));
        }

        //Simulando chuva com 80 gotas
        for (int i = 0; i < 80; i++)
        {
            IParticleType raindropType = factory.GetParticleType("Azul", "Gota", 3);

            double x = RandomPosition();
            double y = RandomPosition();
            double vx = RandomVelocity();
            double vy = RandomVelocity();

            particles.Add(new Particle(raindropType, x, y, vx, vy));
            WaterParticles.Add(new Particle(raindropType, x, y, vx, vy));
        }

        Console.WriteLine("\nDesenhando todas as partículas:");
        foreach (var particle in particles)
        {
            particle.Draw();
        }

        Console.WriteLine("\nSimulando explosão com 100 faíscas:");
        foreach (var particle in SparkParticles)
        {
            particle.Draw();
        }

        Console.WriteLine("\nSimulando chuva com 80 gotas:");
        foreach (var particle in WaterParticles)
        {
            particle.Draw();
        }

        Console.WriteLine($"\nTotal de tipos de partículas criados: {factory.TotalTypesCreated}");
    }

    private static double RandomPosition()
    {
        return new Random().NextDouble() * 1000;
    }

    private static double RandomVelocity()
    {
        return (new Random().NextDouble() * 20) - 10;
    }
}