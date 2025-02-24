using System;

namespace SOLID_MPP_ATVS
{
    internal class SOLID_SRP_A
    {
        public class ClientServices
        {
            public static void CreateClient()
            {
                Console.WriteLine("Cliente Criado!");
            }

            public static void ReadClient()
            {
                Console.WriteLine("\nCliente 01: Cristiane");
            }

            public static void UpdateClient()
            {
                Console.WriteLine("Cliente Atualizado!");
            }

            public static void DeleteClient()
            {
                Console.WriteLine("Cliente Deletado!");
            }
        }

        public class NotificationService
        {
            public static void NotifyClient()
            {
                Console.WriteLine("SMS e/ou Email Enviado(s)!");
            }
        }

        public static void RetornaSRP()
        {
            ClientServices.CreateClient();
            ClientServices.UpdateClient();
            ClientServices.DeleteClient();
            ClientServices.ReadClient();
            NotificationService.NotifyClient();
        }
    }
}
