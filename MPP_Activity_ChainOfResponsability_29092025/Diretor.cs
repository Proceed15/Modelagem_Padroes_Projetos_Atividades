// O Aprovador Concreto: Diretor
    public class Director : HandlerInterfaceManager
    {
        public override void Approve(PurchaseRequest request)
        {
            if (request.Amount <= 10000)
            {
                Console.WriteLine($"Diretor aprovou: {request.Description} (R${request.Amount:F2})");
            }
            else
            {
                Console.WriteLine("Diretor: valor acima do limite, encaminhando...");
                base.Approve(request);
            }
        }
    }