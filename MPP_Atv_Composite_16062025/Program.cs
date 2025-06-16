// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
using System.Collections.Generic;

class Program
{
    public static void Main()
    {

        Organizacao organizacao = new Organizacao("Entidade TeslaXYZ");
        Organizacao departamento1 = new Organizacao("Departamento de TI");
        Organizacao departamento2 = new Organizacao("Departamento de RH");

        organizacao.Add(departamento1);

        organizacao.Add(departamento2);

        Funcionario funcionarioA1 = new Funcionario(1, "José", 191);

        Funcionario funcionarioA2 = new Funcionario(2, "Pedro", 180);

        Funcionario funcionarioA3 = new Funcionario(3, "João", 180);

        departamento1.Add(funcionarioA1);

        departamento1.Add(funcionarioA2);

        departamento1.Add(funcionarioA3);

        Funcionario funcionarioB1 = new Funcionario(4, "Ana", 190);

        Funcionario funcionarioB2 = new Funcionario(5, "Luisa", 190);

        Funcionario funcionarioB3 = new Funcionario(6, "Maria", 180);

        departamento2.Add(funcionarioB1);

        departamento2.Add(funcionarioB2);

        departamento2.Add(funcionarioB3);

        int totalHorasorganizacao = organizacao.GetHoraTrabalhada();

        Console.WriteLine($"\n{organizacao.Nome}");
        Console.WriteLine("\nRelação entre Funcionários, Departamentos e Horas Trabalhadas:");

        Console.WriteLine($"\nDepartamento 1: {departamento1.Nome}");
        Console.WriteLine($"Funcionário(Id:{funcionarioA1.Id}): {funcionarioA1.Nome} trabalhou {funcionarioA1.GetHoraTrabalhada()}");
        Console.WriteLine($"Funcionário(Id:{funcionarioA2.Id}): {funcionarioA2.Nome} trabalhou {funcionarioA2.GetHoraTrabalhada()}");
        Console.WriteLine($"Funcionário(Id:{funcionarioA3.Id}): {funcionarioA3.Nome} trabalhou {funcionarioA3.GetHoraTrabalhada()}");
        Console.WriteLine($"\nDepartamento 2: {departamento2.Nome}");
        Console.WriteLine($"Funcionário(Id:{funcionarioB1.Id}): {funcionarioB1.Nome} trabalhou {funcionarioB1.GetHoraTrabalhada()}");
        Console.WriteLine($"Funcionário(Id:{funcionarioB2.Id}): {funcionarioB2.Nome} trabalhou {funcionarioB2.GetHoraTrabalhada()}");
        Console.WriteLine($"Funcionário(Id:{funcionarioB3.Id}): {funcionarioB3.Nome} trabalhou {funcionarioB3.GetHoraTrabalhada()}");

        Console.WriteLine($"\nTotal de horas Trabalhadas na organizacao: {totalHorasorganizacao}\n");

    }
}