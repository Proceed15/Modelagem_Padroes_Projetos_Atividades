// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;

namespace StatePattern
{
    public interface IEstadoDrone
    {
        void Avancar(Drone drone);
        void Interromper(Drone drone);
    }

    public class EmSolo : IEstadoDrone
    {
        public void Avancar(Drone drone)
        {
            Console.WriteLine("Drone decolando...");
            drone.Estado = new Decolando();
        }

        public void Interromper(Drone drone)
        {
            Console.WriteLine("Drone já está em solo.");
        }
    }

    public class Decolando : IEstadoDrone
    {
        public void Avancar(Drone drone)
        {
            Console.WriteLine("Drone agora está em voo.");
            drone.Estado = new EmVoo();
        }

        public void Interromper(Drone drone)
        {
            Console.WriteLine("Decolagem cancelada. Voltando ao solo.");
            drone.Estado = new EmSolo();
        }
    }

    public class EmVoo : IEstadoDrone
    {
        public void Avancar(Drone drone)
        {
            Console.WriteLine("Drone iniciando pouso...");
            drone.Estado = new Pousando();
        }

        public void Interromper(Drone drone)
        {
            Console.WriteLine("Drone interrompeu o voo e está pousando de emergência!");
            drone.Estado = new Pousando();
        }
    }

    public class Pousando : IEstadoDrone
    {
        public void Avancar(Drone drone)
        {
            Console.WriteLine("Drone pousou com sucesso.");
            drone.Estado = new EmSolo();
        }

        public void Interromper(Drone drone)
        {
            Console.WriteLine("Pouso em andamento, não é possível interromper.");
        }
    }

    public class Drone
    {
        public IEstadoDrone Estado { get; set; }

        public Drone() => Estado = new EmSolo();

        public void Avancar() => Estado.Avancar(this);
        public void Interromper() => Estado.Interromper(this);
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== Padrão State - Controle de Drone Autônomo ===");
            Drone drone = new Drone();
            drone.Avancar();
            drone.Avancar();
            drone.Interromper();
            drone.Avancar();
        }
    }
}
