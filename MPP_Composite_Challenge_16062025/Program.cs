// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        Projeto projetoPrincipal = new Projeto("Sistema Web");
        Tarefa tarefa1 = new Tarefa("Configurar banco de dados");
        Tarefa tarefa2 = new Tarefa("Criar layout da home");
        Projeto subProjeto = new Projeto("Módulo de Autenticação");
        subProjeto.Adicionar(new Tarefa("Tela de login"));
        subProjeto.Adicionar(new Tarefa("Validação de usuário"));
        projetoPrincipal.Adicionar(tarefa1);
        projetoPrincipal.Adicionar(tarefa2);
        projetoPrincipal.Adicionar(subProjeto);
        projetoPrincipal.Exibir();
        int TotalTarefas = projetoPrincipal.ContarTarefas();
        Console.WriteLine($"Total de Tarefas no Projeto: {TotalTarefas}");
    }
}
