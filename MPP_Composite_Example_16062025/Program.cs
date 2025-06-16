// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        Project MainProject = new Project("Sistema Web");
        Task Task1 = new Task("Configurar banco de dados");
        Task Task2 = new Task("Criar layout da home");
        Project SubProject = new Project("Módulo de Autenticação");
        SubProject.Adicionar(new Task("Tela de login"));
        SubProject.Adicionar(new Task("Validação de usuário"));
        MainProject.Adicionar(Task1);
        MainProject.Adicionar(Task2);
        MainProject.Adicionar(SubProject);
        MainProject.Exibir();
    }
}
