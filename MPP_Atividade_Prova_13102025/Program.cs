// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("Prova Observer + Atividade de Clima");
        EstacaoMeteorologica estacao = new EstacaoMeteorologica();
        DisplayCelular Display1 = new DisplayCelular("Display Celular");
        DisplayJanela Display2 = new DisplayJanela("Display Janela");

        estacao.AdicionarObservador(Display1);
        estacao.AdicionarObservador(Display2);
        //Definindo Novas Temperaturas para os Displays
        estacao.SetTemperatura(28);
        estacao.SetTemperatura(30);
        //Mostrando os Dados do Display do Celular
        estacao.RemoverObservador(Display2);
        estacao.SetTemperatura(25);
        estacao.SetTemperatura(35);
        //Mostrando os Dados do Display da janela
        estacao.RemoverObservador(Display1);
        estacao.AdicionarObservador(Display2);
        estacao.SetTemperatura(31);
        estacao.SetTemperatura(35);
    }


    
}


