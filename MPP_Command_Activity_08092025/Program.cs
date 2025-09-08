// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
using System.Collections.Generic;


// ----------------- PROGRAMA PRINCIPAL -----------------
class Program
{
    static void Main()
    {
        Light Light = new Light();
        Termostate Termostate = new Termostate();
        Door Door = new Door();
        CommandCentral central = new CommandCentral();

        // Testando commands individuais
        central.PressingButton(new TurnONLightCommand(Light));
        central.PressingButton(new AdjustIntensityLightCommand(Light, 75));
        central.PressingButton(new AdjustTemperatureCommand(Termostate, 19.5));
        central.PressingButton(new OpenDoorCommand(Door));
        central.PressingButton(new CloseDoorCommand(Door));

        // MacroCommand
        var macro = new MacroCommand(new List<ICommand>
        {
            new DesTurnONLightCommand(Light),
            new AdjustTemperatureCommand(Termostate, 24),
            new OpenDoorCommand(Door)
        });

        Console.WriteLine("\n▶️ Executando Macro...");
        central.PressingButton(macro);

        // Mostrar histórico
        central.ShowHistory();

        // Status final dos dispositivos
        Console.WriteLine("\n📌 Status Final:");
        Light.Status();
        Termostate.Status();
        Door.Status();
   
        Console.WriteLine("\nExecutando Desfazer...");
        central.DesfazerUltimo();
        
        Console.WriteLine("\nStatus Depois do Desfazer:");
        Light.Status();
        Termostate.Status();
        Door.Status();
    }
}










